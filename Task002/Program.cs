// Задача 2. 
// Напишите программу котораяя на вход принимает два числа и выдаёт какое число большее а какое меньшее.
// Например:
	// a = 5; b = 7; -> max = 7
	// a = 2; b = 10; -> max = 10
	// a = -9; b = -3; -> max = -3
Console.WriteLine("Введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());
int max;
int min;
if (number1 > number2){
max = number1;
min = number2;
Console.WriteLine($"max -> {max}");
Console.WriteLine($"min -> {min}");
}

else if (number2 > number1 ) {
    max = number2;
    min = number1;
    Console.WriteLine($"max -> {max}");
    Console.WriteLine($"min -> {min}");
}
else if (number1 == number2) {
    Console.WriteLine($"{number1} и {number2} равны");
}
else {
    Console.WriteLine("Вы ввели неверные данные");
}

