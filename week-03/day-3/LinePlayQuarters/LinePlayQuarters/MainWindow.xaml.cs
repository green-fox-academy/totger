using System;
using System.Windows;
using GreenFox;
using System.Windows.Media;

namespace LinePlayQuarters
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            // divide the canvas into 4 parts
            // and repeat this pattern in each quarter:
            // [https://github.com/greenfox-academy/teaching-materials/blob/master/workshop/drawing/line-play/r1.png]
            
            DrawStuff(0, 0);
            DrawStuff(150, 0);
            DrawStuff(0, 150);
            DrawStuff(150, 150);


        }

        private void DrawStuff(int x, int y)
        {
            var foxDraw = new FoxDraw(canvas);
            for (int i = 0; i < 140; i += 10)
            {
                foxDraw.StrokeColor(Colors.Purple);
                foxDraw.DrawLine(x + i, y, x + 130, y + i);
            }

            for (int i = 0; i < 140; i += 10)
            {
                foxDraw.StrokeColor(Colors.Green);
                foxDraw.DrawLine(x, y + i, x + i, y + 130);
            }
        }
    }
}