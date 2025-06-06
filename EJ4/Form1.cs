namespace EJ4
{
    public partial class Form1 : Form
    {
        int contador = 0;
        double[] valores = new double[100];
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
            lbPromedio.Text = $"El promedio es: {promedio:f2}";
            txtValores.Text = $@"El promedio es: 
                              {promedio,6:f2}";
        }

        private void btoOrdenar_Click(object sender, EventArgs e)
        {
            txtValores.Clear();
            for (int i = 0; i < contador; i++)
            {
                txtValores.Text += $"{valores[i],5:f2}";
            }
            for (int i = 0; i < contador-1; i++)
            {
                for (int j = i+1; j < contador; j++)
                {
                    if (valores[i] > valores[j])
                    {   
                        double aux = valores[i];
                        valores[i] = valores[j];
                        valores[j] = aux;
                    }
                }
            }
        }
    }
}
