using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class DamageRange
{
    private int minValue;
    private int maxValue;

    public DamageRange(int min, int max)
    {
        minValue = min > 0 ? min : 0;
        maxValue = max; //Should i have some maximum value here? 
    }

    public int MinValue
    {
        get
        {
            return minValue;
        }

        set
        {
            minValue = value > 0 ? value : 0;
        }
    }

    public int MaxValue
    {
        get
        {
            return maxValue;
        }

        set
        {
            maxValue = value;
        }
    }

    public int getRoll()
    {
        return UnityEngine.Random.Range(minValue, maxValue);
    }
}

