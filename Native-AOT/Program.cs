// See https://aka.ms/new-console-template for more information

while (!System.Diagnostics.Debugger.IsAttached)
{
    Thread.Sleep(500);
}
System.Diagnostics.Debugger.Break();

Console.WriteLine("Hello, World!");
