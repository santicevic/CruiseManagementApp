using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CruiseManagementApp.Data.Entities.Models;
using CruiseManagementApp.Data.Enums;

namespace CruiseManagementApp.Presentation.Utils
{
    public class FormValidation
    {
        public static string PassengerFormValidation(Passenger passengerToValidate)
        {
            var result = "";

            if(passengerToValidate.FirstName.Length < 3)
            {
                result += "Ime mora sadržavati više od 2 znaka.\n";
            }
            if(passengerToValidate.LastName.Length < 3)
            {
                result += "Prezime mora sadržavati više od 2 znaka.\n";
            }
            if(passengerToValidate.Address.Length < 6)
            {
                result += "Adresa mora sadržavati više od 5 znakova.";
            }

            return result;
        }

        public static string CabinFormValidation(Cabin cabinToValidate)
        {
            var result = "";

            if(cabinToValidate.Name == "")
            {
                result += "Naziv je obavezno polje!\n";
            }
            if(cabinToValidate.Price <= 0)
            {
                result += "Naknada mora biti cijeli broj veći od 0";
            }

            return result;
        }

        public static string EmployeeFormValidation(Employee employeeToValidate)
        {
            var result = "";

            if (employeeToValidate.FirstName.Length < 3)
            {
                result += "Ime mora sadržavati više od 2 znaka.\n";
            }
            if (employeeToValidate.LastName.Length < 3)
            {
                result += "Prezime mora sadržavati više od 2 znaka.\n";
            }
            if (DateTime.Today.Year - employeeToValidate.DateOfBirth.Year < 18)
            {
                result += "Zaposlenik treba imati navršenih 18 godina.";
            }

            return result;
        }

        public static string ShipFormValidation(Ship shipToValidate)
        {
            var result = "";

            if (shipToValidate.Name.Length < 3)
            {
                result += "Ime mora sadržavati više od 2 znaka.\n";
            }
            if (DateTime.Today.Year < shipToValidate.YearOfAssembly.Year)
            {
                result += $"Godina proizvodnje može biti {DateTime.Now.Year}. ili prije!";
            }

            return result;
        }
    }
}
