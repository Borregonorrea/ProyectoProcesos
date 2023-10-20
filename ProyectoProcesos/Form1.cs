using Microsoft.VisualBasic;

namespace ProyectoProcesos
{
    public partial class Form1 : Form
    {
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
            float resultado_probabilidad, division;
            string probabilidad_mostrada = "";
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
                 division = 1 / elementos_fila;
                 resultado_probabilidad =(float)Math.Pow(division, 3);
                 MessageBox.Show(resultado_probabilidad.ToString(), "El resultado de la probabilidad es",
                 MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}