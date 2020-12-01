using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ahorcado
{
    public partial class Form1 : Form
    {
        char[] PalabrasAdivinadas;
        char[] PalabraSeleccionada;
        char[] Alfabeto;
        String[] Palabras;
        int Oportunidades;
        String Path = @"C:\Users\carlo\source\repos\CarlosFdezJim\Desarrollo-Interfaces\Ej_InterfazGráfica\Ahorcado\Ahorcado\Ahorcado\Resources\DataBase.txt";



        public Form1()
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
        public void StartGame()
        {
            readFile();
            flFichasDeJuego.Controls.Clear();
            flFichasDeJuego.Enabled = true;
            picAhorcado.Image = null;
            lblMensajeLose.Visible = false;
            lblMensajeWin.Visible = false;
            Oportunidades = 0;
            btnIniciarJuego.Image = Properties.Resources.Jugando;
            //Palabras = new string[] { "Computer", "Laptop", "Keyboard", "Network" , "Password" };

            Alfabeto = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

            //Crear Palabra aleatoria
            Random ramdom = new Random();
            int IndicePalabrasSeleccionadas = ramdom.Next(0, Palabras.Length);
            PalabraSeleccionada = Palabras[IndicePalabrasSeleccionadas].ToUpper().ToCharArray();
            PalabrasAdivinadas = PalabraSeleccionada;


            //Cargar Alfabeto
            foreach (char LetraAlfabeto in Alfabeto){
                Button btnLetra = new Button();
                btnLetra.Tag = "";
                btnLetra.Text = LetraAlfabeto.ToString();
                btnLetra.Width = 60;
                btnLetra.Height = 40;
                btnLetra.Click += Compara;
                btnLetra.ForeColor = Color.White;
                btnLetra.Font = new Font(btnLetra.Font.Name, 15, FontStyle.Bold);
                btnLetra.BackgroundImageLayout = ImageLayout.Center;
                btnLetra.BackColor = Color.MediumPurple;
                btnLetra.Name = LetraAlfabeto.ToString();
                flFichasDeJuego.Controls.Add(btnLetra);
            }

            flPalabra.Controls.Clear();

            //Colocamos la palabra seleccionada.
            for( int ValorLetra = 0; ValorLetra < PalabraSeleccionada.Length; ValorLetra++)
            {
                Button Letra = new Button();
                Letra.Tag = PalabraSeleccionada[ValorLetra].ToString();
                Letra.Width = 46;
                Letra.Height = 80;
                Letra.ForeColor = Color.MediumPurple;
                Letra.Text = "_";
                Letra.Font = new Font(Letra.Font.Name, 32, FontStyle.Bold);
                Letra.BackgroundImageLayout = ImageLayout.Center;
                Letra.BackColor = Color.White;
                Letra.FlatStyle = FlatStyle.Flat;
                Letra.Name = "Adivinado" + ValorLetra.ToString(); ;
                flPalabra.Controls.Add(Letra);
            }

            //Rellenamos un hueco de para darle pistas al usuario.
            Random ramdomLetra = new Random();
            int indice = ramdomLetra.Next(0, Palabras.Length);
            Button letra1 = this.Controls.Find("Adivinado" + indice, true).FirstOrDefault() as Button;
            letra1.Text = PalabrasAdivinadas[indice].ToString();
            PalabrasAdivinadas[indice] = '-';

            //Añdir otra letra descubierta.
            int indice2 = ramdomLetra.Next(0, Palabras.Length);
            Button letra2 = this.Controls.Find("Adivinado" + indice2, true).FirstOrDefault() as Button;
            letra2.Text = PalabrasAdivinadas[indice2].ToString();
            PalabrasAdivinadas[indice2] = '-';


        }

        void Compara(object sender, EventArgs e)
        {
            //Botón presionado se desactiva.
            bool encontrado = false;
            Button btn = (Button)sender;
            btn.BackColor = Color.White;
            btn.ForeColor = Color.Black;
            btn.Enabled = false;

            //Compara letra seleccionada con las letras de la palabra.
            for(int i = 0; i < PalabrasAdivinadas.Length; i++)
            {
                if(PalabraSeleccionada[i] == Char.Parse(btn.Text))
                {
                    //Si existe la letra selecionada la agrega
                    Button tbx = this.Controls.Find("Adivinado" + i, true).FirstOrDefault() as Button;
                    tbx.Text = PalabrasAdivinadas[i].ToString();
                    PalabrasAdivinadas[i] = '-';
                    encontrado = true;
                }
            }

            //Si el usuario tiene letras pendientes por destapar
            bool ganaste = true;

            for(int i = 0; i < PalabrasAdivinadas.Length; i++)
            {
                if(PalabrasAdivinadas[i] != '-')
                {
                    ganaste = false;
                }
            }

            // El usuario ha ganado
            if (ganaste == true)
            {
                lblMensajeWin.Visible = true;
                btnIniciarJuego.Image = Properties.Resources.btnStart;
            }

            //Si no se encuentra ninguna letra en la palabra
            if(encontrado != true)
            {
                Oportunidades = Oportunidades + 1;
                picAhorcado.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject("image" + Oportunidades);
            }

            //Si se acaban las oportunidades mpstramos la palabra
            if (Oportunidades == 6)
            {
                lblMensajeLose.Visible = true;
                for(int i = 0; i < PalabraSeleccionada.Length; i++)
                {
                    Button btnLetra = this.Controls.Find("Adivinado" + i, true).FirstOrDefault() as Button;
                    btnLetra.Text = btnLetra.Tag.ToString();
                }

                //Desactiva las fichas y cambia el botón a reinicio
                flFichasDeJuego.Enabled = false;
                btnIniciarJuego.Image = Properties.Resources.btnStart;
            }
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StartGame();
        }

        private void btnIniciarJuego_Click(object sender, EventArgs e)
        {
            StartGame();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
                Form1 f1 = new Form1();
                //f1.exit();
            }
        }
    }
}
