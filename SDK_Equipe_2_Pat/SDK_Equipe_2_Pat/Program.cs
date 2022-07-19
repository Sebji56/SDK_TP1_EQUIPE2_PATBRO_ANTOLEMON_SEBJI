using System;
using LibrairieConversionNote;

namespace SDK_Equipe_2_Pat
{
    class Program
    {
        static void Main(string[] args)
        {
            ConversionAlphabetiqueToNote maison = new ConversionAlphabetiqueToNote();
            

            
                Console.Write("Type de conversion à faire : ");
                var input = Console.ReadLine();

                //Si l'utilisateur tape note
                if (input?.ToUpperInvariant() == "NOTE")
                {
                    //On demande en boucle la conversion 
                    while (true)
                    {
                        Console.Write("Conversion à faire : ");
                        var note = Console.ReadLine();
                        string noteRetour = maison.transformer(note);//APPEL DE VOTRE LIB
                        Console.Write(noteRetour);
                        Console.WriteLine();
                    }
                }
            
        }
    
    }
}
