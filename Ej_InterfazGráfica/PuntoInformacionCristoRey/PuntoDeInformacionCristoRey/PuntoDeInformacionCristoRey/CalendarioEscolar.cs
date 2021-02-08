using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PuntoDeInformacionCristoRey
{
    public partial class CalendarioEscolar : UserControl
    {

        
        public CalendarioEscolar()
        {
            InitializeComponent();

            //Cargar Fichero en el Acrobat Reader
            String openPDFFile = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\calendario.pdf";//PDF DOC name
            System.IO.File.WriteAllBytes(openPDFFile, Properties.Resources.calendario);
            axAcroPDF1.LoadFile(openPDFFile);
        }
    }
}
