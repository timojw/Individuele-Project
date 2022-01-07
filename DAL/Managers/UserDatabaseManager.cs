﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using Logic.DTO;
using Logic.Interfaces;

namespace DAL.Managers
{
    public class UserDatabaseManager : DatabaseManager, IUserDatabaseManager
    {
        public List<UserDTO> GetAllUsers()
        {
            List<UserDTO> users = new List<UserDTO>();
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            {
                using (SqlCommand query = new SqlCommand("select * from User", conn))
                {
                    conn.Open();

                    var reader = query.ExecuteReader();
                    while (reader.Read())
                    {
                        UserDTO user = new UserDTO();
                        user.ID = reader.GetInt32(0);
                        user.Name = reader.GetString(1);
                        user.Email = reader.GetString(2);
                        user.Password = reader.GetString(3);
                        user.RegisterDate = reader.GetDateTime(4);
                        user.Country = reader.GetString(5);
                        user.State = reader.GetString(6);
                        user.City = reader.GetString(7);
                        user.Street = reader.GetString(8);
                        user.HouseNumber = reader.GetInt32(9);
                        user.PostalCode = reader.GetString(10);

                        users.Add(user);
                    }
                }
            }
            return users;
        }

        void IUserDatabaseManager.AddUser(UserDTO userDto)
        {
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            {
                using SqlCommand query = new SqlCommand("INSERT INTO [dbo].[User] ([Name], [Email], [Password], [RegisterDate], [Country], [State], [City], [Street], [HouseNumber], [PostalCode]) VALUES (@Name, @Email, @Password, @RegisterDate, @Country, @State, @City, @Street, @HouseNumber, @PostalCode", conn);
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
            }
        }
    }
}
