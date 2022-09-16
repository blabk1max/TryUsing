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


try --->  using
tryを外側にusingを内側にすると、usingでリソースが解放されてから例外を受け取る。

Create Tracer
Dispose Tracer
Exception : Attempted to divide by zero.

using ---> try
usingを外側にtryを内側にすると、例外を受け取ってからusingでリソースが解放される。

Create Tracer
Exception : Attempted to divide by zero.
Dispose Tracer

*/
