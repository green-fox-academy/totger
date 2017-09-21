using System;
using System.Windows;
using GreenFox;

namespace HorizontalLines
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            // create a line drawing function that takes 2 parameters:
            // the x and y coordinates of the line's starting point
            // and draws a 50 long horizontal line from that point.
            // draw 3 lines with that function.

            int x1 = 10;
            int y1 = 10;

            int x2 = 59;
            int y2 = 82;

            int x3 = 115;
            int y3 = 218;

            DrawHorizontal(x1, y1);
            DrawHorizontal(x2, y2);
            DrawHorizontal(x3, y3);

        }

        private void DrawHorizontal(int x, int y)
        {
            var foxDraw = new FoxDraw(canvas);
            foxDraw.DrawLine(x, y, x + 50, y);
        }
    }
}