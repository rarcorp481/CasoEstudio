namespace BibliotecaDigital
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.tabControlPrincipal = new System.Windows.Forms.TabControl();
            this.tabDatos = new System.Windows.Forms.TabPage();
            this.grpAutores = new System.Windows.Forms.GroupBox();
            this.dgvAutores = new System.Windows.Forms.DataGridView();
            this.grpLibros = new System.Windows.Forms.GroupBox();
            this.dgvLibros = new System.Windows.Forms.DataGridView();
            this.tabLineal = new System.Windows.Forms.TabPage();
            this.lblResultadoLineal = new System.Windows.Forms.Label();
            this.btnBusquedaLineal = new System.Windows.Forms.Button();
            this.txtBusquedaLineal = new System.Windows.Forms.TextBox();
            this.lblInstruccionLineal = new System.Windows.Forms.Label();
            this.tabBinaria = new System.Windows.Forms.TabPage();
            this.lblNotaBinaria = new System.Windows.Forms.Label();
            this.lblResultadoBinaria = new System.Windows.Forms.Label();
            this.btnBusquedaBinaria = new System.Windows.Forms.Button();
            this.txtBusquedaBinaria = new System.Windows.Forms.TextBox();
            this.lblInstruccionBinaria = new System.Windows.Forms.Label();
            this.tabAnalisis = new System.Windows.Forms.TabPage();
            this.btnAnalizarAnio = new System.Windows.Forms.Button();
            this.grpResultadosAnalisis = new System.Windows.Forms.GroupBox();
            this.lblLibroReciente = new System.Windows.Forms.Label();
            this.lblLibroAntiguo = new System.Windows.Forms.Label();
            this.tabDescripcion = new System.Windows.Forms.TabPage();
            this.lstResultadosDescripcion = new System.Windows.Forms.ListBox();
            this.btnBuscarDescripcion = new System.Windows.Forms.Button();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblInstruccionDesc = new System.Windows.Forms.Label();
            this.tabControlPrincipal.SuspendLayout();
            this.tabDatos.SuspendLayout();
            this.grpAutores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutores)).BeginInit();
            this.grpLibros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).BeginInit();
            this.tabLineal.SuspendLayout();
            this.tabBinaria.SuspendLayout();
            this.tabAnalisis.SuspendLayout();
            this.grpResultadosAnalisis.SuspendLayout();
            this.tabDescripcion.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlPrincipal
            // 
            this.tabControlPrincipal.Controls.Add(this.tabDatos);
            this.tabControlPrincipal.Controls.Add(this.tabLineal);
            this.tabControlPrincipal.Controls.Add(this.tabBinaria);
            this.tabControlPrincipal.Controls.Add(this.tabAnalisis);
            this.tabControlPrincipal.Controls.Add(this.tabDescripcion);
            this.tabControlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tabControlPrincipal.Name = "tabControlPrincipal";
            this.tabControlPrincipal.SelectedIndex = 0;
            this.tabControlPrincipal.Size = new System.Drawing.Size(800, 500);
            this.tabControlPrincipal.TabIndex = 0;
            // 
            // tabDatos
            // 
            this.tabDatos.Controls.Add(this.grpAutores);
            this.tabDatos.Controls.Add(this.grpLibros);
            this.tabDatos.Location = new System.Drawing.Point(4, 24);
            this.tabDatos.Name = "tabDatos";
            this.tabDatos.Padding = new System.Windows.Forms.Padding(10);
            this.tabDatos.Size = new System.Drawing.Size(792, 472);
            this.tabDatos.TabIndex = 0;
            this.tabDatos.Text = "Base de Datos";
            this.tabDatos.UseVisualStyleBackColor = true;
            // 
            // grpAutores
            // 
            this.grpAutores.Controls.Add(this.dgvAutores);
            this.grpAutores.Location = new System.Drawing.Point(400, 13);
            this.grpAutores.Name = "grpAutores";
            this.grpAutores.Size = new System.Drawing.Size(380, 446);
            this.grpAutores.TabIndex = 1;
            this.grpAutores.TabStop = false;
            this.grpAutores.Text = "Autores Registrados (Ordenados)";
            // 
            // dgvAutores
            // 
            this.dgvAutores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAutores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAutores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAutores.Location = new System.Drawing.Point(3, 19);
            this.dgvAutores.Name = "dgvAutores";
            this.dgvAutores.RowHeadersVisible = false;
            this.dgvAutores.Size = new System.Drawing.Size(374, 424);
            this.dgvAutores.TabIndex = 0;
            // 
            // grpLibros
            // 
            this.grpLibros.Controls.Add(this.dgvLibros);
            this.grpLibros.Location = new System.Drawing.Point(13, 13);
            this.grpLibros.Name = "grpLibros";
            this.grpLibros.Size = new System.Drawing.Size(380, 446);
            this.grpLibros.TabIndex = 0;
            this.grpLibros.TabStop = false;
            this.grpLibros.Text = "Libros Disponibles";
            // 
            // dgvLibros
            // 
            this.dgvLibros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLibros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLibros.Location = new System.Drawing.Point(3, 19);
            this.dgvLibros.Name = "dgvLibros";
            this.dgvLibros.RowHeadersVisible = false;
            this.dgvLibros.Size = new System.Drawing.Size(374, 424);
            this.dgvLibros.TabIndex = 0;
            // 
            // tabLineal
            // 
            this.tabLineal.Controls.Add(this.lblResultadoLineal);
            this.tabLineal.Controls.Add(this.btnBusquedaLineal);
            this.tabLineal.Controls.Add(this.txtBusquedaLineal);
            this.tabLineal.Controls.Add(this.lblInstruccionLineal);
            this.tabLineal.Location = new System.Drawing.Point(4, 24);
            this.tabLineal.Name = "tabLineal";
            this.tabLineal.Padding = new System.Windows.Forms.Padding(30);
            this.tabLineal.Size = new System.Drawing.Size(792, 472);
            this.tabLineal.TabIndex = 1;
            this.tabLineal.Text = "Búsqueda Lineal (Libros)";
            this.tabLineal.UseVisualStyleBackColor = true;
            // 
            // lblResultadoLineal
            // 
            this.lblResultadoLineal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblResultadoLineal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResultadoLineal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblResultadoLineal.Location = new System.Drawing.Point(33, 150);
            this.lblResultadoLineal.Name = "lblResultadoLineal";
            this.lblResultadoLineal.Padding = new System.Windows.Forms.Padding(10);
            this.lblResultadoLineal.Size = new System.Drawing.Size(726, 100);
            this.lblResultadoLineal.TabIndex = 3;
            this.lblResultadoLineal.Text = "Los resultados aparecerán aquí...";
            this.lblResultadoLineal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBusquedaLineal
            // 
            this.btnBusquedaLineal.BackColor = System.Drawing.Color.SteelBlue;
            this.btnBusquedaLineal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBusquedaLineal.ForeColor = System.Drawing.Color.White;
            this.btnBusquedaLineal.Location = new System.Drawing.Point(539, 78);
            this.btnBusquedaLineal.Name = "btnBusquedaLineal";
            this.btnBusquedaLineal.Size = new System.Drawing.Size(120, 29);
            this.btnBusquedaLineal.TabIndex = 2;
            this.btnBusquedaLineal.Text = "Buscar";
            this.btnBusquedaLineal.UseVisualStyleBackColor = false;
            this.btnBusquedaLineal.Click += new System.EventHandler(this.btnBusquedaLineal_Click);
            // 
            // txtBusquedaLineal
            // 
            this.txtBusquedaLineal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBusquedaLineal.Location = new System.Drawing.Point(133, 78);
            this.txtBusquedaLineal.Name = "txtBusquedaLineal";
            this.txtBusquedaLineal.PlaceholderText = "Ingrese el nombre del libro exacto...";
            this.txtBusquedaLineal.Size = new System.Drawing.Size(400, 29);
            this.txtBusquedaLineal.TabIndex = 1;
            // 
            // lblInstruccionLineal
            // 
            this.lblInstruccionLineal.AutoSize = true;
            this.lblInstruccionLineal.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblInstruccionLineal.Location = new System.Drawing.Point(133, 30);
            this.lblInstruccionLineal.Name = "lblInstruccionLineal";
            this.lblInstruccionLineal.Size = new System.Drawing.Size(306, 25);
            this.lblInstruccionLineal.TabIndex = 0;
            this.lblInstruccionLineal.Text = "Búsqueda Lineal: Encontrar Libro";
            // 
            // tabBinaria
            // 
            this.tabBinaria.Controls.Add(this.lblNotaBinaria);
            this.tabBinaria.Controls.Add(this.lblResultadoBinaria);
            this.tabBinaria.Controls.Add(this.btnBusquedaBinaria);
            this.tabBinaria.Controls.Add(this.txtBusquedaBinaria);
            this.tabBinaria.Controls.Add(this.lblInstruccionBinaria);
            this.tabBinaria.Location = new System.Drawing.Point(4, 24);
            this.tabBinaria.Name = "tabBinaria";
            this.tabBinaria.Size = new System.Drawing.Size(792, 472);
            this.tabBinaria.TabIndex = 2;
            this.tabBinaria.Text = "Búsqueda Binaria (Autores)";
            this.tabBinaria.UseVisualStyleBackColor = true;
            // 
            // lblNotaBinaria
            // 
            this.lblNotaBinaria.AutoSize = true;
            this.lblNotaBinaria.ForeColor = System.Drawing.Color.DimGray;
            this.lblNotaBinaria.Location = new System.Drawing.Point(133, 55);
            this.lblNotaBinaria.Name = "lblNotaBinaria";
            this.lblNotaBinaria.Size = new System.Drawing.Size(309, 15);
            this.lblNotaBinaria.TabIndex = 4;
            this.lblNotaBinaria.Text = "* Requiere que la lista esté ordenada alfabéticamente.";
            // 
            // lblResultadoBinaria
            // 
            this.lblResultadoBinaria.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblResultadoBinaria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResultadoBinaria.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblResultadoBinaria.Location = new System.Drawing.Point(33, 150);
            this.lblResultadoBinaria.Name = "lblResultadoBinaria";
            this.lblResultadoBinaria.Padding = new System.Windows.Forms.Padding(10);
            this.lblResultadoBinaria.Size = new System.Drawing.Size(726, 100);
            this.lblResultadoBinaria.TabIndex = 3;
            this.lblResultadoBinaria.Text = "Los resultados aparecerán aquí...";
            this.lblResultadoBinaria.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBusquedaBinaria
            // 
            this.btnBusquedaBinaria.BackColor = System.Drawing.Color.SeaGreen;
            this.btnBusquedaBinaria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBusquedaBinaria.ForeColor = System.Drawing.Color.White;
            this.btnBusquedaBinaria.Location = new System.Drawing.Point(539, 85);
            this.btnBusquedaBinaria.Name = "btnBusquedaBinaria";
            this.btnBusquedaBinaria.Size = new System.Drawing.Size(120, 29);
            this.btnBusquedaBinaria.TabIndex = 2;
            this.btnBusquedaBinaria.Text = "Buscar Binario";
            this.btnBusquedaBinaria.UseVisualStyleBackColor = false;
            this.btnBusquedaBinaria.Click += new System.EventHandler(this.btnBusquedaBinaria_Click);
            // 
            // txtBusquedaBinaria
            // 
            this.txtBusquedaBinaria.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBusquedaBinaria.Location = new System.Drawing.Point(133, 85);
            this.txtBusquedaBinaria.Name = "txtBusquedaBinaria";
            this.txtBusquedaBinaria.PlaceholderText = "Ingrese el nombre del autor...";
            this.txtBusquedaBinaria.Size = new System.Drawing.Size(400, 29);
            this.txtBusquedaBinaria.TabIndex = 1;
            // 
            // lblInstruccionBinaria
            // 
            this.lblInstruccionBinaria.AutoSize = true;
            this.lblInstruccionBinaria.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblInstruccionBinaria.Location = new System.Drawing.Point(133, 30);
            this.lblInstruccionBinaria.Name = "lblInstruccionBinaria";
            this.lblInstruccionBinaria.Size = new System.Drawing.Size(320, 25);
            this.lblInstruccionBinaria.TabIndex = 0;
            this.lblInstruccionBinaria.Text = "Búsqueda Binaria: Encontrar Autor";
            // 
            // tabAnalisis
            // 
            this.tabAnalisis.Controls.Add(this.btnAnalizarAnio);
            this.tabAnalisis.Controls.Add(this.grpResultadosAnalisis);
            this.tabAnalisis.Location = new System.Drawing.Point(4, 24);
            this.tabAnalisis.Name = "tabAnalisis";
            this.tabAnalisis.Size = new System.Drawing.Size(792, 472);
            this.tabAnalisis.TabIndex = 3;
            this.tabAnalisis.Text = "Análisis (Antiguo/Reciente)";
            this.tabAnalisis.UseVisualStyleBackColor = true;
            // 
            // btnAnalizarAnio
            // 
            this.btnAnalizarAnio.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnAnalizarAnio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnalizarAnio.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAnalizarAnio.ForeColor = System.Drawing.Color.White;
            this.btnAnalizarAnio.Location = new System.Drawing.Point(246, 60);
            this.btnAnalizarAnio.Name = "btnAnalizarAnio";
            this.btnAnalizarAnio.Size = new System.Drawing.Size(300, 50);
            this.btnAnalizarAnio.TabIndex = 1;
            this.btnAnalizarAnio.Text = "Analizar Colección";
            this.btnAnalizarAnio.UseVisualStyleBackColor = false;
            this.btnAnalizarAnio.Click += new System.EventHandler(this.btnAnalizarAnio_Click);
            // 
            // grpResultadosAnalisis
            // 
            this.grpResultadosAnalisis.Controls.Add(this.lblLibroReciente);
            this.grpResultadosAnalisis.Controls.Add(this.lblLibroAntiguo);
            this.grpResultadosAnalisis.Location = new System.Drawing.Point(96, 140);
            this.grpResultadosAnalisis.Name = "grpResultadosAnalisis";
            this.grpResultadosAnalisis.Size = new System.Drawing.Size(600, 250);
            this.grpResultadosAnalisis.TabIndex = 0;
            this.grpResultadosAnalisis.TabStop = false;
            this.grpResultadosAnalisis.Text = "Resultados del Análisis";
            // 
            // lblLibroReciente
            // 
            this.lblLibroReciente.BackColor = System.Drawing.Color.Honeydew;
            this.lblLibroReciente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLibroReciente.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLibroReciente.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblLibroReciente.Location = new System.Drawing.Point(310, 50);
            this.lblLibroReciente.Name = "lblLibroReciente";
            this.lblLibroReciente.Padding = new System.Windows.Forms.Padding(10);
            this.lblLibroReciente.Size = new System.Drawing.Size(250, 150);
            this.lblLibroReciente.TabIndex = 1;
            this.lblLibroReciente.Text = "Más Reciente: \n---";
            this.lblLibroReciente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLibroAntiguo
            // 
            this.lblLibroAntiguo.BackColor = System.Drawing.Color.MistyRose;
            this.lblLibroAntiguo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLibroAntiguo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLibroAntiguo.ForeColor = System.Drawing.Color.Maroon;
            this.lblLibroAntiguo.Location = new System.Drawing.Point(40, 50);
            this.lblLibroAntiguo.Name = "lblLibroAntiguo";
            this.lblLibroAntiguo.Padding = new System.Windows.Forms.Padding(10);
            this.lblLibroAntiguo.Size = new System.Drawing.Size(250, 150);
            this.lblLibroAntiguo.TabIndex = 0;
            this.lblLibroAntiguo.Text = "Más Antiguo: \n---";
            this.lblLibroAntiguo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabDescripcion
            // 
            this.tabDescripcion.Controls.Add(this.lstResultadosDescripcion);
            this.tabDescripcion.Controls.Add(this.btnBuscarDescripcion);
            this.tabDescripcion.Controls.Add(this.txtDescripcion);
            this.tabDescripcion.Controls.Add(this.lblInstruccionDesc);
            this.tabDescripcion.Location = new System.Drawing.Point(4, 24);
            this.tabDescripcion.Name = "tabDescripcion";
            this.tabDescripcion.Size = new System.Drawing.Size(792, 472);
            this.tabDescripcion.TabIndex = 4;
            this.tabDescripcion.Text = "Buscar en Descripción";
            this.tabDescripcion.UseVisualStyleBackColor = true;
            // 
            // lstResultadosDescripcion
            // 
            this.lstResultadosDescripcion.FormattingEnabled = true;
            this.lstResultadosDescripcion.ItemHeight = 15;
            this.lstResultadosDescripcion.Location = new System.Drawing.Point(133, 130);
            this.lstResultadosDescripcion.Name = "lstResultadosDescripcion";
            this.lstResultadosDescripcion.Size = new System.Drawing.Size(526, 289);
            this.lstResultadosDescripcion.TabIndex = 3;
            // 
            // btnBuscarDescripcion
            // 
            this.btnBuscarDescripcion.BackColor = System.Drawing.Color.SlateGray;
            this.btnBuscarDescripcion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarDescripcion.ForeColor = System.Drawing.Color.White;
            this.btnBuscarDescripcion.Location = new System.Drawing.Point(539, 80);
            this.btnBuscarDescripcion.Name = "btnBuscarDescripcion";
            this.btnBuscarDescripcion.Size = new System.Drawing.Size(120, 29);
            this.btnBuscarDescripcion.TabIndex = 2;
            this.btnBuscarDescripcion.Text = "Buscar Texto";
            this.btnBuscarDescripcion.UseVisualStyleBackColor = false;
            this.btnBuscarDescripcion.Click += new System.EventHandler(this.btnBuscarDescripcion_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDescripcion.Location = new System.Drawing.Point(133, 80);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.PlaceholderText = "Palabra clave (ej. soledad, política, amor)...";
            this.txtDescripcion.Size = new System.Drawing.Size(400, 29);
            this.txtDescripcion.TabIndex = 1;
            // 
            // lblInstruccionDesc
            // 
            this.lblInstruccionDesc.AutoSize = true;
            this.lblInstruccionDesc.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblInstruccionDesc.Location = new System.Drawing.Point(133, 30);
            this.lblInstruccionDesc.Name = "lblInstruccionDesc";
            this.lblInstruccionDesc.Size = new System.Drawing.Size(325, 25);
            this.lblInstruccionDesc.TabIndex = 0;
            this.lblInstruccionDesc.Text = "Búsqueda Parcial en Descripciones";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.tabControlPrincipal);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Búsqueda Bibliotecaria";
            this.tabControlPrincipal.ResumeLayout(false);
            this.tabDatos.ResumeLayout(false);
            this.grpAutores.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutores)).EndInit();
            this.grpLibros.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).EndInit();
            this.tabLineal.ResumeLayout(false);
            this.tabLineal.PerformLayout();
            this.tabBinaria.ResumeLayout(false);
            this.tabBinaria.PerformLayout();
            this.tabAnalisis.ResumeLayout(false);
            this.grpResultadosAnalisis.ResumeLayout(false);
            this.tabDescripcion.ResumeLayout(false);
            this.tabDescripcion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlPrincipal;
        private System.Windows.Forms.TabPage tabDatos;
        private System.Windows.Forms.GroupBox grpAutores;
        private System.Windows.Forms.DataGridView dgvAutores;
        private System.Windows.Forms.GroupBox grpLibros;
        private System.Windows.Forms.DataGridView dgvLibros;
        private System.Windows.Forms.TabPage tabLineal;
        private System.Windows.Forms.TabPage tabBinaria;
        private System.Windows.Forms.TabPage tabAnalisis;
        private System.Windows.Forms.TabPage tabDescripcion;
        private System.Windows.Forms.Label lblResultadoLineal;
        private System.Windows.Forms.Button btnBusquedaLineal;
        private System.Windows.Forms.TextBox txtBusquedaLineal;
        private System.Windows.Forms.Label lblInstruccionLineal;
        private System.Windows.Forms.Label lblNotaBinaria;
        private System.Windows.Forms.Label lblResultadoBinaria;
        private System.Windows.Forms.Button btnBusquedaBinaria;
        private System.Windows.Forms.TextBox txtBusquedaBinaria;
        private System.Windows.Forms.Label lblInstruccionBinaria;
        private System.Windows.Forms.Button btnAnalizarAnio;
        private System.Windows.Forms.GroupBox grpResultadosAnalisis;
        private System.Windows.Forms.Label lblLibroReciente;
        private System.Windows.Forms.Label lblLibroAntiguo;
        private System.Windows.Forms.ListBox lstResultadosDescripcion;
        private System.Windows.Forms.Button btnBuscarDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblInstruccionDesc;
    }
}