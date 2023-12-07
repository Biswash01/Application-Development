namespace Exercise6
{
   internal class Stack<T>
    {
        internal List<T> list=new List<T>();

        internal void Push(T item)
        {
            list.Add(item);
        }

        internal T Pop() {
            int index = list.Count - 1;
            T item = list[index];
            list.RemoveAt(index);
            return item;
        }

        internal T Peek()
        {
            T topItem=list[list.Count-1];
            return topItem;
        }
        
        internal bool isEmpty()
        {
            if(list.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void Main()
        {

        }
            
    }

 }