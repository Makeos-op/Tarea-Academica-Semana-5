namespace Tarea_Académica_Semana_5
{
    partial class FormVideojuego
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.dgVideojuegos = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.btnAñadirJugador = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAscendente = new System.Windows.Forms.Button();
            this.btnDescendente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgVideojuegos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(346, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registro de Videojuego";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Codigo";
            // 
            // tbCodigo
            // 
            this.tbCodigo.Location = new System.Drawing.Point(45, 297);
            this.tbCodigo.Multiline = true;
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(338, 45);
            this.tbCodigo.TabIndex = 4;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(45, 381);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(338, 45);
            this.btnRegistrar.TabIndex = 6;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // dgVideojuegos
            // 
            this.dgVideojuegos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVideojuegos.Location = new System.Drawing.Point(459, 156);
            this.dgVideojuegos.Name = "dgVideojuegos";
            this.dgVideojuegos.RowHeadersWidth = 51;
            this.dgVideojuegos.RowTemplate.Height = 24;
            this.dgVideojuegos.Size = new System.Drawing.Size(572, 291);
            this.dgVideojuegos.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(453, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(265, 31);
            this.label4.TabIndex = 9;
            this.label4.Text = "Lista de Videojuegos";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(45, 197);
            this.tbNombre.Multiline = true;
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(338, 45);
            this.tbNombre.TabIndex = 3;
            // 
            // btnAñadirJugador
            // 
            this.btnAñadirJugador.Location = new System.Drawing.Point(904, 121);
            this.btnAñadirJugador.Name = "btnAñadirJugador";
            this.btnAñadirJugador.Size = new System.Drawing.Size(127, 29);
            this.btnAñadirJugador.TabIndex = 10;
            this.btnAñadirJugador.Text = "Añadir Jugador";
            this.btnAñadirJugador.UseVisualStyleBackColor = true;
            this.btnAñadirJugador.Click += new System.EventHandler(this.btnAñadirJugador_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(151, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 31);
            this.label5.TabIndex = 11;
            this.label5.Text = "Registro";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAscendente
            // 
            this.btnAscendente.Location = new System.Drawing.Point(459, 454);
            this.btnAscendente.Name = "btnAscendente";
            this.btnAscendente.Size = new System.Drawing.Size(89, 23);
            this.btnAscendente.TabIndex = 12;
            this.btnAscendente.Text = "Ascendente";
            this.btnAscendente.UseVisualStyleBackColor = true;
            this.btnAscendente.Click += new System.EventHandler(this.btnAscendente_Click);
            // 
            // btnDescendente
            // 
            this.btnDescendente.Location = new System.Drawing.Point(554, 453);
            this.btnDescendente.Name = "btnDescendente";
            this.btnDescendente.Size = new System.Drawing.Size(100, 23);
            this.btnDescendente.TabIndex = 13;
            this.btnDescendente.Text = "Descendente";
            this.btnDescendente.UseVisualStyleBackColor = true;
            this.btnDescendente.Click += new System.EventHandler(this.btnDescendente_Click);
            // 
            // FormVideojuego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 499);
            this.Controls.Add(this.btnDescendente);
            this.Controls.Add(this.btnAscendente);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAñadirJugador);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgVideojuegos);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.tbCodigo);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormVideojuego";
            this.Text = "Tarea Académica Semana 5";
            ((System.ComponentModel.ISupportInitialize)(this.dgVideojuegos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.DataGridView dgVideojuegos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Button btnAñadirJugador;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAscendente;
        private System.Windows.Forms.Button btnDescendente;
    }
}