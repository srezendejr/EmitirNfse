using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using EmitirNfse.Modelos;

namespace EmitirNfse.Test
{
    
    
    /// <summary>
    ///This is a test class for ComunsTest and is intended
    ///to contain all ComunsTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ComunsTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for CalculaValores
        ///</summary>
        [TestMethod()]
        public void CalculaValoresTest()
        {
            string Cnpj = string.Empty; // TODO: Initialize to an appropriate value
            Decimal ValorServico = new Decimal(); // TODO: Initialize to an appropriate value
            Decimal OutrasDeducoes = new Decimal(); // TODO: Initialize to an appropriate value
            Decimal DescontoIncondicionado = new Decimal(); // TODO: Initialize to an appropriate value
            Decimal DescontoCondicionado = new Decimal(); // TODO: Initialize to an appropriate value
            bool IssRetido = false; // TODO: Initialize to an appropriate value
            Valores expected = null; // TODO: Initialize to an appropriate value
            Valores actual;
            actual = Comuns.Comuns.CalculaValores(Cnpj, ValorServico, OutrasDeducoes, DescontoIncondicionado, DescontoCondicionado, IssRetido);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
