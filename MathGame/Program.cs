
public static class MathGame
{
    static void Main()
    {
        bool result = false;

        while(true)
        {
            EOptions mainmenu =  MainMenu();
            do
            {
                if((int) mainmenu < 0 || (int) mainmenu > 6)
                {   
                    Console.WriteLine("Enter between 0-6");
                    mainmenu = MainMenu();
                }
            }
            while((int) mainmenu < 0 || (int) mainmenu > 6);

            if(mainmenu == EOptions.Difficulty)
            {
                EDiffuculty diffuculty = DifficultyMenu();
                Games.ProblemDifficulty(diffuculty);
                Main();
            }
       
        switch (mainmenu)
        {
            case EOptions.Addition:
                result = Games.Addition();
            break;

            case EOptions.Subtraction:
                result = Games.Subtraction();
            break;

            case EOptions.Multiplication:
                result = Games.Multiplication();
            break;

            case EOptions.Division:
                result = Games.Division();
            break;

            case EOptions.History:
                RecordKeep.GetHistory();
            break;

            case EOptions.End:
                 return;

        }

        if(result == true && mainmenu != EOptions.History && mainmenu != EOptions.End)
        {
            Console.WriteLine("Correct Answer \n ");
        }
        if( result == false && mainmenu != EOptions.History && mainmenu != EOptions.End)
            Console.WriteLine("Wrong Answer  \n ");
        }
    }

    private static EOptions MainMenu()
    {
        Console.WriteLine("Welcome to MathGame!");
        Console.WriteLine("Pick a number to continue...");
        Console.WriteLine("0 - Addition");
        Console.WriteLine("1 - Subtraction");
        Console.WriteLine("2 - Multiplication");
        Console.WriteLine("3 - Division");
        Console.WriteLine("4 - Set difficulty");
        Console.WriteLine("5 - History");
        Console.WriteLine("6 - End");
        
        string selectedOption = Console.ReadLine();

        int select = int.Parse(selectedOption); 

        EOptions eoptions =  (EOptions)select;

        Console.WriteLine( eoptions + " \n \n");
        
        return eoptions;
    }

    private static EDiffuculty DifficultyMenu()
    {
        EDiffuculty eDiff = EDiffuculty.Easy;

        bool exitCondition = false;
        while(exitCondition == false)
        {

        Console.WriteLine("Pick a number to continue...");
        Console.WriteLine("0 - Easy");
        Console.WriteLine("1 - Medium");
        Console.WriteLine("2 - Hard");
    
        string selectedDifficulty = Console.ReadLine();
        int diff = int.Parse(selectedDifficulty);
        eDiff = (EDiffuculty)diff; 
            if(diff < 3 && diff > 0 ) exitCondition = true;
        }


        Console.WriteLine("\n \n");
        return eDiff;
    }
    
}

//Show a menu on console 0-3 Math operations.
//4-5-6 is difficulty level
//7 is history of previous games.
//8 is back button
//Keep track of menu somehow..