using System;
using System.Windows;
using GreenFox;
using System.Windows.Media;

namespace PurpleSteps
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            // reproduce this:
            // [https://github.com/greenfox-academy/teaching-materials/blob/master/workshop/drawing/purple-steps/r3.png]
            //int size = 5;
            int x = 5;
            for (int i = 0; i < 10; i++)
            {
                foxDraw.FillColor(Colors.Purple);
                foxDraw.DrawRectangle(x, x, x, x);
                x *= 2;
            }
        }
    }
}