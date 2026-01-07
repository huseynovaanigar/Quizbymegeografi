using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizbymegeografi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hej och välkommen till Quiz om Geografi");



            while (true)

            { //skaffa menysystem 

                Console.WriteLine("Meny");

                Console.WriteLine("1. Trycker du 1-- Börja Spel");

                Console.WriteLine("2. Trycker du på 0-- Avsluta Program");

                Console.WriteLine("3. Inmatar du alfabet eller en sträng stängs programmet");

                int input;

                //felhantering av användning try catch metod 

                try

                {

                    input = int.Parse(Console.ReadLine());

                }

                catch (FormatException)

                {

                    Console.WriteLine("Ogiltig inmatning. Ange ett giltigt nummer.");

                    continue;

                }



                if (input == 1)

                {

                    SpelaQuiz();

                    Console.WriteLine("Programmet startas");

                }

                else if (input == 0)

                {

                    Console.WriteLine("Programmet stängs...");

                    break;

                }

                else

                {

                    Console.WriteLine("Ogiltigt val. Vänligen välj 1 för att börja spelet eller 0 för att avsluta programmet.");

                }

                Console.ReadKey();

            }

        }



        //skaffa en metod här föratt sedan använda det i Main  

        static void SpelaQuiz()

        {

            string[] frågor = { "Vilket är det största vattenfallet i världen?",

                            "Vilken är den längsta floden?",

                            "Vilken är den högste toppen?",

                            "Vilken är planeten närmast jorden?",

                            "Det största andra landet i världen efter yta",

                            "Vad heter sundet som skiljer Europa från Afrika?",

                            "Vem upptäckte Amerika?",

                            "Grönland är en del av?",

                            "Vilket land ligger på en halvö och dess huvudstad ligger på en ö?",

                            "Vilken av dessa är den djupaste sjön?" };



            string[] svar = { "A. Viktoria \nB.Angel \nC.Niaqara ",

                         "A. Amazon \nB. Dnepr \nC.Nil",

                         "A. Everest \nB.Klimanjaro \nC.Mak-Kinli",

                         "A. Venus \nB. Mars \nC.Merkuri",

                         "A. USA \nB. Kina \nC.Kanada",

                         "A. Bering \nB.Magellan \nC. Gibraltar",

                         "A.Cristofer Columb \nB. Ameriko Vespuci \nC.Jeyms Kuk",

                         "A. Frankrike \nB. England \nC. Danmark",

                         "A. Turkiet \nB. Danmark \nC. Portugalien",

                         "A. Baikalsjön \nB. Kaspiska havet \nC. Tanqanika" };



            int[] rättasvar = { 1, 2, 2, 0, 2, 2, 0, 2, 1, 0 };



            int score = 0;

            //loop i det här fallet använde jag "For" loopen 

            for (int i = 0; i < frågor.Length; i++)

            {

                Console.WriteLine("Fråga " + (i + 1) + ": " + frågor[i]);

                Console.WriteLine(svar[i]);

                Console.WriteLine("Mäta in ditt svar (A. B. C)");

                string spelarensvar = Console.ReadLine();

                //här spelar det ingen stort roll med vilken bokstav vi skriver in utan den ska alltid compare med rätta svar den som motsvarar till rätta index  



                if (string.Equals(spelarensvar, "B", StringComparison.OrdinalIgnoreCase) && rättasvar[i] == 1)

                {

                    score++;

                }

                else if (string.Equals(spelarensvar, "C", StringComparison.OrdinalIgnoreCase) && rättasvar[i] == 2)

                {

                    score++;

                }

                else if (string.Equals(spelarensvar, "A", StringComparison.OrdinalIgnoreCase) && rättasvar[i] == 2)

                {

                    score++;

                }

                else if (string.Equals(spelarensvar, "A", StringComparison.OrdinalIgnoreCase) && rättasvar[i] == 0)

                {

                    score++;

                }

                else if (string.Equals(spelarensvar, "C", StringComparison.OrdinalIgnoreCase) && rättasvar[i] == 2)

                {

                    score++;

                }

                else if (string.Equals(spelarensvar, "A", StringComparison.OrdinalIgnoreCase) && rättasvar[i] == 2)

                {

                    score++;

                }

                else if (string.Equals(spelarensvar, "A", StringComparison.OrdinalIgnoreCase) && rättasvar[i] == 0)

                {

                    score++;

                }

                else if (string.Equals(spelarensvar, "C", StringComparison.OrdinalIgnoreCase) && rättasvar[i] == 2)

                {

                    score++;

                }

                else if (string.Equals(spelarensvar, "B", StringComparison.OrdinalIgnoreCase) && rättasvar[i] == 1)

                {

                    score++;

                }

                else if (string.Equals(spelarensvar, "A", StringComparison.OrdinalIgnoreCase) && rättasvar[i] == 0)

                {

                    score++;

                }

                Console.WriteLine("Poängen du samlade - " + score + "/" + frågor.Length);

            }



            Console.ReadLine();

        }



    }




}
    

