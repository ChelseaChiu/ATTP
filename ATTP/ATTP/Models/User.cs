using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using SQLite;

namespace ATTP.Models
{
    public class User
    {
        [PrimaryKey]
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public User() { }
        public User(String Username, string Password)
        {
            this.Username = Username;
            this.Password = Password;
        }

        public bool Valdation()
        {
            if (!string.IsNullOrWhiteSpace(this.Username) && !string.IsNullOrWhiteSpace(this.Password) && this.Username=="001096907")
            {
                return true;
            }


            //else if (this.Username = "001083886")
            //{
            //    return false;
            //}

            else
            {
                return false;
            }




        }




    }
}

