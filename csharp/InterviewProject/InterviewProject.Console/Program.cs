using InterviewProject.Backend;

public class Application
{
    private static IList<int> Parse(string arg)
    {
        List<int> l = new List<int>();
        string[] split = arg.Split(",");

        foreach (string entry in split)
        {
            int val = 0;
            if(int.TryParse(entry,out val))
            {
                l.Add(val);
            }
        }

        return l;
    }


    public static void Main(string[] args)
    {
        IList<int> list = args.Length > 0 ? Parse(args[0]) : new List<int>();

        IList<int> result =CollectionManipulation.DeDupe(list);

        Console.WriteLine("Original List: {0}", string.Join(",", list));
        Console.WriteLine("DeDuped List: {0}", string.Join(",", result));
    }
}

