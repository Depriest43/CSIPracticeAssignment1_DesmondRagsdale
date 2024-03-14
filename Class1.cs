using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace CSIPracticeAssignment1_DesmondRagsdale
{
    internal class Class1
    {
        //fields
        private string_make;
        private string_model;
            private int _year;
        private string _color;
        private string _mileage;

        //properties
        public string Make { get => _make; set => _make = value; }
        public string Model { get => _model; set => _model = value; }
        public int Year { get => _year; set => _year = value; }
        public string Color { get => _color; set => _color = value; }
        public int Mileage { get => _mileage; set => _mileage = value; }
    }
}
