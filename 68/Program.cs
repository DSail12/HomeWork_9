// Задача 68. 
// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9

int AkkermanFunction(int numberM, int numberN)
{
    if (numberM == 0)
    {
        return numberN +1;
    }
    else
    {
        if ((numberM !=0) && (numberN == 0))
        {
            return AkkermanFunction(numberM - 1, 1);
        }
            else
            {
                return AkkermanFunction(numberM - 1, AkkermanFunction(numberM, numberN - 1));
            }
        }
    }
    Console.Write("Введите пожалуйста значение M = ");
    int numberM = Convert.ToInt16(Console.ReadLine());

    Console.Write("Введите пожалуйста значение N = ");
    int numberN = Convert.ToInt16(Console.ReadLine());

Console.Write("Результат вычисления функции Аккермана: " + AkkermanFunction(numberM, numberN));