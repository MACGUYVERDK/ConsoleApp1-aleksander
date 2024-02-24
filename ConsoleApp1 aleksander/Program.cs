
string name = "Ewa";
var sex = "woman";
var age = 25;

if (sex == "woman" && age < 30)
{
    Console.WriteLine("Kobieta ponizej 30 lat");
}
else if (name == "Ewa" && age == 30)
{
    Console.WriteLine("Ewa, lat 30");
}
else if (age < 18 && sex == "man")
{
    Console.WriteLine("Niepelnoletni mezczyzna");
}
