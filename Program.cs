using System;

namespace Gissa_talet
{
    class Program
    {
        static void Main(string[] args)
        {
            //I denna uppgift ska du skapa ett klassiskt spel. 
            //Spelet går till så att datorn slumpvis hittar på ett tal mellan 1 och 100. 
            //Förklara spelet.(Jag har gjort delar av detta spel i Programmering 1 så jag använder det.)
            Console.WriteLine("Let's play! Guess what number I am thinking of! ");           
            //Slumpa fram ett heltal mellan 0 och 100.
            Random randomerare = new Random();
            int slump = randomerare.Next(1,101);
            //Användaren ska sedan gissa talet.
            Console.WriteLine("Enter a number between 1 and 100, please: ");
            string tal = Console.ReadLine(); //Läs in tal från användaren.
            int element = Convert.ToInt32(tal); //Omvandlar inmatat till heltal.   
            int counter = 0;
            while (element != slump)
            {                 
                //Gissar man fel svarar programmet "Fel. Talet är mindre." 
                if (element > slump)
                {
                    Console.WriteLine("Try a smaller number: ");
                    tal = Console.ReadLine();
                    element = Convert.ToInt32(tal);
                }
                //respektive "Fel. Talet är större."
                else if (element < slump)
                {
                    Console.WriteLine("Try a larger number: ");
                    tal = Console.ReadLine();
                    element = Convert.ToInt32(tal);
                } 
                //I slutet skriver programmet ut antalet försök. 
                counter++;                                                    
            }
            //Gissar du rätt tal skriver programmet ut en grattis fras.
            if (element == slump)       
            {                
                Console.WriteLine("The number " + slump + " is a match! You win! You tried " + counter + " times!" );
            }
            Console.Read();
        
            //Programmet ska hantera undantag dvs skriver man något annat än ett tal 
            //ska programmet hantera detta på lämpligt sätt. 
               
        }        
    }
}
