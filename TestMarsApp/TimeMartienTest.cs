using MarsApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestMarsApp
{
    
    
    /// <summary>
    ///Classe de test pour TimeMartienTest, destinée à contenir tous
    ///les tests unitaires TimeMartienTest
    ///</summary>
    [TestClass()]
    public class TimeMartienTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Obtient ou définit le contexte de test qui fournit
        ///des informations sur la série de tests active ainsi que ses fonctionnalités.
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

        #region Attributs de tests supplémentaires
        // 
        //Vous pouvez utiliser les attributs supplémentaires suivants lorsque vous écrivez vos tests :
        //
        //Utilisez ClassInitialize pour exécuter du code avant d'exécuter le premier test dans la classe
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Utilisez ClassCleanup pour exécuter du code après que tous les tests ont été exécutés dans une classe
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Utilisez TestInitialize pour exécuter du code avant d'exécuter chaque test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Utilisez TestCleanup pour exécuter du code après que chaque test a été exécuté
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///Test pour op_Addition
        ///</summary>
        [TestMethod()]
        public void op_AdditionTest()
        {
            TimeMartien t1 = new TimeMartien(0, 10, 20, 30);
            TimeMartien t2 = new TimeMartien(1, 20, 30, 40);
            TimeMartien result = new TimeMartien(2, 6, 11, 10);
            TimeMartien somme = t1 + t2;

            Assert.IsTrue(somme == result);
        }

        /// <summary>
        ///Test pour op_Equality
        ///</summary>
        [TestMethod()]
        public void op_EqualityTest()
        {
            // TODO
        }

        /// <summary>
        ///Test pour op_GreaterThan
        ///</summary>
        [TestMethod()]
        public void op_GreaterThanTest()
        {
            // TODO
        }

        /// <summary>
        ///Test pour op_GreaterThanOrEqual
        ///</summary>
        [TestMethod()]
        public void op_GreaterThanOrEqualTest()
        {
            // TODO
        }

        /// <summary>
        ///Test pour op_Inequality
        ///</summary>
        [TestMethod()]
        public void op_InequalityTest()
        {
            // TODO
        }

        /// <summary>
        ///Test pour op_LessThan
        ///</summary>
        [TestMethod()]
        public void op_LessThanTest()
        {
            // TODO
        }

        /// <summary>
        ///Test pour op_LessThanOrEqual
        ///</summary>
        [TestMethod()]
        public void op_LessThanOrEqualTest()
        {
            // TODO
        }

        /// <summary>
        ///Test pour op_Subtraction
        ///</summary>
        [TestMethod()]
        public void op_SubtractionTest()
        {
            // TODO
        }

        /// <summary>
        ///Test pour retirerTemps
        ///</summary>
        [TestMethod()]
        public void retirerTempsTest()
        {
            // TODO
        }

        /// <summary>
        ///Test pour retirerTemps
        ///</summary>
        [TestMethod()]
        public void retirerTempsTest1()
        {
            // TODO
        }

        /// <summary>
        ///Test pour sePasseDansPeriode
        ///</summary>
        [TestMethod()]
        public void sePasseDansPeriodeTest()
        {
            // TODO
        }

        /// <summary>
        ///Test pour Equals
        ///</summary>
        [TestMethod()]
        public void EqualsTest()
        {
            // TODO
        }

        /// <summary>
        ///Test pour ajouterTemps
        ///</summary>
        [TestMethod()]
        public void ajouterTempsTest()
        {
            // TODO
        }

        /// <summary>
        ///Test pour ajouterTemps
        ///</summary>
        [TestMethod()]
        public void ajouterTempsTest1()
        {
            // TODO
        }

        /// <summary>
        ///Test pour calculerJours
        ///</summary>
        [TestMethod()]
        public void calculerJoursTest()
        {
            // TODO
        }

        /// <summary>
        ///Test pour convertirDateTime
        ///</summary>
        [TestMethod()]
        public void convertirDateTimeTest()
        {
            // TODO
        }

        /// <summary>
        ///Test pour nbMinutes
        ///</summary>
        [TestMethod()]
        public void nbMinutesTest()
        {
            // TODO
        }
    }
}
