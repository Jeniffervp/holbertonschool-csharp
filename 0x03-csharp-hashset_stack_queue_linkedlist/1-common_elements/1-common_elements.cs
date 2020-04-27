using System;
using System.Collections.Generic;

class List
{
    public static List<int> CommonElements(List<int> list1, List<int> list2)
    {
        List<int> result = new List<int>();
        foreach (int a in list1) 
        {
            foreach (int b in list2)
            {
                if (a == b)
                {
                    result.Add(a);
                }
            }
        }
        result.Sort();
        return result;
    }
}
