using MarsApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestMarsApp
{


    /// <summary>
    ///Classe de test pour ExplorationExterieureTest, destinée à contenir tous
    ///les tests unitaires ExplorationExterieureTest
    ///</summary>
    [TestClass()]
    public class ExplorationExterieureTest
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
        ///Test pour deplacementAPieds
        ///</summary>
        [TestMethod()]
        public void deplacementAPiedsTest()
        {
            ExplorationExterieure ee = new ExplorationExterieure(new TypeActivite("Toto"), "lel", new TimeMartien(0), new TimeMartien(10), new Lieu(5, 50), null);
            ee.deplacementAPieds();

            Assert.AreEqual(ee.nomTransport(), "Scaphandre", "Le moyen de déplacement n'est pas le bon");
        }

        /// <summary>
        ///Test pour deplacementEnVehicule
        ///</summary>
        [TestMethod()]
        public void deplacementEnVehiculeTest()
        {
            ExplorationExterieure ee = new ExplorationExterieure(new TypeActivite("Toto"), "lel", new TimeMartien(0), new TimeMartien(10), new Lieu(5, 50), null);
            ee.deplacementEnVehicule();

            Assert.AreEqual(ee.nomTransport(), "Vehicule", "Le moyen de déplacement n'est pas le bon");
        }
    }
}
