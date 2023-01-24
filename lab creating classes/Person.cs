using lab_creating_classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_creating_classes
{
    internal class Person
    {
        // Q1
        private int personId;
        private string firstName;
        private string lastName;
        private string favouriteColour;
        private int age;
        private bool isWorking;

        public Person(int personId, string firstName, string lastName, string favouriteColour, int age, bool isWorking)
        {
            this.personId = personId;
            this.firstName = firstName;
            this.lastName = lastName;
            this.favouriteColour = favouriteColour;
            this.age = age;
            this.isWorking = isWorking;
        }

        public void DisplayPersonInfo()
        {
            string formatted = string.Format("{0}: {1} {2}'s favorite color is {3}", personId, firstName, lastName, favouriteColour);
            Console.WriteLine(formatted);
        }

        public string ChangeFavoriteColour
        {
            get 
            {
                favouriteColour = "White";
                return favouriteColour;
            }
        }

        public void GetAgeInTenYears()
        {
            int newAge = age + 10;

            string formatted = string.Format("{0} {1}'s Age in 10 years is: {2}", firstName, lastName, newAge);
            Console.WriteLine(formatted);
        }

        public override string ToString()
        {
            return $"PersonId: {personId}\nFirstName: {firstName}\nLastName: {lastName}\nFavouriteColour: {favouriteColour}\nAge: {age}\nIsWorking: {isWorking}";
        }

        public double GetAge
        {
            get
            {
                return age;
            }
        }

        // getter for Question 3g
        public string GetName
        {
            get
            {
                return firstName;
            }
        }
    }
}
