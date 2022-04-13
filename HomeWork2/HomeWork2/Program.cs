


Console.Write("Kāds Tevi sauc? ");
string name = Console.ReadLine();
Console.WriteLine($"Sveiks  {name} !");

Console.Write("Kāds ir Tavs vecums? ");
string age = Console.ReadLine();
int ageString = int.Parse(age);
int PlusOne = ageString + 1;
if (ageString >= 18)
{
    Console.WriteLine("Tu esi pilngadīgs!");
}
else
{
    Console.WriteLine("Tu neesi pilngadīgs!");
}
Console.WriteLine($"Nākamgad Tev paliks " + PlusOne + " gadi!");



Console.WriteLine();
Console.WriteLine("=======================================================================================================");
Console.WriteLine();



Console.Write("Lūdzu ievadiet skaitli: ");
string firstNumber = Console.ReadLine();
int firstNumberString = int.Parse(firstNumber);

Console.Write("Lūdzu ievadiet citu skaitli: ");
string secondNumber = Console.ReadLine();
int secondNumberString = int.Parse(secondNumber);

Console.Write("Lūdzu ievadiet vēl vienu skaitli: ");
string thirdNumber = Console.ReadLine();
int thirdNumberString = int.Parse(thirdNumber);

int ALargestNumber = Math.Max(firstNumberString, secondNumberString);
int BLargestNumber = Math.Max(ALargestNumber, thirdNumberString);
int AsmallestNumber = Math.Min(firstNumberString, secondNumberString);
int BsmallestNumber = Math.Min(AsmallestNumber, thirdNumberString);

Console.WriteLine();
Console.WriteLine("Lielākais skaitlis: " + BLargestNumber);
Console.WriteLine("Mazākais skaitlis: " + BsmallestNumber);

Console.WriteLine();
Console.WriteLine("Lielākā un mazākā skaitla dalījuma atlikums: " + BLargestNumber % BsmallestNumber);


Console.WriteLine();
if (BLargestNumber % 2 == 0)
{
    Console.WriteLine("Lielākais ievadītais skaitlis ir pāris");
}
else
{
    Console.WriteLine("Lielākais ievadītais skaitlis ir nepāris");
}

Console.WriteLine();
Console.WriteLine("=======================================================================================================");
Console.WriteLine();

Console.Write("Lūdzu ievadiet taisnstūra garumu (cm) : ");
string lenght1 = Console.ReadLine();
double Alenght = double.Parse(lenght1);

Console.Write("Lūdzu ievadiet taisnstūra platumu (cm) : ");
string width1 = Console.ReadLine();
double Awidth = double.Parse(width1);
double area1 = Math.Round(Awidth * Alenght, 2);

Console.WriteLine();
Console.Write("Taisnstūra laukums: " + area1 + " (cm)");


Console.WriteLine();
Console.WriteLine("=======================================================================================================");
Console.WriteLine();

Console.Write("Lūdzu ievadiet taisnleņķa trijstūra sānu malu garumu (cm) : ");
string lenght2 = Console.ReadLine();
double Blenght = double.Parse(lenght2);

Console.Write("Lūdzu ievadiet taisnleņķa trijstūra pamatnes garumu (cm) : ");
string width2 = Console.ReadLine();
double Bwidth = double.Parse(width2);
double area2 = Math.Round((Bwidth * Blenght) / 2, 2);

Console.WriteLine();
Console.Write("Trijstūra laukums: " + area2 + " (cm)");



Console.WriteLine();
Console.WriteLine("=======================================================================================================");
Console.WriteLine();



Console.Write("Kāds ir Tavs vārds? ");
string FirstName = Console.ReadLine();

Console.Write("Kāds ir Tavs vecums? ");
string YourAge = Console.ReadLine();


Console.WriteLine($"Sveiks  {FirstName}, Tavs vecums ir {YourAge} gadi !");


