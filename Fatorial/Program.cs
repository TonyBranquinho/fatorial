using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fatorial {
    class Program {
        static void Main(string[] args) {

            int n, i, fatorial;

            Console.Write("Digite o valor de N: ");
            n = int.Parse(Console.ReadLine());
            
            fatorial = 1;
            for (i = 1; i <= n; i++) {
                fatorial = fatorial * i;
            }

            Console.WriteLine("Fatorial = " + fatorial);
        }
    }
}
