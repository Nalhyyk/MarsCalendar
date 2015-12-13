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

            Assert.IsNull(j.trouverActivite(null, true), "On ne peut pas rechercher quelque chose de null");

            Activite trouve = j.trouverActivite(new TimeMartien(8), true);

            Assert.IsNotNull(trouve, "La fonction trouverActivite ne fonctionne pas");
            Assert.IsTrue(trouve.getNom().Equals(a1.getNom()), "La méthode a trouvé une activité qui ne correspond pas à ce qui est recherché");

            trouve = j.trouverActivite(new TimeMartien(0), false);

            Assert.IsNotNull(trouve, "La fonction trouverActivite ne fonctionne pas");
            Assert.IsTrue(trouve.getNom().Equals(a3.getNom()), "La méthode a trouvé une activité qui ne correspond pas à ce qui est recherché");
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

            trouvees = j.trouverActivites(36);

            Assert.IsNotNull(trouvees, "La fonction trouverActivites ne fonctionne pas");
            Assert.IsTrue(a2.Equals(trouvees.Find(e => e.getNom().Equals(a2.getNom()))), "La méthode a trouvé une activité qui ne correspond pas à ce qui est recherché");
            Assert.IsTrue(trouvees.Count == 2, "La méthode n'a pas trouvé le bon nombre d'éléments");
        }

        /// <summary>
        ///Test pour les accesseurs
        ///</summary>
        [TestMethod()]
        public void accesseursTest()
        {
            Journee j = new Journee(54);

            Assert.IsNotNull(j.getActivites(), "getActivites ne revoie pas la bonne valeur");
            Assert.AreEqual(j.getDescription(), "", "getDescription ne renvoie pas la bonne valeur");
            Assert.AreEqual(j.getNumero(), 54, "getNumero ne renvoie pas la bonne valeur");
            Assert.AreEqual(j.isJourneeExterieure(), false, "isJourneeExterieure ne renvoie pas la bonne valeur");

            j.setRapport("LOL");
            List<Activite> lA = new List<Activite> { new Activite(new TypeActivite("Lel")) };
            j.setListeActivites(lA);
            j.setJourneeExterieure(true);

            Assert.AreEqual(j.getActivites(), lA, "setActivites ne fonctionne pas");
            Assert.AreEqual(j.getDescription(), "LOL", "setDescription ne renvoie pas la bonne valeur");
            Assert.AreEqual(j.isJourneeExterieure(), true, "setJourneeExterieure ne renvoie pas la bonne valeur");

            String str = "";
            for (int i = 0; i < 1000; ++i)
                str += i.ToString();

            bool texteOK = j.setRapport(str);
            Assert.IsFalse(texteOK, "La description dépasse les 1000 caractères");
        }

        /// <summary>
        ///Test pour journeePassee
        ///</summary>
        [TestMethod()]
        public void journeePasseeTest()
        {
            Journee j = new Journee();

            j.journeePassee();
            Assert.AreEqual(j.getEtat(), Constantes.ETAT_PASSE, "L'état de la journée n'est pas le bon");
        }

        /// <summary>
        ///Test pour activiteEnCours
        ///</summary>
        [TestMethod()]
        public void journeeEnCoursTest()
        {
            Journee j = new Journee();

            j.journeeEnCours();
            Assert.AreEqual(j.getEtat(), Constantes.ETAT_ENCOURS, "L'état de la journée n'est pas le bon");
        }

        /// <summary>
        ///Test pour activiteAVenir
        ///</summary>
        [TestMethod()]
        public void journeeAVenirTest()
        {
            Journee j = new Journee();

            j.journeeAVenir();
            Assert.AreEqual(j.getEtat(), Constantes.ETAT_FUTUR, "L'état de la journée n'est pas le bon");
        }

        /// <summary>
        ///Test pour couleurActivite
        ///</summary>
        [TestMethod()]
        public void couleurActiviteTest()
        {
            Journee j = new Journee();
            int[] colP = Constantes.COULEUR_PASSE;
            int[] colEC = Constantes.COULEUR_ENCOURS;
            int[] colF = Constantes.COULEUR_FUTUR;

            j.journeePassee();
            Assert.AreEqual(j.couleurJournee(), colP, "La couleur de la journée n'est pas la bonne");

            j.journeeEnCours();
            Assert.AreEqual(j.couleurJournee(), colEC, "La couleur de la journée n'est pas la bonne");

            j.journeeAVenir();
            Assert.AreEqual(j.couleurJournee(), colF, "La couleur de la journée n'est pas la bonne");
        }
    }
}
