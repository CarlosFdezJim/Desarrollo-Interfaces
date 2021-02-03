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

namespace PuntoDeInformacion
{
    public partial class CalendarioEscolar : UserControl
    {
        public CalendarioEscolar()
        {
            InitializeComponent();
            //axAcroPDF1.LoadFile(@"C:/Users/carlo/source/repos/CarlosFdezJim/Desarrollo-Interfaces/Ej_InterfazGráfica/PuntoDeInformacion/PuntoDeInformacion/calendario_escolar_sevilla_20-21.pdf");
            axAcroPDF1.LoadFile(@"..\..\Resources\calendario.pdf");

            //string directorio = Path.Combine(Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory));
            //string path = Path.Combine(directorio, "calendario.pdf");
            //axAcroPDF1.LoadFile(path);
        }
    }
}
