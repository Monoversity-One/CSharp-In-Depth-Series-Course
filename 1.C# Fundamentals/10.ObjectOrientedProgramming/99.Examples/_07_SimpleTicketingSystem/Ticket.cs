namespace _10.Object_OrientedProgramming._99.Examples._07_SimpleTicketingSystem
{
    public class Ticket: IEquatable<Ticket>
    {
        public int DurationInHours { get; set; }

        public Ticket(int durationInHours)
        {
            DurationInHours = durationInHours;
        }


        public bool Equals(Ticket other)
        {
            if (ReferenceEquals(null, other)) return false;

            if (ReferenceEquals(this, other)) return true;

            return DurationInHours == other.DurationInHours;
        }

        //public override bool Equals(object? obj)
        //{
        //    if (ReferenceEquals(null, obj)) return false;
        //    if (ReferenceEquals(this, obj)) return true;
        //    if (obj.GetType() != this.GetType()) return false;
        //    return Equals((Ticket)obj);
        //}

        //public override int GetHashCode()
        //{
        //    return DurationInHours;
        //}
    }
}
