
using ClassesAndObjects;

// uzdevums telefons:

Phone phone1 = new Phone();
Console.Write(" Lūdzu ievadiet sava telefona marku: ");
phone1.Brand = Console.ReadLine();
Console.Write(" Lūdzu ievadiet sava telefona modeli: ");
phone1.Model = Console.ReadLine();
Console.WriteLine(" Lūdzu ievadiet sava telefona izmēru: ");
phone1.Size = Console.ReadLine();

Console.WriteLine($"Jūsu telefons: {phone1.Brand} {phone1.Model} ");
Console.WriteLine(" Zvanīt (a) vai sūtīt SMS (b) :");
string choice = Console.ReadLine();

if (choice == "a")
{
    Console.WriteLine("Zvana");
}
else
{
    Console.WriteLine("Sūta SMS");
}
Console.WriteLine();





// uzdevums mašīna:

Car car1 = new Car();
Console.Write(" Lūdzu ievadiet sava auto marku: ");
car1.Brand = Console.ReadLine();
Console.Write(" Lūdzu ievadiet sava auto numuru: ");
car1.NumberPlate = Console.ReadLine();
Console.Write($" Jūsu auto {car1.Brand} ar numura zīmi {car1.NumberPlate}! ");
Console.WriteLine();
car1.StartToDrive();
car1.GoFaster();
car1.Beep();
car1.SlowDown();
car1.Stop();
Console.WriteLine();



// uzdevums prece:


Console.WriteLine(" Lūdzu ievadiet preces izmērus: ");
Console.Write("Garums (cm): ");
float length = float.Parse(Console.ReadLine());
Console.Write("Platums (cm): ");
float width = float.Parse(Console.ReadLine());
Console.Write("Augstums (cm): ");
float height = float.Parse(Console.ReadLine());
Product prod1 = new Product(length, width, height);
Console.Write("Svars (kg): ");
float Weight = float.Parse(Console.ReadLine());
float dim = length * width * height;
Console.WriteLine($"Preces izmērs {dim} cm2 un svars {Weight} kg");
Console.WriteLine();




// uzdevums persona:

Person pers1 = new Person();

Console.WriteLine(" Ievadiet savu vārdu: ");
pers1.Name = Console.ReadLine();
Console.WriteLine(" Ievadiet savu uzvārdu: ");
pers1.Surname = Console.ReadLine();
Console.WriteLine(" Ievadiet savu dzimšanas datumu (DD.MM.GGGG): ");
pers1.BirthDate = DateTime.Parse(Console.ReadLine());
int dob = DateTime.Now.Year - pers1.BirthDate.Year;
Console.WriteLine(" Kāds ir Jūsu hobijs? ");
pers1.Hobby = Console.ReadLine();
Console.WriteLine(" Kāds ir Jūsu dzimums? 1) vīrietis; 2) sieviete ");
int IsMale = int.Parse(Console.ReadLine());
if (IsMale == 1)
{
    pers1.Gender = true;
}
else
{
    pers1.Gender = false;
}


Console.WriteLine();
Console.WriteLine($" Sveiks {pers1.Name} {pers1.Surname}," +
    $" Tu esi {dob} gadus vecs(-a), Tev patīk {pers1.Hobby}!");

