﻿//Math >= 90; Biology >=90; Chemistry >=90;

int math, biology, chemistry;
Console.WriteLine("Enter Your Math result:");
math = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter Your Biology result:");
biology = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter Your Chemistry result:");
chemistry = Int32.Parse(Console.ReadLine());    


if(math >= 90 && biology >= 90 && chemistry >= 90)
{
    Console.WriteLine("Congartulations! You got accpeted.");
}
else
{
    Console.WriteLine("Your application cannot be approved.");
}
