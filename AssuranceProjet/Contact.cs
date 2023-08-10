using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssuranceProjet
{
    
    class Contact
    {
        private static int nombreContact;
        private int contactCreer;
        private string nom;
        private string prenom;
        private string numeroTelephone;
        private string typeNumeroTelephone;

        public Contact(string nom, string prenom, string numeroTelephone, string typeNumeroTelephone)
        {
            nombreContact++;
            contactCreer = nombreContact;
            this.nom = nom;
            this.prenom = prenom;
            this.numeroTelephone = numeroTelephone;
            this.typeNumeroTelephone = typeNumeroTelephone;
        }

        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string NumeroTelephone { get => numeroTelephone; set => numeroTelephone = value; }
        public string  TypeNumeroTelephone { get => typeNumeroTelephone; set => typeNumeroTelephone = value; }
        public int ContactCreer { get => contactCreer; }

        //methode d'affichage d'un contact 
        public override string ToString()
        {
            return "                 contact :"+contactCreer + "\n"+ "nom est :" + nom + "\n" + "prenom est:" + prenom + "\n" + "numeroTelephone est :" + numeroTelephone +
                "\n" + "typeNumeroTelephone est:" + typeNumeroTelephone ;
        }

        
    }
}
