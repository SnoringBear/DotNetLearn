namespace DotNetLearn.DataType;
[TestFixture]
public class StringDemo
{
    [Test]
    public void Test01()
    {
        string str = " Hello    World ";
        string trim = str.Trim();
        string replace = trim.Replace(" ","");
        Console.WriteLine("replace:{0}", replace);
    }
    
    [Test]
    public void Test02()
    {
        var path = new ActionPath("a:b:c");
        foreach (var action in path)
        {
            Console.WriteLine("action:{0}", action);
        }
    }
}

public readonly ref struct ActionPath
{
    private readonly String _str;

    /// <summary>
    /// ActionPath.
    /// </summary>
    /// <param name="str">String representing the operation path, separated by ':'.</param>
    public ActionPath(String str)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(str, nameof(str));
        _str = str;
    }

    /// <inheritdoc/>
    public override String ToString() => _str;

    /// <inheritdoc/>
    public override Int32 GetHashCode() => _str.GetHashCode();

    /// <summary>
    /// Whether the path is empty.
    /// </summary>
    public Boolean IsEmpty => String.IsNullOrWhiteSpace(_str);

    /// <summary>
    /// Get enumerator.
    /// </summary>
    /// <returns>Enumerator.</returns>
    public Enumerator GetEnumerator() => new(_str);

    /// <summary>
    /// Implicitly convert ActionPath to string.
    /// </summary>
    /// <param name="actionPath"><see cref="ActionPath"/>.</param>
    public static implicit operator String(ActionPath actionPath) => actionPath._str;

    /// <summary>
    /// Implicitly convert string to <see cref="ActionPath"/>.
    /// </summary>
    /// <param name="str">String.</param>
    public static implicit operator ActionPath(String str) => new(str);

    /// <summary>
    /// Enumerator.
    /// </summary>
    public ref struct Enumerator
    {
        private readonly String _str;
        private Int32 _startIndex;
        private String? _temp;

        internal Enumerator(String str) => _str = str;

        /// <summary>
        /// Current value.
        /// </summary>
        public readonly String Current => _temp
            ?? throw new InvalidOperationException("Enumerator not initialized or moved to next.");

        /// <summary>
        /// Try to move to the next value.
        /// </summary>
        /// <returns>Returns <see langword="true"/> if successful, otherwise <see langword="false"/>.</returns>
        public Boolean MoveNext()
        {
            if (_startIndex >= _str.Length)
            {
                _temp = null;
                return false;
            }
            var nextIndex = _str.IndexOf(':', _startIndex);
            if (nextIndex > 0)
            {
                _temp = _str[_startIndex..nextIndex];
                _startIndex = nextIndex + 1;
            }
            else
            {
                _temp = _str[_startIndex..];
                _startIndex = _str.Length;
            }
            return true;
        }
    }
}
