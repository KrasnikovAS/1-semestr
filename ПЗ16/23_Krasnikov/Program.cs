using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace PeopleAnalyzer
{
    [Serializable]
    public class Person
    {
        public string Name { get; set; }
        public int[] Marks { get; set; }

        public Person() { }

        public Person(string name, int[] marks)
        {
            Name = name;
            Marks = marks;
        }

        public double AverageMarks => Marks.Average();
    }

    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "..\\..\\..\\people.xml";

            List<Person> people = DeserializePeople(filePath);

            while (true)
            {
                Console.WriteLine("Команды:");
                Console.WriteLine("1 - Показать самого лучшего ученика");
                Console.WriteLine("2 - Показать самого худшего ученика");
                Console.WriteLine("3 - Показать весь список");
                Console.WriteLine("4 - Показать учеников со средним баллом больше...");

                string command = Console.ReadLine();

                switch (command)
                {
                    case "1":
                        ShowBestPerson(people);
                        break;
                    case "2":
                        ShowWorstPerson(people);
                        break;
                    case "3":
                        ShowAllPeople(people);
                        break;
                    case "4":
                        ShowPeopleAboveAverage(people);
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Некорректная команда. Попробуйте снова.");
                        break;
                }
            }
        }

        static List<Person> DeserializePeople(string filePath)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Person>));
            using (FileStream fs = new FileStream(filePath, FileMode.Open))
            {
                return (List<Person>)serializer.Deserialize(fs);
            }
        }

        static void ShowBestPerson(List<Person> people)
        {
            var bestPerson = people.OrderByDescending(p => p.AverageMarks).FirstOrDefault();
            if (bestPerson != null)
            {
                Console.WriteLine($"Лучший ученик: {bestPerson.Name}, Средний балл: {bestPerson.AverageMarks:F2}");
            }
            else
            {
                Console.WriteLine("Список пуст.");
            }
        }

        static void ShowWorstPerson(List<Person> people)
        {
            var worstPerson = people.OrderBy(p => p.AverageMarks).FirstOrDefault();
            if (worstPerson != null)
            {
                Console.WriteLine($"Худший ученик: {worstPerson.Name}, Средний балл: {worstPerson.AverageMarks:F2}");
            }
            else
            {
                Console.WriteLine("Список пуст.");
            }
        }

        static void ShowAllPeople(List<Person> people)
        {
            if (people.Any())
            {
                Console.WriteLine("Список учеников:");
                foreach (var person in people)
                {
                    Console.WriteLine($"{person.Name}, Средний балл: {person.AverageMarks:F2}");
                }
            }
            else
            {
                Console.WriteLine("Список пуст.");
            }
        }

        static void ShowPeopleAboveAverage(List<Person> people)
        {
            Console.Write("Введите минимальный средний балл: ");
            if (double.TryParse(Console.ReadLine(), out double minAverage))
            {
                var filteredPeople = people.Where(p => p.AverageMarks > minAverage).ToList();
                if (filteredPeople.Any())
                {
                    Console.WriteLine("Ученики со средним баллом выше заданного:");
                    foreach (var person in filteredPeople)
                    {
                        Console.WriteLine($"{person.Name}, Средний балл: {person.AverageMarks:F2}");
                    }
                }
                else
                {
                    Console.WriteLine("Нет учеников с таким средним баллом.");
                }
            }
            else
            {
                Console.WriteLine("Некорректный ввод.");
            }
        }
    }
}
