//get text from keyboard
Console.Write("Enter text: ");
string text = Console.ReadLine();

//split text as words by spaces
string[] words = text.Split();
string result = "";

//run foreach loop to display words
foreach (string word in words)
{
    int repeatTimes = word.Length;
    //total loop is equal to word length
    for (int i = 0; i < repeatTimes; i++)
        result += word;
}
Console.WriteLine(result);