using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pair<X, Y> : System.ICloneable
{
    public X x;
    public Y y;

    public Pair(X x, Y y) {
        this.x = x;
        this.y = y;
    }

    public object Clone()
    {
        return new Pair<X, Y>(x, y);
    }

    public override bool Equals(object obj)
    {
        Pair<X, Y> target = (Pair<X, Y>)obj;
        return x.Equals(target.x) && y.Equals(target.y);
    }

    public override string ToString()
    {
        return x.ToString() + ", " + y.ToString();
    }
}
