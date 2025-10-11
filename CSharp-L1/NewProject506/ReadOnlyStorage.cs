namespace NewProject506;

class ReadOnlyStorage<T>
    where T : IComparable<T>
{
    public T Data { get; init; }

    public ReadOnlyStorage(T data) => Data = data;

    public bool IsGreater(T data)
    {
        return Data.CompareTo(data) > 0;
    }

}
