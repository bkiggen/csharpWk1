using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes.Models;

namespace Shapes.Tests
{
    [TestClass]
    public class CubeTests
    {
        [TestMethod]
        public void Cube_GetVolume_VolumeOfCube()
        {
            Rectangle newRectangle = new Rectangle(4, 4);
            Cube newCube = new Cube(newRectangle);
            int result = newCube.GetVolume();
            Assert.AreEqual(result, 64);
        }
        public void Cube_GetSurfaceArea_SurfaceAreaOfCube()
        {
            Rectangle newRectangle = new Rectangle(4, 4);
            Cube newCube = new Cube(newRectangle);
            int result = newCube.GetSufaceArea();
            Assert.AreEqual(result, 96);
        }
    }
}