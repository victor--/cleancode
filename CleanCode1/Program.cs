
using System;

namespace CleanCode1 {
	class Program {
		static void Main(string[] args) {
			int[] primes = GeneratePrimes.Generate(100);

			for (int i = 0; i < primes.Length; i++) {
				Console.WriteLine("Prime number with index " + i + ": " + primes[i]);
			}

			if (System.Diagnostics.Debugger.IsAttached) {
				Console.WriteLine("Press enter to close...");
				Console.ReadLine();
			}
		}
	}
}
