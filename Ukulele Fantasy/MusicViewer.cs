using DarkUI.Forms;
using PdfiumViewer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ukulele_Fantasy.Models;

namespace Ukulele_Fantasy
{
    public partial class MusicViewer : DarkForm
    {
        public MusicViewer()
        {
            InitializeComponent();

            pdfViewer.Document?.Dispose();
            pdfViewer.Document = OpenDocument();
        }

        private PdfDocument OpenDocument()
        {
            return PdfDocument.Load(iGVars.CurrentFIle);
        }
    }
}
