using System.Security.Cryptography.X509Certificates;

namespace Eventos2
{

    public class Counter
    {
        public event EventHandler ThresholdReached;
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
                OnThresholdReached(EventArgs.Empty);
            }
        }

        protected virtual void OnThresholdReached(EventArgs e)
        {
            ThresholdReached?.Invoke(this,e);
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
