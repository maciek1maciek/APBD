using System;

namespace Zadanie_3.Models
{
    public class Student
    {
        public Student(string firstName, string lastName, string study, string studyType, string index, string dateOfBirth, string email, string mothername, string fatherName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.index = index;
            this.dateOfBirth = dateOfBirth;
            this.study = study;
            this.studyType = studyType;
            this.email = email;
            this.fatherName = fatherName;
            this.mothername = mothername;
        }

        public string firstName { get; set; }
        public string lastName { get; set; }

        public string index { get; set; }
         
        public string dateOfBirth { get; internal set; }

        public string study { get; set; }

        public string studyType { get; set; }

        public string email { get; set; }

        public string fatherName { get; set; }

        public string mothername { get; set; }


        public override string ToString()
        {
            return this.firstName.ToString() + "," +
                   this.lastName.ToString() + "," +
                   this.study.ToString() + "," +
                   this.studyType.ToString() + "," +
                   this.index.ToString() + "," +
                   this.dateOfBirth.ToString() + "," + 
                   this.email.ToString() + "," +
                   this.fatherName.ToString() + "," +
                   this.mothername.ToString();
        }


    }

    



    }
