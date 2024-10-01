
public class PromptGenerator{

    Random random = new Random();

    public List<string> _prompts = new List<string>(){
        "What exciting thing happened to me today?",
        "Was today better than yesterday?",
        "If I had one thing I could do over today, what would it be?",
        "What goals for today did i accomplish?"
    };
    public string GetRandomPrompt(){
        //get random index value and lookup the string in _prompts
        int index = random.Next(1, _prompts.Count());
        string prompt = _prompts[index];
        return prompt;

    }
}