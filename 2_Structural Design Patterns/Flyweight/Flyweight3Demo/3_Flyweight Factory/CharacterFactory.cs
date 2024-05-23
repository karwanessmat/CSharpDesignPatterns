using System.Collections.Generic;
using Flyweight3Demo._1_Flyweight_Interface;
using Flyweight3Demo._2__Concrete_Flyweight;

namespace Flyweight3Demo._3_Flyweight_Factory;

internal class CharacterFactory
{
    private  readonly Dictionary<string,Character> _characters = new();

    public int TotalObjectsCreated => _characters.Count;
    public Character GetCharacter(string key)
    {
        key = key.ToLower().Trim();
        // Uses "lazy initialization"
        Character character = null;
        if (_characters.TryGetValue(key, out Character characterValue))
        {
            character = characterValue;
        }
        else
        {
            character = key switch
            {
                "a" => new CharacterA(),
                "b" => new CharacterB(),
                _ => new CharacterZ()
            };
            _characters.Add(key, character);
        }

        return character;
    }
}