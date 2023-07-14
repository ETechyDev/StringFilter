abstract class StringFilter
{
    protected string filtered;
    public virtual string ClString(string str)
    {
        
        for(int i = 0; i < str.Length; i++)
        {
            if(i%2==0)
            {
                filtered += str[i];
            }
        }
        return filtered;
    }
}

class WordFilter : StringFilter
{
    public override string ClString(string str)
    {
        for(int i = 0; i <str.Length;i++)
        {
            if(str[i] != ' ')
            {
                filtered += str[i] ;
            }
        }
        return filtered;
    }
}

class NumberFilter : StringFilter
{
    public override string ClString(string str)
    {
        for(int i = 0; i < str.Length; i++)
        {
            if (DictManager.nums.Contains(str[i]))
            {
                filtered += str[i];
            }
        }

        return filtered;
    }
}
