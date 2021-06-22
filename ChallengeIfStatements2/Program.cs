using System;

namespace ChallengeIfStatements2
{
    /// <summary>
    /// Create an application with a score, highscore and a highscorePlayer.
    /// Create a method which has two parameters, one for the score and one for
    /// the player name.
    /// The method should display the score, player name, and if the score is
    /// the new high score.
    /// </summary>
    class Program
    {       static int score = 14;
            static int highScore = 13;
            static string highScorePlayer = "Jim";
        static void Main(string[] args)
        {
            GetHighScore(score, "Warren");

            static void GetHighScore(int score, string playerName)
            {
                Console.WriteLine($"{playerName} got {score} points");
                if (score > highScore)
                {
                    Console.WriteLine($"Congrats {playerName}, your the new High Score");
                    highScorePlayer = playerName;
                }
                else
                {
                    Console.WriteLine($"Oof, the high score was {highScore} points, held by {highScorePlayer}!.\nBetter luck next time {playerName}");
                }
            }
        }
    }
}
