public abstract class Heap
{
    // {0,1,2,3,4,5}
    protected SortedSet<int> _heaps;
    public Heap()
    {
        _heaps = new SortedSet<int>();
    }

    public void Insert(int item)
    {
        _heaps.Add(item);
    }
    public abstract int Extract();
}
