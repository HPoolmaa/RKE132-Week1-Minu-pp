// See on kommentaar minu koodile - rohelisega märgistatakse koodi vahel olevaid kommentaare mis ei osale rakenduse töös. Kommentaari ees peab olema kaks kaldkriipsu.

// Ülesanne -
// 1. Rakendus küsib kasutajalt, et ta sisestaks oma nime
// 2. Rakendus tervitab kasutajat sisestatud nime järgi
Console.WriteLine("Sisesta oma nimi:");
// String - "Sõne" - ei ole "Sõna" mis on valesti kirjutatud :)
string UserName = Console.ReadLine();

// Console.WriteLine("Tere, " + UserName + "!");
// Saab kasutada ka ("Tere" + ", " + UserName + "!")

// Kasutame stringi interpolatsiooni
Console.WriteLine($"Tere, {UserName}!");