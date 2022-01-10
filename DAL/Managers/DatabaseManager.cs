using System;
using System.Collections.Generic;
using System.Text;


namespace DAL.Managers
{
    public class DatabaseManager
    {
        public string connectionString { get; } = "Data Source=Timo-Desktop;Initial Catalog=MarktplaatsDatabase;Integrated Security=True";
        //public string connectionString { get; } = "Server=TIMO-DESKTOP;Database=MarktplaatsDatabase;Trusted_Connection=True;MultipleActiveResultSets=true"

    }
}


