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
                if (proxy.Login(id))
                {
                    proxy.CloseAsync();
                    return true;
                }
                else
                {
                    proxy.CloseAsync();
                    return false;
                }
            }
            catch (CommunicationException)
            {
                proxy.Abort();
                return false;
            }
            catch (TimeoutException)
            {
                proxy.Abort();
                return false;
            }
            catch (Exception)
            {

                throw;
            }


        }

        public static User getStudentById(string id)
        {
            try
            {
                proxy = new StudentServiceClient(StudentServiceClient.EndpointConfiguration.BasicHttpsBinding_IStudentService);
                if (proxy != null)
                {
                    if (proxy.State != CommunicationState.Faulted)
                    {
                        proxy = new StudentServiceClient(StudentServiceClient.EndpointConfiguration.BasicHttpsBinding_IStudentService);
                        User user = new User();
                        var s = proxy.GetStudentById(id);
                        if (s != null)
                        {
                            user.Username = String.Format(s.GivenName + "  " + s.LastName);
                            user.Id = s.StudentID;
                            proxy.CloseAsync();
                            return user;

                        }
                        else
                        {
                            proxy.CloseAsync();
                            return null;
                        }
                    }
                    else
                    {
                        proxy.Abort();
                        return null;
                    }

                }
                else
                {
                    proxy.Abort();
                    return null;
                }


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

        public static List<Qualification> GetQualifications(string studentId)
        {

            try
            {
                proxy = new StudentServiceClient(StudentServiceClient.EndpointConfiguration.BasicHttpsBinding_IStudentService);
                if (proxy != null)
                {
                    if (proxy.State != CommunicationState.Faulted)
                    {
                        List<Qualification> qualifications = new List<Qualification>();
                        var qList = proxy.GetQualificationList(studentId);
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
                        proxy.CloseAsync();
                        return qualifications;
                    }
                    else
                    {
                        proxy.Abort();
                        return null;
                    }

                }
                else
                {
                    proxy.Abort();
                    return null;
                }


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

        public static double CalQualProgress(string studentId, string qualCode)
        {
            try
            {
                proxy = new StudentServiceClient(StudentServiceClient.EndpointConfiguration.BasicHttpsBinding_IStudentService);
                if (proxy != null)
                {
                    if (proxy.State != CommunicationState.Faulted)
                    {
                        proxy = new StudentServiceClient(StudentServiceClient.EndpointConfiguration.BasicHttpsBinding_IStudentService);
                        double progress = 0.00d;
                        progress = proxy.CalQualProgress(studentId, qualCode);
                        if (progress >= 1)
                        {
                            proxy.CloseAsync();
                            return 1.00d;
                        }
                        else
                        {
                            proxy.CloseAsync();
                            return progress;
                        }
                    }
                    else
                    {
                        proxy.Abort();
                        return 0;
                    }

                }
                else
                {
                    proxy.Abort();
                    return 0;
                }


            }
            catch (CommunicationException)
            {
                proxy.Abort();
                return 0;
            }
            catch (TimeoutException)
            {
                proxy.Abort();
                return 0;
            }
            catch (Exception)
            {

                throw;
            }

        }



        public static List<Competency> GetCompetencies(string studentId, string qualCode)
        {
            try
            {
                proxy = new StudentServiceClient(StudentServiceClient.EndpointConfiguration.BasicHttpsBinding_IStudentService);
                if (proxy != null)
                {
                    if (proxy.State != CommunicationState.Faulted)
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
                            comp.SubjectCode = cList[i].SubjectCode;
                            comp.CompTypeCode = cList[i].TrainingPakckageUsage;
                            comp.Results = cList[i].Results;
                            competencies.Add(comp);

                        }
                        proxy.CloseAsync();
                        return competencies;
                    }
                    else
                    {
                        proxy.Abort();
                        return null;
                    }

                }
                else
                {
                    proxy.Abort();
                    return null;
                }


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
