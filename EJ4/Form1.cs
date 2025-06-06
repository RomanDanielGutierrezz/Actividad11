using EJ4.Models;

namespace EJ4
{
    public partial class Form1 : Form
    {
        Servicio servicio = new Servicio();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btoRegistrar_Click(object sender, EventArgs e)
        {
            servicio.valores[servicio.contador] = Convert.ToDouble(txtRegistro.Text);
            servicio.contador++;
            txtRegistro.Clear();
        }
        private void btoResult_Click(object sender, EventArgs e)
        {
            double promedio = servicio.Promedio();
            lbPromedio.Text = $"El promedio es: {promedio:f2}";
            txtValores.Text = $@"El promedio es: 
                              {promedio,6:f2}";
        }

        private void btoOrdenar_Click(object sender, EventArgs e)
        {
            txtValores.Clear();
            for (int i = 0; i < servicio.contador; i++)
            {
                txtValores.Text += $"{servicio.valores[i],5:f2}";
            }
            
        }
    }
}
