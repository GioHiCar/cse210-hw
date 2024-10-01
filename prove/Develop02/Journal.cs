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
    }
    public void LoadFromFile(string file){
        //loop through file and create entry objects to put in the list 
    }
}