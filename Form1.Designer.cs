namespace Parcial_1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.nombreJugador = new System.Windows.Forms.TextBox();
            this.numeroJugador = new System.Windows.Forms.TextBox();
            this.equipoJugador = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.fechaJuego = new System.Windows.Forms.DateTimePicker();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.equipoContrario = new System.Windows.Forms.ComboBox();
            this.golesAnotados = new System.Windows.Forms.NumericUpDown();
            this.Fecha = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ListarJugadores = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.golesAnotados)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(114, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingreso Jugadores";
            // 
            // nombreJugador
            // 
            this.nombreJugador.Location = new System.Drawing.Point(162, 69);
            this.nombreJugador.Name = "nombreJugador";
            this.nombreJugador.Size = new System.Drawing.Size(157, 20);
            this.nombreJugador.TabIndex = 1;
            // 
            // numeroJugador
            // 
            this.numeroJugador.Location = new System.Drawing.Point(162, 95);
            this.numeroJugador.MaxLength = 6;
            this.numeroJugador.Name = "numeroJugador";
            this.numeroJugador.Size = new System.Drawing.Size(157, 20);
            this.numeroJugador.TabIndex = 2;
            // 
            // equipoJugador
            // 
            this.equipoJugador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.equipoJugador.FormattingEnabled = true;
            this.equipoJugador.Location = new System.Drawing.Point(162, 121);
            this.equipoJugador.Name = "equipoJugador";
            this.equipoJugador.Size = new System.Drawing.Size(157, 21);
            this.equipoJugador.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(97, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(135, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(104, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Equipo";
            // 
            // fechaJuego
            // 
            this.fechaJuego.Location = new System.Drawing.Point(162, 149);
            this.fechaJuego.Name = "fechaJuego";
            this.fechaJuego.Size = new System.Drawing.Size(157, 20);
            this.fechaJuego.TabIndex = 7;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // equipoContrario
            // 
            this.equipoContrario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.equipoContrario.FormattingEnabled = true;
            this.equipoContrario.Location = new System.Drawing.Point(162, 175);
            this.equipoContrario.Name = "equipoContrario";
            this.equipoContrario.Size = new System.Drawing.Size(157, 21);
            this.equipoContrario.TabIndex = 8;
            // 
            // golesAnotados
            // 
            this.golesAnotados.Location = new System.Drawing.Point(162, 203);
            this.golesAnotados.Name = "golesAnotados";
            this.golesAnotados.Size = new System.Drawing.Size(157, 20);
            this.golesAnotados.TabIndex = 9;
            // 
            // Fecha
            // 
            this.Fecha.AutoSize = true;
            this.Fecha.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fecha.Location = new System.Drawing.Point(39, 150);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(118, 15);
            this.Fecha.TabIndex = 10;
            this.Fecha.Text = "Fecha Encuentro";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(39, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Equipo Contrario";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(48, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Goles Anotados";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(70, 252);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 46);
            this.button1.TabIndex = 13;
            this.button1.Text = "Guardar Información";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(325, 121);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 21);
            this.button2.TabIndex = 15;
            this.button2.Text = "Agregar Equipo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ListarJugadores
            // 
            this.ListarJugadores.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListarJugadores.Location = new System.Drawing.Point(233, 252);
            this.ListarJugadores.Name = "ListarJugadores";
            this.ListarJugadores.Size = new System.Drawing.Size(157, 46);
            this.ListarJugadores.TabIndex = 16;
            this.ListarJugadores.Text = "Lista Jugadores";
            this.ListarJugadores.UseVisualStyleBackColor = true;
            this.ListarJugadores.Click += new System.EventHandler(this.ListarJugadores_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(466, 323);
            this.Controls.Add(this.ListarJugadores);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Fecha);
            this.Controls.Add(this.golesAnotados);
            this.Controls.Add(this.equipoContrario);
            this.Controls.Add(this.fechaJuego);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.equipoJugador);
            this.Controls.Add(this.numeroJugador);
            this.Controls.Add(this.nombreJugador);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.golesAnotados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nombreJugador;
        private System.Windows.Forms.TextBox numeroJugador;
        private System.Windows.Forms.ComboBox equipoJugador;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker fechaJuego;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ComboBox equipoContrario;
        private System.Windows.Forms.NumericUpDown golesAnotados;
        private System.Windows.Forms.Label Fecha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button ListarJugadores;
    }
}

