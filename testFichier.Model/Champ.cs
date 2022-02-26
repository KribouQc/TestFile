using System;

namespace testFichier.Model
{
    public class Champ
    {
        public Guid Id { get; set; }
        public string Nom { get; set; }
        public int ColDebut { get; set; }
        public int ColFin { get; set; }
        public string FormatChamp { get; set; }
    }
}
