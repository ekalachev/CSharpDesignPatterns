namespace Visitor
{
    interface IVisitor<T>
    {
        void Visit(T element);
    }
}
