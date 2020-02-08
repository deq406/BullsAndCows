//using System;
//using System.Collections.Generic;
//using System.Text;
//using System.Linq;
//using System.Data.SqlClient;
//using System.Configuration;
//using Microsoft.EntityFrameworkCore;
//using BullsAndCows.Service;
//using BullsAndCows.Database;

//namespace BullsAndCows.Cons
//{
//   public class Program 
//    {
//      public static void Main(string[] args)
//        {
//            int countSteps = 0;
//            using (PlayerContext db = new PlayerContext())
//            {
//                //Player player = new Player { login = "Deepsel", password = "123456", numberOfGames = 0 };
//                //db.Players.Add(player);
//               string userName;
//               string userPass;
//                Console.WriteLine("1.Зарегистрироваться" +
//                    " 2.Авторизироваться");
//                switch (Console.ReadLine())
//                {
//                    case "1":
//                        Console.WriteLine("Введите логин и пароль");
//                        userName = Console.ReadLine();
//                        userPass = Console.ReadLine();
//                        Player player = new Player { login = userName, password = userPass, numberOfGames = 0 };
//                        db.Players.Add(player);
//                        db.SaveChanges();
//                        Console.WriteLine("Вы были успешно зарегистрированы");
//                        return;
//                    case "2":
//                        Console.WriteLine("Введите логин и пароль");
//                         userName = Console.ReadLine();
//                         userPass = Console.ReadLine();
//                        if (userName != "" && userPass != "")
//                        {
//                            try
//                            {
//                              var result = db.Players.Where(s => s.login == userName && s.password == userPass).ToList();


//                                if (result.Count >= 1)
//                                {
//                                    Console.WriteLine("Вы прошли авторизацию");
//                                    Numbers numbers = new Numbers();
//                                    numbers.NovoeChislo();
//                                    Console.WriteLine(numbers.s);
//                                    while (numbers.polnoeSovpadenie != 4)
//                                    {
//                                        countSteps++;
//                                        if (countSteps == 34)
//                                        {
//                                            Console.WriteLine("Вы проиграли");
//                                            for (int i = 0; i < result.Count; i++)
//                                            {
//                                                result[i].numberOfGames++;
//                                                db.SaveChanges();
//                                            }

//                                        }
//                                        string chislo = Console.ReadLine();
//                                        if (chislo.Length != 4)
//                                        {
//                                            throw new AppException("Число должно быть четырехзначное");
//                                        }
//                                        else
//                                        {
//                                            numbers.SravenieChisel(chislo);
//                                            numbers.ResultShow();

//                                        }
//                                        if (numbers.polnoeSovpadenie == 4)
//                                        {
//                                            Console.WriteLine("Вы угадали правильное число");
//                                            for (int i = 0; i < result.Count; i++)
//                                            {
//                                                result[i].numberOfGames++;
//                                                db.SaveChanges();
//                                            }
//                                        }
//                                    }
//                                }
//                                else
//                                {
//                                    throw new AppException("Такого пользователя не существует1");
//                                }
//                            }


//                            catch
//                            {
//                                throw new AppException("Такого пользователя не существует");
//                            }

//                        }
//                        else
//                        {
//                            Console.WriteLine("Введите данные");
//                        }
//                        return;
//                }
               
//               }
//            //    var remove = db.Players.Where(s => s.login == "Deepsel");
//            //    db.RemoveRange(remove);
//            //    db.SaveChanges();
//            //    Console.WriteLine("Введите логин и пароль");
//            //    string userName = Console.ReadLine();
//            //    string userPass = Console.ReadLine();
//            //    if (userName != "" && userPass != "")
//            //    {
//            //        try
//            //        {
//            //            var result = db.Players.Where(s => s.login == userName && s.password == userPass).ToList();

//            //            if (result.Count>=1)
//            //            {
//            //                Console.WriteLine("Вы прошли авторизацию");
//            //            }
//            //            else
//            //            {
//            //                throw new AppException("Такого пользователя не существует");
//            //            }

//            //        }
//            //        catch
//            //        {
//            //            throw new AppException("Такого пользователя не существует");
//            //        }

//            //    }
//            //    else
//            //    {
//            //        Console.WriteLine("Введите данные");
//            //    }
                
//            //}



//        }
//    }
//}
