namespace ISorterNamespace
{
    public class ElementsAreSwappedEventArgs
    {
        public int[] Array { get; set; }
        public int FirstElement { get; set; }
        public int SecondElement { get; set; }

        public ElementsAreSwappedEventArgs(int[] array, int firstElement, int secondElement)
        {
            Array = array;
            FirstElement = firstElement;
            SecondElement = secondElement;
        }
    }
}