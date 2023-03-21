
namespace task_11
{
    internal class Shape
    {
        public  string Type { get; set; }  
        public Shape(string type)
        {
            this.Type = type;
        }

        public  virtual void Print()
        {
            Console.WriteLine($"\n\n\nPrint {Type}\n" );
        }
    }
}
