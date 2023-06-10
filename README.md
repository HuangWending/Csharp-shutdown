# Csharp-shutdown
C#关机程序
using System;：这一行是用来引入 System 命名空间，其中包含了许多常用的系统类和方法。

class Program：这是定义一个名为 Program 的类，它包含了程序的逻辑。

static void Main()：这是程序的入口点，所有的代码都在这里执行。static 表示该方法是静态方法，void 表示该方法不返回任何值。

Console.WriteLine("关机程序启动！");：这一行使用 Console.WriteLine 方法在控制台输出一条消息。

System.Diagnostics.Process.Start("shutdown", "/s /t 0");：这一行使用 Process.Start 方法启动一个新的进程，并执行指定的命令。在这里，我们使用 "shutdown" 命令来执行关机操作，"/s /t 0" 参数表示立即关机。通过启动一个新进程执行关机命令，可以保证程序能够立即退出而不会被关机命令阻塞。
