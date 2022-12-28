public class ExceptionListEmpty : ApplicationException
{
    public ExceptionListEmpty(string element) : base("La " + element + " esta vacia!!!")
    {

    }
}