// Task №2
Console.WriteLine ("Input number 1: ");
int number1 = Convert.ToInt32(Console.ReadLine ());
Console.WriteLine ("Input number 2: ");
int number2 = Convert.ToInt32(Console.ReadLine ());
if (number1>number2)
     Console.WriteLine ("Max=: "+ number1);
else if (number1==number2)
    Console.WriteLine ("You input two same numbers");
else 
    Console.WriteLine ("Max=: "+ number2);

// Task №4   
Console.WriteLine ("Input number 1: ");
int number1 = Convert.ToInt32(Console.ReadLine ());
Console.WriteLine ("Input number 2: ");
int number2 = Convert.ToInt32(Console.ReadLine ());
Console.WriteLine ("Input number 2: ");
int number3 = Convert.ToInt32(Console.ReadLine ());
int maxNumber=number1;
if (number2>number1) maxNumber=number2;
if (number3>number2) maxNumber=number3;
    Console.WriteLine ("Max=: "+ maxNumber);

// Task №6
Console.WriteLine ("Input number: ");
int number = Convert.ToInt32(Console.ReadLine ());
if (number%2==0) Console.WriteLine ("Yes. This number share on 2");
else Console.WriteLine ("No. This number no share on 2");

