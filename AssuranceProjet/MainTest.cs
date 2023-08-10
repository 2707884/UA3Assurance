using System;
using System.Collections.Generic;

namespace AssuranceProjet
{
    internal class MainTest
    {

        static void Main(string[] args)
        {

            Fichier fiche = new Fichier();
            string nombreiteration;


            do
            {
                Console.WriteLine("                                       Menu                                ");
                Console.WriteLine("1.   Ajouter un contact ");
                Console.WriteLine("2.   Chercher un numero de telephone d'une personne  ");
                Console.WriteLine("3.   Afficher le contenu du repertoire ");
                Console.WriteLine("4.   Quitter le programme ");


                Console.WriteLine("choisir votre option : (1,2,3,4)");
                Console.Write("option = ");
                int option = int.Parse(Console.ReadLine());
                if (option == 1)
                {
                    Console.WriteLine("entrer un nom :");
                    string nom = Console.ReadLine();
                    Console.WriteLine("entrer un prenom :");
                    string prenom = Console.ReadLine();
                    Console.WriteLine("entrer un numero de telephone :");
                    string telephone = Console.ReadLine();
                    Console.WriteLine("entrer un type de numero de telephone : Domicile/Portable ");
                    string type = Console.ReadLine();
                    fiche.AjouterContact(nom, prenom, telephone, type);
                    Console.WriteLine("voulez vous encore effectuer une action ????  oui/non");
                    nombreiteration = Console.ReadLine();
                    if (nombreiteration == "non")
                    {
                        fiche.AfficherContact();
                        break;
                    }
                }
                else if (option == 2)
                {
                    Console.WriteLine("entrer un numero de telephone :");
                    string telephone = Console.ReadLine();
                    Contact reponse = fiche.recherche(telephone);
                    if (reponse != null)
                    {
                        Console.WriteLine(reponse);
                    }
                    else
                    {
                        break;
                    }

                    Console.WriteLine("voulez vous encore effectuer une action ????  oui/non");
                    nombreiteration = Console.ReadLine();
                    if (nombreiteration == "non")
                    {
                        break;
                    }


                }

                else if (option == 3)
                {
                    fiche.AfficherContact();

                    Console.WriteLine("voulez vous encore effectuer une action ????  oui/non");
                    nombreiteration = Console.ReadLine();
                    if (nombreiteration == "non")
                    {
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("voulez vous reellement quitter ??? O/N");
                    Console.Write("answer = ");
                    string answer = Console.ReadLine();
                    if (answer == "O")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("voulez vous encore effectuer une action ???? oui /non");
                        Console.Write("nombreiteration = ");
                        nombreiteration = Console.ReadLine();
                        if (nombreiteration == "non")
                        {
                            break;
                        }
                    }

                }


            } while (nombreiteration == "oui");
        }

    
    }   
}

    

