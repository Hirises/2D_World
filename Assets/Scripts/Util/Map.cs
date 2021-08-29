using UnityEngine;
using System.Collections;
using System;

public class Map<K, V> : System.ICloneable
{
    public readonly ArrayList keys = new ArrayList();
    public readonly ArrayList values = new ArrayList();

    public Map()
    {

    }

    public Map(Map<K, V> map)
    {
        foreach(K k in map.keys)
        {
            keys.Add(k);
        }
        foreach (V v in map.values)
        {
            values.Add(v);
        }
    }

    public void Put(K key, V value)
    {
        if (ContainKey(key))
        {
            int index = keys.IndexOf(key);
            values.RemoveAt(index);
            values.Insert(index, value);
        }
        else
        {
            keys.Add(key);
            values.Add(value);
        }
    }

    public V Get(K key)
    {
        for (int i = 0; i < keys.Count; i++)
        {
            if (keys[i].Equals(key))
            {
                return (V) values[i];
            }
        }
        return default(V);
    }

    public void RemoveKey(K key)
    {
        if (ContainKey(key))
        {
            values.Remove(Get(key));
            keys.Remove(key);
        }
    }

    public bool ContainKey(K key)
    {
        return keys.Contains(key);
    }

    public bool ContainValue(V value)
    {
        return values.Contains(value);
    }

    object ICloneable.Clone()
    {
        return new Map<K, V>(this);
    }
}
