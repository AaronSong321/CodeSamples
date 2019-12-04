using System;

namespace Aaron.DataStructure
{
    public interface IPriorityQueue<TNode>
        where TNode: IComparable<TNode>
    {
        void Enqueue(TNode node);
        void Dequeue();
        TNode Peek();
    }
}
