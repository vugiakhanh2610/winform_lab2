using DemoCRUD.Models;
using DemoCRUD.Repositories;
using DemoCRUD.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoCRUD.Presenters {
  public class MainPresenter {
    private IMainView mainView;
    private readonly string dbConnectionString;

    public MainPresenter(IMainView mainView, string dbConnectionString) {
      this.mainView = mainView;
      this.dbConnectionString = dbConnectionString;
      this.mainView.ShowPetView += ShowPetView;
    }

    private void ShowPetView(object sender, EventArgs e) {
      IPetRepository petRepository = new PetRepository(dbConnectionString);
      IPetView petView = PetView.GetInstance((Form) mainView);
      new PetPresenter(petView, petRepository);
    }
  }
}
