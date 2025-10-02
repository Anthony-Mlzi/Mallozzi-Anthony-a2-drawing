// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;

// The namespace your code is in.
namespace MohawkGame2D
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        // Place your variables here:

        ColorF bgColor = new ColorF(0.3f, 0.1f, 0.1f);
        ColorF symColor = new ColorF(0.8f, 0.2f, 0.1f);
        ColorF shelfColor = new ColorF(0.5f, 0.3f, 0.2f);
        ColorF runeColorA = new ColorF(1.0f, 0.0f, 0.9f);
        ColorF runeColorB = new ColorF(0.0f, 0.9f, 1.0f);
        ColorF runeColorC = new ColorF(0.25f, 1.0f, 0.0f);

        float playerY;
        float playerX;

        float gapsY1;
        float gapsY2;

        float rectanglePosition;

        bool aVisibility = false;
        bool bVisibility = false;
        bool cVisibility = false;

        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("drawing");
            Window.SetSize(400, 400);
            Window.TargetFPS = 60;
        }

        //Backgound Gaps function

        public void bgGapsFunc()
        {
            Draw.LineSize = 4;
            Draw.LineColor = Color.Black;
            Draw.Line(0, gapsY1, 500 - 50, gapsY2);
        }

        //triangle symbol function

        public void symbolTriangle()
        {
            Draw.LineSize = 15;
            Draw.LineColor = Color.Black;
            Draw.FillColor = Color.Clear;
            Draw.Triangle(200 - playerX, 45 - playerY, 80 - playerX, 300 - playerY, 320 - playerX, 300 - playerY);

            Draw.LineSize = 8;
            Draw.LineColor = symColor;
            Draw.FillColor = Color.Clear;
            Draw.Triangle(200 - playerX, 45 - playerY, 80 - playerX, 300 - playerY, 320 - playerX, 300 - playerY);
        }

        //circle symbol function

        public void symbolCircle()
        {
            Draw.LineSize = 15;
            Draw.LineColor = Color.Black;
            Draw.FillColor = Color.Clear;
            Draw.Circle(200 - playerX, 200 - playerY, 150);

            Draw.LineSize = 8;
            Draw.LineColor = symColor;
            Draw.FillColor = Color.Clear;
            Draw.Circle(200 - playerX, 200 - playerY, 150);
        }

        //shelf function

        public void bottomItems()
        {
            Draw.LineSize = 5;
            Draw.LineColor = Color.Black;
            Draw.FillColor = shelfColor;
            Draw.Rectangle(0, rectanglePosition, 400, 100);
        }
        public void letterA()
        {
            Draw.LineSize = 5;
            Draw.LineColor = Color.Black;
            Draw.Line(130 - playerX, 480 - playerY, 150 - playerX, 420 - playerY);
            Draw.Line(150 - playerX, 420 - playerY, 180 - playerX, 480 - playerY);
        }
        public void letterB()
        {
            Draw.LineSize = 5;
            Draw.LineColor = Color.Black;
            Draw.Line(170 - playerX, 450 - playerY, 210 - playerX, 460 - playerY);
            Draw.Line(210 - playerX, 460 - playerY, 180 - playerX, 480 - playerY);
            Draw.Line(180 - playerX, 480 - playerY, 170 - playerX, 420 - playerY);
            Draw.Line(170 - playerX, 420 - playerY, 210 - playerX, 440 - playerY);
            Draw.Line(210 - playerX, 440 - playerY, 170 - playerX, 460 - playerY);
        }
        public void letterC()
        {
            Draw.LineSize = 5;
            Draw.LineColor = Color.Black;
            Draw.Line(250 - playerX, 460 - playerY, 230 - playerX, 480 - playerY);
            Draw.Line(230 - playerX, 480 - playerY, 210 - playerX, 450 - playerY);
            Draw.Line(210 - playerX, 450 - playerY, 230 - playerX, 420 - playerY);
            Draw.Line(230 - playerX, 420 - playerY, 250 - playerX, 440 - playerY);
        }

        //symbol A function

        public void ritualCircleOne()
        {
            Draw.LineSize = 12.0f;
            Draw.LineColor = Color.Black;
            Draw.Line(180 - playerX, 40 - playerY, 210 - playerX, 20 - playerY);
            Draw.Line(210 - playerX, 20 - playerY, 210 - playerX, 70 - playerY);

            Draw.LineSize = 5.0f;
            Draw.LineColor = runeColorA;
            Draw.Line(180 - playerX, 40 - playerY, 210 - playerX, 20 - playerY);
            Draw.Line(210 - playerX, 20 - playerY, 210 - playerX, 70 - playerY);

        }

        //symbol B function

        public void ritualCircleTwo()
        {
            Draw.LineSize = 12.0f;
            Draw.LineColor = Color.Black;
            Draw.Line(300 - playerX, 320 - playerY, 330 - playerX, 260 - playerY);
            Draw.Line(330 - playerX, 260 - playerY, 340 - playerX, 300 - playerY);
            Draw.Line(340 - playerX, 300 - playerY, 300 - playerX, 280 - playerY);

            Draw.LineSize = 5.0f;
            Draw.LineColor = runeColorB;
            Draw.Line(300 - playerX, 320 - playerY, 330 - playerX, 260 - playerY);
            Draw.Line(330 - playerX, 260 - playerY, 340 - playerX, 300 - playerY);
            Draw.Line(340 - playerX, 300 - playerY, 300 - playerX, 280 - playerY);
        }

        //symbol C function

        public void ritualCircleThree()
        {
            Draw.LineSize = 12.0f;
            Draw.LineColor = Color.Black;
            Draw.Line(80 - playerX, 300 - playerY, 80 - playerX, 280 - playerY);
            Draw.Line(80 - playerX, 280 - playerY, 100 - playerX, 280 - playerY);
            Draw.Line(100 - playerX, 280 - playerY, 70 - playerX, 310 - playerY);
            Draw.Line(70 - playerX, 310 - playerY, 90 - playerX, 310 - playerY);
            Draw.Line(90 - playerX, 310 - playerY, 90 - playerX, 290 - playerY);

            Draw.LineSize = 5.0f;
            Draw.LineColor = runeColorC;
            Draw.Line(80 - playerX, 300 - playerY, 80 - playerX, 280 - playerY);
            Draw.Line(80 - playerX, 280 - playerY, 100 - playerX, 280 - playerY);
            Draw.Line(100 - playerX, 280 - playerY, 70 - playerX, 310 - playerY);
            Draw.Line(70 - playerX, 310 - playerY, 90 - playerX, 310 - playerY);
            Draw.Line(90 - playerX, 310 - playerY, 90 - playerX, 290 - playerY);

        }

        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            
            Window.ClearBackground(bgColor);

            //declare and initialize keyboard inputs

            bool keyInputA = Input.IsKeyboardKeyDown(KeyboardInput.A);

            bool keyInputB = Input.IsKeyboardKeyDown(KeyboardInput.B);

            bool keyInputC = Input.IsKeyboardKeyDown(KeyboardInput.C);

            bool[] keyInputArray = { keyInputA, keyInputB, keyInputC };

            //declare player mouse position

            playerY = Input.GetMouseY() * 0.4f - 50;
            playerX = Input.GetMouseX() * 0.4f - 50;

            //creat backround gaps using loop and function

            for (float i = 0; i < 16; i++)
            {
                gapsY2 = (i * 50 - 50) - playerY;
                gapsY1 = (i * 50 - 50) - playerY;
                bgGapsFunc();
            }

            //place shapes

            symbolCircle();

            symbolTriangle();

            letterA();
            letterB();
            letterC();

            //set keys to symbol appearances

            if (keyInputArray[0] == true)
            {
                aVisibility = true;
                bVisibility = false;
                cVisibility = false;
                Console.WriteLine("ritual A selected");
            }
            else if (keyInputArray[1] == true)
            {
                bVisibility = true;
                aVisibility = false;
                cVisibility = false;
                Console.WriteLine("ritual B selected");
            }
            else if (keyInputArray[2] == true)
            {
                cVisibility = true;
                aVisibility = false;
                bVisibility = false;
                Console.WriteLine("ritual C selected");
            }
            else if (Input.IsKeyboardKeyPressed(KeyboardInput.Space))
            {

            }

            if (aVisibility == true)
            {
                ritualCircleOne();
            }

            if (bVisibility == true)
            {
                ritualCircleTwo();
            }

            if (cVisibility == true)
            {
                ritualCircleThree();
            }
        }
    }
}
