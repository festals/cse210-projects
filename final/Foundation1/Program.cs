using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        Video vid1 = new Video();
        Video vid2 = new Video();
        Video vid3 = new Video();

        Comment comm1 = new Comment();
        Comment comm2 = new Comment();
        Comment comm3 = new Comment();

        comm1._text = "That was so cool.";
        comm1._name = "Malory Stewart";
        comm2._text = "Thank you, I learn a lot!";
        comm2._name = "Theo Guy";
        comm3._text = "I had so much fun watching your video";
        comm3._name = "Derric Friedman";
        
        vid1.AddComment(comm1);
        vid1.AddComment(comm2);
        vid1.AddComment(comm3);

        vid1._title = "How to make your own dried fruit";
        vid1._author = "Pascal Lieger";
        vid1._length = "155";



        Comment comm4 = new Comment();
        Comment comm5 = new Comment();
        Comment comm6 = new Comment();

        comm4._text = "Thank you for sharing. This is so beautiful";
        comm4._name = "Sam Sarik";
        comm5._text = "This song is one of my all time favorite";
        comm5._name = "Chris Coleman";
        comm6._text = "You have a lovely voice";
        comm6._name = "Karen Streid";
        

        vid2.AddComment(comm4);
        vid2.AddComment(comm5);
        vid2.AddComment(comm6);

        vid2._title = "Consider the lilies, cover";
        vid2._author = "Stefany Kiess";
        vid2._length = "271";



        Comment comm7 = new Comment();
        Comment comm8 = new Comment();
        Comment comm9 = new Comment();
        Comment comm10 = new Comment();

        comm7._text = "Tried it. They were the best!";
        comm7._name = "Max Solone";
        comm8._text = "Did for my little sister birthday party, they loved it";
        comm8._name = "Cam Pridget";
        comm9._text = "Really easy to follow and clear instructions. Thank you.";
        comm9._name = "Martha Doberlan";
        comm10._text = "Just what I needed after this long day, yumm!";
        comm10._name = "Patricia Coral";
        
        vid3.AddComment(comm7);
        vid3.AddComment(comm8);
        vid3.AddComment(comm9);
        vid3.AddComment(comm10);

        vid3._title = "Best cookie recipe!!";
        vid3._author = "Lana Rodrigues";
        vid3._length = "110";



        List<Video> vid = new List<Video>{vid1,vid2,vid3};

        foreach (Video v in vid)
        {
            v.DisplayAll();
        }



    }
}