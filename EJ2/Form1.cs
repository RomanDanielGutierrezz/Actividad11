using System.Reflection;

namespace EJ2
{
    public partial class Promedios : Form
    {
        double acumulador = 0;
        int contador = 0;

        public Promedios()
        {
            InitializeComponent();
        }

        private void btoRegistrar_Click(object sender, EventArgs e)
        {
            acumulador += Convert.ToDouble(txtRegistro.Text);
            contador++;
            txtRegistro.Clear();
        }

        private void btoResult_Click(object sender, EventArgs e)
        {
            double promedio = acumulador / contador;
            lbPromedio.Text = $"El promedio es: {promedio}";
            txtValores.Text = $@"El promedio es: 
                              {promedio,10:f2}";
        }
    }
}
