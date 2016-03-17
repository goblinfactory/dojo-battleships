using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DojoBattleships.Lib;
using NUnit.Framework;

namespace DojoBattleships.Tests
{
    public class human_or_computer_moves
    {
  
/*        
  | hit?    | ship      | hits  | mark      | fatal?   | sunk?  | announcement               | wholefleet?   |game-resumes |
  |---------|-----------|-------|-----------|----------|--------|----------------------------|---------------|----------------|
  | yes     | Submarine | 0     | X         | fatal!   | sunk   | {player} sunk a Submarine! | no            | resumes        |
  | no      |           |       | -         |          |        |                            |               | resumes        |
  | yes     | Cruiser   | 0     | X         | no       | damaged| {player} hit a cruiser   ! | no            | resumes        |
  | yes     | Aircraft  | 4     | X         | fatal!   | sunk   | {player} sunk an Aircraft! Congratulations {player} wins! | yes | game-over |
        */

        [TestCase(true,ShipClass.Submarine, 0,'X',true,true,"{player} sunk a Submarine!",false, true)]
        [TestCase(false,ShipClass.NA, 0,'-',false,false,"",false, true)]
        [TestCase(true,ShipClass.Cruiser, 0,'X',false,false,"{player} hit a cruiser!",false, true)]
        [TestCase(true,ShipClass.Aircraft, 4,'X',true,true,"{player} sunk an Aircraft! Congratulations {player} wins!",true, false)]
        public void move_tests(bool hit, ShipClass @class, int hits, char mark, bool fatal, bool sunk, string announcement, bool wholefleet, bool resume)
        {
            Assert.Fail("not implemented");
        }
    }
}
