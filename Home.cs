using System;

public class Class1
{
    public Class1()
    {
        static void Main(string[] args)
        {
            x = input().split() //строка с числами разделенными пробелами на вход
            if len(x) == 1:
                print(x[0])
            else if len(x) > 1: //создаю новый список
                y = [int(x[i - 1]) + int(x[i + 1]) for i in range(-1, len(x) - 1)]
            for i in range(1, len(y)):
                print(y[i], end = ' ') //вывожу значения со второго до последнего
            print(y[0]) //вывожу первое значение

            Random rnd = new Random();
            int j = rnd.Next(10);
            a = [j for i in range(10)]
            print(a)
            b = [i for i in a if i % 2 == 0] + [i for i in a if I % 2 != 0]
            print(b)

        }
    }
}
