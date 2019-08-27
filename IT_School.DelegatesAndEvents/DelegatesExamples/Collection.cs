namespace IT_School.DelegatesAndEvents
{
    public class Collection
    {
        public CollectionItem Root { get; private set; }
        public CollectionItem Current { get; private set; }

        public void AddItem(object item)
        {
            Current = new CollectionItem(item, Current);
        }
    }


}
