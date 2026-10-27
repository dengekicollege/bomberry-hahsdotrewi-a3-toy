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
        Guy Guy1 = new Guy();
        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("A3!");



            Window.SetSize(1280, 720);

            Guy1.Setup();

           // bool move;
           
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {

            bool move;

            Window.ClearBackground(Color.White);

            Guy1.Update();

        }
    }

}
