using System;
using System.Numerics;

namespace MohawkGame2D;

public class Guy
{
    float x;
    float y;
    float time;
    float waittime;
    float timelim = 0;
    float movementSpeed = 5;
    public void Setup()
    {
        x = Window.Width / 2;

        y = Random.Integer(Window.Height);

        waittime = Random.Integer(5, 9);
    }

    public float speedX;


    public void Update()
    {

        Draw.FillColor = Color.Black;
        Draw.LineSize = 1;
        Draw.LineColor = Color.Black;
        x += speedX * Time.DeltaTime;
        Draw.Circle(x, y, 50);
        

        // time value starts adding up
      //  time += Time.DeltaTime;

        time += 1;

        Console.WriteLine(x);



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
            //// follow the speed limit! if speedX goes over, you get srt back!
            //if(speedX > movementSpeed)
            //{
            //    speedX = speedX -= movementSpeed;
            //}
            //if(speedX < -movementSpeed)
            //{
            //    speedX = speedX += movementSpeed;
            //}



            //when the guys go offscreen, forcefully shove them back
            if(x <= 0)
            {
                speedX = 0;
                speedX += movementSpeed * 10;
            }
            if(x >= Window.Width)
            {
                speedX = 0;
                speedX -= movementSpeed * 10;
            }
        }
    }
}
