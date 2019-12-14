using System;

namespace BasicClasses
{
    class Person
    {
        private string _lastName;
        public string FirstName { get; }

        public int Age { get; }

        public string LastName
        {
            get => _lastName;
            set
            {
                if (value == null)
                    throw new ArgumentNullException("Name cannot be null");
                _lastName = value;
            }
        }

        public Person(string firstName, string lastName, int age)
        {
            if (firstName == null || lastName == null)
                throw new ArgumentNullException("Names cannot be null");
            if (age <= 0)
                throw new ArgumentOutOfRangeException("Age must be postive");
            _lastName = lastName;
            FirstName = firstName;
            Age = age;
        }
    }
}