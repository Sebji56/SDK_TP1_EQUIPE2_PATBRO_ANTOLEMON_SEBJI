using System;

namespace LibrairieConversionNote
{
    public class ConversionAlphabetiqueToNote
    {
        public string transformer(string alphabetique)
        {
            if (alphabetique == "A")
            {
                return "LA";
            }

            else if (alphabetique == "B")
            {
                return "SI";
            }

            else if (alphabetique == "C")
            {
                return "DO";
            }

            else if (alphabetique == "D")
            {
                return "RE";
            }

            else if (alphabetique == "E")
            {
                return "MI";
            }

            else if (alphabetique == "F")
            {
                return "FA";
            }

            else if (alphabetique == "G")
            {
                return "SOL";
            }
            else
            {
                return "Entree invalide";
            }
        }
    }
}
