using System;

namespace DesignPatterns.Creational.Prototype
{
    public class Person
    {
        public int Age;
        public DateTime BirthDate;
        public IdInfo IdInfo;
        public string Name;

        public Person ShallowCopy()
        {
            return (Person) MemberwiseClone();
        }

        public Person DeepCopy()
        {
            var clone = (Person) MemberwiseClone();
            clone.IdInfo = new IdInfo(IdInfo.IdNumber);
            clone.Name = Name;
            return clone;
        }
    }
}