namespace Generic_Stack
{
    public class GenericStack<T>
    {
        private T[] _items;
        private int _top;
        public GenericStack() 
        {
            _items = new T[4];
            _top = -1;
        }

        public void Push(T obj) 
        {
            if(_top==_items.Length-1)
                Array.Resize(ref _items, _items.Length*2);
            _top++;
            _items[_top] = obj;
        }

        public T Pop() 
        {
            if (_top == -1)
                throw new InvalidOperationException("Stack is empty");
            var item = _items[_top];
            _top--;
            return item;
        }

        public void Clear()
        {
            Array.Clear(_items, 0, _items.Length);
            _top = -1;
        }

        public int Count => _top + 1;

        public T Peek()
        {
            if (_top == -1)
                throw new InvalidOperationException("Stack is empty");
            return _items[_top];
        }

        public void CopyTo(T[] array, int startIndex)
        {
            if (array == null) throw new ArgumentNullException("Array cannot be null.");
            if (startIndex < 0) throw new ArgumentOutOfRangeException("Index cannot be negative.");
            if (startIndex + Count > array.Length) throw new ArgumentException("The number of elements in the source collection exceeds the availiable space in the destination array.");
            Array.Copy(_items,0,array, startIndex, Count);
        }
    }
}
