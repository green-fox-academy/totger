using System;
using System.Windows;
using GreenFox;

namespace GoToCenter
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            // create a line drawing function that takes 2 parameters:
            // the x and y coordinates of the line's starting point
            // and draws a line from that point to the center of the canvas.
            // draw 3 lines with that function.
            var point1 = new Point(10, 10);
            var point2 = new Point(84, 93);
            var point3 = new Point(109, 28);
            DrawLine(point1);
            DrawLine(point2);
            DrawLine(point3);

        }

        public void DrawLine(Point point)
        {
            var foxDraw = new FoxDraw(canvas);
            var middlePoint = new Point(150, 150);
            foxDraw.DrawLine(point, middlePoint);
        }
    }
}