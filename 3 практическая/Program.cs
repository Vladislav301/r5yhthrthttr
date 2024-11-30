using System;

public class MyLibraryClass
{
    // Методы типа void
    public void MethodVoid1()
    {
        Console.WriteLine("Метод void 1 выполнен.");
    }

    public void MethodVoid2(string message)
    {
        Console.WriteLine($"Метод void 2: {message}");
    }


    // Методы с возвращаемыми значениями
    public int Add(int a, int b)
    {
        return a + b;
    }

    public string GetGreeting(string name)
    {
        return $"Привет, {name}!";
    }

    public DateTime GetCurrentDateTime()
    {
        return DateTime.Now;
    }
}



