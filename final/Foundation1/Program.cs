using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Video vid1 = new Video("click this video!", "Jack", 975);
        Video vid2 = new Video("Now Live!", "Mark", 100245);
        Video vid3 = new Video("Woah! He did what?!", "Felix", 387);
        List<Video> videos = new List<Video>{vid1,vid2,vid3};
       

        Comment c1 = new Comment("PixelNomad42", "This was actually really interesting");
        Comment c2 = new Comment("SierraWaves", "I didn’t expect to watch the whole thing but I did");
        Comment c3 = new Comment("JaxonRidge", "That part in the middle stood out a lot");
        Comment c4 = new Comment("LunarMaple", "Pretty clear explanation overall");
        Comment c5 = new Comment("CodeyMcCloud", "I like how simple this was to follow");
        Comment c6 = new Comment("TessaBloom", "Learned something new from this");
        Comment c7 = new Comment("OrbitRiley", "This kept my attention the whole time");
        Comment c8 = new Comment("NovaHarper", "The examples made it easier to understand");
        Comment c9 = new Comment("CedarFox88", "Solid video, no complaints");
        
        vid1.AddComment(c1);
        vid1.AddComment(c2);
        vid1.AddComment(c3);
        vid2.AddComment(c4);
        vid2.AddComment(c5);
        vid2.AddComment(c6);
        vid3.AddComment(c7);
        vid3.AddComment(c8);
        vid3.AddComment(c9);

        foreach (Video vid in videos){
            vid.Display();
        }
    }


}