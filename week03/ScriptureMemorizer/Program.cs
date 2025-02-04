// To show creativity for this project, a claas library was added at line 38 to have the program work with a library of scriptures rather than a single one.

using System;


class Program
{
    static void Main(string[] args)
    {
        ScriptureLibrary scriptureLibrary = new ScriptureLibrary();
        Random random = new Random();
        
        while (true)
        {
            Scripture scripture = scriptureLibrary.GetRandomScripture(random);
            
            while (!scripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit.");
                string input = Console.ReadLine();
                
                if (input.ToLower() == "quit")
                {
                    Console.WriteLine("The  program has ended. Goodbye!");
                    return;
                }
                scripture.HideRandomWords();
            }
            // Display the final fully hidden scripture before ending
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("All words are hidden. Program ended.");

        }
    }
}   
class ScriptureLibrary
{
    private List<Scripture> scriptures = new List<Scripture>
    {
        new Scripture(new Reference("Psalm",40,1-3), "I waited patiently for the LORD; he inclined to me and heard my cry. He drew me up from the pit of destruction, out of the miry bog, and set my feet upon a rock, making my steps secure. He put a new song in my mouth, a song of praise to our God. Many will see and fear, and put their trust in the LORD."),
        new Scripture(new Reference("Psalm",61, 1-3), "Hear my cry, O God, listen to my prayer; from the end of the earth I call to you when my heart is faint. Lead me to the rock that is higher than I, for you have been my refuge, a strong tower against the enemy."),
        new Scripture(new Reference("Jeremiah", 17, 7-8), "Blessed is the man who trusts in the LORD, whose trust is the LORD. He is like a tree planted by water, that sends out its roots by the stream, and does not fear when heat comes, for its leaves remain green, and is not anxious in the year of drought, for it does not cease to bear fruit."),
        new Scripture(new Reference("John",14 ,27),"Peace I leave with you; my peace I give to you. Not as the world gives do I give to you. Let not your hearts be troubled, neither let them be afraid."),
    };
    
    public Scripture GetRandomScripture(Random random)
    {
        int index = random.Next(scriptures.Count);
        return new Scripture(scriptures[index]); // Return a copy to prevent modifications to the library
    }
}

class Scripture
{
    private Reference reference;
    private List<Word> words;
    private Random random = new Random();

    public Scripture(Reference reference, string text)
    {
        this.reference = reference;
        words = text.Split(' ').Select(word => new Word(word)).ToList();
    }
    
    public Scripture(Scripture scripture)
    {
        this.reference = scripture.reference;
        this.words = scripture.words.Select(w => new Word(w.Text)).ToList();
    }

    public void HideRandomWords()
    {
        int wordsToHide = random.Next(1, 3);
        List<Word> visibleWords = words.Where(w => !w.IsHidden).ToList();
        
        if (visibleWords.Count > 0)
        {
            for (int i = 0; i < wordsToHide && visibleWords.Count > 0; i++)
            {
                int index = random.Next(visibleWords.Count);
                visibleWords[index].Hide();
                visibleWords.RemoveAt(index);
            }
        }
    }
    
    public bool IsCompletelyHidden()
    {
        return words.All(w => w.IsHidden);
    }
    
    public string GetDisplayText()
    {
        return $"{reference.GetDisplayText()} - " + string.Join(" ", words.Select(w => w.GetDisplayText()));
    }
}

class Reference
{
    private string book;
    private int chapter;
    private int startVerse;
    private int? endVerse;
    
    public Reference(string book, int chapter, int startVerse, int? endVerse = null)
    {
        this.book = book;
        this.chapter = chapter;
        this.startVerse = startVerse;
        this.endVerse = endVerse;
    }
    
    
    public string GetDisplayText()
    {
        return endVerse == null ? $"{book} {chapter}:{startVerse}-{endVerse}" : $"{book} {chapter}:{startVerse}";
    }
}

class Word
{
    public string Text { get; private set; }
    public bool IsHidden { get; private set; }
    
    public Word(string text)
    {
        Text = text;
        IsHidden = false;
    }
    
    public void Hide()
    {
        IsHidden = true;
    }
    
    public string GetDisplayText()
    {
        return IsHidden ? new string('_', Text.Length) : Text;
    }
}
