// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;
using System.IO;

// The namespace your code is in.
namespace MohawkGame2D
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("bung dingle");



            Window.SetSize(400, 400);


            
    
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        /// 
        public bool printdingle = true;
        public void Update()
        {
            
            int[] values = new int [10];
            // generates random numbers in the values aray
            for(int i = 0; i < 10; i++)
            {
                values[i] = Random.Integer(10); 
            }
            // prints every value in values to console once
            if (printdingle == true)
            {
                foreach (int i in values)
                {
                    Console.WriteLine(values[i]);
                }
                printdingle = false;
            }
        }
    }

}
