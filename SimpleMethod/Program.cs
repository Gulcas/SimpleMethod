using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMethod
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.Write("Your name: ");
            string name = Console.ReadLine();

            Console.Write("Your surname: ");
            string surname = Console.ReadLine();

            Console.Write("Your city: ");
            string city = Console.ReadLine();

            /* char[] nameLiterki = name.ToCharArray();
             Array.Reverse(nameLiterki);

             char[] surnameLiterki = surname.ToCharArray();
             Array.Reverse(surnameLiterki);

             char[] cityLiterki = city.ToCharArray();
             Array.Reverse(cityLiterki);

             foreach (char literki in nameLiterki)
             {
                 Console.Write(literki);
             }

             foreach (char literki in surnameLiterki)
             {
                 Console.Write(literki);
             }

             foreach (char literki in cityLiterki)
             {
                 Console.Write(literki);
             }
             */
            Console.WriteLine(name + surname + city); //wyrzucam na konsolę zebrane dane
            ReverseString(name); //przywołuję metodę i daje jej parametr określony wcześniej
            ReverseString(surname);
            DisplayString(ReverseStringTwo(city)); //przywołuję metodę drukującą na ekranie 
                                                   //ale wcześniej przekazuje jej parametr którym jest wynik innej metody, 
                                                   //można też połączyć kilka parametrów w tym miejscu 
                                                   //co sprawi że będą jednym długim stringiem,  
                                                   //np: DisplayString(ReverseStringTwo(city) + ReverseStringTwo(name));
            Console.ReadLine();

        }

        private static void ReverseString(string message) //utworzona metoda przyjmuje parametr i używa go jako message, 
                                                          //metody powinny być krótkie-6 linijek kodu
        {
            char[] literki = message.ToCharArray(); //przyjmuje parametr i rozbija go na pojedyńcze znaki
            Array.Reverse(literki); //odwraca kolejność pojedyńczych znaków

            foreach (char znaki in literki) //wykorzystuje pętlę by zwrócić wątek odwróconych znaków
            {
                Console.Write(znaki);
            }
        }

        private static string ReverseStringTwo(string message) //utworzona metoda przyjmuje parametr i używa go jako message
        {
            char[] literki = message.ToCharArray(); //przyjmuje parametr i rozbija go na pojedyńcze znaki
            Array.Reverse(literki); //odwraca kolejność pojedyńczych znaków

            return String.Concat(literki); //zwraca stringa ze z utworzonej wcześniej listy array

        }

        private static void DisplayString(string reverseCity) //tu po przecinku można dodawać paremetry 
                                                              //albo sprawić by przekazywany parametr był jednym długim stringiem
        {
            Console.Write(String.Format("{0}", reverseCity)); //wyrzucam na konsolę ileś tam naście stringów bez namnażania kodu
        }




    }
}
