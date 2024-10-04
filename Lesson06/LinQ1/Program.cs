/*
 * Problem: Enter list of words (separated by space)
 * then display words which length (total characters) is divisible by 2
 */

//input
Console.Write("Enter list of words (separated by space): ");
string[] words = Console.ReadLine()
.Split()
.Where(w => w.Length % 2 == 0)
.ToArray();

//output
foreach (string word in words)
    Console.WriteLine(word);