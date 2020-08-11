using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VacuumCleanerWorld
{
    class Square
    {
        private bool dirty;
        private int number;

        public Square()
        {
            dirty = true;
            number = 0;
        }
        public Square(bool dirt, int name)
        {
            dirty = dirt;
            number = name;
        }

        public bool Dirty
        {
            get
            {
                return dirty;
            }
            set
            {
                dirty = value;
            }
        }

        public int Number
        {
            get
            {
                return number;
            }
            set
            {
                number = value;
            }
        }
    }
}
