namespace EJ3
{
    public partial class Form1 : Form
    {
        int contador = 0;
        double[] valores = new double[100];
        public Form1()
        {
            InitializeComponent();
        }
        private void btoRegistrar_Click(object sender, EventArgs e)
        {
            valores[contador] = Convert.ToDouble(txtRegistro.Text);
            contador++;
            txtRegistro.Clear();
        }
        private void btoResult_Click(object sender, EventArgs e)
        {
            double acumulador = 0;
            for (int i = 0; i < contador; i++)
            {
                acumulador += valores[i];
            }
            double promedio = acumulador / contador;
            lbPromedio.Text = $"El promedio es: {promedio}";
            txtValores.Text = $@"El promedio es: 
                              {promedio,6:f2}";
        }

        private void txtRegistro_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
