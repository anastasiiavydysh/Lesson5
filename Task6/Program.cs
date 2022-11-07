//Відомо, що у чисел, які є ступенем двійки, тільки один біт має значення 1. 
//    Використовуючи Visual Studio, створіть проект шаблону Console Application. 
//    Напишіть програму, яка виконуватиме перевірку – чи є вказане число ступенем двійки чи ні.

Console.Write("Enter your number from interval [0;256) -> ");
byte number = Convert.ToByte(Console.ReadLine());

int count = 0;
if ((number & (1 << 0)) == 1) //0000 0000
    count++;
number >>= 1;

if ((number & (1 << 0)) == 1) //1000 0000
    count++;
number >>= 1;

if ((number & (1 << 0)) == 1) //1100 0000
    count++;
number >>= 1;

if ((number & (1 << 0)) == 1) //1110 0000
    count++;
number >>= 1;

if ((number & (1 << 0)) == 1) //1111 0000
    count++;
number >>= 1;

if ((number & (1 << 0)) == 1) //1111 1000
    count++;
number >>= 1;

if ((number & (1 << 0)) == 1) //1111 1100
    count++;
number >>= 1;

if ((number & (1 << 0)) == 1) //1111 1110
    count++;

if(count == 1)
    Console.WriteLine("The number is a power of two. Press any key");
else
    Console.WriteLine("The number is NOT a power of two. Press any key");

Console.ReadLine();