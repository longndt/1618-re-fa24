//index of first element in array is always 0
//index of last element in array is total elements subtract 1

//initialize an array
int[] numbers = new int[10]; //array size: 10, index: 0-9
string[] words = new string[5]; //array size: 5, index: 0-4
//assign values for elements in array
numbers[9] = 7; //index = 10, value = 7; last element 
numbers[0] = 10; //index = 0, value = 10; first element
numbers[1] = 9;  //index = 1, value = 9; second element
//numbers[20] = 100; //runtime exception: index was out of bound
words[0] =  "Ha Noi";
words[1] = "HCM City";
words[2] = "Da Nang";
words[3] = "Can Tho";
words[4] = "Viet Nam";
//display specific element
Console.WriteLine(numbers[9]);
//Console.WriteLine(numbers[20]); //error

//display all elements of an array
for (int i = 0; i < words.Length; i++)
{
    Console.WriteLine(words[i]);
}
