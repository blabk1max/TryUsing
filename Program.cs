using System;

namespace TrfyUsing {
  internal class Program {
    static void Main(string[] args) {

      Console.WriteLine("try --->  using");
      try {
        using(var tracer = new Tracer()) {
          int y = 5;
          int x = 0;

          int a = y / x;

        }
      } catch (Exception ex) {
        Console.WriteLine($"Exception : {ex.Message}");
      }

      Console.WriteLine("using ---> try");
      using(var tracer = new Tracer()) {
        try {
          int y = 5;
          int x = 0;

          int a = y / x;

        } catch (Exception ex) {
          Console.WriteLine($"Exception : {ex.Message}");
        }
      }

    }
  }
}


/*

usingステートメントに対して、try~catchを使う場合、usingの外側に記述する。
これにより、try~catchの処理を待たずにDisposeを行うことができるため、最速でリソースを解放することができる。

try --->  using
Create Tracer
Dispose Tracer
Exception : Attempted to divide by zero.

using ---> try
Create Tracer
Exception : Attempted to divide by zero.
Dispose Tracer

*/
