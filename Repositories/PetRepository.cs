using DemoCRUD.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCRUD.Repositories {
  public class PetRepository : BaseRepository, IPetRepository {

    public PetRepository(string dbConnectionString) {
      this.dbConnectionString = dbConnectionString;
    }

    public void Create(Pet pet) {
      using (var connection = new SqlConnection(dbConnectionString))
      using (var command = connection.CreateCommand()) {
        connection.Open();
        command.CommandText = @"INSERT INTO pet VALUES (@name, @color)";
        command.Parameters.Add("@name", SqlDbType.NVarChar).Value = pet.Name;
        command.Parameters.Add("@color", SqlDbType.NVarChar).Value = pet.Color;
        command.ExecuteNonQuery();
      }
    }

    public void Delete(int id) {
      using (var connection = new SqlConnection(dbConnectionString))
      using (var command = connection.CreateCommand()) {
        connection.Open();
        command.CommandText = @"DELETE FROM pet WHERE id = @id";
        command.Parameters.Add("@id", SqlDbType.Int).Value = id;
        command.ExecuteNonQuery();
      }
    }

    public IEnumerable<Pet> GetAll(string keyword) {
      List<Pet> petList = new List<Pet>();
      using (var connection = new SqlConnection(this.dbConnectionString))
      using (var command = connection.CreateCommand()) {
        connection.Open();
        command.CommandText = "SELECT * FROM PET ";
        if (string.IsNullOrEmpty(keyword) == false) {
          command.CommandText += "WHERE id=@id or name like '%' + @name + '%' ";
          int id = int.TryParse(keyword, out _) ? Convert.ToInt32(keyword) : 0;
          command.Parameters.Add("@id", SqlDbType.Int).Value = id;
          command.Parameters.Add("@name", SqlDbType.VarChar).Value = keyword;
        }
        command.CommandText += "ORDER BY id DESC ";
        using (var reader = command.ExecuteReader()) {
          while (reader.Read()) {
            Pet pet = new Pet();
            pet.Id = reader.GetInt32(0);
            pet.Name = reader.GetString(1);
            pet.Color = reader.GetString(2);
            petList.Add(pet);
          }
        }
      }
      return petList;
    }

    public void Update(Pet pet) {
      using (var connection = new SqlConnection(dbConnectionString))
      using (var command = connection.CreateCommand()) {
        connection.Open();
        command.CommandText = @"UPDATE pet SET name = @name, color = @color WHERE id = @id";
        command.Parameters.Add("@id", SqlDbType.Int).Value = pet.Id;
        command.Parameters.Add("@name", SqlDbType.NVarChar).Value = pet.Name;
        command.Parameters.Add("@color", SqlDbType.NVarChar).Value = pet.Color;
        command.ExecuteNonQuery();
      }
    }
  }
}
