using PdfSharp;
using PdfSharp.Pdf;
using PdfSharp.Drawing;
using System.Diagnostics;
using System.Text;

namespace PDF_Resume_Creator

{



    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Generatebtn_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "PDF|*.pdf";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    PdfDocument pdf = new PdfDocument();
                    sfd.FileName = "RIVERA_ROMMUEL";
                    pdf.Info.Title = "Resume";
                    PdfPage page = pdf.AddPage();

                    XGraphics graph = XGraphics.FromPdfPage(page);
                    XFont font = new XFont("Verdana", 18, XFontStyle.Regular);

                    graph.DrawString("This is the first page of the document", font, XBrushes.Black, new XRect(0, 0, page.Width.Point, page.Height.Point), XStringFormats.Center);
                    
                    pdf.Save(sfd.FileName);
                    
                }
            }

        }
    }
}