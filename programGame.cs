using System;

public class Game
{
    private const int MaxAttempts = 3;
    private const int TotalTasks = 5;
    private int attemptsLeft;
    private int correctAnswersCount;

    public void Run()
    {
        attemptsLeft = MaxAttempts;
        correctAnswersCount = 0;

        for (int taskNumber = 1; taskNumber <= TotalTasks; taskNumber++)
        {
            Console.WriteLine($"Задание {taskNumber}:");
            mathimating problem = new mathimating();
            if (problem.Play())
            {
                correctAnswersCount++;
                Console.WriteLine("Правильно!");
            }
            else
            {
                attemptsLeft--;
                Console.WriteLine($"Неправильно! Попробуйте еще раз. Осталось попыток: {attemptsLeft}");
            }

            if (attemptsLeft == 0)
            {
                Console.WriteLine("Вы проиграли, попробуйте еще раз.");
                Console.ReadLine();
                return;
            }
        }

        Console.WriteLine($"Игра окончена! Количество правильных ответов: {correctAnswersCount}");
        Console.ReadLine();
    }
}
