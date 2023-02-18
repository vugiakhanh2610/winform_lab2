using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoCRUD.Views {
  public interface IPetView {
    string PetID { get; set; }
    string PetName { get; set; }
    string PetColor { get; set; }

    string Keyword { get; set; }
    bool IsUpdate { get; set; }
    bool IsSuccessful { get; set; }
    string Message { get; set; }

    event EventHandler SearchEvent;
    event EventHandler CreateEvent;
    event EventHandler UpdateEvent;
    event EventHandler DeleteEvent;
    event EventHandler SaveEvent;
    event EventHandler CancelEvent;

    void SetPetListBindingResource(BindingSource petList);
    void Show();
  }
}
