using System;
using System.Collections.Generic;

namespace testFichier.Model
{
    public class VMCreation
    {
        public LeModel Model { get; set; }
        public Champ leChamp { get; set; }
        public string[] ListFormat { get; set; } = Constantes.LISTE_FORMAT;
    }
}
