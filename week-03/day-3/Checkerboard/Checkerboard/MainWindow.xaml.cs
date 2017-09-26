using System;
using System.Windows;
using GreenFox;
using System.Windows.Media;

namespace Checkerboard
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            int x = 0;
            int y = 0;
            // fill the canvas with a checkerboard pattern.
            for (int i = 1; i < 9; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    foxDraw.FillColor(Colors.Black);
                    foxDraw.DrawRectangle(x, y, 20, 20);
                    x += 40;
                }
                if (i % 2 == 1)
                    x = 20;
                else
                    x = 0;
                y += 20;
            }
        }
    }
}