//Math >= 90; Biology>=90; Chemistry >=90;

int math, biology, chemestry;

Console.WriteLine("Enter your Math result:");
math = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your Biology result:");
biology= Int32.Parse(Console.ReadLine());

Console.WriteLine("Enteryour Chemestry result:");
chemestry= Int32.Parse(Console.ReadLine()); 


if(math >= 90 && biology >= 90 && chemestry >= 90)
{
    Console.WriteLine("Congratulations! You got accepted!");
}
else
{
    Console.WriteLine("Your application cannot be approved.");
}
