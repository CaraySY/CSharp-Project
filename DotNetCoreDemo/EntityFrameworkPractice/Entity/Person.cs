using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameworkPractice.Entity
{
    public class Person
    {
        private int id;
        private string lastName;
        private string firstName;

        public int Id { get => id; set => id = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string FirstName { get => firstName; set => firstName = value; }

        public override string ToString()
        {
            return $"Person [id={id},lastName={lastName},firstName={firstName}]";
        }
    }
}
