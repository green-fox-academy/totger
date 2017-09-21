using System;
using System.Windows;
using GreenFox;
using System.Windows.Media;

namespace LinePlay
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            // reproduce this:
            // [https://github.com/greenfox-academy/teaching-materials/blob/master/workshop/drawing/line-play/r1.png]
            int x = 10;
            int y = 10;

            for (int i = 0; i < 30; i += 2)
            {
                foxDraw.StrokeColor(Colors.Purple);
                foxDraw.DrawLine(x*i, 0, 300, y*i);
            }

            for (int i = 0; i < 30; i += 2)
            {
                foxDraw.StrokeColor(Colors.Green);
                foxDraw.DrawLine(0, x*i, y*i, 300);

            }
        }
    }
}