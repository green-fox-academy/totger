using System;
using System.Windows;
using GreenFox;

namespace CenterBoxFunction
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            // create a square drawing function that takes 1 parameter:
            // the square size
            // and draws a square of that size to the center of the canvas.
            // draw 3 squares with that function.
            DrawSquare(130);
            DrawSquare(90);
            DrawSquare(30);
        }

        private void DrawSquare(double size)
        {
            var foxDraw = new FoxDraw(canvas);
            foxDraw.DrawRectangle(150 - size / 2, 150 - size / 2, size, size);
        }
    }
}