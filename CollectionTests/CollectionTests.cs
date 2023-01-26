using Collections;

namespace CollectionTests
{
    public class CollectionTests
    {
        [Test]
        public void Test_Collection_EmptyConstructor()
        {
            // Arrange
            var nums = new Collection<int>();

            // Assert
            Assert.That(nums.ToString(), Is.EqualTo("[]"));
        }
        
        [Test]
        public void Test_Collection_ConstructorSingleItem()
        {
            var nums = new Collection<int>(6);
            Assert.That(nums[0], Is.EqualTo(6));
        }

        [Test]
        public void Test_Collection_GetByIndex()
        {
            // Arrange
            var strings = new Collection<int>(1,2,3,4,5,6,7);

            Console.WriteLine(strings[2].ToString());

            // Assert
            Assert.That(strings[3].ToString, Is.EqualTo("4"));
        }
    }
}