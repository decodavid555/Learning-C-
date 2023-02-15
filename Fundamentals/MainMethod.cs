//This is the entry point of any C# application. When the application is started, the Main method is the first method that is invoked.

// class TestClass{
//     static void Main(string[] args)
//     {
//         //Display the number of command line arguments.
//         Console.WriteLine(args.Length);
//     }
// }


//Starting in C# 9, you can omit the Main method, and write C# statements as if they were in the Main method

using System.Text; 
StringBuilder builder =new();
builder.AppendLine("Hello");
builder.AppendLine("World");

Console.WriteLine(builder.ToString());

