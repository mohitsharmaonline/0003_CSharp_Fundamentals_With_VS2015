using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades.Tests.Types
{
    [TestClass]
    public class TypeTests
    {
        [TestMethod]
        public void ValueTypesPassByReference()
        {
            int x = 46;
            IncreamentNumber(x);

            Assert.AreEqual(46, x);
        }

        [TestMethod]
        public void ValueTypesPassByReference_1()
        {
            int x = 46;
            IncreamentNumber_1(ref x);

            Assert.AreEqual(47, x);
        }

        private void IncreamentNumber(int number)
        {
            number += 1;
        }

        private void IncreamentNumber_1(ref int number)
        {
            number += 1;
        }

        [TestMethod]
        public void ReferenceTypesPassByValue()
        {
            GradeBook book1 = new GradeBook();
            GradeBook book2 = book1;

            GiveBookAName(book2);
            Assert.AreEqual("A GradeBook", book1.Name);
        }

        [TestMethod]
        public void ReferenceTypesPassByValue_2()
        {
            GradeBook book1 = new GradeBook();
            GradeBook book2 = book1;

            GiveBookAName_2(book2);
            Assert.AreNotEqual("A GradeBook", book1.Name);
        }

        [TestMethod]
        public void ReferenceTypesPassByValue_3()
        {
            GradeBook book1 = new GradeBook();
            GradeBook book2 = book1;

            GiveBookAName_3(ref book2);
            Assert.AreEqual("A GradeBook", book2.Name);
            Assert.AreNotEqual("A GradeBook", book1.Name);
        }

        private void GiveBookAName(GradeBook book)
        {
            book.Name = "A GradeBook";
        }

        private void GiveBookAName_2(GradeBook book)
        {
            book = new GradeBook();
            book.Name = "A GradeBook";
        }

        private void GiveBookAName_3(ref GradeBook book)
        {
            book = new GradeBook();
            book.Name = "A GradeBook";
        }

        [TestMethod]
        public void StringComparisons()
        {
            string name1 = "Scott";
            string name2 = "scott";

            bool result = String.Equals(name1, name2, StringComparison.InvariantCultureIgnoreCase);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IntVariablesHoldsAValue()
        {
            int x1 = 100;
            int x2 = x1;

            x1 = 4;
            Assert.AreNotEqual(x1, x2);
        }

        [TestMethod]
        public void GradebookVariablesHoldsAReference()
        {
            GradeBook g1 = new GradeBook();
            GradeBook g2 = g1;

            g1.Name = "Scott's gradebook";
            Assert.AreEqual(g1.Name, g2.Name);
        }

        [TestMethod]
        public void GradebookVariablesHoldsAReference_2()
        {
            GradeBook g1 = new GradeBook();
            GradeBook g2 = g1;

            g1 = new GradeBook();
            g1.Name = "Scott's gradebook";
            Assert.AreNotEqual(g1.Name, g2.Name);
        }
    }
}
