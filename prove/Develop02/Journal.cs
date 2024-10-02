using System.IO; 
public class Journal{
    
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry){
        //adds new entry to _entries list
        _entries.Add(newEntry);
    }
    public void DisplayAll(){
        //displays all entries from _entries
        foreach(Entry entry in _entries){
            entry.Display();
        }
    }
    public void SaveToFile(string file){
        //loop through entries and save to file one by one
        using(StreamWriter outputFile = new StreamWriter(file)){
            foreach(Entry entry in _entries){
            outputFile.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}|");
            }
        }
        Console.WriteLine("file has been saved");
    }
    public void LoadFromFile(string file){
        //loop through file and create entry objects to put in the list 
        string[] lines = System.IO.File.ReadAllLines(file);
        foreach (string line in lines){
            Entry newEntry = new Entry();
            string[] parts = line.Split("|");
            newEntry._date = parts[0];
            newEntry._promptText = parts[1];
            newEntry._entryText = parts[2];
            _entries.Add(newEntry);
        }
    }
}