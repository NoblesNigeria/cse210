using System;
using System.Collections.Generic;

public class PromptGenerator
{
    List<string> prompts = new List<string>()
    {
        "What made you happy today?",
        "What did you learn today?",
        "Who helped you today?",
        "What challenge did you overcome?",
        "What are you grateful for today?",
        "What goal do you have for tomorrow?"
    };

    Random random = new Random();

    public string GetRandomPrompt()
    {
        int index = random.Next(prompts.Count);
        return prompts[index];
    }
}