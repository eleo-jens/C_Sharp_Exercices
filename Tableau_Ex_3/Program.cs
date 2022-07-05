using System;

namespace Tableau_Ex_3
{
    //Demandez à l’utilisateur d’introduire deux nombres au clavier 
    //et faite l’addition de ces deux nombres en ne convertissant que
    //caractère par caractère. (Méthode «ToCharArray()» de la classe «string»).
    //Bien subdiviser la tâche
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---Addition---");
            string number1, number2;
            do {
                Console.WriteLine("Indiquez un premier nombre: ");
                number1 = Console.ReadLine();
            } while (!int.TryParse(number1, out _));

            do
            {
                Console.WriteLine("Indiquez un deuxieme nombre: ");
                number2 = Console.ReadLine();
            } while (!int.TryParse(number2, out _));
            
            if(number2.Length > number1.Length)
            {
                string temp = number1;
                number1 = number2;
                number2 = temp;
            }

            for (int i = number1.Length; i < number2.Length; i++)
            {
                number1 = "0" + number1; 
                //number1 = $"0{number1}";
            }

            char[] nb1 = number1.ToCharArray();
            char[] nb2 = number2.ToCharArray();
            string result = "";
            int report= 0; // car le report doit être utilisé à chaque itération suivante 

            for (int i = nb1.Length - 1; i >= 0; i--)
            {
                // on a caractère qu'on transforme en string qu'on transforme en int
                int chiffre1 = int.Parse(nb1[i].ToString());
                int chiffre2 = int.Parse(nb2[i].ToString());
                int addition = report + chiffre1 + chiffre2;
                report = addition / 10; //pour récupérer le report ex: 13/10 = 1 ou ex: 3 / 10 = 0 donc n'impactera pas l'addition
                addition = addition % 10; //pour récupérer l'unité qui nous intéresse ex: 13 % 10 = 3

                // autre façon de le faire: 
                //if (addition > 10)
                //{
                //    report = 1;
                //    // récupère le dernier caractère de l'addition et on transforme le caractère en string et puis en int
                //    addition = int.Parse(addition.ToString()[1].ToString());
                //}
                //else report = 0;


                result = addition + result; //pour afficher dans le bon ordre ; le premier chiffre ira à la fin de notre string 
            }
            if (report > 0) result = report + result; //dans le cas où le résultat donne plus de caractères que les nombres en eux même, il faut pouvoir boucler une fois de plus ex: 99 + 1 = donnera 100 donc 3 caractères: c'est la cas du dernier report
        }

    }
}
