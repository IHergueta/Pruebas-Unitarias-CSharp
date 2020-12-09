using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PruebasUnitarias;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            IPersona per = (IPersona)new Persona("Juan", "Palomares", 65);

            string nombre = per.getNombre();

            Assert.AreEqual("Juan", nombre);
        }

        [TestMethod]
        public void TestMethod2()
        {

            IPersona per = (IPersona)new Persona("Juan", "Palomares", 65);

            string ape = per.getApellido();

            Assert.AreEqual("Palomares", ape);
        }

        [TestMethod]
        public void TestMethod3()
        {

            IPersona per = (IPersona)new Persona("Juan", "Palomares", 65);

            int edad = per.getEdad();

            Assert.AreEqual(65, edad);
        }

        

        [TestMethod]
        public void TestMethod5()
        {

            IPersona per = (IPersona)new Persona("Juan", "Palomares", 65);

            per.setNombre("Fernando");

            Assert.AreEqual("Fernando",per.getNombre());
        }
    }
}
