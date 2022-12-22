using RefactoringAufgabe;

double a;
double b;
double c;

Console.Write("Seitenlänge1: ");
a = Convert.ToDouble(Console.ReadLine());

Console.Write("Seitenlänge2: ");
b = Convert.ToDouble(Console.ReadLine());

Console.Write("Seitenlänge3: ");
c = Convert.ToDouble(Console.ReadLine());

Dreieck dreieck1 = new Dreieck(a, b, c);

Console.WriteLine(dreieck1.Fläche);







