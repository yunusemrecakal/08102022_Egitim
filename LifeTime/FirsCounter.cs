namespace LifeTime
{
    public class FirsCounter : IFirsCounter
    {
        private readonly ICounter counter;

        public FirsCounter(ICounter counter)
        {
            this.counter = counter;
        }
        public int IncrementAndGet()
        {
            counter.Increment();
            return counter.Get();
        }
    }
}
