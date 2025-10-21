namespace _10.Object_OrientedProgramming._99.Examples._04_Blog
{
    //ImagePost derives from Post and adds a property (ImageURL) and two constructors
    public class ImagePost : Post
    {
        public string ImageUrl { get; set; }

        public ImagePost() { }

        public ImagePost(string title, string sendByUserName, string imageUrl, bool isPublic)
        {
            //the following properties and the GetNextId method are inherited from Post
            this.Id = GetNextId();
            this.Title =title;
            this.SendByUserName = sendByUserName;
            this.IsPublic = isPublic;

            //property ImageUrl is a member of ImagePost, but not of Post
            this.ImageUrl = imageUrl;
        }
    }
}
