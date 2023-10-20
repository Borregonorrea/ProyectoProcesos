namespace ProyectoProcesos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Maquina = new System.Windows.Forms.DataGridView();
            this.Carretilla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Carretilla2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Carretilla3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.Elementos_Filas = new System.Windows.Forms.TextBox();
            this.b_inicio = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Maquina)).BeginInit();
            this.SuspendLayout();
            // 
            // Maquina
            // 
            this.Maquina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Maquina.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Carretilla,
            this.Carretilla2,
            this.Carretilla3});
            this.Maquina.Location = new System.Drawing.Point(111, 142);
            this.Maquina.Name = "Maquina";
            this.Maquina.RowTemplate.Height = 25;
            this.Maquina.Size = new System.Drawing.Size(362, 195);
            this.Maquina.TabIndex = 0;
            this.Maquina.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Carretilla
            // 
            this.Carretilla.HeaderText = "Carretilla";
            this.Carretilla.Name = "Carretilla";
            this.Carretilla.ReadOnly = true;
            // 
            // Carretilla2
            // 
            this.Carretilla2.HeaderText = "Carretilla2";
            this.Carretilla2.Name = "Carretilla2";
            this.Carretilla2.ReadOnly = true;
            // 
            // Carretilla3
            // 
            this.Carretilla3.HeaderText = "Carretilla3";
            this.Carretilla3.Name = "Carretilla3";
            this.Carretilla3.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(167, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(272, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ingrese la cantidad de elementos de cada carretilla";
            // 
            // Elementos_Filas
            // 
            this.Elementos_Filas.Location = new System.Drawing.Point(152, 44);
            this.Elementos_Filas.Name = "Elementos_Filas";
            this.Elementos_Filas.Size = new System.Drawing.Size(299, 23);
            this.Elementos_Filas.TabIndex = 4;
            // 
            // b_inicio
            // 
            this.b_inicio.Location = new System.Drawing.Point(260, 85);
            this.b_inicio.Name = "b_inicio";
            this.b_inicio.Size = new System.Drawing.Size(75, 23);
            this.b_inicio.TabIndex = 5;
            this.b_inicio.Text = "Inicio";
            this.b_inicio.UseVisualStyleBackColor = true;
            this.b_inicio.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Carrete 1";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.b_inicio);
            this.Controls.Add(this.Elementos_Filas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Maquina);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Maquina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView Maquina;
        private Label label2;
        private TextBox Elementos_Filas;
        private Button b_inicio;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn Carretilla;
        private DataGridViewTextBoxColumn Carretilla2;
        private DataGridViewTextBoxColumn Carretilla3;
    }
}