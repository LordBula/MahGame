using System;

public class mathimating
{
    private readonly Random random = new Random();

    public bool Play()
    {
        int number1 = GenerateRandomNumber();
        int number2 = GenerateRandomNumber();

        int sum = number1 + number2;

        Console.WriteLine($"Сложите два числа: {number1} + {number2}");
        int userAnswer = Input.GetUserAnswer();

        return userAnswer == sum;
    }

    private int GenerateRandomNumber()
    {
        return random.Next(1, 101);
    }
}
