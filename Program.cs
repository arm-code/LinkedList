using System;

class Program
{
    public static void Main()
    {
        List list = new List();

        string name;
        object elementDeleted;

        int option = 0;
        while (option != 6)
        {
            Console.WriteLine("please, choose an option: \n"
         + "1. Insert to Front\n"
         + "2. Insert Last\n"
         + "3 . Delete from front\n"
         + "4. Delete from last\n"
         + "5. Print list\n"
         + "6. Exit\n"
         + "> ");
            option = Int32.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    name = Console.ReadLine();
                    list.InsertFront(name);
                    break;

                case 2:
                    name = Console.ReadLine();
                    list.InsertLast(name);
                    break;
                case 3:
                    elementDeleted = "";
                    try
                    {
                        elementDeleted = list.DeleteFront();
                        Console.WriteLine(elementDeleted + " eliminado!!!");
                    }
                    catch (ExceptionListEmpty e)
                    {
                        Console.WriteLine("\n" + e);
                    }
                    break;
                case 4:
                    elementDeleted = "";
                    try
                    {
                        elementDeleted = list.DeleteLast();
                        Console.WriteLine(elementDeleted + " eliminado!!!");
                    }
                    catch (ExceptionListEmpty e)
                    {
                        Console.WriteLine("\n" + e);
                    }
                    break;
                case 5:
                    list.PrintList();
                    break;
                default:
                    Environment.Exit(0);
                    break;


            }

        }
    }


}
