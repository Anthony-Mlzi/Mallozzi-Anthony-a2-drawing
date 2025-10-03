// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;

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
        ColorF runeColorA = new ColorF(1.0f, 0.0f, 0.9f, 1.0f);
        ColorF runeColorB = new ColorF(0.0f, 0.9f, 1.0f, 1.0f);
        ColorF runeColorC = new ColorF(0.25f, 1.0f, 0.0f, 1.0f);

        float playerY;
        float playerX;

        float gapsY1;
        float gapsY2;

        float rectanglePosition;

        bool aVisibility = false;
        bool bVisibility = false;
        bool cVisibility = false;

        float colorChange;
        float timeDelt;
        float alpha;
        float red = 1.0f;
        float blue = 0.4f;
        float green = 0.0f;

        float circleX;
        float circleY;

        System.Random rng = new System.Random();

        int[] arrayOne = new int[15];
        int[] arrayTwo = new int[15];

        float y;

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

        //Light function

        public void lightA()
        {
            Draw.LineSize = 0;
            Draw.FillColor = runeColorA;
            Draw.Circle(200, 200, 200);
        }

        //runelight function

        public void runelight()
        {

            alpha += Time.DeltaTime * 0.3f;
            ColorF colorChange = new ColorF(red, blue, green, alpha);

            Draw.LineSize = 0;
            Draw.FillColor = colorChange;
            Draw.Circle(circleX - playerX, circleY - playerY, alpha * 50);

            if (alpha > 0.7f)
            {
                alpha -= alpha;
            }
        }

        //shade

        public void shade()
        {
            ColorF shade = new ColorF(0.0f, 0.0f, 0.0f, 0.3f);
            Draw.LineSize = 0;
            Draw.FillColor = shade;
            Draw.Rectangle(-200 - playerX, -100 - playerY, 800, 125 - playerY);
            Draw.Rectangle(-200 - playerX, -100 - playerY, 800, 90 - playerY);
            Draw.Rectangle(-200 - playerX, -100 - playerY, 800, 45 - playerY);
        }

        //centerlight

        public void centerlight()
        {
            ColorF shine = new ColorF(1.0f, 4.0f, 0.0f, 0.1f);
            Draw.LineSize = 0.0f;
            Draw.FillColor = shine;
            Draw.Circle(200 - playerX, 200 - playerY, 125);
            Draw.Circle(200 - playerX, 200 - playerY, 90);
            Draw.Circle(200 - playerX, 200 - playerY, 50);
        }

        //paper

        public void paper()
        {
            ColorF sheet = new ColorF(1.0f, 0.9f, 0.6f);
            Draw.LineSize = 0;
            Draw.FillColor = sheet;
            Draw.Rectangle(70 - playerX, 400 - playerY, 250, 300);
        }
        
        //add particles

        public void particles()
        {
            for (int i = 0; i < 1; i++)
            {
                arrayOne[i] = rng.Next(150, 250);
                arrayTwo[i] = rng.Next(150, 250);
                Draw.LineSize = 3;
                Draw.Circle(arrayOne[i] - playerX, arrayTwo[i] - playerY, 10);
            }
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

            float seconds = Time.SecondsElapsed;

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

            paper();

            letterA();
            letterB();
            letterC();

            centerlight();

            shade();

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

            if (aVisibility == true)
            {
                circleX = 200;
                circleY = 45;
                runelight();
                ritualCircleOne();
                particles();
            }

            if (bVisibility == true)
            {
                circleX = 320;
                circleY = 300;
                runelight();
                ritualCircleTwo();
                particles();
            }

            if (cVisibility == true)
            {
                circleX = 80;
                circleY = 300;
                runelight();
                ritualCircleThree();
                particles();
            }
        }
    }
}
