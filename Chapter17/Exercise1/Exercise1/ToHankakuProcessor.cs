using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1 {
    class ToHankakuProcessor : Class1 {
        private int _count;

        protected override void Initialize(string fname) {
            _count = 0;
        }

        protected override void Execute(string line) {
            _count++;
        }

        protected override void Terminate() {
            Console.WriteLine("{0} 行", _count);
        }
    }
}
