using System;

namespace TrfyUsing {
  public class Tracer : IDisposable {
    public Tracer() {
      Console.WriteLine("Create Tracer");
    }

    public void Dispose() {
      Console.WriteLine("Dispose Tracer");
    }
  }
}