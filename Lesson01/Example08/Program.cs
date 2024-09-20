int a = 10;
//a++ : post-fix operator
int b = a++; //b=a=10; a++=a+1=10+1=11
//++a : pre-fix operator
int c = ++a; //++a=a+1=11+1=12; c=a=12

Console.WriteLine("a = " + a);  //12
Console.WriteLine("b = " + b);  //10
Console.WriteLine("c = " + c);  //12