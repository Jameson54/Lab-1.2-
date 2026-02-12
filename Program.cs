using System;

class Program {
  static void Main() {
    int PowerResult = 1;
    int LoopCounter = 0; LoopCounter

    Console.WriteLine("Task 1");
    Console.Write("Enter A: ");
    int ValueA = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter N: ");
    int ExponentValue = Convert.ToInt32(Console.ReadLine());

    for (LoopCounter = 0; LoopCounter < ExponentValue; ++LoopCounter) PowerResult *= ValueA;
    Console.WriteLine($"{ValueA}^{ExponentValue} = {PowerResult}");

    Console.WriteLine("\nTask 2");
    Console.Write("Enter x (>=100): ");
    int InputValue = Convert.ToInt32(Console.ReadLine());

    int temporary = InputValue;
    int NumberOfDigits = 0;
    while (temporary > 0) {
      temporary /= 10; ++NumberOfDigits;
    }

    int SecondDigit, FinalAnswer, ModifiedNumber, RemainingPart, FirstDigit;
    
    SecondDigit = (InputValue / (int)Math.Pow(10, NumberOfDigits - 2)) % 10;
    FirstDigit = InputValue / (int)Math.Pow(10, NumberOfDigits - 1);
    RemainingPart = InputValue % (int)Math.Pow(10, NumberOfDigits - 2);
    ModifiedNumber = FirstDigit * (int)Math.Pow(10, NumberOfDigits - 2) + RemainingPart;
    FinalAnswer = ModifiedNumber * 10 + SecondDigit;

    Console.WriteLine($"x = {InputValue}");
    Console.WriteLine($"Result n = {FinalAnswer}");
  }
}
