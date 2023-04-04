namespace Generic_Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GenericStack<int> stack = new GenericStack<int>();
            int[] array = new int[10];
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            stack.Push(6);
            stack.Pop();
            stack.Pop();
            stack.CopyTo(array, 5);
            stack.Peek();
            stack.Clear();
        }
    }
}