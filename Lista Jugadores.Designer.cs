namespace Parcial_1
{
    partial class Lista_Jugadores
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button2 = new System.Windows.Forms.Button();
            this.informacionJugadores = new System.Windows.Forms.DataGridView();
            this.OrdenarLista = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.promedioGoles = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.informacionJugadores)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(12, 417);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 21);
            this.button2.TabIndex = 17;
            this.button2.Text = "Regresar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // informacionJugadores
            // 
            this.informacionJugadores.AllowUserToAddRows = false;
            this.informacionJugadores.AllowUserToDeleteRows = false;
            this.informacionJugadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.informacionJugadores.Location = new System.Drawing.Point(51, 131);
            this.informacionJugadores.Name = "informacionJugadores";
            this.informacionJugadores.ReadOnly = true;
            this.informacionJugadores.Size = new System.Drawing.Size(244, 249);
            this.informacionJugadores.TabIndex = 18;
            // 
            // OrdenarLista
            // 
            this.OrdenarLista.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrdenarLista.Location = new System.Drawing.Point(189, 89);
            this.OrdenarLista.Name = "OrdenarLista";
            this.OrdenarLista.Size = new System.Drawing.Size(104, 21);
            this.OrdenarLista.TabIndex = 20;
            this.OrdenarLista.Text = "Ordenar";
            this.OrdenarLista.UseVisualStyleBackColor = true;
            this.OrdenarLista.Click += new System.EventHandler(this.OrdenarLista_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Mayor a Menor",
            "Menor a Mayor"});
            this.comboBox1.Location = new System.Drawing.Point(51, 89);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(132, 21);
            this.comboBox1.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(168, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 28);
            this.label1.TabIndex = 21;
            this.label1.Text = "Lista Jugadores";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(344, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Promedio Goles";
            // 
            // promedioGoles
            // 
            this.promedioGoles.Enabled = false;
            this.promedioGoles.Location = new System.Drawing.Point(347, 165);
            this.promedioGoles.Name = "promedioGoles";
            this.promedioGoles.Size = new System.Drawing.Size(121, 20);
            this.promedioGoles.TabIndex = 23;
            // 
            // Lista_Jugadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(518, 450);
            this.Controls.Add(this.promedioGoles);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OrdenarLista);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.informacionJugadores);
            this.Controls.Add(this.button2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Lista_Jugadores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista_Jugadores";
            this.Load += new System.EventHandler(this.Lista_Jugadores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.informacionJugadores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView informacionJugadores;
        private System.Windows.Forms.Button OrdenarLista;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox promedioGoles;
    }
}