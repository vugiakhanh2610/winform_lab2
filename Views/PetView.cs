using System;
using System.Windows.Forms;

namespace DemoCRUD.Views {
  public partial class PetView : Form, IPetView {
    private string message;
    private bool isSuccessful;
    private bool isUpdate;


    public PetView() {
      InitializeComponent();
      AssociateAndRaiseViewEvents();
      tabControl.TabPages.Remove(tabPagePetDetail);
    }

    private void AssociateAndRaiseViewEvents() {
      btnSearch.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
      inputKeyword.KeyDown += (sender, e) => {
        if (e.KeyCode == Keys.Enter) {
          SearchEvent?.Invoke(this, EventArgs.Empty);
        }
      };
      btnCreate.Click += delegate { 
        CreateEvent?.Invoke(this, EventArgs.Empty);
        SwitchToDetailTab();
      };
      btnUpdate.Click += delegate {
        UpdateEvent?.Invoke(this, EventArgs.Empty);
        SwitchToDetailTab();
      };
      btnSave.Click += delegate { 
        SaveEvent?.Invoke(this, EventArgs.Empty);
        if (isSuccessful) {
          SwitchToListTab();
        }
        MessageBox.Show(Message);
      };
      
      btnDelete.Click += delegate { 
        var result = MessageBox.Show("This action cannot be undone", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        if (result == DialogResult.Yes) {
          DeleteEvent?.Invoke(this, EventArgs.Empty);
        }
      };

      btnCancel.Click += delegate { 
        CancelEvent?.Invoke(this, EventArgs.Empty);
        SwitchToListTab();
      };
    }

    private void SwitchToListTab() {
      tabControl.TabPages.Add(tabPagePetList);
      tabControl.TabPages.Remove(tabPagePetDetail);
    }

    private void SwitchToDetailTab() {
      tabControl.TabPages.Add(tabPagePetDetail);
      tabControl.TabPages.Remove(tabPagePetList);
    }

    public string PetID {
      get => inputPetId.Text;
      set => inputPetId.Text = value;
    }
    public string PetName {
      get => inputPetName.Text;
      set => inputPetName.Text = value;
    }
    public string PetColor { 
      get => inputPetColor.Text;
      set => inputPetColor.Text = value; 
    }
    public string Keyword { 
      get => inputKeyword.Text; 
      set => inputKeyword.Text = value;
    }
    public bool IsUpdate { 
      get => isUpdate;
      set => isUpdate = value; 
    }
    public bool IsSuccessful { 
      get => isSuccessful; 
      set => isSuccessful = value; 
    }
    public string Message { 
      get => message;
      set => message = value; 
    }

    public event EventHandler SearchEvent;
    public event EventHandler CreateEvent;
    public event EventHandler UpdateEvent;
    public event EventHandler DeleteEvent;
    public event EventHandler SaveEvent;
    public event EventHandler CancelEvent;

    public void SetPetListBindingResource(BindingSource petList) {
      dataGridView.DataSource = petList;
    }

    public static PetView instance;
    public static PetView GetInstance(Form parentForm) {
      if (instance == null) {
        instance = new PetView();
        instance.MdiParent = parentForm;
        instance.FormBorderStyle = FormBorderStyle.None;
        instance.Dock = DockStyle.Fill;
      }
      else { 
        if (instance.WindowState == FormWindowState.Minimized) {
          instance.WindowState = FormWindowState.Normal;
        }
        instance.BringToFront();
      }
      return instance;
    }
  }
}
