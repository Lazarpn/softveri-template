using Common.Models;
using Database;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core;

public class UserManager
{
    private readonly DatabaseBroker db;

    public UserManager()
    {
        db = new DatabaseBroker();
    }

    public bool SignIn(UserSignInModel model)
    {
        string query = $"Select Id, Firstname, Lastname From [User] Where Username=@user and Password=@pass";
        using SqlCommand command = new SqlCommand(query, db.connection);
        command.Parameters.AddWithValue("user", model.UserName);
        command.Parameters.AddWithValue("pass", model.Password);
        using SqlDataReader reader = command.ExecuteReader();

        if (reader.Read()) 
        {
            return true;
        }

        db.CloseConnection();
        return false;
    }
}
