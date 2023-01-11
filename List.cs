public class List
{
    private Node firstNode;
    private Node lastNode;
    private string name; //testing data

    //constructors
    public List(string nameList)
    {
        name = nameList;
        firstNode = lastNode = null;
    }
    /*
    **  this
    **  (overloading constrctors)
    **  To avoid code duplication, one constructor can call another, using the "this" keyword.
    **  In the next constructor, "this" calls to previous constructor.
    **  
    */
    public List() : this("list")
    {
        // this method build an empty list calling to public List(string nameList)
    }

    //methods
    public void InsertFront(object elementToInsert)
    {
        //check if is empty
        if (IsEmpty())
        {
            firstNode = lastNode = new Node(elementToInsert);
        }
        else
        {
            firstNode = new Node(elementToInsert, firstNode);
        }
    }

    public void InsertLast(object elementToInsert)
    {
        if (IsEmpty())
        {
            firstNode = lastNode = new Node(elementToInsert);
        }
        else
        {
            lastNode = lastNode.Next = new Node(elementToInsert);
        }
    }

    public object DeleteFront()
    {
        if (IsEmpty())
            throw new ExceptionListEmpty(name);
        object elementForDelete = firstNode.Data;
        if (firstNode == lastNode)
            firstNode = lastNode = null;
        else
            firstNode = firstNode.Next;
        return elementForDelete;

    }

    public object DeleteLast()
    {
        if(IsEmpty())
            throw new ExceptionListEmpty(name);
        object elementForDelete = lastNode.Data;
        if(firstNode == lastNode)
            firstNode = lastNode = null;
        else{
            Node current = firstNode;
            while(current.Next != lastNode)
                current = current.Next;
            lastNode =current;
            current.Next = null;
        }
        return elementForDelete;
    }

    public bool IsEmpty(){
        return firstNode == null;
    }

    public void PrintList(){
        if(IsEmpty()){
            Console.WriteLine(name + "empty list!!!");
            return;
        }
        Console.Write("La " + name + " es: ");
        Node current = firstNode;

        while(current != null){
            Console.Write(current.Data + " ");
            current = current.Next;
        }
        Console.WriteLine("\n");
    }
}
