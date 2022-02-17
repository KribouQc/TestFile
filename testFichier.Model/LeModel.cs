using System;
using System.Collections.Generic;

namespace testFichier.Model
{
    public class LeModel
    {
        public string NomModel { get; set; }
        public List<Champ> ListeChamps { get; set; }

        public LeModel()
        {
            ListeChamps = new List<Champ>();
        }
    }
}
