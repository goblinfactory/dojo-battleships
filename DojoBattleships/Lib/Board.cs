using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DojoBattleships.Lib
{
    public class Board
    {
        public IEnumerable<Ship> Ships
        {
            get { return new Ship[0]; }
        }
    }
}
