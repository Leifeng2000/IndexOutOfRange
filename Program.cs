internal class Program
{
    private static void Main(string[] args)
    {
        List<char> characters = new List<char>();
        characters.AddRange(new Char[] { 'a', 'b', 'c', 'd', 'e', 'f' });
        try
        {
            List<char> characters2 = new List<char>();
            characters2.AddRange(new Char[] { 'a', 'b', 'c', 'd', 'e', 'f' });
            int value = characters2[6];
        }
        catch (IndexOutOfRangeException ex)
        {
            System.Console.WriteLine(ex);
        }
    }
}