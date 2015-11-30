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

            Assert.IsTrue(somme == result, "Le résultat de l'addition entre 2 TimeMartien est faux");
        }

        /// <summary>
        ///Test pour op_Equality
        ///</summary>
        [TestMethod()]
        public void op_EqualityTest()
        {
            TimeMartien t1 = new TimeMartien(0, 10, 20, 30);
            TimeMartien t2 = new TimeMartien(0, 10, 20, 30);

            Assert.IsTrue(t1 == t2, "Le résultat de l'égalité entre 2 TimeMartien est faux");
        }

        /// <summary>
        ///Test pour op_GreaterThan
        ///</summary>
        [TestMethod()]
        public void op_GreaterThanTest()
        {
            TimeMartien t1 = new TimeMartien(0, 10, 20, 30);
            TimeMartien t2 = new TimeMartien(0, 11, 00, 00);

            Assert.IsTrue(t2 >= t1, "Le résultat de l'inégalité > entre 2 TimeMartien est faux");
        }

        /// <summary>
        ///Test pour op_GreaterThanOrEqual
        ///</summary>
        [TestMethod()]
        public void op_GreaterThanOrEqualTest()
        {
            TimeMartien t1 = new TimeMartien(0, 10, 20, 30);
            TimeMartien t2 = new TimeMartien(0, 11, 00, 00);
            TimeMartien t3 = new TimeMartien(0, 10, 20, 30);

            Assert.IsTrue(t2 >= t1, "Le résultat de >= entre 2 TimeMartien est faux");
            Assert.IsTrue(t3 >= t1, "Le résultat de l'inégalité >= entre 2 TimeMartien est faux");
        }

        /// <summary>
        ///Test pour op_Inequality
        ///</summary>
        [TestMethod()]
        public void op_InequalityTest()
        {
            TimeMartien t1 = new TimeMartien(0, 10, 20, 30);
            TimeMartien t2 = new TimeMartien(0, 15, 20, 30);

            Assert.IsTrue(t1 != t2, "Le résultat de l'inégalité entre 2 TimeMartien est faux");
            Assert.IsFalse(t1 == t2, "Le résultat de l'inégalité entre 2 TimeMartien est faux");
        }

        /// <summary>
        ///Test pour op_LessThan
        ///</summary>
        [TestMethod()]
        public void op_LessThanTest()
        {
            TimeMartien t1 = new TimeMartien(0, 10, 20, 30);
            TimeMartien t2 = new TimeMartien(0, 11, 00, 00);

            Assert.IsTrue(t1 <= t2, "Le résultat de l'inégalité < entre 2 TimeMartien est faux");
        }

        /// <summary>
        ///Test pour op_LessThanOrEqual
        ///</summary>
        [TestMethod()]
        public void op_LessThanOrEqualTest()
        {
            TimeMartien t1 = new TimeMartien(0, 10, 20, 30);
            TimeMartien t2 = new TimeMartien(0, 11, 00, 00);
            TimeMartien t3 = new TimeMartien(0, 10, 20, 30);

            Assert.IsTrue(t1 <= t2, "Le résultat de >= entre 2 TimeMartien est faux");
            Assert.IsTrue(t3 <= t1, "Le résultat de l'inégalité >= entre 2 TimeMartien est faux");
        }

        /// <summary>
        ///Test pour op_Subtraction
        ///</summary>
        [TestMethod()]
        public void op_SubtractionTest()
        {
            TimeMartien t1 = new TimeMartien(2, 10, 20, 30);
            TimeMartien t2 = new TimeMartien(1, 20, 30, 40);
            TimeMartien result = new TimeMartien(1, 14, 29, 50);
            TimeMartien diff = t1 - t2;

            Assert.IsTrue(diff == result, "Le résultat de la soustraction entre 2 TimeMartien est faux");
            Assert.IsTrue((diff + t2) == t1, "Le résultat de la soustraction entre 2 TimeMartien est faux");
        }

        /// <summary>
        ///Test pour retirerTemps
        ///</summary>
        [TestMethod()]
        public void retirerTempsTest()
        {
            TimeMartien t1 = new TimeMartien(5, 10, 20, 30);
            t1.retirerTemps(2, 10, 21, 35);
            TimeMartien result = new TimeMartien(3, 24, 38, 55);

            Assert.IsTrue(t1 == result, "Le temps n'a pas bien été retiré");

            t1 = new TimeMartien(5, 10, 20, 30);
            t1.retirerTemps(2, 9, 15, 10);
            result = new TimeMartien(3, 1, 5, 20);

            Assert.IsTrue(t1 == result, "Le temps n'a pas bien été retiré");
        }

        /// <summary>
        ///Test pour sePasseDansPeriode
        ///</summary>
        [TestMethod()]
        public void sePasseDansPeriodeTest()
        {
            TimeMartien deb = new TimeMartien(1, 2, 3, 4);
            TimeMartien fin = new TimeMartien(2, 3, 4, 5);
            TimeMartien actDeb = new TimeMartien(1, 10, 50, 0);
            TimeMartien actFin = new TimeMartien(2, 3, 0, 0);

            Assert.IsTrue(TimeMartien.sePasseDansPeriode(actDeb, actFin, deb, fin));

            actDeb = new TimeMartien(1, 2, 3, 4);
            actFin = new TimeMartien(2, 3, 4, 5);

            Assert.IsTrue(TimeMartien.sePasseDansPeriode(actDeb, actFin, deb, fin));

            actDeb = new TimeMartien(1, 1, 3, 4);
            actFin = new TimeMartien(2, 4, 4, 5);

            Assert.IsTrue(TimeMartien.sePasseDansPeriode(actDeb, actFin, deb, fin));
        }

        /// <summary>
        ///Test pour Equals
        ///</summary>
        [TestMethod()]
        public void EqualsTest()
        {
            TimeMartien t1 = new TimeMartien(0, 10, 20, 30);
            TimeMartien t2 = new TimeMartien(0, 10, 20, 30);

            Assert.IsTrue(t1.Equals(t2), "Le résultat de l'égalité entre 2 TimeMartien est faux");
        }

        /// <summary>
        ///Test pour ajouterTemps
        ///</summary>
        [TestMethod()]
        public void ajouterTempsTest()
        {
            TimeMartien t1 = new TimeMartien(5, 10, 20, 30);
            t1.ajouterTemps(2, 10, 21, 35);
            TimeMartien result = new TimeMartien(7, 20, 42, 5);

            Assert.IsTrue(t1 == result, "Le temps n'a pas bien été ajouté");

            t1 = new TimeMartien(5, 20, 0, 0);
            t1.ajouterTemps(2, 5, 30, 75);
            result = new TimeMartien(8, 0, 51, 15);

            Assert.IsTrue(t1 == result, "Le temps n'a pas bien été ajouté");
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
