namespace DotNetLearn.Attribute;

public class DeBugInfoAttribute: System.Attribute
{
    private int bugNo;
    private string developer;
    private string lastReview;
    public string message;

    public DeBugInfoAttribute(int bg, string dev, string d)
    {
        this.bugNo = bg;
        this.developer = dev;
        this.lastReview = d;
        this.message = string.Empty;
    }

    public int BugNo
    {
        get
        {
            return bugNo;
        }
    }
    public string Developer
    {
        get
        {
            return developer;
        }
    }
    public string LastReview
    {
        get
        {
            return lastReview;
        }
    }
    public string Message
    {
        get
        {
            return message;
        }
        set
        {
            message = value;
        }
    }
}