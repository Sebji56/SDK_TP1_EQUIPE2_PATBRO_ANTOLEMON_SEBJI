using System;

namespace LibrairieConversionNote
{
    public class ConversionAlphabetiqueToNote
    {
        public string transformer(string alphabetique)
        {
            if (alphabetique.ToUpperInvariant() == "A")
            {
                return "LA";
            }

            else if (alphabetique.ToUpperInvariant() == "B")
            {
                return "SI";
            }

            else if (alphabetique.ToUpperInvariant() == "C")
            {
                return "DO";
            }

            else if (alphabetique.ToUpperInvariant() == "D")
            {
                return "RE";
            }

            else if (alphabetique.ToUpperInvariant() == "E")
            {
                return "MI";
            }

            else if (alphabetique.ToUpperInvariant() == "F")
            {
                return "FA";
            }

            else if (alphabetique.ToUpperInvariant() == "G")
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
