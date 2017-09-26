using System;
using System.Windows;
using GreenFox;
using System.Windows.Media;

namespace ColoredBox
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            // draw a box that has different colored lines on each edge.
            foxDraw.StrokeColor(Colors.Coral);
            foxDraw.DrawLine(10, 10, 70, 10);

            foxDraw.StrokeColor(Colors.Maroon);
            foxDraw.DrawLine(70, 10, 70, 70);

            foxDraw.StrokeColor(Colors.DarkKhaki);
            foxDraw.DrawLine(70, 70, 10, 70);

            foxDraw.StrokeColor(Colors.Gainsboro);
            foxDraw.DrawLine(10, 70, 10, 10);
        }
    }
}