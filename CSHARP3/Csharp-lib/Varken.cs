using System;

namespace Csharp3_library
{
    // Subklasse Varken
    public class Varken : Dier
    {
        public Varken(int gewicht) : base(gewicht)
        {
        }

        public override string Geluid()
        {
            return "knor.mp3"; // Bestandsnaam voor het geluid
        }
    }
}