using Iterator00Demo.Step1_Iterator_Interface;
using Iterator00Demo.Step3_Collection_Interface;

namespace Iterator00Demo;

internal class SortedBinaryTreeCollection : IAggregate
{
    private Node? _root = null;

    public IIterator CreateIterator()
    {
        return new SortedBinaryTreeIterator(this);
    }

    public Node? GetFirst()
    {
        Node? current = _root;

        while (true)
        {
            if (current?.Left is not null)
            {
                current = current.Left;
            }
            else
            {
                return current;
            }
        }
    }

    public void Insert(int value)
    {
        var newNode = new Node(value);

        if (_root is null)
        {
            _root = newNode;
        }
        else
        {
            Node? temp = _root;

            while (true)
            {
                Node? parent = temp;

                if (value < temp.Value)
                {
                    temp = temp.Left;

                    if (temp is null)
                    {
                        parent.Left = newNode;
                        newNode.Parent = parent;
                        return;
                    }
                }
                else
                {
                    temp = temp.Right;

                    if (temp is null)
                    {
                        parent.Right = newNode;
                        newNode.Parent = parent;
                        return;
                    }
                }
            }
        }
    }
}