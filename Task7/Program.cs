//Використовуючи Visual Studio, створіть проект за шаблоном Console Application. 
//    Використовуючи теорему Де Моргана, перетворіть вихідний вираз A | B, в еквівалентний вираз.

bool A = false;
bool B = false;

Console.WriteLine("A | B = " + (A | B));
// | -> &
// A -> !A
// B -> !B
// () -> !()
Console.WriteLine("!(!A & !B) = " + !(!A & !B));

Console.ReadKey();