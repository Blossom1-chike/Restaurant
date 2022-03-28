namespace Cakes.Data.Entities
{
    public class RestaurantJSON
    {
        private IList<Hours> monday;
        private IList<Hours> tuesday;
        private IList<Hours> wednesday;
        private IList<Hours> thursday;
        private IList<Hours> friday;
        private IList<Hours> saturday;
        private IList<Hours> sunday;

        public IList<Hours> Monday { get { return monday; } set { monday = value; } }
        public IList<Hours> Tuesday { get { return tuesday; } set { tuesday = value; } }
        public IList<Hours> Wednesday { get { return wednesday; } set { wednesday = value; } }
        public IList<Hours> Thursday { get { return thursday; } set { thursday = value; } }
        public IList<Hours> Friday { get { return friday; } set { friday = value; } }
        public IList<Hours> Saturday { get { return saturday; } set { saturday = value; } }
        public IList<Hours> Sunday { get { return sunday; } set { sunday = value; } }
    }
}
