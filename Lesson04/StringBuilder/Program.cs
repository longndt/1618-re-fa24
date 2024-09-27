using System.Text;

//declare StringBuilder
StringBuilder sports = new StringBuilder();

//add string to StringBuilder using Append
sports.Append("Football");
sports.Append("Badminton");
sports.Append("Golf");
sports.Append("Pickleball");

//display value
Console.WriteLine(sports);

//set max length (max characters)
sports.Capacity = 30; 

//display length (total characters)
Console.WriteLine(sports.Length);

//sports.Append("Running");   //Error: out of capacity

//Remove: clear content in range
//Clear: clear all content in string
//Insert: insert content in specific index (position)
//Replace: replace old value with new value
 

