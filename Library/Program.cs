/*
 * Week 4 tutorial: Adding lists
 * accept book and member info from the user instead of
 * entering into individual instances of Book and Member
 * 
 * Store all info into a list tha can be accessed for further analysis
 */ 



using Library;

class Program
{
    static void Main(string[] args)
    {

        //create new lists to be used to store book and members
        List<Book> books = new List<Book>();
        List<Member> members = new List<Member>();

        // create and add new Book objects to list
        books.Add(new Book("C# for beginners", "Bill Gates", "1234567"));
        books.Add(new Book("Ultimate C#", "Microsoft", "2233445"));


        // create and add new Member objects to list
        members.Add(new Member(1, "John Smith", "1 High Street", "0790090090"));
        members.Add(new Member(2, "Mary Jones", "103 Garden Road", "0790345666"));

        //display all books in the list using foreach loop
        //examine each row in the book list
        foreach (Book book in books)
        {
            //book temprarily holds each element from collection books
            book.DisplayInfo();
        }

        // display all members within members list
        foreach (Member member in members)
        {
            member.DisplayInfo();
        }






        // Create a dictionary to track book inventory by ISBN
        Dictionary<string, int> bookInventory = new Dictionary<string, int>();


        // Add our two sample books to the inventory (ISBN, Quantity)
        bookInventory.Add("1234567", 5);
        bookInventory.Add("2233445", 2);


        // Display the inventory for a specific book using its ISBN key
        Console.WriteLine($"Copies of 'C# for beginners' in stock: {bookInventory["1234567"]}");




        Console.WriteLine("Checking inventory for a missing book...");

        try
        {
            // This ISBN does not exist, so it will throw a KeyNotFoundException
            Console.WriteLine(bookInventory["9999999"]);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: That ISBN was not found in the inventory system.");
        }
        finally
        {
            Console.WriteLine("Inventory check complete.");
        }


    }
}