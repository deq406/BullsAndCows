using BullsAndCows.Database;
using System;
using System.Threading.Tasks;
using System.Linq;
using BullsAndCows.Service.Models;

namespace BullsAndCows.Service
{
    public class GameService
    {
        private PlayerContext _db;
        public GameService(PlayerContext db)
        {
            _db = db ?? throw new ArgumentNullException();
        }
        public Game CreateGame()
        {
            var game = new Game
            {
                Attempts = 0,
                CorrectNumber = SecretNumber(),
                LatestEnteredNumber = 0,
                Bulls = 0,
                Cows = 0
            };
            _db.Games.Add(game);
            _db.SaveChanges();
            

            return game;
        }

        public CowsAndBullsModel CheckNumber(int id, int number)
        {

            var game = _db.Games.FirstOrDefault(game => game.Id == id) ?? throw new ArgumentNullException();

            game.LatestEnteredNumber = number;
            game.Attempts++;
            _db.Update(game);
            _db.SaveChanges();
            if (game.CorrectNumber == game.LatestEnteredNumber)
            {
                return new CowsAndBullsModel
                {
                    Bulls = 4,
                    Cows = 0,
                    IsFinished = true,
                    Win = "Вы угадали верное число"
                    
                };
                
            }
            else
            return NumberComparison(game.CorrectNumber, game.LatestEnteredNumber);
            
            
        }

        private int SecretNumber()
        {
            Random rand = new Random();
            int[] x = new int[4];
            bool contains;// флаг сравнения
            for (int i = 0; i < 4; i++)
            {
                do
                {
                    contains = false;
                    x[i] = rand.Next(10);
                    for (int k = 0; k < i; k++)
                        if (x[k] == x[i])
                            contains = true;
                } while (contains);
            }
            return Convert.ToInt32(x[0].ToString() + x[1] + x[2] + x[3]);
        }


        private CowsAndBullsModel NumberComparison(int correct, int chislo)
        {
            // обнуление счетчиков
            int bulls = 0;
            int cows = 0;
            for (int i = 0; i < 4; i++)
            {
                // если строка correct содержит в себе элемент массива
                if (correct.ToString().Contains(chislo.ToString()[i]))
                {
                    // если номер символа в массиве совпадает с номером символа в строке
                    if (correct.ToString()[i] == chislo.ToString()[i])
                        // увеличиваем счетчик полного совпадения
                        bulls++;
                    else
                        // если номер символа в массиве не совпадает с номером символа в строке
                        // увеличиваем счетчик неполного совпадения
                        cows++;
                }
            }

            return new CowsAndBullsModel
            {
                Bulls = bulls,
                Cows = cows,
            };

        }
    }
}

