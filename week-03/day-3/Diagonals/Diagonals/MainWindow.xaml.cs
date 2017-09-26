using System;
using System.Windows;
using GreenFox;
using System.Windows.Media;

namespace Diagonals
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            // draw the canvas' diagonals in green.
            foxDraw.StrokeColor(Colors.Green);
            foxDraw.DrawLine(0, 0, 300, 300);
            foxDraw.DrawLine(0, 300, 300, 0);
        }
    }
}