using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
public class PromptGenerator
{
    Random randomPromt = new Random();
    public List<string> _prompts = new List<string>
    {
        "What made you smile today, even if just for a moment?",
        "What was the most unexpected part of your day?",
        "Did you take a moment for yourself today?",
        "What is one thing you learned or realized today about yourself?",
        "What drained your energy today? What gave you energy?",
        "Describe a moment when you felt present and aware today?",
        "If you had to give today a title like a book or movie, what would it be?",
    };
    public string GetRandomPromt()
    {
        int index = randomPromt.Next(_prompts.Count);
        return _prompts[index];
    }
   
    
}