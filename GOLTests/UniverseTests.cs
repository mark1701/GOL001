using NUnit.Framework;
using GOL;

namespace GOLTests
{
    [TestFixture]
    class UniverseTests
    {
        [Test]
        public void An_empty_universe_is_empty() {

            var emptyUniverse = Universe.GetEmptyUniverse();

            Assert.IsTrue(emptyUniverse.IsEmpty());
        }

        [Test]
        public void Adding_a_cell_to_an_empty_universe_makes_the_universe_no_longer_empty()
        {
            /*
             logical concepts: cell, universe, emptiness
             operations: adding a cell, checking if the universe is empty
             */

            var emptyUniverse = Universe.GetEmptyUniverse();

            //where am I adding the cell? -> concept of coordinates or location
            //what is a cell? -> a new entity
            //what type of cell? -> specializations and 1 abstraction? go poly?
            //conflicts with existing cells? who is in charge of checking those conflicts?
            //why adding? we could assume that cells are already there and we are turning them on and off (life and death)
            emptyUniverse.AddCell(new object());

            Assert.IsFalse(emptyUniverse.IsEmpty());
        }

        [Test]
        public void An_empty_universe_remains_empty() {


        }
    }
}
