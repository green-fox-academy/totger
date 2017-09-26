using System;
using System.Windows;
using GreenFox;

namespace EnvelopeStar
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            // reproduce this:
            // [https://github.com/greenfox-academy/teaching-materials/blob/master/workshop/drawing/envelope-star/r2.png]

           

            DrawStuff(0, 150);
            int x = 0;
            int y = 150;
            for (int i = 0; i <= 150; i += 5)
            {
                foxDraw.DrawLine(x + i, 150 + i, y, y + 2 * i);
            }

        }

        private void DrawStuff(int x, int y)
        {
            for (int i = 0; i <= 150; i += 5)
            {
                var foxDraw = new FoxDraw(canvas);
                foxDraw.DrawLine(x + i, y, 150, y - 2 * i);
            }
        }
    }
}