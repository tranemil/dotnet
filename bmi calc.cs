using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class HealthProfile
    {
        private String firstName, lastName, gender;
        private int month, day, birthYear;
        private double height, weight;
        private int currentYear = DateTime.Now.Year;
        private int currentYear = DateTime.;

        public HealthProfile(String fN,String lN, String g, int m, int d, int bY, double h, double w)
        {
            firstName = fN;
            lastName = lN;
            gender = g;
            month = m;
            day = d;
            birthYear = bY;
            height = h;
            weight = w;
        }

        public void SetFirstName(String firstName)
        {
            this.firstName = firstName;
        }

        public void SetLastName(String lastName)
        {
            this.lastName = lastName;
        }

        public void SetGender(String gender)
        {
            this.gender = gender;
        }

        public void SetMonth(int month)
        {
            this.month = month;
        }

        public void SetDay(int day)
        {
            this.day = day;
        }

        public void SetBirthYear(int birthYear)
        {
            this.birthYear = birthYear;
        }

        public void SetHeight(double height)
        {
            this.height = height;
        }

        public void SetWeight(double weight)
        {
            this.weight = weight;
        }

        public void SetCurrentYear(int currentYear)
        {
            this.currentYear = currentYear;
        }

        public String GetFirstName()
        {
            return firstName;
        }

        public String GetLastName()
        {
            return lastName;
        }

        public String GetGender()
        {
            return gender;
        }

        public int GetMonth()
        {
            return month;
        }

        public int GetDay()
        {
            return day;
        }

        public int GetBirthYear()
        {
            return birthYear;
        }

        public double GetHeight()
        {
            return height;
        }

        public double GetWeight()
        {
            return weight;
        }

        public int GetCurrentYear()
        {
            return currentYear;
        }

        public int CalculateAge()
        {
            return currentYear - birthYear;
        }

        public int CalculateMaxHR()
        {
            return 220 - CalculateAge();
        }

        public double CalculateHeartRangeMin()
        {
            return CalculateMaxHR() * 0.5;
        }

        public double CalculateHeartRangeMax()
        {
            return CalculateMaxHR() * 0.85;
        }

        public double CalculateBMI()
        {
            return (weight * 703) / (height * height);
        }

        public String BMIValues()
        {
            if (CalculateBMI() < 18.5)
            {
                return "Underweight";
            }
            else if (CalculateBMI() >= 18.5 && CalculateBMI() <= 24.9)
            {
                return "Normal";
            }
            else if (CalculateBMI() >= 25 && CalculateBMI() <= 29.9)
            {
                return "Overweight";
            }
            else return "Obese";
        }


        static void Main(string[] args)
        {
            Console.Write("Enter your first name: ");
            string firstName = Console.ReadLine();
            Console.Write("Enter your last name: ");
            string lastName = Console.ReadLine();
            Console.Write("Enter your gender: ");
            string gender = Console.ReadLine();
            Console.Write("Enter your day of birth: ");
            int birthDay = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter your month of birth: ");
            int birthMonth = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter your year of birth: ");
            int birthYear = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter your height (in inches): ");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter your weight (in pounds): ");
            double weight = Convert.ToDouble(Console.ReadLine());

            HealthProfile profile = new HealthProfile(firstName, lastName, gender, birthMonth, birthDay, birthYear, height, weight);

            Console.WriteLine($"Name: {firstName} {lastName}\nGender: {gender}\nAge: {profile.CalculateAge()}\nBMI: {profile.CalculateBMI()}\nBMI value: {profile.BMIValues()}");
        }
    }
}
