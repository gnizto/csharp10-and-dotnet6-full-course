using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleApp
{
    internal class Human
    {
        //member variable
        private string? firstName;
        private string? lastName;
        private string? eyeColor;
        private int? age;

        public Human()
        {

        }

        public Human(string firstName)
        {
            this.firstName = firstName;
        }

        public Human(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public Human(string firstName, string lastName, string eyeColor)
        {
            this.firstName = firstName;
            this.lastName = lastName;

            this.eyeColor = eyeColor;
        }


        public Human (string firstName, string lastName, string eyeColor, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;

            this.eyeColor = eyeColor;
            this.age = age;
        }

        public void IntroduceMyself()
        {
            string fullName = "";
            fullName += firstName ?? "";
            fullName += lastName != null ? " " + lastName :  "";

            string yearText = age + (age == 1 ? " year" : " years");
            //Console.WriteLine("Hi, I'm {0} {1}. My eyes are {2} and I'm {3} old.", firstName, lastName, eyeColor, yearText);

            string message = "Hi";
            message += fullName != "" ? ", I'm " + fullName + "" : "";
            message += eyeColor != null ? " My eyes are " + eyeColor : "";
            message += age != null ? " and I'm " + yearText + " old." : ".";
            Console.WriteLine(message);
        }
    }
}
