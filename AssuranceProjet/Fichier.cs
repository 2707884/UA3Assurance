using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssuranceProjet
{
    class Fichier
    {
        

        List<Contact> listeContact = new List<Contact>();


        
        //methode pour ajouter un contact
        public void AjouterContact(string nom, string prenom, string numeroTelephone, string typeNumeroTelephone)
        {
            this.listeContact.Add(new Contact(nom, prenom, numeroTelephone, typeNumeroTelephone));


        }

        // methode de recherche du contact apartir du numero de telephone
        public Contact recherche(string tel)
        {
            foreach (Contact contact in listeContact)
            {
                if (contact.NumeroTelephone.Equals(tel))
                {
                    return contact;
                }
                else
                {
                    Console.WriteLine("ce numero de contact  n'existe pas ....... ");
                    break;
                }
            }
            return null;
        }

        // methode d'affichage de la liste des contacts
        public void AfficherContact()
        {
            foreach (Contact contact in listeContact)
            {
                Console.WriteLine(contact);
            }
        }


           // methode pour quitter du programme
        public void Quitter()
        {
            Console.WriteLine("Aurevoir !!!!!!!!!");
            

        }


    }
}
    

