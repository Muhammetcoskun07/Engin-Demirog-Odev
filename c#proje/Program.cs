using c_proje.issürecleri;
using c_proje.varliklar;

Console.WriteLine("Hello. World!");
string message1 = "Krediler";
int term = 12;
double amount = 100000;

bool isAuthenticated = true;
Console.WriteLine(message1);

if (isAuthenticated)
    Console.WriteLine("Buton-->Hosgeldin Muhammet");
else
    Console.WriteLine("Buton-->Sisteme giris yap");

string[] loans = { "Kredi 1", "Kredi 2", "Kredi 3", "Kredi 4", "Kredi 5", "Kredi 6" };

for (int i=0; i<loans.Length; i++)
{
    Console.WriteLine(loans[i]);
}



CourseManager courseManager = new();
Course[] courses2 = courseManager.GetAll();

for (int i = 0; i < courses2.Length; i++)
{
    Console.WriteLine(courses2[i].Name + " / " + courses2[i].Price);
}

Console.WriteLine("kod bitti");