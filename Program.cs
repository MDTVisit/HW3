// See https://aka.ms/new-console-template for more information
class Program
{
static void Main (string[] args)
{
       Queue<char> fruit = new Queue<char>();
       
       while (true) {
       char f = char.Parse(Console.ReadLine());
     if (f == 'L') {fruit.Push('1');}
     if (f == 'M') {fruit.Push('2');}
     if (f == 'S') {fruit.Push('3');}

      Console.Write(fruit.GetLength());
break;
       }

while(fruit.GetLength()!=0)
{
char f = fruit.Pop();
Console.Write(f);
if (f == '1' ) {fruit.Push('2');fruit.Push('2');}
else if (f == '2' ) {fruit.Push('3');fruit.Push('3');fruit.Push('3');}
}             
}
}