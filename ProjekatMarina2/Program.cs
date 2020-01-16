using System;
using ProjekatMarina2.Page.Test;
using System.Threading;

namespace ProjekatMarina2
{
    public class Program

    {


        static void Main(string[] args)
        {
           
             int izbor=-1;
             bool izlaz = false;
             int waitInMilliseconds = 1000;
             do
             {
                 PrintMenu();
                 try
                 {
                     izbor = int.Parse(Console.ReadLine());
                 }
                 catch (Exception e){
                     izbor = -1;
                     Console.WriteLine(e.ToString());
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

                             Console.WriteLine("Izabrali ste odlazak na Home Page i logovanje korisnika");
                             Thread.Sleep(waitInMilliseconds);
                             TestLogin.TestFillForm();
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
                             Console.WriteLine("Sginout test");
                             Thread.Sleep(waitInMilliseconds);
                             SignOutTest.TestSignOut();
                             break;
                         }
                     case 4:
                         {
                             Console.WriteLine("Testiranje dodavanja novog zaposlenog");
                             Thread.Sleep(waitInMilliseconds);
                             AddEmployeesTest.TestAddEmployees();
                             break;
                         }
                     case 5:
                         {
                             Console.WriteLine("Testiranje dodavanja vise zaposlednih iz Excel foldera");
                             Thread.Sleep(waitInMilliseconds);
                             AddEmployeesTest.TestFillFormAutomatic();

                             break;
                         }

                     case 6:
                         {
                             Console.WriteLine("Testiranje podesavanja");
                             Thread.Sleep(waitInMilliseconds);
                             HumanitySettingsTest.TeostGoToSettings();
                             break;
                         }
                     case 7:
                         {
                             Console.WriteLine("Testiranje dodavanja podataka o zaposlenom - Edite Profile Test");
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

        
           
        
    }
}
