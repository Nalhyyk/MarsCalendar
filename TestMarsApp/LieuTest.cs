using MarsApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestMarsApp
{


    /// <summary>
    ///Classe de test pour LieuTest, destinée à contenir tous
    ///les tests unitaires LieuTest
    ///</summary>
    [TestClass()]
    public class LieuTest
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
        ///Test pour Equals
        ///</summary>
        [TestMethod()]
        public void EqualsTest()
        {
            Lieu l = new Lieu(-60, 80);
            Lieu l2 = new Lieu(-60, 80);
            Lieu l3 = new Lieu(60, -80);

            Assert.IsTrue(l.Equals(l2), "Les lieux devraient être égaux");
            Assert.IsFalse(l.Equals(l3), "Les lieux ne devraient pas être égaux");
        }
    }
}
