namespace task13part4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> source = new Stack<int>();
            Stack<int> auxiliary = new Stack<int>();
            Stack<int> destination = new Stack<int>();
            int numDisks = 6;
            for (int i = numDisks; i > 0; i--)
            {
                source.Push(i);
            }
            MoveDisks(numDisks, source, auxiliary, destination);
            Console.WriteLine("Source Tower: " + string.Join(", ", source));
            Console.WriteLine("Auxiliary Tower: " + string.Join(", ", auxiliary));
            Console.WriteLine("Destination Tower: " + string.Join(", ", destination));
        }

        static void MoveDisks(int numDisks, Stack<int> source, Stack<int> auxiliary, Stack<int> destination)
        {
            if (numDisks > 0)
            {
                MoveDisks(numDisks - 1, source, destination, auxiliary);
                destination.Push(source.Pop());
                Console.WriteLine("Move disk {0} from Tower {1} to Tower {2}", destination.Peek(), source == null ? 0 : source.Count, destination == null ? 0 : destination.Count);
                MoveDisks(numDisks - 1, auxiliary, source, destination);
            }
        }
    }
}