public class MaxHeap : Heap
{
    public override int Extract()
    {
        var max = _heaps.Last();
        _heaps.Remove(max);
        return max;
    }
}
