


public static class Games
{
    
    static int difficultyLevel = 100;
    private static bool Answer(int fn, int sn, int _answer, string symbol)
    {
        int anss = 0;

        RecordKeep.RecordData( fn.ToString() , sn.ToString() ,_answer.ToString(), symbol);
        
        string ans = Console.ReadLine();
        
        bool isParsed = false;
        while(isParsed == false)
        {
            isParsed = int.TryParse(ans, out anss);
            if(isParsed == false) 
            {
                Console.WriteLine("Enter Valid Answer");
                ans = Console.ReadLine();
            }
        }

        if(anss == _answer)
        {
            return true;
        }
        
        return false;

    }
    public static bool Addition()
    {
        Random random = new Random();
        int maxLimit = difficultyLevel;
        
        int firstNumber = random.Next(1,maxLimit);
        int secondNumber = random.Next(1,maxLimit);
        
        int answer = firstNumber + secondNumber;
        Console.WriteLine(firstNumber + " + " + secondNumber);
        
        bool isPass = Answer(firstNumber, secondNumber, answer, new string("+"));

        return isPass;
    }

    public static bool Subtraction()
    {
        Random random = new Random();
        int maxLimit = difficultyLevel;
        
        int firstNumber = random.Next(1,maxLimit);
        int secondNumber = random.Next(1,maxLimit);
        
        int answer = firstNumber - secondNumber;

        Console.WriteLine(firstNumber + " - " + secondNumber);

        bool isPass = Answer(firstNumber, secondNumber, answer, new string("-"));

        return isPass;
    }

    public static bool Multiplication()
    {
        Random random = new Random();
        int maxLimit = difficultyLevel;
        
        int firstNumber = random.Next(1,maxLimit);
        int secondNumber = random.Next(1,maxLimit);
        
        int answer = firstNumber * secondNumber;

        Console.WriteLine(firstNumber + " * " + secondNumber);
        bool isPass = Answer(firstNumber, secondNumber, answer, new string("*"));

        return isPass;
    }

    public static bool Division()
    {
        Random random = new Random();
        int maxLimit = difficultyLevel;
        float IntAnswer;
        int firstNumber;
        int secondNumber;
        do
        {
            firstNumber = random.Next(1,maxLimit);
            secondNumber = random.Next(1,maxLimit);
        
            IntAnswer = (float) firstNumber/secondNumber; //now this will do floating point division.
        }
         while ( MathF.Floor(IntAnswer) != IntAnswer);
        // while ( IntAnswer * 10 % 10 != 0);

        Console.WriteLine(firstNumber + " / " + secondNumber);
        bool isPass = Answer(firstNumber, secondNumber, firstNumber/secondNumber, new string("/"));

        return isPass;
    }

    public static void  ProblemDifficulty(EDiffuculty diff)
    {
        switch (diff)
        {
            case EDiffuculty.Easy :
                difficultyLevel = 100;
                break;
            case EDiffuculty.Medium:
                difficultyLevel = 1000;  
                break;
            case EDiffuculty.Hard:
                difficultyLevel = 1000;  
                break;
            default:
            throw new ArgumentException("Invalid difficulty level.");
        }
    }
}