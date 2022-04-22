using System.Runtime.InteropServices;

Console.WriteLine("Hello, World!");
var x = call_rust_fn();
Console.WriteLine("Modern Humanity emerged {0} years ago.", x);

[DllImport("lib.dll")]
static extern UInt32 call_rust_fn();