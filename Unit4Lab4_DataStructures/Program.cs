using System.Text;

Console.WriteLine("Welcome to the Input Reversal Application!");
PauseAndClearScreen();

bool runningProgram = true;
while (runningProgram)
{
    Console.WriteLine("Enter a word or phrase, and I will write that word or phrase back to you in reverse order!");
    Console.Write("Enter your word or phrase: ");
    string userEntry = Console.ReadLine();
    Console.WriteLine();
    Console.WriteLine($"Your word/phrase reversed in full is {ReverseFullInput(userEntry)}");
    Console.WriteLine();
    Console.WriteLine($"Your word/phrase reversed by word is {ReverseEachWord(userEntry)}");
    PauseAndClearScreen();

    runningProgram = false;
}
Console.WriteLine("Thank you for using the Input Reversal Application!");
Console.WriteLine("Goodbye...");

static void PauseAndClearScreen()
{
    Console.WriteLine();
    Console.WriteLine("Press Enter to Continue.");
    Console.ReadLine();
    Console.Clear();
}

static string ReverseFullInput(string userEntry)
{
    char[] letters = userEntry.ToCharArray();
    Array.Reverse(letters);
    return new string(letters);
}

static string ReverseEachWord(string userEntry)
{
    StringBuilder reverseWordString = new StringBuilder();
    List<char> charlist = new List<char>();
    for (int i = 0; i < userEntry.Length; i++)
    {
        if (userEntry[i] == ' ' || i == userEntry.Length - 1)
        {
            if (i == userEntry.Length - 1)
            {
                charlist.Add(userEntry[i]);
            }
            for (int j = charlist.Count - 1; j >= 0; j--)
            {
                reverseWordString.Append(charlist[j]);
            }
            reverseWordString.Append(' ');
            charlist = new List<char>();
        }
        else
        {
            charlist.Add(userEntry[i]);
        }
    }
    return reverseWordString.ToString();
}