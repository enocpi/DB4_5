using System;
using System.Collections;

namespace _4_5_LABDANABRIDGES
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList myScores = new ArrayList();
            myScores.Add(4400);
            myScores.Add(8900);
            myScores.Add(1200);
            myScores.Add(3700);
            myScores.Add(7200);

            foreach (int score in myScores)
            {
                Console.WriteLine(score);
            }

            myScores.Sort();

            foreach (int score in myScores)
            {
                Console.WriteLine(score);
            }

            myScores.Reverse();

            foreach (int score in myScores)
            {

                Console.WriteLine(score);
            }

            myScores.Add(2400);

            foreach (int score in myScores)
            {
                Console.WriteLine(score);
            }


            myScores.Remove(4400);

            foreach(int score in myScores)
            {
                Console.WriteLine(score);
            }

























        }
    }
}
