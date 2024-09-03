using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab_2_lib;

namespace Lab2APP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Кількість осіб: ");
            int NumPeople = int.Parse(Console.ReadLine());
            Passport_document[] arrData = new Passport_document[NumPeople];
            for (int i = 0; i < NumPeople; i++)
            {
                Console.Write("Введіть ID: ");
                string sID = Console.ReadLine();
                Console.Write("Введіть ім'я: ");
                string sName = Console.ReadLine();
                Console.Write("Введіть прізвище: ");
                string sSurname = Console.ReadLine();
                Console.Write("Введіть дату народження (yyyy-MM-dd): ");
                string sDateOfBirth = Console.ReadLine();
                Console.Write("Введіть національність: ");
                string sNationality = Console.ReadLine();
                Console.Write("Вкажіть стать (чоловік/жінка) [ч/ж]: ");
                ConsoleKeyInfo keyHasSex = Console.ReadKey();
                Console.WriteLine();
                Console.Write("Введіть дату видачі паспорта (yyyy-MM-dd): ");
                string sDateOfIssue = Console.ReadLine();
                Console.Write("Введіть дату закінчення терміну дії паспорта (yyyy-MM-dd): ");
                string sDateOfExpire = Console.ReadLine();
                Console.Write("Введіть індивідуальний податковий номер: ");
                string sIndividualTaxNumber = Console.ReadLine();
                Console.WriteLine();

                // Створюємо новий екземпляр people_data
                Passport_document person = new Passport_document
                {
                    ID = sID,
                    Name = sName,
                    Surname = sSurname,
                    Date_Of_Birth = sDateOfBirth,
                    Nationality = sNationality,
                    sex = keyHasSex.Key == ConsoleKey.Y,
                    Date_Of_Issue = sDateOfIssue,
                    Date_Of_expire = sDateOfExpire,
                    Individual_tax_number = sIndividualTaxNumber
                };

                // Додаємо об'єкт в масив
                arrData[i] = person;

            }
            foreach (Passport_document person in arrData)
            {
                // Виводимо інформацію про особу та термін дії паспорта
                Console.WriteLine("Дані про особу:");
                Console.WriteLine("------------------------------------------");
                Console.WriteLine($"ID: {person.ID}");
                Console.WriteLine($"Ім'я: {person.Name}");
                Console.WriteLine($"Прізвище: {person.Surname}");
                Console.WriteLine($"Дата народження: {person.Date_Of_Birth}");
                Console.WriteLine($"Національність: {person.Nationality}");
                Console.WriteLine($"Стать: {(person.sex ? "Чоловік" : "Жінка")}");
                Console.WriteLine($"Дата видачі паспорта: {person.Date_Of_Issue}");
                Console.WriteLine($"Дата закінчення терміну дії паспорта: {person.Date_Of_expire}");
                Console.WriteLine($"Індивідуальний податковий номер: {person.Individual_tax_number}");
                Console.WriteLine($"Термін дії паспорта закінчується через: {person.Passport_Expired_in()}");
            }
            Console.ReadKey();


        }
    }
}
