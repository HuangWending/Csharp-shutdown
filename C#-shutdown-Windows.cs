using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("关机程序启动！");
        System.Diagnostics.Process.Start("shutdown", "/s /t 0");
    }
}
