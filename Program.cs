using D1W2;

namespace MyNamespace
{
    class Program
    {
        
        public static void Main(string[] args)
        {
            new Program().Start();
            //Console.WriteLine(cmd.Comedian);

            //new Comedians("Hello Brave New World!");
        }

        void Start()
        {
            Comedians cmd = new Comedians();
            cmd.Comedian = "Jim Carrey";
            cmd.BirthDay = new DateTime(1962, 1, 17);
            ShowComedian(cmd);

            Comedians cmd3 = new();
            cmd3.Comedian = "Anden";
            Console.WriteLine(cmd.Comedian);

            Comedians cmd4 = new("Steve Carell", new DateTime(1962, 8, 16));

            Comedians cmd5 = new() {Comedian = "Bill Burr" , BirthDay = new (1968,6,10)};
        }

        void ShowComedian(Comedians cmd2)
        {
            Console.WriteLine(cmd2.Comedian);

            cmd2.Comedian += " is funny";
        }
    }
}