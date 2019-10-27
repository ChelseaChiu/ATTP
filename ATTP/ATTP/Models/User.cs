using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using SQLite;
using StudentServiceRef;

namespace ATTP.Models
{
    public class User
    {
        [PrimaryKey]
        public string Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

       // public string Dob { get; set; }

        public User() { }
        public User(string id, string password)
        {
            this.Id = id;
            this.Password = password;
        }

        
         public bool Valdation(string id, string password)
        {
            

            if(Proxy.login(id))
            {
   
                return true;
            }

 //           if (!string.IsNullOrWhiteSpace(this.Username) && !string.IsNullOrWhiteSpace(this.Password) && this.Username=="001096907")
 //           {
 //               return true;
 //           }


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

