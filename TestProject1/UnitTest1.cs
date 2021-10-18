using NUnit.Framework;

namespace FormsAndUnitTesting
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            Familia familiaTest = new Familia(1, "Test", "Test", "Test", 5, "Test", 15);
            Main.familias.Add(familiaTest);
        }

        [Test]
        public void EnviarAyudaCasoBueno()
        {
            Assert.IsTrue(Main.entregarAyudas(1, 100));
        }

        [Test]
        public void EnviarAyudaNoEncontrado()
        {
            Assert.IsFalse(Main.entregarAyudas(979999999, 100));
        }

        [Test]
        public void EnvairAyudaDineroInvalido()
        {
            Assert.IsFalse(Main.entregarAyudas(1, -45));
        }
    }
}