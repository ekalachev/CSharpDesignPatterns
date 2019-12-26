namespace Visitor
{
    class CalculateDogAge : IVisitor<Dog>
    {
        public void Visit(Dog dog)
        {
            dog.Age = dog.DatePassed.Year - dog.BirthDate.Year;
        }
    }
}
