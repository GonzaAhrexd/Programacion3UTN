using System.Security.Cryptography.X509Certificates;

namespace Eventos2
{

    public class ThresholdReachedEventArgs : EventArgs
    {
        public int Threshold { get; set; }
        public DateTime TimeReached { get; set; }
    }

    public class Counter
    {
        public event EventHandler<ThresholdReachedEventArgs> ThresholdReached;
        private int threshold;
        private int total;

        public Counter(int passedThreshold)
        {
            threshold = passedThreshold;
        }

        public void Add(int x)
        {
            total += x;
            if(total >= threshold)
            {
                ThresholdReachedEventArgs args = new ThresholdReachedEventArgs();
                args.Threshold = threshold;
                args.TimeReached = DateTime.Now;
                OnThresholdReached(args);

            }
        }

        protected virtual void OnThresholdReached(ThresholdReachedEventArgs e)
        {
            ThresholdReached?.Invoke(this, e);
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Counter c = new Counter(10);
            c.ThresholdReached += Reached;
            int a = 0;
            while(Console.ReadKey(true).KeyChar == 'a')
            {
                Console.WriteLine("Adding 1");
                c.Add(1);
                a++;
            }



        }
        public static void Reached(object sender, EventArgs e)
        {
            Console.WriteLine("The threshold was reached.");
            Environment.Exit(0);
        }
    }
}
