using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DemoCRUD.Models {
  public class Pet {

    private int id;
    private string name;
    private string color;

    [DisplayName("Pet ID")]
    public int Id {
      get => id;
      set => id = value;
    }

    [DisplayName("Pet Name")]
    [Required(AllowEmptyStrings = false, ErrorMessage = "Required field")]
    public string Name {
      get => name;
      set => name = value;
    }

    [DisplayName("Pet Color")]
    public string Color {
      get => color;
      set => color = value;
    }
  }
}
