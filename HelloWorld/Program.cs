using HelloWorld.Model;
using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //value Type (memorizzati nello stack)//
            int numeroInetero = 3;
            float numeroConValoreLogico32;
            double numeroConValoreLogico64;
            bool valoreLogico;
            char carattere;
            decimal valoreDecimale;     //Molto preciso con i numeri dopo la virgola, utilizzato solitamente per valori monetari

            //reference Type (memorizzati nella heap)//
            string insiemeDiCaratteri;

            string stringa1 = "la mia casa è bella";
            string stringa2 = stringa1;

            //Console.WriteLine(stringa1);
            //Console.WriteLine(stringa2);

            object oggetto;

            
            Person luca = new Person("Luca", "Lippi");         //p oggetto con modello la classe Person
            luca.age = 18;
            Console.WriteLine(luca.Anagrafica());

            Person giovanni = luca;

            giovanni.name = "Giovanni";
            Console.WriteLine(giovanni.Anagrafica());
            

            Person andrea = new Person("Andrea", "Parodi", 170, 70);

            //Console.WriteLine(andrea.CalculateBMI());
            Console.WriteLine(andrea.Anagrafica());
        }
    }
}
