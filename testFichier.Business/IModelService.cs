using System;
using testFichier.Model;

namespace testFichier.Business
{
	public interface IModelService
	{
		public void CreateModel(LeModel leModel);
		public void AddChamp(Champ champ);
		public LeModel GetModel();
		public Champ GetChamp(Guid id);
		public void Update(Champ champ);
		public void ChangeNomModel(string nom);
	}
}
