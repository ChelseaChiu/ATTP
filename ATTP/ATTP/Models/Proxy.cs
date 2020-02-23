//using StudentServiceRef;
using StudentServiceRef;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace ATTP.Models
{
    public class Proxy
    {
        private static StudentServiceClient proxy = null;

        public static bool login(string id)
        {
            try
            {
                proxy = new StudentServiceClient(StudentServiceClient.EndpointConfiguration.BasicHttpsBinding_IStudentService);
                if (proxy.LoginAsync(id).Result)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (CommunicationException)
            {
                return false;
            }
            catch (TimeoutException)
            {
                return false;
            }
            catch (Exception)
            {

                throw;
            }


        }

        public static StudentServiceRef.Student getStudentById(string id)
        {
            try
            {
                proxy = new StudentServiceClient(StudentServiceClient.EndpointConfiguration.BasicHttpsBinding_IStudentService);

                        proxy = new StudentServiceClient(StudentServiceClient.EndpointConfiguration.BasicHttpsBinding_IStudentService);
                        var s = proxy.GetStudentByIdAsync(id).Result;
                        if (s != null)
                        {
                            return s;
                        }
                        else
                        {
                            return null;
                        }                  

            }
            catch (CommunicationException)
            {
                return null;
            }
            catch (TimeoutException)
            {
                return null;
            }
            catch (Exception)
            {
                throw;
            }

        }

        public static List<StudentServiceRef.Qualification> GetQualifications(string studentId)
        {

            try
            {
                proxy = new StudentServiceClient(StudentServiceClient.EndpointConfiguration.BasicHttpsBinding_IStudentService);
                var qList = proxy.GetQualificationListAsync(studentId).Result;
                List<StudentServiceRef.Qualification> qualifications = new List<StudentServiceRef.Qualification>();
                foreach (var q in qList)
                {
                    qualifications.Add(q);
                }

                return qualifications;

            }
            catch (CommunicationException)
            {
                return null;
            }
            catch (TimeoutException)
            {
                return null;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static double CalQualProgress(string studentId, string qualCode)
        {
            try
            {
                proxy = new StudentServiceClient(StudentServiceClient.EndpointConfiguration.BasicHttpsBinding_IStudentService);
                var progress = proxy.CalQualProgressAsync(studentId, qualCode).Result;
                if (progress >= 1)
                {
                    return 1.00d;
                }
                else
                {
                    return progress;
                }

            }
            catch (CommunicationException)
            {
                return 0;
            }
            catch (TimeoutException)
            {
                return 0;
            }
            catch (Exception)
            {
                throw;
            }

        }



        public static List<StudentServiceRef.Competency> GetCompetencies(string studentId, string qualCode)
        {
            try
            {
                proxy = new StudentServiceClient(StudentServiceClient.EndpointConfiguration.BasicHttpsBinding_IStudentService);
                List<StudentServiceRef.Competency> competencies = new List<StudentServiceRef.Competency>();
                var cList = proxy.GetCompetencyListAsync(studentId, qualCode).Result;
                foreach (var c in cList)
                {
                    competencies.Add(c);
                }
                return competencies;


            }
            catch (CommunicationException)
            {
                proxy.Abort();
                return null;
            }
            catch (TimeoutException)
            {
                proxy.Abort();
                return null;
            }
            catch (Exception)
            {

                throw;
            }

        }




    }
}
