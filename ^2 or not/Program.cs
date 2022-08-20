Console.WriteLine("Input number");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number squared");
int squaredNumber = Convert.ToInt32(Console.ReadLine());

if (squaredNumber==number*number){
 Console.WriteLine(squaredNumber+ " is square of "+ number);   
}
else {
    Console.WriteLine(squaredNumber+ " is not square of "+ number); 
}
