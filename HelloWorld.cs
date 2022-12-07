using System; // Imports the System namespace and its types into the scope

// Namespace (package/module which serves as a container for types and other namespacs. Used to organize and structure code. Prevents naming conflicts.
namespace HelloWorld {

    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello World!");
        }
    }
}

// This file needs to be given write permissions, compiled and run
// 0) chmod +x HelloWorld.cs
// 1) mcs HelloWorld.cs
// 2) mono HelloWorld.exe