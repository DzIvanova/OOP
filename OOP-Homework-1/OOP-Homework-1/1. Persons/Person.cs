﻿using System;

namespace _1.Persons
{
    public class Person
    {
        private string name;
        private int age;
        private string email;

        public Person(string name, int age, string email)
        {
            this.Name = name;
            this.Age = age;
            this.Email = email;
        }
        public Person(string name, int age)
            : this(name, age, null)
        {
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be empty!");
                }
                if (value.Length < 1)
                {
                    throw new ArgumentException("Name is too short! It should be at least one letter.");
                }
                if (value.Length >= 100)
                {
                    throw new ArgumentException("Name is too long! The maximum size is 100 letters.");
                }
                this.name = value;
            }
        }
        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value < 1 || value >= 100)
                {
                    throw new ArgumentException("Invalid input! The age should be in range [1...100].");
                }
                this.age = value;
            }
        }
        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                if (null != value && (value.Length == 0 || !value.Contains("@")))
                {
                    throw new ArgumentException("Invalid e-mail!");
                }
                this.email = value;
            }
        }
        public override string ToString()
        {
            return string.Format("Your name is: {0}\nYour age is: {1}\nYour email is:{2}", this.Name, this, Age, this.Email ?? "[unknwn]");
        }
    }

}