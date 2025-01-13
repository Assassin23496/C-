namespace Objektuwka
{
    internal class List
    {
        private Node head;
        private Node tail;
        private int count = 0;

        
        public void AddFirst(int liczba)
        {
            Node newnode = new Node(liczba);
            if (head == null)
            {
                head = tail = newnode;
            }
            else
            {
                newnode.next = head;
                head.prev = newnode;
                head = newnode;
            }
            count++;
        }
        public void AddLast(int liczba)
        {
            Node newNode = new Node(liczba);
            if(tail == null)
            {
                head = tail = newNode;
            }
            else
            {
                newNode.prev = tail;
                tail.next = newNode;
                tail = newNode;
            }
            count++;
        }
        public void RemoveFirst()
        {
            if (tail == null)
                return;
            if(head == tail)
            {
                head = tail = null;
            }
            else
            {
                head = tail.prev;
                head.prev = null;
            }
            count--;
        }
        public void RemoveLast()
        {
            if (tail == null)
                return;
            if(head == tail)
            {
                head = tail = null;
            }
            else
            {
                tail = tail.prev;
                tail.next = null;
            }
            count--;
        }
        public int Get(int index)
        {
            if(index < 0 || index >= count)
                throw new IndexOutOfRangeException("Index out of range");
            Node current = head;
            for(int i = 0; i < index; i++)
            {
                current = current.next;
            }
            return current.Data;
        }
        public override string ToString()
        {
            if (head == null)
                return "List is empty";

            var result = new System.Text.StringBuilder();
            Node current = head;
            while (current != null)
            {
                result.Append(current.Data + " ");
                current = current.next;
            }
            return result.ToString().Trim();
        }
    }
}