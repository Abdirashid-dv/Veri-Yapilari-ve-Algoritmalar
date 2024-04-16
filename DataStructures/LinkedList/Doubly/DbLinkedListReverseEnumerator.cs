
using System.Collections;

namespace DataStructures.LinkedList.Doubly;


public class DbLinkedListReverseEnumerator<T> : IEnumerator<T>
{
    private DbNode<T> Head { get; set; }
    private DbNode<T> Tail { get; set; }
    public DbNode<T> Curr { get; set; }

    public T Current => Curr != null ? Curr.Value : default;

    object IEnumerator.Current => Current;

    public DbLinkedListReverseEnumerator()
    {

    }

    public DbLinkedListReverseEnumerator(DbNode<T> head, DbNode<T> tail)
    {
        this.Head = head;
        this.Tail = tail;
        Curr = null;
    }
    public void Dispose()
    {
        Head = null;
        Tail = null;
    }

    public bool MoveNext()
    {

        if (Tail is null)
            return false;

        if (Curr is null)
        {
            Curr = Tail;
            return true;
        }

        if (Curr.Prev is not null)
        {
            Curr = Curr.Prev;
            return true;
        }

        return false;
    }

    public void Reset()
    {
        Curr = null;
        Tail = null;
        Head = null;
    }
}