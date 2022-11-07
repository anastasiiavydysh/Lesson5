//Відомо, що у парних чисел молодший біт має значення 0. 
//    Використовуючи Visual Studio, створіть проект за шаблоном ConsoleApplication. 
//    Напишіть програму, яка виконуватиме перевірку чисел на парність.
//    Запропонуйте два варіанти вирішення поставленого завдання.

Console.Write("Enter your integer number -> ");
int number = Convert.ToInt32(Console.ReadLine());

if (number != 0)
{
    if ((number & 0b00000000) == 0)
        Console.WriteLine("Number is even number. Press any key.");
    else
        Console.WriteLine("Number is odd number. Press any key.");
}
else
    Console.WriteLine("Number is 0. Press any key.");

Console.ReadKey();