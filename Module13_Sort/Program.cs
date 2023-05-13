using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module13_Sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var phoneBook = new List<Contact>();

            // добавляем контакты
            phoneBook.Add(new Contact("Игорь", "Николаев", 79990000001, "igor@example.com"));
            phoneBook.Add(new Contact("Сергей", "Довлатов", 79990000010, "serge@example.com"));
            phoneBook.Add(new Contact("Анатолий", "Карпов", 79990000011, "anatoly@example.com"));
            phoneBook.Add(new Contact("Валерий", "Леонтьев", 79990000012, "valera@example.com"));
            phoneBook.Add(new Contact("Сергей", "Брин", 799900000013, "serg@example.com"));
            phoneBook.Add(new Contact("Иннокентий", "Смоктуновский", 799900000013, "innokentii@example.com"));
            {
                // пропускаем нужное количество элементов и берем 2 для показа на странице
                //var pageContent = phoneBook.Skip((pageNumber - 1) * 2).Take(2)
                var pageContent = phoneBook
                .OrderBy(s => s.Name)
                .ThenBy(s => s.LastName);
                Console.WriteLine();
                // выводим результат
                foreach (var entry in pageContent)
                    Console.WriteLine(entry.Name + " " + entry.LastName + ": " + entry.PhoneNumber);
            Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
