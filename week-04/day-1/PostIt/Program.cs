using System;

namespace PostIt
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            PostIt postIt1;
            PostIt postIt2;
            PostIt postIt3;

            postIt1.BackgroundColor = "orange";
            postIt1.TextColor = "blue";
            postIt1.Text = "idea1";

            postIt2.BackgroundColor = "pink";
            postIt2.TextColor = "black";
            postIt2.Text = "Awesome";

            postIt3.BackgroundColor = "yellow";
            postIt3.TextColor = "green";
            postIt3.Text = "Superb!";
        }
    }
}
