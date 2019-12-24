namespace DesignPatterns.VisitorPattern
{
    interface IVisitor<T>
    {
        void Visit(T element);
    }
}
