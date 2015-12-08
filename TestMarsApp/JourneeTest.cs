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
            Journee target = new Journee();
            bool expected = false;
            bool actual;
            actual = target.mettreAJourJourneeExterieure();
            Assert.AreEqual(expected, actual);

            target = new Journee();
            target.ajouterActivite(new ExplorationExterieure(new TypeActivite("Toto"), "", new TimeMartien(0), new TimeMartien(2), new Lieu(0, 0), null));
            expected = true;
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
            Journee j = new Journee();
            j.setListeActivites(new List<Activite>());
            Activite a1 = new Activite(new TypeActivite("Lel1"), "xD1", new TimeMartien(0), new TimeMartien(10), new Lieu(0, 0));
            Activite a2 = new Activite(new TypeActivite("Lel2"), "xD2", new TimeMartien(10), new TimeMartien(20), new Lieu(20, 30));
            Activite a3 = new Activite(new TypeActivite("Lel3"), "xD3", new TimeMartien(20), new TimeMartien(0, 24, 40, 0), new Lieu(12, 45));
            Activite a4 = new Activite(new TypeActivite("Lel4"), "xD4", new TimeMartien(10), new TimeMartien(15), new Lieu(20, 30));

            j.ajouterActivite(a1);
            j.ajouterActivite(a2);
            j.ajouterActivite(a3);
            j.ajouterActivite(a4);

            Activite trouve = j.trouverActivite(new TimeMartien(8), true);

            Assert.IsNotNull(trouve, "La fonction trouverActivites ne fonctionne pas");

            Assert.IsTrue(trouve.getNom().Equals(a1.getNom()), "La méthode a trouvé une activité qui ne correspond pas à ce qui est recherché");
        }

        /// <summary>
        ///Test pour trouverActivites
        ///</summary>
        [TestMethod()]
        public void trouverActivitesTest()
        {
            Journee j = new Journee();
            j.setListeActivites(new List<Activite>());
            Activite a1 = new Activite(new TypeActivite("Lel1"), "xD1", new TimeMartien(0), new TimeMartien(10), new Lieu(0, 0));
            Activite a2 = new Activite(new TypeActivite("Lel2"), "xD2", new TimeMartien(10), new TimeMartien(20), new Lieu(20, 30));
            Activite a3 = new Activite(new TypeActivite("Lel3"), "xD3", new TimeMartien(20), new TimeMartien(0, 24, 40, 0), new Lieu(12, 45));
            Activite a4 = new Activite(new TypeActivite("Lel4"), "xD4", new TimeMartien(10), new TimeMartien(15), new Lieu(20, 30));

            j.ajouterActivite(a1);
            j.ajouterActivite(a2);
            j.ajouterActivite(a3);
            j.ajouterActivite(a4);

            List<Activite> trouvees = j.trouverActivites(11);

            Assert.IsNotNull(trouvees, "La fonction trouverActivites ne fonctionne pas");

            Assert.IsTrue(a2.Equals(trouvees.Find(e => e.getNom().Equals(a2.getNom()))), "La méthode a trouvé une activité qui ne correspond pas à ce qui est recherché");

            Assert.IsTrue(trouvees.Count == 2, "La méthode n'a pas trouvé le bon nombre d'éléments");
        }
    }
}
