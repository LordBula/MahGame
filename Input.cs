using System;

public static class Input
{
    public static int GetUserAnswer()
    {
        int userAnswer;

        while (!int.TryParse(Console.ReadLine(), out userAnswer))
        {
            Console.WriteLine("Некорректный ввод. Пожалуйста, введите число:");
        }

        return userAnswer;
    }
}
