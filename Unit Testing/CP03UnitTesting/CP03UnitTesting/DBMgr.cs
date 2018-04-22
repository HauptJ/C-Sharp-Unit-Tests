using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP03UnitTesting
{
    class DBMgr
    {
        public bool penExists(string penID)
        {
            return true;
        }

        public bool addPen(Pen newPen)
        {
            return true;
        }

        public Pen editPen(string penID)
        {
            Pen member = new Pen("TestName", "123");
            return member;
        }

        public bool updatePen(Pen newPen)
        {
            return true;
        }

        public Pen searchPen(string penID)
        {
            Pen member = null;
            return member;
        }
    }
}
