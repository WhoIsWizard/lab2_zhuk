using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_zhuk
{
    public class Passport_document
    {
        public string ID;
        public string Name;
        public string Surname;
        public string Date_Of_Birth;
        public string Nationality;
        public bool sex;                        // True for man,   False for woman
        public string Date_Of_Issue;
        public string Date_Of_expire;
        public string Individual_tax_number;

        public string Passport_Expired_in()
        {
            // ОТРИМУЄМО СЬОГОДНІШНЮ ДАТУ
            DateTime expireDate = DateTime.Parse(Date_Of_expire);
            DateTime currentDate = DateTime.Now;

            // РІЗНИЦЯ МІЖ ДАТОЮ ВИДАЧІ ТА ТЕПЕРІШНЬОЮ ДАТОЮ 
            TimeSpan difference = expireDate.Subtract(currentDate);

            // ПОВНІ РОКИ ДО ЗАКІНЧЕННЯ ПАСПОРТУ
            return $"Passport expires in {difference.Days / 365} years";
        }

    }
}
