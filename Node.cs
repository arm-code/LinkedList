public class Node
{
    private object data;
    private Node next;
    public Node(object values) : this(values, null) { /* constructor */ }

    public Node(object values, Node next_node)
    {
        data = values;
        next = next_node;
    }

    public Node Next
    {
        get
        {
            return next;
        }

        set
        {
            next = value;
        }
    }

    public object Data
    {
        get
        {
            return data;
        }
    }
}