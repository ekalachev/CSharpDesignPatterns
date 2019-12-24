namespace DesignPatterns.VisitorPattern
{
    interface IElement<T>
    {
        void Accept(IVisitor<T> visitor);
    }
}
