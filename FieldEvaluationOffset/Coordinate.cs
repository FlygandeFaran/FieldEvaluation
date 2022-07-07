using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldEvaluationOffset
{
    public class Coordinate
    {
        private string _sign;
        private Plane _dir;
        private double _Offset;

        public Plane Dir
        {
            get { return _dir; }
            set { _dir = value; }
        }
        public string Sign
        {
            get { return _sign; }
            set { _sign = value; }
        }
        public double Offset
        {
            get { return _Offset; }
            set { _Offset = value; }
        }

    }
}
