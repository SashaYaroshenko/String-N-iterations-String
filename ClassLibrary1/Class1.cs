public class JomoPipi
{

    public static string jumbledString(string s, long n)
    {
        int count = 0;
        List<string> evens = new List<string>();
        List<string> odds = new List<string>();
        
        while (count!=n)
        {
            for(int i=0; i<s.ToCharArray().Length; i++)
            {
                if(i%2==0)
                {
                    evens.Add(s[i].ToString());
                }
                else
                {
                    odds.Add(s[i].ToString());
                }
            }
            s = string.Join("", evens);
            s += String.Join("", odds);
            count++;
            evens.Clear();
            odds.Clear();
        }
        return s;
    }

}