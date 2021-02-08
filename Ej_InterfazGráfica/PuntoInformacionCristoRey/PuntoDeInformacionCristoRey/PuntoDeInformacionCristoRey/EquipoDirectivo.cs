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
    public partial class EquipoDirectivo : UserControl
    {
        String[] Palabras;
        String Path = @"\DataBase.txt";
        public EquipoDirectivo()
        {
            InitializeComponent();
        }

        public void writeFile(String palabra)
        {
            //creo un txtbox en el form.
            //Cuando escribe en txtBox
            File.AppendAllText(this.Path, palabra);

        }

        public void readFile()
        {
            //Cargar palabras de un fichero
            Palabras = System.IO.File.ReadAllLines(this.Path);
        }
    }
}
