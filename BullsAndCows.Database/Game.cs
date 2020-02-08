namespace BullsAndCows.Database
{
    public class Game
    {
        public int Id { get; set; }
        public int Attempts { get; set; }
        public int CorrectNumber { get; set; }
        public int LatestEnteredNumber { get; set; }
        public int Cows { get; set; }
        public int Bulls { get; set; }
    }
}
