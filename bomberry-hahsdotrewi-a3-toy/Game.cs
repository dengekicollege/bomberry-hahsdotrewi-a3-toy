// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;
using System.Runtime.CompilerServices;

// The namespace your code is in.
namespace MohawkGame2D
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        Guy[] Guy1 = new Guy[300];
        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("A3!");

            //set up every guy in the guy array

            Window.SetSize(1280, 720);
            for (int i = 0; i < Guy1.Length; i++)
            {
                Guy1[i] = new Guy();

                Guy1[i].Setup();
            }
           
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {

            Window.ClearBackground(Color.White);
            //runs the update in guy for every individual guy
            for (int i = 0; i < Guy1.Length; i++)
            {
                Guy1[i].Update();
            }
        }
    }

}
