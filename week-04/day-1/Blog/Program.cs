using System;

namespace Blog
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            BlogPost post1 = new BlogPost();
            BlogPost post2 = new BlogPost();
            BlogPost post3 = new BlogPost();

            post1.AuthorName = "John Doe";
            post1.Title = "Lorem Ipsum";
            post1.PublicationDate = "2000.05.04";
            post1.Text = "Lorem ipsum dolor sit amet.";

            post2.AuthorName = "Tim Urban";
            post2.Title = "Wait but why";
            post2.PublicationDate = "2010.10.10";
            post2.Text = "A popular long-form, stick-figure-illustrated blog " +
                         "about almost everything.";

            post3.AuthorName = "William Turton";
            post3.Title = "One Engineer Is Trying to Get IBM to Reckon With Trump";
            post3.PublicationDate = "2017.03.28";
            post3.Text = "Daniel Hanley, a cybersecurity engineer at IBM, " +
                         "doesn’t want to be the center of attention. When I " +
                         "asked to take his picture outside one of IBM’s " +
                         "New York City offices, he told me that he wasn’t " +
                         "really into the whole organizer profile thing.";
        }
    }
}
