
using System.Text;

EOptions //?
public static class MathGame
{

    static void Main()
    {
        int selectedOption =  MainMenu();
        
        EOptions // ?
        Enums e = new Enums(); //?
        Enums.EOptions //?
        
    }

    private static int MainMenu()
    {
        StringBuilder stringBuilder = new StringBuilder();
        Console.WriteLine("Welcome to MathGame!");
        Console.WriteLine("Pick a number to continue...");
        Console.WriteLine("0 - Addition");
        Console.WriteLine("1 - Subtraction");
        Console.WriteLine("2 - Multiplication");
        Console.WriteLine("3 - Division");
        Console.WriteLine("4 - Set difficulty");
        Console.WriteLine("5 - End");
        Enums.EOptions.Addiion
        int selectedOption = Console.Read();
        Console.WriteLine("\n \n");
        return selectedOption;
    }

    
}

//Show a menu on console 0-3 Math operations.
//4-5-6 is difficulty level
//7 is history of previous games.
//8 is back button
//Keep track of menu somehow..