namespace _10.Object_OrientedProgramming._99.Examples._04_Blog
{
    public class VideoPost : Post
    {
        //Member Fields
        protected bool isPlaying = false;
        protected int currentDuration = 0;
        private Timer timer;

        //Properties 
        protected string VideoUrl { get; set; }
        protected int Length { get; set; }

        public VideoPost() { }

        public VideoPost(string title, string sendByUserName, string videoUrl, bool isPublic, int length)
        {
            //the following properties and the GetNextId method are inherited from Post
            this.Id = GetNextId();
            this.Title = title;
            this.SendByUserName = sendByUserName;
            this.IsPublic = isPublic;

            //Properties Video Url and Length are the members of VideoPost, but not of Post
            this.VideoUrl = videoUrl;
            this.Length = length;
        }

        public void Play()
        {
            if (!isPlaying)
            {
                isPlaying = true;
                Console.WriteLine("Playing");
                timer = new Timer(TimerCallBack, null, 0, 1000);
            }
        }

        private void TimerCallBack(Object o)
        {
            if (currentDuration < Length)
            {
                currentDuration++;
                Console.WriteLine("Video at {0}s", currentDuration);
                GC.Collect();
            }
            else
            {
                Stop();
            }
        }

        public void Stop()
        {
            if (isPlaying)
            {
                isPlaying = false;
                Console.WriteLine("Stopped at {0}", currentDuration);
                currentDuration = 0;
                timer.Dispose();
            }
        }

        public override string ToString()
        {
            return String.Format("{0} - {1} - {2} - {3} - by {4}",
                this.Id, this.Title, this.VideoUrl, this.Length, this.SendByUserName);
        }
    }
}
