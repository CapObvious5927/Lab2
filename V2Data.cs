using System;
using System.IO;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Threading.Tasks;

namespace Lab2 {
    abstract class V2Data : IEnumerable<DataItem> {
        public string Info { get; set; }
        public double EM_freq { get; set; }

        public V2Data(string x, double y) {
            Info = x;
            EM_freq = y;
        }

        public abstract IEnumerator<DataItem> GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() {
            return GetEnumerator();
        }

        public abstract Complex[] NearAverage(float eps);
        public abstract string ToLongString();

        public override string ToString() {
            return $"Info\nElectromagnetic field frequency = {EM_freq}\n";
        }

        public abstract string ToLongString(string format);
    }
}
