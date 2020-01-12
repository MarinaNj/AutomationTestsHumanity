using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjekatMarina2.Page.Objects;
using ProjekatMarina2.Page.Test;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Threading;

namespace ProjekatMarina2
{
    public class Program

    {


        static void Main(string[] args)
        {

            //SignOutTest.TestSignOut();

            //HumanityEditStaffTest.TestUploadPicture();
            int izbor=-1;
            bool izlaz = false;
            int waitInMilliseconds = 1000;
            do
            {
                PrintMenu();
                //dodaj try catch
                try
                {
                    izbor = int.Parse(Console.ReadLine());
                }
                catch (Exception e){
                    izbor = -1;
                    Console.WriteLine("Unesite cifru ");
                    Thread.Sleep(waitInMilliseconds);
                }
              
                switch (izbor)
                {
                    case 0:
                        {
                            Console.WriteLine("Izabrali ste izlaz");
                            izlaz = true;
                            break;
                           
                        }
                    case 1:
                        {

                            Console.WriteLine("Izabrali ste odlazak na Home Page i logovanje");
                            Thread.Sleep(waitInMilliseconds);
                            TestLogin.TeostGoToLogin();
                            break;
                        }

                    case 2:
                        {
                            Console.WriteLine("Izabrali ste logovanje korisnika iz Excel tabele");
                            Thread.Sleep(waitInMilliseconds);
                            TestLoginExcell.TestLoginUsers(); 
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("3");
                            Thread.Sleep(waitInMilliseconds);
                            SignOutTest.TestSignOut();
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("4");
                            Thread.Sleep(waitInMilliseconds);
                            AddEmployeesTest.TestAddEmployees();
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("5");
                            Thread.Sleep(waitInMilliseconds);
                            AddEmployeesTest.TestFillFormAutomatic();

                            break;
                        }

                    case 6:
                        {
                            Console.WriteLine("6");
                            Thread.Sleep(waitInMilliseconds);
                            HumanitySettingsTest.TeostGoToSettings();
                            break;
                        }
                    case 7:
                        {
                            Console.WriteLine("7");
                            Thread.Sleep(waitInMilliseconds);
                            HumanityEditStaffTest.TestUploadPicture();
                            break;
                        }
                    case -1:
                        {
                            Console.WriteLine("Molimo Vas Unesite ponudjene opcije");
                            Thread.Sleep(waitInMilliseconds);                  
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Opcija ne postoji");
                            break;
                        }
                       
                }
            } while (!izlaz);

        }





         static void PrintMenu()
         {
                Console.WriteLine("0-Izlaz");
                Console.WriteLine("1-Test odlaska na Home Page i logovanja korisnika");
                Console.WriteLine("2-Test odlaska na Home Page i logovanje korisnika sa podacima iz Excel tabele");
                Console.WriteLine("3-Sginout test");
                Console.WriteLine("4-Add new employee test");
                Console.WriteLine("5-Add new employee test using Excel data");
                Console.WriteLine("6-Settings Test");
                Console.WriteLine("7-Edite Profile Test");
            }
            




            //  TestLogin.TeostGoToLogin();
            //  TestLogin.TestFillForm();

            //AddEmployeesTest.TestAddEmployees();
            // AddEmployeesTest.TestFillFormAutomatic();
            // HumanitySettingsTest.TeostGoToSettings();
            //TestLoginExcell.TestLoginUsers();

        
    }
}
