namespace Visitor
{
    interface IElement<T>
    {
        void Accept(IVisitor<T> visitor);
    }
}
