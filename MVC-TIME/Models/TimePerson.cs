using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_TIME.Models
{

    public class TimePerson
    {

        public int Year { get; set; }
        public string Honor { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public int BirthYear { get; set; }
        public int DeathYear { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }
        public string Context { get; set; }

        public TimePerson(int year, string honor, string name, string country, int birthYear, int deathYear, string title, string category, string context)
        {
            Year = year;
            Honor = honor;
            Name = name;
            Country = country;
            BirthYear = birthYear;
            DeathYear = deathYear;
            Title = title;
            Category = category;
            Context = context;
        }

        public List<TimePerson> GetPerson(int startyear, int endyear)
        {
            string _filePath = @"C:\Code\Lab 11-My First MVC App\Lab11-MyFirstMVC_App\MVC-TIME\wwwroot\PersonOfTheYear.csv";


            List<string> allPeople = LoadCsvFile(_filePath);
            // This is strings List of csv file

            // This is TimePerson List of query
            var query = from line in allPeople
                        let data = line.Split(',')
                        select new TimePerson(Int32.Parse(data[0]), data[1], data[2], data[3], Int32.Parse(data[4]), Int32.Parse(data[5]), data[6], data[7], data[98]);

            List<TimePerson> requestedPeople = new List<TimePerson>();

            foreach (TimePerson person in query)
            {
                if (person.Year >= startyear || person.Year <= endyear)
                    requestedPeople.Add(person);
            }

            return requestedPeople;
        }

        List<String> LoadCsvFile(string _filePath)
        {
            var reader = new StreamReader(File.OpenRead(_filePath));
            List<String> searchList = new List<String>();
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                searchList.Add(line);
            }
            return searchList;
        }

    }

}

}
