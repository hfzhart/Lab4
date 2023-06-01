using System.Xml.Serialization;
using Vector3D;

namespace Vector3DTests
{
    [TestClass]
    public class Vector3DTests
    {
        [TestMethod]
        public void Length_DefaultVector_ReturnsZero()
        {
            
            var vector = new Vector3D.Vector3D();

            
            var length = vector.Length();

            
            Assert.AreEqual(0, length);
        }

        [TestMethod]
        public void Length_VectorWithPositiveValues_ReturnsCorrectLength()
        {
           
            var vector = new Vector3D.Vector3D(3, 4, 12);

           
            var length = vector.Length();

          
            Assert.AreEqual(13, length);
        }

        [TestMethod]
        public void Distance_TwoEqualVectors_ReturnsZero()
        {
            
            var vector1 = new Vector3D.Vector3D(2, 3, 4);
            var vector2 = new Vector3D.Vector3D(2, 3, 4);

            var distance = Vector3D.Vector3D.Distance(vector1, vector2);

            Assert.AreEqual(0, distance);
        }

        [TestMethod]
        public void Distance_TwoDifferentVectors_ReturnsCorrectDistance()
        {
           
            var vector1 = new Vector3D.Vector3D(1, 2, 3);
            var vector2 = new Vector3D.Vector3D(4, 5, 6);

            var distance = Vector3D.Vector3D.Distance(vector1, vector2);

            Assert.AreEqual(5.196152, distance, 0.000001);
        }

        [TestMethod]
        public void Add_TwoVectors_ReturnsCorrectResult()
        {
            var vector1 = new Vector3D.Vector3D(2, 3, 4);
            var vector2 = new Vector3D.Vector3D(1, 2, 3);

            var result = vector1 + vector2;

            Assert.AreEqual(new Vector3D.Vector3D(3, 5, 7), result);
        }

        [TestMethod]
        public void Subtract_TwoVectors_ReturnsCorrectResult()
        {
            var vector1 = new Vector3D.Vector3D(2, 3, 4);
            var vector2 = new Vector3D.Vector3D(1, 2, 3);

            var result = vector1 - vector2;

            Assert.AreEqual(new Vector3D.Vector3D(1, 1, 1), result);
        }

        [TestMethod]
        public void ParallelCheck_ParallelVectors_ReturnsTrue()
        {
            var vector1 = new Vector3D.Vector3D(2, 4, 6);
            var vector2 = new Vector3D.Vector3D(4, 8, 12);

            var result = vector1 | vector2;

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ParallelCheck_NonParallelVectors_ReturnsFalse()
        {
            var vector1 = new Vector3D.Vector3D(2, 3, 4);
            var vector2 = new Vector3D.Vector3D(1, 2, 3);

            var result = vector1 | vector2;

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ScalarProduct_TwoVectors_ReturnsCorrectResult()
        {
            var vector1 = new Vector3D.Vector3D(2, 3, 4);
            var vector2 = new Vector3D.Vector3D(1, 2, 3);

            var result = vector1 * vector2;

            
            Assert.AreEqual(20, result);
        }

        [TestMethod]
        public void CrossProduct_TwoVectors_ReturnsCorrectResult()
        {
            
            var vector1 = new Vector3D.Vector3D(1, 0, 0);
            var vector2 = new Vector3D.Vector3D(0, 1, 0);

            var result = vector1 ^ vector2;

            
            Assert.AreEqual(new Vector3D.Vector3D(0, 0, 1), result);
        }

     
    }
}
