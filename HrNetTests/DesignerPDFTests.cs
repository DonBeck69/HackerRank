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
    public class DesignerPDFTests
    {
        [TestMethod()]
        public void designerPdfViewerTest1()
        {
            DesignerPDF designerPDF = new DesignerPDF();
            int[] h = new int[] { 1, 3, 1, 3, 1, 4, 1, 3, 2, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5 };
            int res = designerPDF.designerPdfViewer(h, "abc");
            Assert.IsTrue(res == 9);
        }

        [TestMethod()]
        public void designerPdfViewerTest2()
        {
            DesignerPDF designerPDF = new DesignerPDF();
            int[] h = new int[] { 1, 3, 1, 3, 1, 4, 1, 3, 2, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 7 };
            int res = designerPDF.designerPdfViewer(h, "zeba");
            Assert.IsTrue(res == 28);
        }
    }
}