using System.Security.Cryptography.X509Certificates;

namespace Eventos
{

    public delegate void Notify();

    public class Counter
    {
        public event Notify ThresholdReached;
        private int threshold;
        private int total;

        public Counter(int passedThreshold)
        {
            threshold = passedThreshold;
        }

        public void Add(int x)
        {
            total += x;
            if (total >= threshold)
            {
                OnThresholdReached();
            }
        }

        protected virtual void OnThresholdReached()
        {
            ThresholdReached?.Invoke();
        }
    }
    public  class Program
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
            public static void Reached(){
            Console.WriteLine("The threshold was reached.");

        }
    }
}
