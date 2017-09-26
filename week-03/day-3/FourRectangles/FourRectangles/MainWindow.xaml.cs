using System;
using System.Windows;
using GreenFox;
using System.Windows.Media;

namespace FourRectangles
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            // draw four different size and color rectangles.
            foxDraw.FillColor(Colors.AliceBlue);
            foxDraw.DrawRectangle(10, 10, 120, 120);

            foxDraw.FillColor(Colors.DarkSalmon);
            foxDraw.DrawRectangle(150, 100, 80, 190);

            foxDraw.FillColor(Colors.Indigo);
            foxDraw.DrawRectangle(0, 200, 100, 100);

            foxDraw.FillColor(Colors.HotPink);
            foxDraw.DrawRectangle(83, 94, 170, 170);
        }
    }
}