using Microsoft.VisualStudio.TestTools.UnitTesting;
using HrNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrNet.Tests
{
    [TestClass()]
    public class DrawingBookTests
    {
        [TestMethod()]
        public void pageCountTest62()
        {
            DrawingBook drawingBook = new DrawingBook();
            int res = drawingBook.pageCount(6, 2);
            Assert.IsTrue(res == 1);
        }

        [TestMethod()]
        public void pageCountTest53()
        {
            DrawingBook drawingBook = new DrawingBook();
            int res = drawingBook.pageCount(5, 3);
            Assert.IsTrue(res == 1);
        }

        [TestMethod()]
        public void pageCountTest54()
        {
            DrawingBook drawingBook = new DrawingBook();
            int res = drawingBook.pageCount(5, 4);
            Assert.IsTrue(res == 0);
        }

        [TestMethod()]
        public void pageCountTest94()
        {
            DrawingBook drawingBook = new DrawingBook();
            int res = drawingBook.pageCount(9, 4);
            Assert.IsTrue(res == 2);
        }

        [TestMethod()]
        public void pageCountTest11()
        {
            DrawingBook drawingBook = new DrawingBook();
            int res = drawingBook.pageCount(1, 1);
            Assert.IsTrue(res == 0);
        }

    }
}