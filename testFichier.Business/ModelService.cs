using System;
using testFichier.Model;
using System.Linq;

namespace testFichier.Business
{
    public class ModelService : IModelService
    {
        private LeModel leModel = new LeModel();

        public void AddChamp(Champ champ)
        {
            champ.Id = Guid.NewGuid();
            leModel.ListeChamps.Add(champ);
        }

        public void ChangeNomModel(string nom)
        {
            leModel.NomModel = nom;
        }

        public void CreateModel(LeModel leModel)
        {
            this.leModel = leModel;
        }

        public Champ GetChamp(Guid id)
        {
            return leModel.ListeChamps.SingleOrDefault(x => x.Id == id);
        }

        public LeModel GetModel()
        {
            return leModel;
        }

        public void Update(Champ champ)
        {
            var oldChamp = GetChamp(champ.Id);
            oldChamp = champ;
        }
    }
}
