using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DojoBattleships.Lib;
using NUnit.Framework;

namespace DojoBattleships.Tests
{
    public class board_layout_requirements
    {
        [Test]
        public void scenario_starting_the_game()
        {
            // given a board for the human player
            // ==================================
            var humanBoard = new Board();

            //and a board for the computer
            // ==================================
            var computerBoard = new Board();

            //when the game starts
            // ==================================
            var game = new Game(humanBoard, computerBoard);
            game.Start();

            //then the boards will be "randomly setup"
            // ==================================
            Assert.That(game.HumanBoard.IsValid());
            Assert.That(game.ComputerBoard.IsValid());

        }
    }

    public static class BoardValidator
    {
        public static bool IsValid(this Board b)
        {
            // Q: will the code below cause multiple enumerations of the ship list? 
            if (!ConfirmAllShipsPresent(b.Ships)) return false;
            foreach (Ship ship in b.Ships)
            {
                if (!ship.IsFullyOnTheBoard) return false;
                if (!ship.IsNotOverlappingAnyOtherShip(b.Ships)) return false;
            }
            return true;
        }

        private static bool ConfirmAllShipsPresent(IEnumerable<Ship> ships)
        {
            return false;
        }
    }
}
