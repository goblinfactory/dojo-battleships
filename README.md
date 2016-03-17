# dojo-battleships

Battleships starter projects with a few failing unit tests - for use in an Object Calisthenics coding Dojo.
I've made the failing test deliberately easy to pass because this exercise is not about passing the tests, but ENTIRELY about refactoring the final working code applying the <a href="http://williamdurand.fr/2013/06/03/object-calisthenics"> 9 rules of object calithenics.</a>

- Only One Level Of Indentation Per Method
- Don’t Use The ELSE Keyword
- Wrap All Primitives And Strings
- First Class Collections
- One Dot Per Line
- Don’t Abbreviate
- Keep All Entities Small
- No Classes With More Than Two Instance Variables
- No Getters or Setters or Properties

This is tougher than it looks! ;-D 


**Board arrangement**

- each ship occupies a number of squares, also shown is the quantity of ships 
  - 1 x Aircraft [5]
  - 1 x Battleship [4]
  - 1 x cruiser [3]
  - 2 x Destroyer [2]
  - 2 x Submarine [1]
- ships cannot overlap

<a href="https://upload.wikimedia.org/wikipedia/commons/thumb/e/e4/Battleships_Paper_Game.svg/595px-Battleships_Paper_Game.svg.png">sample board layout</a>


**Playing the game**
- the game proceeds in a series of rounds. 
- In each round, each player takes a turn to announce ( enter the grid coordinate of his shot, into a text prompt) a target square in the opponent's grid which is to be shot at. 
- The computer announces whether or not the square is occupied by a ship, and if it is a "miss", the computer marks their primary grid with a dash '-'; if a "hit" they mark this on their own primary grid with a cross 'X'. 

When all of the squares of a ship have been hit, the ship is sunk, and the computer prints at the bottom of the screen ( "You sank my "battleship!"  {SHIP}). If all of a player's ships have been sunk, the game is over and their opponent wins.

Dojo attendees can choose details, how and where to display the 'announcements' of ships being sunk, and any other missing detail.

**Game end - Winning**
-  First human or computer to sink all of his or her or IT's opponents ships ends the game and a "YOU WON" or "I WON" is displayed, together with a message, "Do you want to play again?"

Not too much detail in the requirements; Enough description to show what to do. 

**Objective is not to complete the project, but to practice the 9 object calisthenics rules.**

# Unit tests

The following failing unit tests are in the solution;

###`board_layout_requirements.cs`

```
   given a board for the human player
   and a board for the computer
   when the game starts
   then the boards will be "randomly setup"

```

###`human_or_computer_moves.cs`

```
scenario: player makes a move
    * a game in progress
    * it is the players turn
    * player enters coordinates that <hit> a <ship> with <hits> existing hits 
    * the shot is marked with an <mark> on the board
    * shot was <fatal?>
    * ship is marked as <sunk?>
    * <announcement> is announced
    * shot has sunk <wholefleet?> fleet
    * game <ends?>

Examples:
  | hit?    | ship      | hits  | mark      | fatal?   | sunk?  | announcement               | wholefleet?   |ends-or-resumes |
  |---------|-----------|-------|-----------|----------|--------|----------------------------|---------------|----------------|
  | yes     | Submarine | 0     | X         | fatal!   | sunk   | {player} sunk a Submarine! | no            | resumes        |
  | no      |           |       | -         |          |        |                            |               | resumes        |
  | yes     | Cruiser   | 0     | X         | no       | damaged| {player} hit a cruiser   ! | no            | resumes        |
  | yes     | Aircraft  | 4     | X         | fatal!   | sunk   | {player} sunk an Aircraft! Congratulations {player} wins! | yes | game-over |

    Attendees to add in as many examples as are needed to give their code suitable coverage. One example at least of all the edge cases,
    and not all of the combinations are necessary. This is "Specification by example." 
    Each "example" demonstrates how each change affects the desired system behavior.
