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

        float playerY;
        float playerX;

        float gapsY1;
        float gapsY2;

        float rectanglePosition;

        bool keyInputA;
        bool keyInputB;
        bool keyInputC;

        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("drawing");
            Window.SetSize(400, 400);
            Window.TargetFPS = 60;
        }
        public void bgGapsFunc()
        {
            Draw.LineSize = 4;
            Draw.LineColor = Color.Black;
            Draw.Line(0, gapsY1, 500 - 50, gapsY2);
        }

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
        public void bottomItems()
        {
            Draw.LineSize = 5;
            Draw.LineColor = Color.Black;
            Draw.FillColor = shelfColor;
            Draw.Rectangle(0, rectanglePosition, 400, 100);
        }

        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(bgColor);

            rectanglePosition = Input.GetMouseY() * -0.3f + 425;

            keyInputA = Input.IsKeyboardKeyDown(KeyboardInput.A);
            



            playerY = Input.GetMouseY() * 0.4f - 50;
            playerX = Input.GetMouseX() * 0.4f - 50;

            for (float i = 0; i < 16; i++)
            {
                gapsY2 = (i * 50 - 50) - playerY;
                gapsY1 = (i * 50 - 50) - playerY;
                bgGapsFunc();
            }

            symbolCircle();

            symbolTriangle();

            bottomItems();

            for (int i = 0; i <= 3; i++)
            {
                if (keyInput)
            }
        }

    }
}
