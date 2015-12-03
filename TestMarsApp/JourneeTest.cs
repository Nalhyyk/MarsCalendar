using MarsApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace TestMarsApp
{
    
    
    /// <summary>
    ///Classe de test pour JourneeTest, destinée à contenir tous
    ///les tests unitaires JourneeTest
    ///</summary>
    [TestClass()]
    public class JourneeTest
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
        ///Test pour ajouterActivite
        ///</summary>
        [TestMethod()]
        public void ajouterActiviteTest()
        {
            Journee j = new Journee();
            Activite a = new Activite(new TypeActivite("Lel"), "xD", new TimeMartien(0, 0, 0, 0), new TimeMartien(1, 2, 3, 4), new Lieu(0, 0));
            j.ajouterActivite(a);

            Assert.IsNotNull(j.getActivites(), "L'ajout d'activité a échoué");
        }

        /// <summary>
        ///Test pour mettreAJourJourneeExterieure
        ///</summary>
        [TestMethod()]
        public void mettreAJourJourneeExterieureTest()
        {
            Journee target = new Journee(); // TODO: initialisez à une valeur appropriée
            bool expected = false; // TODO: initialisez à une valeur appropriée
            bool actual;
            actual = target.mettreAJourJourneeExterieure();
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///Test pour supprimerActivite
        ///</summary>
        [TestMethod()]
        public void supprimerActiviteTest()
        {
            Journee j = new Journee();
            Activite a = new Activite(new TypeActivite("Lel"), "xD", new TimeMartien(0, 0, 0, 0), new TimeMartien(1, 2, 3, 4), new Lieu(0, 0));
            j.ajouterActivite(a);
            j.supprimerActivite(a);

            Activite actSuppr = j.getActivites().Find(e => (e.getNom().Equals(a.getNom()) && e.getDescription().Equals(a.getDescription())));

            Assert.IsNull(actSuppr, "La suppression d'activité a échoué");
        }

        /// <summary>
        ///Test pour trouverActivite
        ///</summary>
        [TestMethod()]
        public void trouverActiviteTest()
        {
            Journee target = new Journee(); // TODO: initialisez à une valeur appropriée
            TimeMartien tm = null; // TODO: initialisez à une valeur appropriée
            bool debut = false; // TODO: initialisez à une valeur appropriée
            Activite expected = null; // TODO: initialisez à une valeur appropriée
            Activite actual;
            actual = target.trouverActivite(tm, debut);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///Test pour trouverActivites
        ///</summary>
        [TestMethod()]
        public void trouverActivitesTest()
        {
            Journee target = new Journee(); // TODO: initialisez à une valeur appropriée
            int heureD = 0; // TODO: initialisez à une valeur appropriée
            List<Activite> expected = null; // TODO: initialisez à une valeur appropriée
            List<Activite> actual;
            actual = target.trouverActivites(heureD);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Vérifiez l\'exactitude de cette méthode de test.");
        }
    }
}
