using Iterator00Demo.Step1_Iterator_Interface;

namespace Iterator00Demo;

internal class SortedBinaryTreeIterator(SortedBinaryTreeCollection aggregate) : IIterator
{
    private Node? _current = null;

    public int GetCurrent()
    {
        return _current.Value;
    }

    public bool MoveNext()
    {
        if (_current is null)
        {
            _current = aggregate.GetFirst();
            return true;
        }

        if (_current.Right is not null)
        {
            _current = _current.Right;

            while (true)
            {
                if (_current.Left is null)
                {
                    break;
                }

                _current = _current.Left;
            }

            return true;
        }
        else
        {
            var originalValue = _current.Value;

            while (true)
            {
                if (_current.Parent is not null)
                {
                    _current = _current.Parent;

                    if (_current.Value > originalValue)
                    {
                        return true;
                    }
                }
                else
                {
                    return false;
                }
            }
        }
    }
}