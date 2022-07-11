using PdfSharp;
using PdfSharp.Pdf;
using PdfSharp.Drawing;
using System.Diagnostics;
using System.Text;
using System.Text.Json;

using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.IO;

namespace PDF_Resume_Creator

{
    
    public class Resumeinfo 
    { 
    
        //Basic Information
        public string Name { get; set; }
        public string Birthday { get; set; }
        public string Contact_Number { get; set; }
        public string Email_Address { get; set; }
        public string Address { get; set; }

        //Educational Background
        public string College { get; set; }
        public string SeniorHighSchool { get; set; }
        public string JuniorHighSchool { get; set; }
        

        //Awards and Certificates
        public string Award1 { get; set; }
        public string Award2 { get; set; }
        public string Certificate1 { get; set; }
        public string Certificate2 { get; set; }

        //Skills
        public string Skill1 { get; set; }
        public string Skill2 { get; set; }
        public string Skill3 { get; set; }
        public string Skill4 { get; set; }
        public string Skill5 { get; set; }


    }

  
    

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            string filename = "resume.json";
            string jsonstring = File.ReadAllText(filename);
            Resumeinfo resumeinfo = JsonSerializer.Deserialize<Resumeinfo>(jsonstring)!;
            
            
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