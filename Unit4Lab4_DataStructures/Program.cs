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

    Console.Write($"Your word/phrase reversed in full is ");
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.Write(ReverseFullInput(userEntry));
    Console.ResetColor();
    Console.WriteLine();
    Console.WriteLine();

    Console.Write($"Your word/phrase reversed by word without using a Stack is ");
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.Write(ReverseEachWordWithoutAStack(userEntry));
    Console.ResetColor();
    Console.WriteLine();
    Console.WriteLine();

    Console.Write($"Your word/phrase reversed by word using a Stack is ");
    Console.ForegroundColor = ConsoleColor.DarkRed;
    ReverseWordUsingAStack(userEntry);
    Console.ResetColor();

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

static string ReverseEachWordWithoutAStack(string userEntry)
{
    StringBuilder reverseString = new StringBuilder();
    List<char> characterList = new List<char>();
    for (int i = 0; i < userEntry.Length; i++)
    {
        if (userEntry[i] == ' ' || i == userEntry.Length - 1)
        {
            if (i == userEntry.Length - 1)
            {
                characterList.Add(userEntry[i]);
            }
            for (int j = characterList.Count - 1; j >= 0; j--)
            {
                reverseString.Append(characterList[j]);
            }
            reverseString.Append(' ');
            characterList = new List<char>();
        }
        else
        {
            characterList.Add(userEntry[i]);
        }
    }
    return reverseString.ToString();
}
static void ReverseWordUsingAStack(string userEntry)
{
    Stack<char> charStack = new Stack<char>();
    // Traverse the given string and push all characters
    // to stack until we see a space.  
    for (int i = 0; i < userEntry.Length; ++i)
    {
        if (userEntry[i] != ' ')
        {
            charStack.Push(userEntry[i]);
        }
        // When seeing a space, then print contents of the stack.  
        else
        {
            while (charStack.Count > 0)
            {
                Console.Write(charStack.Pop());
            }
            Console.Write(" ");
        }
    }
    // Since there may not be space after last word.  
    while (charStack.Count > 0)
    {
        Console.Write(charStack.Pop());
    }
}