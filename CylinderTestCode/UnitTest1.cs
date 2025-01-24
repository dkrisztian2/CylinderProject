using CylinderProject.Models;

namespace CylinderTestCode
{
    public class UnitTest1
    {
        [Fact]
        public void HelyesenAllitjaBe()
        {
            var cyl = new Cylinder(5, 10);

            Assert.Equal(5, cyl.Radius);
            Assert.Equal(10, cyl.Height);
        }

        [Fact]
        public void LeheteNullaVagyNegativ()
        {
            Assert.Throws<ArgumentException>(() => new Cylinder(0, 10));
            Assert.Throws<ArgumentException>(() => new Cylinder(5, 0));

            Assert.Throws<ArgumentException>(() => new Cylinder(-5, 10));
            Assert.Throws<ArgumentException>(() => new Cylinder(5, -10));
        }

        [Fact]
        public void HelyesTerfogatFelszin()
        {
            var cyl = new Cylinder(5, 10);

            Assert.Equal(Math.Round(cyl.GetVolume()), Math.Round((cyl.Radius*cyl.Radius)*Math.PI*cyl.Height));
            Assert.Equal(Math.Round(cyl.GetSurfaceArea()), Math.Round(2 * (cyl.Radius * cyl.Radius) * Math.PI + 2 * cyl.Radius * Math.PI * cyl.Height));
        }

        [Fact]
        public void HelyesenMukodikaResize()
        {
            var cyl = new Cylinder(5, 10);

            cyl.Resize(6, 12);

            Assert.Equal(6, cyl.Radius);
            Assert.Equal(12, cyl.Height);

            Assert.Throws<ArgumentException>(() => cyl.Resize(0, 12));
            Assert.Throws<ArgumentException>(() => cyl.Resize(-6, 12));

            Assert.Throws<ArgumentException>(() => cyl.Resize(6, 0));
            Assert.Throws<ArgumentException>(() => cyl.Resize(6, -12));
        }

        [Fact]
        public void isNull()
        {
            Assert.NotNull(() => new Cylinder(5, 10));
        }

        [Fact]
        public void isInRange()
        {
            double min = 1, max = 100;
            var cyl = new Cylinder(5, 10);
            Assert.InRange(cyl.Radius, min, max);
        }

    }
}