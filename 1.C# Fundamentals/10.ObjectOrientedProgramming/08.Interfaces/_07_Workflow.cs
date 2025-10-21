namespace _10.Object_OrientedProgramming._08.Interfaces
{
    public class Workflow
    {
        public List<IActivity> Activities { get; }

        public Workflow(List<IActivity> activities)
        {
            Activities = activities;
        }
    }
}