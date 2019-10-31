using StudentServiceRef;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
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


            if (s != null)
            {
                user.Username = String.Format(s.GivenName + "  " + s.LastName);
                user.Id = s.StudentID;
                return user;

            }
            else return null;
        }

        public static List<Qualification> GetQualifications(string studentId)
        {
            proxy = new StudentServiceClient(StudentServiceClient.EndpointConfiguration.BasicHttpsBinding_IStudentService);
            List<Qualification> qualifications = new List<Qualification>();
            var qList =proxy.GetQualificationList(studentId);
            for (int i = 0; i < qList.Count; i++)
            {
                Qualification qual = new Qualification();
                qual.QualCode = qList[i].QualCode;
                qual.QualName = qList[i].QualName;
                qual.CoreUnits = qList[i].CoreUnits;
                qual.TafeQualCode = qList[i].TafeQualCode;
                qual.NationaQualCode = qList[i].NationalQualCode;
                qual.TotalUnits = qList[i].TotalUnits;
                qual.ElectedUnits = qList[i].ElectedUnits;
                qual.ReqListedElectedUnits = qList[i].ReqListedElectedUnits;

                qualifications.Add(qual);
            }
            return qualifications;
           
        }

        public static double CalQualProgress(string studentId, string qualCode)
        {
            proxy = new StudentServiceClient(StudentServiceClient.EndpointConfiguration.BasicHttpsBinding_IStudentService);
            double progress = 0.00d;
            progress = proxy.CalQualProgress(studentId, qualCode);
            return progress;
        }

        public static List<Competency> GetCompetencies(string studentId, string qualCode)
        {
            proxy = new StudentServiceClient(StudentServiceClient.EndpointConfiguration.BasicHttpsBinding_IStudentService);
            List<Competency> competencies = new List<Competency>();
            var cList = proxy.GetCompetencyList(studentId, qualCode);
            for (int i = 0; i < cList.Count; i++)
            {
                Competency comp = new Competency();
                comp.TafeCompCode = cList[i].TafeCode;
                comp.NationaCompCode = cList[i].NationalCode;
                comp.CompetencyName = cList[i].CompetencyName;
            }

        }




    }   
}
