namespace DotNetLearn.Indexer;

public class IndexedNames
{
    private string[] namelist = new string[size];
    static public int size = 10;
    public IndexedNames()
    {
        for (int i = 0; i < size; i++)
            namelist[i] = "N. A.";
    }
    public string this[int index]
    {
        get
        {
            string tmp;

            if( index >= 0 && index <= size-1 )
            {
                tmp = namelist[index];
            }
            else
            {
                tmp = "";
            }

            return ( tmp );
        }
        set
        {
            if( index >= 0 && index <= size-1 )
            {
                namelist[index] = value;
            }
        }
    }

}