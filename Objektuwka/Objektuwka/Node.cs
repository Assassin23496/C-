namespace Objektuwka
{
    internal class Node
    {
        public Node next { get; set; }
        public Node prev { get; set; }
        public int Data { get; set; }
        public Node(int data)
        {
            Data = data;
            next = null;
            prev = null;
        } 
    }
   
}