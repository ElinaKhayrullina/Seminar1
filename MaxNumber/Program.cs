// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// Entering the data
/*
Console.WriteLine("Input number 1");
int number1= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number 2");
int number2= Convert.ToInt32(Console.ReadLine());
//Finding the maximum number
if (number1>number2){
    Console.WriteLine("Max number is "+number1);
}
else{
   Console.WriteLine("Max number is "+number2); 
}
*/
//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// Entering the data
/*
Console.WriteLine("Input number 1");
int number1= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number 2");
int number2= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number 3");
int number3= Convert.ToInt32(Console.ReadLine());
//Finding the maximum number
int max = number1;
if (number2>max){
    max=number2;
}
if (number3>max) {
   max=number3; 
}
//Displaying a number on the screen
Console.WriteLine("Max number is "+max); 
*/
//Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка).
/*
Console.WriteLine("Input number");
int number= Convert.ToInt32(Console.ReadLine());

//Finding the even number

if (number%2==0){
    Console.WriteLine(number + " is even"); 
}
else {
   Console.WriteLine(number + " is odd"); 
}
*/
//Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Input positive number");
int number= Convert.ToInt32(Console.ReadLine());

//Finding the even numbers
int firstNumber =1;

while (firstNumber<=number){
   if (firstNumber%2==0){
    Console.WriteLine(firstNumber); 
} 
firstNumber++;
}
