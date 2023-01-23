using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_creating_classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Q3a
            Person person1 = new Person(1, "Ian", "Brooks", "Red", 30, true);
            Person person2 = new Person(2, "Gina", "James", "Green", 18, false);
            Person person3 = new Person(3, "Mike", "Briscoe", "Blue", 45, true);
            Person person4 = new Person(4, "Mary", "Beals", "Yellow", 28, true);

            // Q3b
            person2.DisplayPersonInfo();

            // Q3c
            Console.WriteLine(person3.ToString());

            // Q3d
            string newColor = person1.ChangeFavoriteColour;
            person1.DisplayPersonInfo();

            // Q3e
            person4.GetAgeInTenYears();
            
            // Q3g
            Person[] people = new Person[] {person1, person2, person3, person4};

            double averageAge = (people[0].GetAge + people[1].GetAge + people[2].GetAge + people[3].GetAge) / 4;
            //double averageAge = people[0..3].GetAge / 4;
            Console.WriteLine("Average age is: " + averageAge);

            var nameAgeTable = new Dictionary<double, string>()
            {
                {people[0].GetAge, people[0].GetName},
                {people[1].GetAge, people[1].GetName},
                {people[2].GetAge, people[2].GetName},
                {people[3].GetAge, people[3].GetName},
            };
            Console.WriteLine("The youngest person is: " + nameAgeTable[new[] {people[0].GetAge, people[1].GetAge, people[2].GetAge, people[3].GetAge}.Min()]);
            Console.WriteLine("The oldest person is: " + nameAgeTable[new[] {people[0].GetAge, people[1].GetAge, people[2].GetAge, people[3].GetAge}.Max()]);
        }
    }
}
