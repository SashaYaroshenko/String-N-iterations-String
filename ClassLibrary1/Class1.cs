using System;
using System.Collections.Generic;
using System.Linq;

public class JomoPipi
{

    public static string jumbledString(string s, long n)
    {
        int count = 0;
        List<char> chars = s.ToCharArray().ToList();
        List<char> evens;
        List<char> odds;

        while (count != n)
        {
            evens = chars.Where((c, i) => i % 2 == 0).ToList();
            odds = chars.Where((c, i) => i % 2 != 0).ToList();
            chars = new List<char>();
            chars.AddRange(evens);
            chars.AddRange(odds);
            count++;
        }
        s = new string(chars.ToArray());

        //while (count!=n)
        //{
        //    for(int i=0; i<s.ToCharArray().Length; i++)
        //    {
        //        if(i%2==0)
        //        {
        //            evens.Add(s[i].ToString());
        //        }
        //        else
        //        {
        //            odds.Add(s[i].ToString());
        //        }
        //    }
        //    s = string.Join("", evens);
        //    s += String.Join("", odds);
        //    count++;
        //    evens.Clear();
        //    odds.Clear();
        //}
        return s;
    }

}