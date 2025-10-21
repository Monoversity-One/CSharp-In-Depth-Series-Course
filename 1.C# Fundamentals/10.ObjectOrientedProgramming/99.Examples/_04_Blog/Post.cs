namespace _10.Object_OrientedProgramming._99.Examples._04_Blog
{
    public class Post
    {
        private static int currentPostId;

        //properties
        protected int Id { get; set; }
        protected string Title { get; set; }
        protected string SendByUserName { get; set; }
        protected bool IsPublic { get; set; }

        //default constructor
        // if a derived class does not invoke a base class constructor explicitly,
        //the default constructor is called implicitly.
        public Post()
        {
            Id = 0;
            Title = "My first post";
            IsPublic = true;
            SendByUserName = "Elliot One";
        }

        //instance constructor that has three parameters
        public Post(string title, bool isPublic, string sendByUserName)
        {
            this.Id = GetNextId();
            this.Title = title;
            this.IsPublic = isPublic;
            this.SendByUserName = sendByUserName;
        }

        protected int GetNextId()
        {
            return ++currentPostId;
        }

        public void Update(string title, bool isPublic)
        {
            this.Title = title;
            this.IsPublic = isPublic;
        }

        //Virtual method override of the ToString method that is inherited from System.Object
        public override string ToString()
        {
            return String.Format("{0} - {1} - by {2}", this.Id, this.Title, this.SendByUserName);
        }
    }
}
