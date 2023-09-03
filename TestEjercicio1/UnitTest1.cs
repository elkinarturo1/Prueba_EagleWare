using Ejercicio_1;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using NUnit.Framework;

namespace TestEjercicio1
{
    public class Tests
    {

        private BubbleSortCollectionSorter programa1 = new BubbleSortCollectionSorter();
 
       
        [Test]
        public void SortAscending()
        {            
            var numbers = new int[5] { 5, 2, 3, 6, 8 };
            var resultExpected = new string[5] { "2", "3", "5", "6", "8" };
            var result = programa1.SortAscending(numbers);
            Assert.AreEqual(resultExpected, result);
                    
        }

        [Test]
        public void SortAscendingNotNull()
        {
            var numbers = new int[5] { 5, 2, 3, 6, 8 };
            var resultExpected = new string[5] { "2", "3", "5", "6", "8" };
            var result = programa1.SortAscending(numbers);            
            Assert.IsNotNull(result);            
        }


        [Test]
        public void SortDescending()
        {
            var numbers = new int[5] { 5, 2, 3, 6, 8 };
            var resultExpected = new string[5] { "8", "6", "5", "3", "2" };
            var result = programa1.SortDescending(numbers);
            Assert.AreEqual(resultExpected, result);                  
        }


        [Test]
        public void SortDescendingNotNull()
        {
            var numbers = new int[5] { 5, 2, 3, 6, 8 };
            var resultExpected = new string[5] { "8", "6", "5", "3", "2" };
            var result = programa1.SortDescending(numbers);
            Assert.IsNotNull(result);
        }

    }
}