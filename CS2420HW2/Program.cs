




public class LinkedList
{
    private Node head;
    private Node tail;
    private int length;
    public LinkedList(int value)
    {
        Node newNode = new Node(value);
        head = newNode;
        tail = newNode;
        length = 1;
    }
    public Node GetHead() { return head; }
    public Node GetTail() { return tail; }
    public int GetLength() { return length; }
    public void RemoveDuplicates()
    {
        Node current = head;
        while(current.next.value != void)
            {
            if (current.value == current.next.value)
            {
                current.next = current.next.next;
            }
        }
    }
}
public class Node
{
    public int value;
    public Node next;
    public Node prev;
    public Node(int value)
    {
        this.value = value;
    }
}