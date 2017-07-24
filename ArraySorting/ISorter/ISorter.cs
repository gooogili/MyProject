using System;

namespace ISorterNamespace
{
    public interface ISorter
    {
        string methodName { get; }
        float methodTime { get; }
        int speedChanger { get; set; }

        event EventHandler<ElementsAreSwappedEventArgs> ElementsAreSwapped;

        int[] Sort(int[] arrayForSorting);
    }
}
