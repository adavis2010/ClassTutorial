using System;
using System.Collections.Generic;
using System.Text;

namespace ClassTutorial {
    class Student {
        public string Name;
        public string Address;
        public decimal GPA;
        public string Major;
        public bool Graduated = false;


        //default constructor
        public Student() {
            Console.WriteLine("Called Default Constructor");
        }
        public Student(string name) {
            Name = name.ToUpper();
            Console.WriteLine("Called 1 parameter constructor");
        }



        public string UppercaseName() {
            return Name.ToUpper();
        }
        public void NewGPA(decimal GPA) {
            this.GPA = GPA;
        }



        public void HasGraduated() {
            Graduated = true;
        }

        public void Print() {
            Console.Write($"Name is {Name},GPA is {GPA}, Major is {Major}");
            Console.WriteLine($", Graduated {Graduated}");

        }
    }
}


