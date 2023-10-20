using Microsoft.VisualBasic;

namespace ProyectoProcesos
{

    public partial class Form1 : Form
    {
        static float resultado_probabilidad, division;

        public Form1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Cantidad_Maquinas_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int elementos_fila;
            Random aleat = new Random();
 
            elementos_fila = int.Parse(Elementos_Filas.Text);

            if(elementos_fila <= 5)
            {
                MessageBox.Show("Porfavor ingrese un valor mayor o igual a 5", "Error en elementos de Carretilla",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                for (int i = 0; i < elementos_fila; i++)
                {
                    Maquina.Rows.Add(aleat.Next(1, 1000000000), aleat.Next(1, 1000000000), aleat.Next(1, 1000000000));
                }

                 division = 1f / elementos_fila;
                 resultado_probabilidad =(float)Math.Pow(division, 3);
                 MessageBox.Show(resultado_probabilidad.ToString(), "El resultado de la probabilidad es",
                 MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void Graficar_Funcion_Click(object sender, EventArgs e)
        {
            int i;
            float funcion_masa_1, funcion_masa_2, funcion_masa_3;
            for ( i = 0; i < 10; i++)
            {
                funcion_masa_1 = (float)Math.Pow(resultado_probabilidad, i);
                funcion_masa_2 = (float)Math.Pow(Math.E, -(resultado_probabilidad));
                funcion_masa_3 = (funcion_masa_1) * (funcion_masa_2)/Factorial(i);

            }
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

        }

        private float Factorial(float elemento)
        {
            if(elemento == 0)
            {
                return 1;
            }
            else
            {
                return elemento * (elemento - 1);
            }

        }
    }
}