using System;
using System.Diagnostics;
using System.Drawing;
using System.Numerics;

namespace MohawkGame2D;

public class Guy
{
    Vector2 guyXY;
    float guyRadius = 50;
    Color guyColor = new Color();
    float time;
    float waittime;
    float timelim = 0;
    float movementSpeed = 5;
    Vector2 mousepos;
    public void Setup()
    {

        waittime = Random.Integer(5, 19);

        guyXY = Random.Vector2(Window.Size);


    }

    public float speedX;


    public void Update()
    {
        //constantly updates value of mouse pos
        mousepos = Input.GetMousePosition();
        //bool for detecting if the mouse is on the guys
        bool isPointInGuy = Vector2.Distance(mousepos, guyXY) <= guyRadius;
        //body
        Draw.FillColor = guyColor;
        Draw.LineSize = 1;
        Draw.LineColor = Color.Black;
        if (isPointInGuy == true)
        {
            guyColor = Random.Color();

            Console.WriteLine("mouse on guy");
        }

        guyXY.X += speedX * Time.DeltaTime * 30;
       
        //for(int i = 0;  i < 10; i++)
        //{
        //    speedX -= 1 * Time.DeltaTime * 10;
        //}
        speedX = 0;
        Draw.Circle(guyXY, guyRadius / 2);
        //eyes
        //Draw.FillColor = Color.OffWhite;
        // the eyes dont work anymore but do work when i put in 4 args. i dont get it.
        //Draw.Circle(guyXY.X - 10, guyXY.Y - 15, 5);
        //Draw.Circle(guyXY.X + 10, guyXY.Y - 15, 5);

        // time value starts adding up
          time += Time.DeltaTime;

        //time += 1;

      //  Console.WriteLine(guyXY.X);



        // movement loop
        if (time >= waittime)
        {
            int random = Random.Integer(0, 2);

            if (random == 0)
            {
                // speedx goes on for this amount of time
                while (timelim <= time)
                {
                    timelim += 1;
                    speedX += movementSpeed;
                }
            }
            else if (random == 1)
            {
                while (timelim <= time)
                {
                    timelim += 1;
                    speedX -= movementSpeed;
                }
                
            }
            time = 0;
            timelim = 0;
            //// follow the speed limit! if speedX goes over, you get set back!
            //if(speedX > movementSpeed)
            //{
            //    speedX = speedX -= movementSpeed;
            //}
            //if(speedX < -movementSpeed)
            //{
            //    speedX = speedX += movementSpeed;
            //}



            //when the guys go offscreen, forcefully shove them back
            if(guyXY.X <= 0)
            {
                //speedX = 0;
                speedX += movementSpeed * 10;
            }
            if(guyXY.X >= Window.Width)
            {
               // speedX = 0;
                speedX -= movementSpeed * 10;
            }
        }
    }
}
