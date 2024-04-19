namespace Iterator00Demo;

internal class Node
{
    public Node(int value)
    {
        Value = value;
    }

    public int Value { get; set; }
    public Node Left { get; set; }
    public Node Right { get; set; }
    public Node Parent { get; set; }
}