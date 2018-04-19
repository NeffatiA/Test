using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceEtudiant
{
    class Etudiant
    {
        string nom;
        string prenom;
        int[] tabnotes; 
        float moyennne;
        public Etudiant()
        {
            tabnotes = new int[10];
        }
        
        void saisie()
        {
            Console.WriteLine(" Veuiller entrer le nom et prenom de l'etudiant");
            nom = Console.ReadLine();
            prenom = Console.ReadLine();
            Console.WriteLine("Vous avez entrer " + nom +" "+ prenom);

            //Console.WriteLine("Quel sont sa note? ");
            int a;
            for (a=0; a<10; a++)
            {
                Console.WriteLine("Quel sont sa note "+a+" ?");
                tabnotes[a] = Convert.ToInt32(Console.ReadLine());
            }
        }

       /* void affichage()
        {
            Console.WriteLine("Vous avez entrer " + nom + prenom);
        }*/

        
        
        float moyenne()
        {
            /*float A;
            moyennne = tabnotes[0] + tabnotes[1] + tabnotes[2] + tabnotes[3] + tabnotes[4] + tabnotes[5] + tabnotes[6] + tabnotes[7] + tabnotes[8] + tabnotes[9];
            A = moyennne % 2;*/
            // return moyennne;
            int i;
            float sum=0;
            for ( i=0; i<10; i++)
            {
                sum += tabnotes[i];
            }
            sum = sum / 10;

            Console.WriteLine("La moyenne est de " + moyenne());
            return sum;
            
        }


        int Admis()
        {
            if (moyennne >= 10)
            {
                Console.WriteLine("\n1");
            }
            else
            {
                Console.WriteLine("\n0");
            }
            return 0;
        }

        
        int exaequo(Etudiant E)
        {
            
            //incomplet
            return 0;
        }
      


        public static void Main()
        {
            Etudiant etudiant = new Etudiant();
            etudiant.saisie();
            //etudiant.affichage();
            etudiant.Admis();
            etudiant.moyenne();
            Console.WriteLine(etudiant.moyenne());
            Console.ReadKey();
           
        }
    }
}
