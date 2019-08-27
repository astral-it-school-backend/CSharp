namespace IT_School.DelegatesAndEvents
{
    public class CollectionItem
    {
        public object Value { get; set; }

        public CollectionItem Parent { get; set; }

        public CollectionItem(object value, CollectionItem parent)
        {
            Value = value;
            Parent = parent;
        }
    }


}
