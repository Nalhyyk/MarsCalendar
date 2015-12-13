using MarsApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace TestMarsApp
{


    /// <summary>
    ///Classe de test pour DomaineTest, destinée à contenir tous
    ///les tests unitaires DomaineTest
    ///</summary>
    [TestClass()]
    public class DomaineTest
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
            Domaine d = new Domaine("Toto");

            Assert.IsNotNull(d.getActivites(), "La liste des activités ne devrait pas être nulle");
            Assert.IsTrue(d.getActivites().Count == 0, "La liste des activités devrait être vide");

            d.ajouterActivite(new TypeActivite("Tata"));
            d.ajouterActivite(new TypeActivite("Tata"));
            d.ajouterActivite(new TypeActivite("Tata"));

            Assert.IsTrue(d.getActivites().Count == 3, "Une activité n'a pas été ajoutée");
        }

        /// <summary>
        ///Test pour supprimerActivite
        ///</summary>
        [TestMethod()]
        public void supprimerActiviteTest()
        {
            Domaine d = new Domaine("Toto");

            d.ajouterActivite(new TypeActivite("Tata"));
            d.ajouterActivite(new TypeActivite("Tota"));
            TypeActivite ta = new TypeActivite("Tato");
            d.ajouterActivite(ta);
            d.supprimerActivite(ta);

            Assert.IsTrue(d.getActivites().Count == 2, "Une activité n'a pas été supprimée");
            Assert.IsNull(d.getActivites().Find(e => (e.getNom().Equals(ta.getNom()))), "L'activité supprimée n'est pas la bonne");
        }

        /// <summary>
        ///Test pour nbTypeActivite
        ///</summary>
        [TestMethod()]
        public void nbTypeActiviteTest()
        {
            Domaine d = new Domaine("Toto");

            d.ajouterActivite(new TypeActivite("Tata"));
            d.ajouterActivite(new TypeActivite("Tota"));

            int nb = 5;
            d.nbTypeActivite(ref nb);

            Assert.IsTrue(nb == 7, "nbTypeActivite n'a pas ajouté le bon nombre d'activités");
        }

        /// <summary>
        ///Test pour les accesseurs
        ///</summary>
        [TestMethod()]
        public void accesseursTest()
        {
            int[] col = {0, 1, 2};
            Domaine d = new Domaine("Toto", col);

            d.ajouterActivite(new TypeActivite("Tata"));
            d.ajouterActivite(new TypeActivite("Tota"));

            Assert.IsNotNull(d.getActivites(), "getActivites ne renvoie pas la bonne valeur");
            Assert.AreEqual(d.getCouleur(), col, "getCouleur ne renvoie pas la bonne valeur");
            Assert.AreEqual(d.getNom(), "Toto", "getNom ne renvoie pas la bonne valeur");
            Assert.IsNotNull(d.getNomActivites(), "getNomActivites ne renvoie pas la bonne valeur");
        }
    }
}
