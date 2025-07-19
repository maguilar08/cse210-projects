public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;
    public string _postscript;


    public Entry(string date, string promptText, string entryText, string postscript)
    {
        _date = date;
        _promptText = promptText;
        _entryText = entryText;
        _postscript = postscript;
    }

    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Response: {_entryText}");
        Console.WriteLine($"P.D.: {_postscript}");
        Console.WriteLine("----------------------------------------");
    }

    public override string ToString()
    {
        string line = $"{_date}|{_promptText}|{_entryText}|{_postscript}";
        return line;
    }

    public static Entry FromString(string line)
    {
        string[] parts = line.Split("|");
        string date = parts[0];
        string prompt = parts[1];
        string response = parts[2];
        string postscript = parts[3];

        Entry loadEntry = new Entry(date, prompt, response, postscript);
        return loadEntry;
    }
}
