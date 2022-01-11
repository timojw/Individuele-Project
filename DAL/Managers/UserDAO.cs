using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using Logic.DTO;
using Logic.Interfaces;

namespace DAL.Managers
{
    public class UserDAO : DatabaseManager, IUserDAO
    {
        public List<UserDTO> GetAllUsers()
        {
            List<UserDTO> users = new List<UserDTO>();
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            {
                using (SqlCommand query = new SqlCommand("SELECT * FROM [dbo].[User]", conn))
                {
                    conn.Open();

                    var reader = query.ExecuteReader();

                    while (reader.Read())
                    {
                        users.Add(new UserDTO
                        {
                            ID = Convert.ToInt32(reader["ID"]),
                            Name = reader["name"].ToString(),
                            Email = reader["email"].ToString(),
                            Password = reader["password"].ToString(),
                            RegisterDate = (DateTime)reader["registerDate"],
                            Country = reader["country"].ToString(),
                            State = reader["state"].ToString(),
                            City = reader["city"].ToString(),
                            Street = reader["street"].ToString(),
                            HouseNumber = Convert.ToInt32(reader["houseNumber"]),
                            PostalCode = reader["postalCode"].ToString()
                        });
                    }
                }
            }
            return users;
        }
        public UserDTO GetUserByID(int id)
        {
            UserDTO user = new();
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            using (SqlCommand query = new SqlCommand("SELECT * FROM [dbo].[User] WHERE [ID] = @id", conn))
            {
                query.Parameters.AddWithValue("@id", id);
                query.Connection.Open();

                using (SqlDataReader reader = query.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        user.ID = Convert.ToInt32(reader["ID"]);
                        user.Name = reader["name"].ToString();
                        user.Email = reader["email"].ToString();
                        user.Password = reader["password"].ToString();
                        user.RegisterDate = (DateTime)reader["registerDate"];
                    }
                }
            }
            return user;
        }

        public int AddUser(UserDTO userDto)
        {
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            {
                using SqlCommand query = new SqlCommand("INSERT INTO User (name, email, [password], [registerDate], [country], [state], [city], [street], [houseNumber], [postalCode]) VALUES (@Name, @Email, @Password, @RegisterDate, @Country, @State, @City, @Street, @HouseNumber, @PostalCode)" + "SELECT CAST(scope_identity() AS int)", conn);
                conn.Open();
                query.Parameters.AddWithValue("@Name", userDto.Name);
                query.Parameters.AddWithValue("@Email", userDto.Email);
                query.Parameters.AddWithValue("@Password", userDto.Password);
                query.Parameters.AddWithValue("@RegisterDate", userDto.RegisterDate);
                query.Parameters.AddWithValue("@Country", userDto.Country);
                query.Parameters.AddWithValue("@State", userDto.State);
                query.Parameters.AddWithValue("@City", userDto.City);
                query.Parameters.AddWithValue("@Street", userDto.Street);
                query.Parameters.AddWithValue("@HouseNumber", userDto.HouseNumber);
                query.Parameters.AddWithValue("@PostalCode", userDto.PostalCode);

                var modified = query.ExecuteScalar();
                userDto.ID = (int)modified;
                return userDto.ID;
            }
        }
        public void DeleteUser(UserDTO user)
        {
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            {
                SqlCommand query = new SqlCommand("DELETE FROM [dbo].[User] WHERE [ID] = @id", conn);
                query.Parameters.AddWithValue("@id", user.ID);
                conn.Open();
                query.ExecuteNonQuery();
            }
        }
    }
}