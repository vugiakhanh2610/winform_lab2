using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DemoCRUD.Models;
using DemoCRUD.Presenters.Common;
using DemoCRUD.Views;

namespace DemoCRUD.Presenters {
  public class PetPresenter {
    private IPetView view;
    private IPetRepository repository;
    private BindingSource bindingSource;
    private IEnumerable<Pet> petList;

    public PetPresenter(IPetView view, IPetRepository repository) {
      this.view = view;
      this.repository = repository;
      this.bindingSource = new BindingSource();
      this.view.SetPetListBindingResource(this.bindingSource);

      this.view.SearchEvent += Search;
      this.view.CreateEvent += Create;
      this.view.UpdateEvent += LoadSelectedPet;
      this.view.DeleteEvent += Delete;
      this.view.SaveEvent += Save;
      this.view.CancelEvent += Cancel;

      GetAll();
      this.view.Show();
    }

    private void Search(object sender, EventArgs e) {
      this.GetAll(this.view.Keyword);
    }

    private void GetAll(string keyword = "") {
      petList = repository.GetAll(keyword);
      bindingSource.DataSource = petList; 
    }

    private void Create(object sender, EventArgs e) {
      view.IsUpdate = false;
    }

    private void LoadSelectedPet(object sender, EventArgs e) {
      Pet pet = bindingSource.Current as Pet;
      view.PetID = pet.Id.ToString();
      view.PetName = pet.Name;
      view.PetColor = pet.Color;
      view.IsUpdate = true;
    }

    private void Cancel(object sender, EventArgs e) {
      CleanFields();
    }

    private void CleanFields() {
      view.PetID = "0";
      view.PetName = "";
      view.PetColor = "";
    }

    private void Save(object sender, EventArgs e) {
      Pet pet = new Pet {
        Id = Convert.ToInt32(view.PetID),
        Name = view.PetName,
        Color = view.PetColor
      };

      try {
        ModelDataValidation.Validate(pet);
        if (view.IsUpdate) {
          repository.Update(pet);
          view.Message = "Updated successfully";
        } else {
          repository.Create(pet);
          view.Message = "Created successfully";
        }
        view.IsSuccessful = true;
        CleanFields();
        GetAll();
      }
      catch (Exception ex) {
        view.IsSuccessful = false;
        view.Message = ex.Message;
      }
    }

    private void Delete(object sender, EventArgs e) {
      try {
        Pet pet = bindingSource.Current as Pet;
        repository.Delete(pet.Id);
        view.Message = "Deleted successfully";
        view.IsSuccessful = true;
        GetAll();
      }
      catch (Exception ex) {
        view.IsSuccessful = false;
        view.Message = "An error occured";
      }
    }

  }
}
