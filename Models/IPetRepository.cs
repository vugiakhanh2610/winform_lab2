using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCRUD.Models {
  public interface IPetRepository {
    void Create(Pet pet);
    void Update(Pet pet);
    void Delete(int id);
    IEnumerable<Pet> GetAll(string keyword = "");
  }
}
