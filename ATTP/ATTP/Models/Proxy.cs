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

        public static bool login(string id, string password)
        {
            try
            {
                proxy = new StudentServiceClient(StudentServiceClient.EndpointConfiguration.BasicHttpsBinding_IStudentService);
                if (proxy.Login(id,password))
                {
                    proxy.CloseAsync();
                    Console.WriteLine("login successfully");
                    return true;
                }
                else
                {
                    proxy.CloseAsync();
                    Console.WriteLine("login failed");
                    return false;
                }
            }
            catch (CommunicationException ex)
            {
                proxy.Abort();
                Console.WriteLine(ex.Message);
                return false;
            }
            catch (TimeoutException ex)
            {
                proxy.Abort();
                Console.WriteLine(ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }


        }

        public static Student getStudentById(string id)
        {
            try
            {
                proxy = new StudentServiceClient(StudentServiceClient.EndpointConfiguration.BasicHttpsBinding_IStudentService);
                if (proxy != null)
                {
                    if (proxy.State != CommunicationState.Faulted)
                    {
                        var s = proxy.GetStudentById(id);
                        if (s != null)
                        {
                            proxy.CloseAsync();
                            return s;
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
            catch (CommunicationException ex)
            {
                proxy.Abort();
                Console.WriteLine(ex.Message);
                return null;
            }
            catch (TimeoutException ex)
            {
                proxy.Abort();
                Console.WriteLine(ex.Message);
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }

        }

        public static List<StudentServiceRef.Qualification> GetQualificationList(string studentId)
        {
            try
            {
                proxy = new StudentServiceClient(StudentServiceClient.EndpointConfiguration.BasicHttpsBinding_IStudentService);
                if (proxy != null)
                {
                    if (proxy.State != CommunicationState.Faulted)
                    {
                        var qList = proxy.GetQualificationList(studentId);
                        proxy.CloseAsync();
                        List<StudentServiceRef.Qualification> qualifications = new List<StudentServiceRef.Qualification>();
                        foreach (var q in qList)
                        {
                            qualifications.Add(q);
                        }
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
                            qual.Progress = qList[i].Progress;
                            qual.DoneC = qList[i].DoneC;
                            qual.DoneE = qList[i].DoneE;
                            qual.DoneLE = qList[i].DoneLE;
                            qual.DoneTotal = qList[i].DoneTotal;
                            qual.StringCoreResult = String.Format("Core Units: {0} of {1}", qual.DoneC, qual.CoreUnits);
                            qual.StringElectiveResult = String.Format("Elective Units: {0} of {1}", qual.DoneE, qual.ElectedUnits);
                            qual.StringLEResult = String.Format("List Elective Units: {0} of {1}", qual.DoneLE, qual.ReqListedElectedUnits);
                            qual.StringTotalResult = String.Format("Total Units: {0} of {1}", qual.DoneTotal, qual.TotalUnits);
                            qual.StringProgress = String.Format(qual.Progress * 100 + "%");

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

        //public static double CalQualProgress(string studentId, string qualCode)
        //{
        //    try
        //    {
        //        proxy = new StudentServiceClient(StudentServiceClient.EndpointConfiguration.BasicHttpsBinding_IStudentService);
        //        if (proxy != null)
        //        {
        //            if (proxy.State != CommunicationState.Faulted)
        //            {
        //                double progress = 0.00d;
        //                progress = proxy.CalQualProgress(studentId, qualCode);
        //                if (progress >= 1)
        //                {
        //                    proxy.CloseAsync();
        //                    return 1.00d;
        //                }
        //                else
        //                {
        //                    proxy.CloseAsync();
        //                    return progress;
        //                }
        //            }
        //            else
        //            {
        //                proxy.Abort();
        //                return 0;
        //            }

        //        }
        //        else
        //        {
        //            proxy.Abort();
        //            return 0;
        //        }


        //    }
        //    catch (CommunicationException)
        //    {
        //        proxy.Abort();
        //        return 0;
        //    }
        //    catch (TimeoutException)
        //    {
        //        proxy.Abort();
        //        return 0;
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }

        //}



        public static List<StudentServiceRef.Competency> GetCompetencies(string studentId, string qualificationID)
        {
            try
            {
                proxy = new StudentServiceClient(StudentServiceClient.EndpointConfiguration.BasicHttpsBinding_IStudentService);
                if (proxy != null)
                {
                    if (proxy.State != CommunicationState.Faulted)
                    {
                        List<StudentServiceRef.Competency> competencies = new List<StudentServiceRef.Competency>();
                        var cList = proxy.GetCompetencyList(studentId, qualificationID);
                        foreach (var c in cList)
                        {
                            competencies.Add(c);
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
