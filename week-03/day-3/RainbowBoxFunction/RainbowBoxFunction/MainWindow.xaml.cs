using System;
using System.Windows;
using GreenFox;
using System.Windows.Media;

namespace RainbowBoxFunction
{
    public partial class MainWindow : Window
    {
        Random random;
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            // create a square drawing function that takes 2 parameters:
            // the square size, and the fill color,
            // and draws a square of that size and color to the center of the canvas.
            // create a loop that fills the canvas with rainbow colored squares.
            //Byte[] color = new Byte[3] { 255, 79, 199 };
            //SquareDraw(50, color);

            random = new Random();
            for (int i = 0; i < 1000; i++)
            {
                
                Byte[] colors = new Byte[3];
                random.NextBytes(colors);    
                int size = random.Next(1, 220);
                SquareDraw(size, colors);
                Console.WriteLine("hello");
            }
        }

        private void SquareDraw(int size, Byte[] color)
        {
            var foxDraw = new FoxDraw(canvas);
            foxDraw.FillColor(Color.FromRgb(color[0], color[1], color[2]));
            foxDraw.DrawRectangle(random.Next(0, 150), random.Next(0,200), size, size);
           
        }
    }
}