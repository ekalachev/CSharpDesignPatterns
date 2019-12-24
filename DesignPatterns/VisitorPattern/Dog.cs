using System;

namespace DesignPatterns.VisitorPattern
{
    internal class Dog : IElement<Dog>
    {
        public DateTime DatePassed { get; set; }
        public DateTime BirthDate { get; set; }
        public int Age { get; internal set; }

        public void Accept(IVisitor<Dog> visitor)
        {
            visitor.Visit(this);
        }
    }
}