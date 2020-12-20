using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Lab2 {
    struct DataItem {
        public Vector2 Coord { get; set; }
        public Complex EM_field { get; set; }

        public DataItem(Vector2 x, Complex y) {
            Coord = x;
            EM_field = y;
        }

        public override string ToString() {
            return $"Coord = ({Coord.X}, {Coord.Y})\nEM_field = {EM_field}\n";
        }

        public string ToString(string format) {
            return $"Coord = {Coord.ToString(format)}\nEM_field = {EM_field.ToString(format)}\n" +
                   $"Abs of EM_field = {EM_field.Magnitude.ToString(format)}\n";
        }

    }
}
