using System.Collections.Generic;
using ClosedXML.Excel;

namespace Excel
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var contactList = new List<Person>
            {
                new Person
                {
                    Age = 32,
                    Name = "Victor",
                    Surname = "Kuznetsov",
                    Phone = 123456
                },
                new Person
                {
                    Age = 45,
                    Name = "Alexandra",
                    Surname = "Petrova",
                    Phone = 562341
                }
            };

            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Лист1");

                worksheet.Cell("A" + 1).Value = "Name";
                worksheet.Cell("B" + 1).Value = "Surname";
                worksheet.Cell("C" + 1).Value = "Age";
                worksheet.Cell("D" + 1).Value = "Phone";

                var i = 2;

                foreach (var person in contactList)
                {
                    worksheet.Cell("A" + i).Value = person.Name;
                    worksheet.Cell("B" + i).Value = person.Surname;
                    worksheet.Cell("C" + i).Value = person.Age;
                    worksheet.Cell("D" + i).Value = person.Phone;

                    i++;
                }

                worksheet.Columns().Width = 12;
                workbook.SaveAs("Contacts.xlsx");
            }
        }
    }
}
