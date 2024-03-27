using System;

namespace Pr3
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Book b1 = new Book("Title1", "Author1", "Content1");
            //b1.Author.Text = "Another author";
            //b1.Content.Text = "Another content";
            //// b1.Title.Text = "Cannot change title";
            //b1.Show();

            Point A = new Point(15, 15, "A");
            Point B = new Point(0, 0, "B");
            Point C = new Point(12, 6, "C");
            Point D = new Point(7, 5, "D");
            Point E = new Point(0, 4, "E");

            Figure figure = new Figure(A, B, C, D, E);
            figure.FigureInfo();
        }
    }
}