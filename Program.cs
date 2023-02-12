using System;
using System.Reflection.Emit;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp {
  class Program {
    private static void Main(string[] args) {
      Console.WriteLine("Введите 1 или 2 и выберите программу для выполнения (stepen/replacement)");
      int selection = int.Parse(Console.ReadLine());
      switch (selection) {  // Переключение между программами
        case 1:
          stepen();
          break;
        
        case 2:
          replacement();
          break;
      }
    }
    
    private static void stepen() {
      Console.WriteLine("Программа со степенью выбрана");
      
      Console.WriteLine("Введите число (number): ");
      int number = int.Parse(Console.ReadLine());
      
      Console.WriteLine("Введите степень (stepen):");
      int stepen = int.Parse(Console.ReadLine());
      
      int result = 1;
      double answer = 1;
      
      if (stepen > 0) {
        for (int index = 0; index < stepen; ++index) {  // Используем цикл для умножения result на number stepen раз
            result *= number;
        }
        Console.WriteLine($"a^n = {result}");
        Console.ReadKey();
      }
      if (stepen < 0) {
        stepen = stepen * -1;
        for (int index = 0; index < stepen; ++index)
        {  // Используем цикл для умножения answer на number stepen раз
            answer *= number;
        }
        answer = 1 / answer;
        Console.WriteLine($"Ответ 1/x^n = {answer}");
        Console.ReadKey();
      }
    }
    private static void replacement() {
      Console.WriteLine("Введите целое число больше 100 (x):");
      
      int number = int.Parse(Console.ReadLine());
      int digit = number;
      
      do {
        number = number / 10;
        if (number < 100) {
          do {
              number = number - 10;  // Нахождение второй цифры в числе
          
          
          }
          while (number > 10);
        }
      }
      while (number > 100);
      
      int сonclusion = int.Parse(digit.ToString().Remove(1, 1) + number);  // Подстановка второй цифры в конец числа
      Console.WriteLine($"Результат: {сonclusion}");  // Вывод результата
      Console.ReadKey();
    }
  }
}