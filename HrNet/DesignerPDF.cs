using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrNet
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/designer-pdf-viewer/problem
    /// </summary>
    public class DesignerPDF
    {
        public int designerPdfViewer(int[] h, string word)
        {
            int max = 0;
            foreach(char c in word)
            {
                if (h[c-97] > max)
                {
                    max = h[c - 97];
                }
            }
            return max * word.Length;
        }
    }
}
