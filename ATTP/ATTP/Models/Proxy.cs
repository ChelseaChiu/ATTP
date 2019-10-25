using StudentServiceRef;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ATTP.Models
{
    public class Proxy
    {
        private static StudentServiceClient proxy = null;

        public static bool login(string id)
        {
            proxy = new StudentServiceClient(StudentServiceClient.EndpointConfiguration.BasicHttpsBinding_IStudentService);
            if (proxy.Login(id))
            {
                return true;
            }
            else return false;
            
        }

        public static User getStudentById(string id)
        {
            
            proxy = new StudentServiceClient(StudentServiceClient.EndpointConfiguration.BasicHttpsBinding_IStudentService);
            User user = new User();
            var s = proxy.GetStudentById(id);

            
            if (s!=null)
            {
                user.Username = String.Format(s.GivenName + "  " + s.LastName);
                user.Id = s.StudentID;
               // Debug.WriteLine(user.Username);
               // Debug.WriteLine(user.Id);

              // App._language = user.Username;
              //  App._language = user.Id;
                // user.Password = "AA" + s.;
                return user;
                
            }
            else return null;
        }


    }
}
