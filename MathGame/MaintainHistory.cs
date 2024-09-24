
public static class RecordKeep
{
    public static List<string> History = new List<string>();

    public static void RecordData(string fn, string sn, string ans, string symbol )
    {
        History.Add(fn);
        History.Add(sn);
        History.Add(ans);
        History.Add(symbol);
    }
    public static void GetHistory()
    {
        if(History.Count == 0)
        {
            Console.WriteLine("No history to show");
            return;
        }
        for (int i = 0; i < History.Count ; i = i+4)
        {
            Console.WriteLine(History[i] + "  " + History[i+3] +"  " +  History[i+1] + " = " + History[i+2]);
        }
    }


}