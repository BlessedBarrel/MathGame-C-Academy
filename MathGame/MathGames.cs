


public class Games
{
    public int Addition()
    {
        Random random = new Random();
        int maxLimit = ProblemDifficulty();
        
        int firstNumber = random.Next(1-maxLimit);
        int secondNumber = random.Next(1-maxLimit);
        
        int answer = firstNumber + secondNumber;

        Console.WriteLine(firstNumber + " + " + secondNumber);
        return answer;
    }

    public int Subtraction()
    {
        Random random = new Random();
        int maxLimit = ProblemDifficulty();
        
        int firstNumber = random.Next(1-maxLimit);
        int secondNumber = random.Next(1-maxLimit);
        
        int answer = firstNumber - secondNumber;

        Console.WriteLine(firstNumber + " - " + secondNumber);
        return answer;
    }

    public int Multiplication()
    {
        Random random = new Random();
        int maxLimit = ProblemDifficulty();
        
        int firstNumber = random.Next(1-maxLimit);
        int secondNumber = random.Next(1-maxLimit);
        
        int answer = firstNumber * secondNumber;

        Console.WriteLine(firstNumber + " * " + secondNumber);
        return answer;
    }

    public int Division()
    {
        Random random = new Random();
        int maxLimit = ProblemDifficulty();
        int answer;
        int firstNumber;
        int secondNumber;
        do
        {
            firstNumber = random.Next(1-maxLimit);
            secondNumber = random.Next(1-maxLimit);
        
            answer = firstNumber/secondNumber; //5/2 -- 2.5
        }
        while (answer * 10 % 10 == 0);

        Console.WriteLine(firstNumber + " * " + secondNumber);
        return answer;
    }

    private int GetDifficulty()
    {
        throw new NotImplementedException();
    }
    private int ProblemDifficulty()
    {
        int difficulty = GetDifficulty();
        int factor;
        
        switch (difficulty)
        {
            case 1:
                factor = 100;
                break;
            case 2:
                factor = 1000;  
                break;
            case 3:
                factor = 1000;  
                break;
            default:
            throw new ArgumentException("Invalid difficulty level.");
        }

        return factor;
    }
}