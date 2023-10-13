using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2eme_cours_Louis
{

    // acces: public, type: classe, nom de la classe: personnage
    public class Personnage
    {
        public string _nom; //par convention on nome une variable de cette facon: underscore+nom en minuscule

        public int _age;

        public string Nom //propriete (variable ++) s'appele Nom car elle est liée a la variable _nom
        {
            get
            {
                Console.WriteLine("get du nom est appelé");
                return _nom;
            }

            set
            {
                Console.WriteLine("set du nom est appelé");
                _nom = value;
            }
        }
        public string Sexe { get; set; } // reviens au meme que ce qu'on a fait pour "Nom" mais le get et le set sont sous-entendu

        public int PV { get; set; } 

        public int PA { get; set; }

        public Personnage(string nom, int age, string sexe)//ici on crée un constructeur, une structure qui comprend l'instanciation d'une classe et tout ce qu'elle comporte (ici nom, age, sexe), s'ecrit toujours: acces+nomdelaclasse+parenthese
        {
            Console.WriteLine("classe Personnage est instanciée");
            Nom = nom;
            _age = age;
            Sexe = sexe;
            PV = 100;
            PA = 5;
        }

        public void Attaque(Personnage adversaire) // ici on crée une methode (une action): acces, void(car pas de retour), et on la nomme et dans parenthese le sujet de l'acttion
        {
            Console.WriteLine($"{Nom} attaque {adversaire.Nom}");
            adversaire.PV -= PA;
        }

        public int GetPV()
        {
            return PV;
        }





















    }
}
