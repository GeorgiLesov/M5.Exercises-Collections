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
            var nums = new Collection<int>(5);
            Assert.That(nums[0], Is.EqualTo(5));
        }
    }
}