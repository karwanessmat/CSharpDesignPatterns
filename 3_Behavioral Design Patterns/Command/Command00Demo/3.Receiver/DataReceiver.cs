namespace Command00Demo._3.Receiver;

internal class DataReceiver
{
    private readonly Dictionary<string, string> _data = [];

    public void Upsert(string key, string value)
    {
        if (_data.TryAdd(key, value))
        {
            Console.WriteLine($"Inserted: {key} - {value}.");

        }
        else
        {
            _data[key] = value;
            Console.WriteLine($"Updated: {key} - {value}.");

        }

        Console.WriteLine($"Count {_data.Count}");
    }

    public void Delete(string key)
    {
        if (!_data.ContainsKey(key)) return;

        _data.Remove(key);
        Console.WriteLine($"Removed: {key}.");
    }
}