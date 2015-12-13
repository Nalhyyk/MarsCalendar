using MarsApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestMarsApp
{
    
    
    /// <summary>
    ///Classe de test pour ActiviteTest, destinée à contenir tous
    ///les tests unitaires ActiviteTest
    ///</summary>
    [TestClass()]
    public class ActiviteTest
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
            Activite a = new Activite(new TypeActivite("Toto"), "lel", new TimeMartien(0), new TimeMartien(10), new Lieu(0, 0));
            Activite a2 = new Activite(new TypeActivite("Toto"), "lel", new TimeMartien(0), new TimeMartien(10), new Lieu(0, 0));

            Assert.IsTrue(a.Equals(a2), "La méthode Equals ne fonctionne pas");
        }

        /// <summary>
        ///Test pour activitePassee
        ///</summary>
        [TestMethod()]
        public void activitePasseeTest()
        {
            Activite a = new Activite(new TypeActivite("Toto"), "lel", new TimeMartien(0), new TimeMartien(10), new Lieu(0, 0));
            
            a.activitePassee();
            Assert.AreEqual(a.getEtat(), Constantes.ETAT_PASSE, "L'état de l'activité n'est pas le bon");
        }

        /// <summary>
        ///Test pour activiteEnCours
        ///</summary>
        [TestMethod()]
        public void activiteEnCoursTest()
        {
            Activite a = new Activite(new TypeActivite("Toto"), "lel", new TimeMartien(0), new TimeMartien(10), new Lieu(0, 0));

            a.activiteEnCours();
            Assert.AreEqual(a.getEtat(), Constantes.ETAT_ENCOURS, "L'état de l'activité n'est pas le bon");
        }

        /// <summary>
        ///Test pour activiteAVenir
        ///</summary>
        [TestMethod()]
        public void activiteAVenirTest()
        {
            Activite a = new Activite(new TypeActivite("Toto"), "lel", new TimeMartien(0), new TimeMartien(10), new Lieu(0, 0));

            a.activiteAVenir();
            Assert.AreEqual(a.getEtat(), Constantes.ETAT_FUTUR, "L'état de l'activité n'est pas le bon");
        }

        /// <summary>
        ///Test pour couleurActivite
        ///</summary>
        [TestMethod()]
        public void couleurActiviteTest()
        {
            Activite a = new Activite(new TypeActivite("Toto"), "lel", new TimeMartien(0), new TimeMartien(10), new Lieu(0, 0));
            int[] colP = Constantes.COULEUR_PASSE;
            int[] colEC = Constantes.COULEUR_ENCOURS;
            int[] colF = Constantes.COULEUR_FUTUR;

            a.activitePassee();
            Assert.AreEqual(a.couleurActivite(), colP, "La couleur de l'activité n'est pas la bonne");

            a.activiteEnCours();
            Assert.AreEqual(a.couleurActivite(), colEC, "La couleur de l'activité n'est pas la bonne");

            a.activiteAVenir();
            Assert.AreEqual(a.couleurActivite(), colF, "La couleur de l'activité n'est pas la bonne");
        }

        /// <summary>
        ///Test pour les accesseurs
        ///</summary>
        [TestMethod()]
        public void accesseursTest()
        {
            Activite a = new Activite(new TypeActivite("Toto"), "lel", new TimeMartien(0), new TimeMartien(10), new Lieu(0, 0));

            Assert.AreEqual(a.getDescription(), "lel", "getDescription ne renvoie pas le bon résultat");
            Assert.AreEqual(a.getDuree(), new TimeMartien(10), "getDuree ne renvoie pas le bon résultat");
            Assert.AreEqual(a.getHeureDebut(), new TimeMartien(0), "getHeureDebut ne renvoie pas le bon résultat");
            Assert.AreEqual(a.getHeureFin(), new TimeMartien(10), "getHeureFin ne renvoie pas le bon résultat");
            Assert.AreEqual(a.getLieu(), new Lieu(0, 0), "getLieu ne renvoie pas le bon résultat");
            Assert.AreEqual(a.getNom(), "Toto", "getNom ne renvoie pas le bon résultat");
            Assert.AreEqual(a.getTypeActivite(), new TypeActivite("Toto"), "getTypeActivite ne renvoie pas le bon résultat");
            Assert.AreEqual(a.isActiviteExterieure(), false, "isActiviteExterieure ne renvoie pas le bon résultat");
            Assert.AreEqual(a.isExperience(), false, "isExperience ne renvoie pas le bon résultat");
            Assert.AreEqual(a.isExploration(), false, "isExploration ne renvoie pas le bon résultat");
            Assert.AreEqual(a.isModifiable(), true, "isModifiable ne renvoie pas le bon résultat");
        }
    }
}
