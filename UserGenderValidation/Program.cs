// See https://aka.ms/new-console-template for more information

//rakendus küsib kasutajal valida tema sugu (m/f)
//Rakendus küsib kasutajal sisestada oma perekonnanime
//lähtudes kasutaja valikust, rakendus tervitab kasutajat järgnevalt:
//"Welcome, Mr. [kasutaja perekonnanimi]" / "Welcome, Ms [kasutaja perekonnanimi]"

Console.WriteLine("please, select your gender (m/f):");

Char userGender = char.Parse(Console.ReadLine()); //loeb konsoolist maha andmeid string (sõne) formaadis

Console.WriteLine("Please, enter your surname:");
string usersurname = Console.ReadLine();


if (userGender == 'm')
{
    Console.WriteLine($"Welcome, Mr. {usersurname}!");
}
else if (userGender == 'f')
{
    Console.WriteLine($"Welcome, Ms. {usersurname}!");
}
else
{
    Console.WriteLine($"Welcome, {usersurname}!");
}