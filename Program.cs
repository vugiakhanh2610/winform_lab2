using DemoCRUD.Models;
using DemoCRUD.Repositories;
using DemoCRUD.Views;
using System;
using System.Windows.Forms;
using System.Configuration;
using DemoCRUD.Presenters;

namespace DemoCRUD {
  internal static class Program {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main() {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      string dbConnectionString = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;
      IMainView mainView = new MainView();
      new MainPresenter(mainView, dbConnectionString);
      Application.Run((Form) mainView);
    }
  }
}
