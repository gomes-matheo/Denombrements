/**
 * Name : Denombrements
 * Original author : EMDS
 * Creation date : ???
 * Modification author : GOMES Mathéo
 * Last modification : 11/10/2023
 */
using System;

namespace Denombrements
{
    class Program
    {
        /// <summary>
        /// Asks for an integer and returns it
        /// </summary>
        /// <param name="question">A question (string value)</param>
        /// <returns>The chosen integer</returns>
        static int f1 (string question)
        {
            Console.WriteLine(question);
            int n = int.Parse(Console.ReadLine());
            return n;
        }

        /// <summary>
        /// Permutation, calculate the number of combinations of a n value number
        /// </summary>
        /// <param name="n">Number of values possible in the number</param>
        static void Permuation (int n)
        {
            long nbrComb = 1; //number of combinations, 1 because it starts from the first value of k

            for (int k = 1; k <= n; k++)
                nbrComb *= k;
            Console.WriteLine(n + "! = " + nbrComb);
        }

        /// <summary>
        /// To calculate an arrangement
        /// </summary>
        /// <param name="t">Total number of elements to manage </param>
        /// <param name="n">The subset</param>
        
        static void Arrangement (int t, int n)
        {
            // calcul de r
            int r = 1;
            for (int k = (t - n + 1); k <= t; k++)
                r *= k;
            Console.WriteLine("A(" + t + "/" + n + ") = " + r);
        }

        /// <summary>
        /// To calculate the number of combinations possible
        /// </summary>
        /// <param name="t">Total of elements possible</param>
        /// <param name="n">Subset</param>
        static void Combinations (int t, int n)
        {
            // calcul de r1
            long r1 = 1;
            for (int k = (t - n + 1); k <= t; k++)
                r1 *= k;
            // calcul de r2
            long r2 = 1;
            for (int k = 1; k <= n; k++)
                r2 *= k;
            Console.WriteLine("C(" + t + "/" + n + ") = " + (r1 / r2));
        }

        /// <summary>
        /// Main module
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int c = 1;
            while (c != 0)
            {
                Console.WriteLine("Permutation ...................... 1");
                Console.WriteLine("Arrangement ...................... 2");
                Console.WriteLine("Combinaison ...................... 3");
                Console.WriteLine("Quitter .......................... 0");
                Console.Write("Choix :                            ");
                c = int.Parse(Console.ReadLine());

                switch (c)
                {
                    case 1: //permutation
                        int n = f1("nombre total d'éléments à gérer = "); // le nombre d'éléments à gérer
                        Permuation(n);
                        break;

                    case 2: //arrangement
                        int aTotalElem = f1("nombre total d'éléments à gérer = "); // le nombre d'éléments à gérer
                        int arrSubset = f1("nombre d'éléments dans le sous ensemble = "); // le sous ensemble
                        Arrangement(aTotalElem, arrSubset);
                        break;

                    case 3: // combinaison
                        int cTotalElem = f1("nombre total d'éléments à gérer = "); // le nombre d'éléments à gérer
                        int combSubset = f1("nombre d'éléments dans le sous ensemble = "); // le sous ensemble
                        Combinations(cTotalElem, combSubset);
                        break;
                    default:
                        Environment.Exit(0);
                        break;
                }
            }
            Console.ReadLine();
        }
    }
}
