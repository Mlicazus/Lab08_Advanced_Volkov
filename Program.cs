// // Шаг 2. CountDown и первая модификация

// void CountUp(int i, int n) // здесь я добавил i, как число, с которого мы начинаем
// {

//     if (i > n) // здесь поменял условие так, чтобы метод работал до ограничения в виде n
//     {
//         Console.WriteLine("Пуск!");
//         return;
//     }
//     Console.WriteLine(i); // вывожу на экран i вместо n
//     CountUp(i + 1, n); // теперь здесь я добавляю к i единицу, n не трогаю
// }
// CountUp(1, 5);

// // Шаг 3. Соберите SumToN с трассировкой самостоятельно

// int SumToN(int n)
// {
//     Console.WriteLine($"Вход: {n}");
//     if (n == 1)
//     {
//         return 1;
//     }
//     int result = n + SumToN(n - 1);
//     System.Console.WriteLine($"Выход: {n}, result = {result}");
//     return result;
// }
// SumToN(5);

// // Шаг 4. Глубина рекурсии

// void CountDownWithDepth(int n, int depth)
// {
//     Console.WriteLine($"{new string(' ', depth * 2)}Вызов: n={n}");
//     if (n == 0)
//         return;
//     CountDownWithDepth(n - 1, depth + 1);
// }
// CountDownWithDepth(3, 1);
