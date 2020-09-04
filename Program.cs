using System;
using System.Reflection;
using System.Runtime.Versioning;

namespace HelloWorldSample {
  public static class Program {
    public static void Main() {
      Console.WriteLine("Hello, World!");
      Console.WriteLine($"{Assembly.GetEntryAssembly()?.GetCustomAttribute<TargetFrameworkAttribute>()?.FrameworkName;}");
    }
  }
}