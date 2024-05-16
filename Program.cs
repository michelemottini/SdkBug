using System.Linq.Expressions;

var test = new Test<Intermediate>();
Console.WriteLine(test.X(intermediate => intermediate.Strings));

class Intermediate
{
    public List<string> Strings { get; } = new List<string>();
    public string String { get; set; } = string.Empty;
}

class Test<TIntermediate>
{
    public int X<TElement>(params Expression<Func<TIntermediate, TElement>>[] getItem)
    {
        return 0;
    }

    public int X<TElement>(params Expression<Func<TIntermediate, List<TElement>>>[] getList)
    {
        return 1;
    }
}
