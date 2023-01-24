namespace D1W2
{
    internal class Comedians
    {
        public static int Age = 10;
        //Field
        private string? comedian;
        //Property

        public int Id { get; set; }
        public string? Comedian 
        { 
            get { return comedian; } 
            set { comedian = value; } 
        }

        public Class3 Class34 { get; set; }

        public Class2 Class2 { get; set; }
        public DateTime BirthDay { get; set; }
        //Empty Constructor
        public Comedians()
        {

        }
        //Constructor with parameter
        public Comedians(string comedian, DateTime bd)
        {
            this.comedian = comedian;
            BirthDay = bd;
        }

        public class Class3
        {

        }
    }
}
