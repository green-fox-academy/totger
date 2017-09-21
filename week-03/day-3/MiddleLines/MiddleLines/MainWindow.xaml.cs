using System;
using System.Windows;
using GreenFox;
using System.Windows.Media;

namespace MiddleLines
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            //  draw a red horizontal line to the canvas' middle.
            //  draw a green vertical line to the canvas' middle.
            foxDraw.StrokeColor(Colors.Red);
            foxDraw.DrawLine(0, 150, 300, 150);

            foxDraw.StrokeColor(Colors.Green);
            foxDraw.DrawLine(150, 0, 150, 300);
        }
    }
}