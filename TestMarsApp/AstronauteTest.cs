using MarsApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace TestMarsApp
{
    
    
    /// <summary>
    ///Classe de test pour AstronauteTest, destinée à contenir tous
    ///les tests unitaires AstronauteTest
    ///</summary>
    [TestClass()]
    public class AstronauteTest
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
        ///Test pour creerEdT
        ///</summary>
        [TestMethod()]
        public void creerEdTTest()
        {
            Astronaute a = new Astronaute("Bob", "Machin", 20);
            int numJour = 20;
            a.creerEdT(numJour);

            Assert.IsNotNull(a.getJourneesMission(), "L'emploi du temps n'a pas été créé");

            List<Journee> journees = new List<Journee>(a.getJourneesMission().Values);

            int passees = journees.FindAll(e => (!e.isModifiable())).Count;
            int enCours = journees.FindAll(e => (e.isEnCours())).Count;
            int resultPassee = 19;
            int resultEnCours = 1;

            Assert.IsTrue(passees == resultPassee && enCours == resultEnCours, "L'emploi du temps a été créé, mais " +
                "les journées n'ont pas le bon état");
        }

        /// <summary>
        ///Test pour nbJournees
        ///</summary>
        [TestMethod()]
        public void nbJourneesTest()
        {
            Astronaute a = new Astronaute("Bob", "Machin", 20);
            int numJour = 20;
            a.creerEdT(numJour);

            int nbElems = a.getJourneesMission().Count * 7; // 7 est le nombre d'activités dans une journée, par défaut
            int result = 500 * 7;

            Assert.AreEqual(nbElems, result, "Le nombre d'éléments dans l'EdT de l'astronaute n'est pas bon");
        }
    }
}
