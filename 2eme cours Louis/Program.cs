// See https://aka.ms/new-console-template for more information
using _2eme_cours_Louis;

Console.WriteLine("Hello, World!");

//ici, on instancie une classe, c'est a dire que je vais creer un personnage qui contiendra toute les infos déclarée dans la classe Personnage
Personnage Renaud = new Personnage("Renaud", 29, "Mâle"); //nom de la classe appelée, nom donné a l'instanciation, puis TOUJOURS = new nomdelaclasseappelée

//Renaud.Nom = "Renaud";
//Renaud._age = 29;
//Renaud.Sexe = "Mâle";

Personnage Louis = new Personnage("Louis", 28, "Mâle");

//Louis.Nom = "Louis";
//Louis._age = 28;
//Louis.Sexe = "Mâle";

Personnage Anton = new Personnage("Anton", 28, "Femelle");

// controle+k+c mettre tout en commentaire et controle+k+u remettre tout normale

Console.WriteLine(Renaud.Nom);
Console.WriteLine(Renaud._age);
Console.WriteLine(Renaud.Sexe);

Console.WriteLine(Louis.Nom);
Console.WriteLine(Louis.PV);
Renaud.Attaque(Louis);
Console.WriteLine(Louis.Nom);
Console.WriteLine(Louis.PV);


Console.WriteLine(Anton.Nom);
Console.WriteLine(Anton.PV);
Renaud.Attaque(Anton);
Console.WriteLine(Anton.Nom);
Console.WriteLine(Anton.PV);

Console.WriteLine(Renaud.PV);
Console.WriteLine(Renaud.GetPV());

