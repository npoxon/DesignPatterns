using System;

namespace DesignPatterns.Creational.Prototype
{
    public class Person
    {
        public int Age;
        public DateTime BirthDate;
        public string Name;
        public IdInfo IdInfo;

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