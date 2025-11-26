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
            tabControlPrincipal = new TabControl();
            tabDatos = new TabPage();
            grpAutores = new GroupBox();
            dgvAutores = new DataGridView();
            grpLibros = new GroupBox();
            dgvLibros = new DataGridView();
            tabLineal = new TabPage();
            lblResultadoLineal = new Label();
            btnBusquedaLineal = new Button();
            txtBusquedaLineal = new TextBox();
            lblInstruccionLineal = new Label();
            tabBinaria = new TabPage();
            lblNotaBinaria = new Label();
            lblResultadoBinaria = new Label();
            btnBusquedaBinaria = new Button();
            txtBusquedaBinaria = new TextBox();
            lblInstruccionBinaria = new Label();
            tabAnalisis = new TabPage();
            btnAnalizarAnio = new Button();
            grpResultadosAnalisis = new GroupBox();
            lblLibroReciente = new Label();
            lblLibroAntiguo = new Label();
            tabDescripcion = new TabPage();
            lstResultadosDescripcion = new ListBox();
            btnBuscarDescripcion = new Button();
            txtDescripcion = new TextBox();
            lblInstruccionDesc = new Label();
            tabControlPrincipal.SuspendLayout();
            tabDatos.SuspendLayout();
            grpAutores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAutores).BeginInit();
            grpLibros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLibros).BeginInit();
            tabLineal.SuspendLayout();
            tabBinaria.SuspendLayout();
            tabAnalisis.SuspendLayout();
            grpResultadosAnalisis.SuspendLayout();
            tabDescripcion.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlPrincipal
            // 
            tabControlPrincipal.Controls.Add(tabDatos);
            tabControlPrincipal.Controls.Add(tabLineal);
            tabControlPrincipal.Controls.Add(tabBinaria);
            tabControlPrincipal.Controls.Add(tabAnalisis);
            tabControlPrincipal.Controls.Add(tabDescripcion);
            tabControlPrincipal.Dock = DockStyle.Fill;
            tabControlPrincipal.Location = new Point(0, 0);
            tabControlPrincipal.Margin = new Padding(3, 4, 3, 4);
            tabControlPrincipal.Name = "tabControlPrincipal";
            tabControlPrincipal.SelectedIndex = 0;
            tabControlPrincipal.Size = new Size(914, 667);
            tabControlPrincipal.TabIndex = 0;
            // 
            // tabDatos
            // 
            tabDatos.Controls.Add(grpAutores);
            tabDatos.Controls.Add(grpLibros);
            tabDatos.Location = new Point(4, 29);
            tabDatos.Margin = new Padding(3, 4, 3, 4);
            tabDatos.Name = "tabDatos";
            tabDatos.Padding = new Padding(11, 13, 11, 13);
            tabDatos.Size = new Size(906, 634);
            tabDatos.TabIndex = 0;
            tabDatos.Text = "Base de Datos";
            tabDatos.UseVisualStyleBackColor = true;
            // 
            // grpAutores
            // 
            grpAutores.Controls.Add(dgvAutores);
            grpAutores.Location = new Point(457, 17);
            grpAutores.Margin = new Padding(3, 4, 3, 4);
            grpAutores.Name = "grpAutores";
            grpAutores.Padding = new Padding(3, 4, 3, 4);
            grpAutores.Size = new Size(434, 595);
            grpAutores.TabIndex = 1;
            grpAutores.TabStop = false;
            grpAutores.Text = "Autores Registrados (Ordenados)";
            // 
            // dgvAutores
            // 
            dgvAutores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAutores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAutores.Dock = DockStyle.Fill;
            dgvAutores.Location = new Point(3, 24);
            dgvAutores.Margin = new Padding(3, 4, 3, 4);
            dgvAutores.Name = "dgvAutores";
            dgvAutores.RowHeadersVisible = false;
            dgvAutores.RowHeadersWidth = 51;
            dgvAutores.Size = new Size(428, 567);
            dgvAutores.TabIndex = 0;
            // 
            // grpLibros
            // 
            grpLibros.Controls.Add(dgvLibros);
            grpLibros.Location = new Point(15, 17);
            grpLibros.Margin = new Padding(3, 4, 3, 4);
            grpLibros.Name = "grpLibros";
            grpLibros.Padding = new Padding(3, 4, 3, 4);
            grpLibros.Size = new Size(434, 595);
            grpLibros.TabIndex = 0;
            grpLibros.TabStop = false;
            grpLibros.Text = "Libros Disponibles";
            // 
            // dgvLibros
            // 
            dgvLibros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLibros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLibros.Dock = DockStyle.Fill;
            dgvLibros.Location = new Point(3, 24);
            dgvLibros.Margin = new Padding(3, 4, 3, 4);
            dgvLibros.Name = "dgvLibros";
            dgvLibros.RowHeadersVisible = false;
            dgvLibros.RowHeadersWidth = 51;
            dgvLibros.Size = new Size(428, 567);
            dgvLibros.TabIndex = 0;
            // 
            // tabLineal
            // 
            tabLineal.Controls.Add(lblResultadoLineal);
            tabLineal.Controls.Add(btnBusquedaLineal);
            tabLineal.Controls.Add(txtBusquedaLineal);
            tabLineal.Controls.Add(lblInstruccionLineal);
            tabLineal.Location = new Point(4, 29);
            tabLineal.Margin = new Padding(3, 4, 3, 4);
            tabLineal.Name = "tabLineal";
            tabLineal.Padding = new Padding(34, 40, 34, 40);
            tabLineal.Size = new Size(906, 634);
            tabLineal.TabIndex = 1;
            tabLineal.Text = "Búsqueda Lineal (Libros)";
            tabLineal.UseVisualStyleBackColor = true;
            // 
            // lblResultadoLineal
            // 
            lblResultadoLineal.BackColor = Color.WhiteSmoke;
            lblResultadoLineal.BorderStyle = BorderStyle.FixedSingle;
            lblResultadoLineal.Font = new Font("Segoe UI", 12F);
            lblResultadoLineal.Location = new Point(38, 200);
            lblResultadoLineal.Name = "lblResultadoLineal";
            lblResultadoLineal.Padding = new Padding(11, 13, 11, 13);
            lblResultadoLineal.Size = new Size(829, 133);
            lblResultadoLineal.TabIndex = 3;
            lblResultadoLineal.Text = "Los resultados aparecerán aquí...";
            lblResultadoLineal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnBusquedaLineal
            // 
            btnBusquedaLineal.BackColor = Color.SteelBlue;
            btnBusquedaLineal.FlatStyle = FlatStyle.Flat;
            btnBusquedaLineal.ForeColor = Color.White;
            btnBusquedaLineal.Location = new Point(616, 104);
            btnBusquedaLineal.Margin = new Padding(3, 4, 3, 4);
            btnBusquedaLineal.Name = "btnBusquedaLineal";
            btnBusquedaLineal.Size = new Size(137, 39);
            btnBusquedaLineal.TabIndex = 2;
            btnBusquedaLineal.Text = "Buscar";
            btnBusquedaLineal.UseVisualStyleBackColor = false;
            btnBusquedaLineal.Click += btnBusquedaLineal_Click;
            // 
            // txtBusquedaLineal
            // 
            txtBusquedaLineal.Font = new Font("Segoe UI", 12F);
            txtBusquedaLineal.Location = new Point(152, 104);
            txtBusquedaLineal.Margin = new Padding(3, 4, 3, 4);
            txtBusquedaLineal.Name = "txtBusquedaLineal";
            txtBusquedaLineal.PlaceholderText = "Ingrese el nombre del libro exacto...";
            txtBusquedaLineal.Size = new Size(457, 34);
            txtBusquedaLineal.TabIndex = 1;
            // 
            // lblInstruccionLineal
            // 
            lblInstruccionLineal.AutoSize = true;
            lblInstruccionLineal.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblInstruccionLineal.Location = new Point(152, 40);
            lblInstruccionLineal.Name = "lblInstruccionLineal";
            lblInstruccionLineal.Size = new Size(392, 32);
            lblInstruccionLineal.TabIndex = 0;
            lblInstruccionLineal.Text = "Búsqueda Lineal: Encontrar Libro";
            // 
            // tabBinaria
            // 
            tabBinaria.Controls.Add(lblNotaBinaria);
            tabBinaria.Controls.Add(lblResultadoBinaria);
            tabBinaria.Controls.Add(btnBusquedaBinaria);
            tabBinaria.Controls.Add(txtBusquedaBinaria);
            tabBinaria.Controls.Add(lblInstruccionBinaria);
            tabBinaria.Location = new Point(4, 29);
            tabBinaria.Margin = new Padding(3, 4, 3, 4);
            tabBinaria.Name = "tabBinaria";
            tabBinaria.Size = new Size(906, 634);
            tabBinaria.TabIndex = 2;
            tabBinaria.Text = "Búsqueda Binaria (Autores)";
            tabBinaria.UseVisualStyleBackColor = true;
            // 
            // lblNotaBinaria
            // 
            lblNotaBinaria.AutoSize = true;
            lblNotaBinaria.ForeColor = Color.DimGray;
            lblNotaBinaria.Location = new Point(152, 73);
            lblNotaBinaria.Name = "lblNotaBinaria";
            lblNotaBinaria.Size = new Size(368, 20);
            lblNotaBinaria.TabIndex = 4;
            lblNotaBinaria.Text = "* Requiere que la lista esté ordenada alfabéticamente.";
            // 
            // lblResultadoBinaria
            // 
            lblResultadoBinaria.BackColor = Color.WhiteSmoke;
            lblResultadoBinaria.BorderStyle = BorderStyle.FixedSingle;
            lblResultadoBinaria.Font = new Font("Segoe UI", 12F);
            lblResultadoBinaria.Location = new Point(38, 200);
            lblResultadoBinaria.Name = "lblResultadoBinaria";
            lblResultadoBinaria.Padding = new Padding(11, 13, 11, 13);
            lblResultadoBinaria.Size = new Size(829, 133);
            lblResultadoBinaria.TabIndex = 3;
            lblResultadoBinaria.Text = "Los resultados aparecerán aquí...";
            lblResultadoBinaria.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnBusquedaBinaria
            // 
            btnBusquedaBinaria.BackColor = Color.SeaGreen;
            btnBusquedaBinaria.FlatStyle = FlatStyle.Flat;
            btnBusquedaBinaria.ForeColor = Color.White;
            btnBusquedaBinaria.Location = new Point(616, 113);
            btnBusquedaBinaria.Margin = new Padding(3, 4, 3, 4);
            btnBusquedaBinaria.Name = "btnBusquedaBinaria";
            btnBusquedaBinaria.Size = new Size(137, 39);
            btnBusquedaBinaria.TabIndex = 2;
            btnBusquedaBinaria.Text = "Buscar Binario";
            btnBusquedaBinaria.UseVisualStyleBackColor = false;
            btnBusquedaBinaria.Click += btnBusquedaBinaria_Click;
            // 
            // txtBusquedaBinaria
            // 
            txtBusquedaBinaria.Font = new Font("Segoe UI", 12F);
            txtBusquedaBinaria.Location = new Point(152, 113);
            txtBusquedaBinaria.Margin = new Padding(3, 4, 3, 4);
            txtBusquedaBinaria.Name = "txtBusquedaBinaria";
            txtBusquedaBinaria.PlaceholderText = "Ingrese el nombre del autor...";
            txtBusquedaBinaria.Size = new Size(457, 34);
            txtBusquedaBinaria.TabIndex = 1;
            // 
            // lblInstruccionBinaria
            // 
            lblInstruccionBinaria.AutoSize = true;
            lblInstruccionBinaria.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblInstruccionBinaria.Location = new Point(152, 40);
            lblInstruccionBinaria.Name = "lblInstruccionBinaria";
            lblInstruccionBinaria.Size = new Size(412, 32);
            lblInstruccionBinaria.TabIndex = 0;
            lblInstruccionBinaria.Text = "Búsqueda Binaria: Encontrar Autor";
            // 
            // tabAnalisis
            // 
            tabAnalisis.Controls.Add(btnAnalizarAnio);
            tabAnalisis.Controls.Add(grpResultadosAnalisis);
            tabAnalisis.Location = new Point(4, 29);
            tabAnalisis.Margin = new Padding(3, 4, 3, 4);
            tabAnalisis.Name = "tabAnalisis";
            tabAnalisis.Size = new Size(906, 634);
            tabAnalisis.TabIndex = 3;
            tabAnalisis.Text = "Análisis (Antiguo/Reciente)";
            tabAnalisis.UseVisualStyleBackColor = true;
            // 
            // btnAnalizarAnio
            // 
            btnAnalizarAnio.BackColor = Color.DarkSlateBlue;
            btnAnalizarAnio.FlatStyle = FlatStyle.Flat;
            btnAnalizarAnio.Font = new Font("Segoe UI", 12F);
            btnAnalizarAnio.ForeColor = Color.White;
            btnAnalizarAnio.Location = new Point(281, 80);
            btnAnalizarAnio.Margin = new Padding(3, 4, 3, 4);
            btnAnalizarAnio.Name = "btnAnalizarAnio";
            btnAnalizarAnio.Size = new Size(343, 67);
            btnAnalizarAnio.TabIndex = 1;
            btnAnalizarAnio.Text = "Analizar Colección";
            btnAnalizarAnio.UseVisualStyleBackColor = false;
            btnAnalizarAnio.Click += btnAnalizarAnio_Click;
            // 
            // grpResultadosAnalisis
            // 
            grpResultadosAnalisis.Controls.Add(lblLibroReciente);
            grpResultadosAnalisis.Controls.Add(lblLibroAntiguo);
            grpResultadosAnalisis.Location = new Point(110, 187);
            grpResultadosAnalisis.Margin = new Padding(3, 4, 3, 4);
            grpResultadosAnalisis.Name = "grpResultadosAnalisis";
            grpResultadosAnalisis.Padding = new Padding(3, 4, 3, 4);
            grpResultadosAnalisis.Size = new Size(686, 333);
            grpResultadosAnalisis.TabIndex = 0;
            grpResultadosAnalisis.TabStop = false;
            grpResultadosAnalisis.Text = "Resultados del Análisis";
            // 
            // lblLibroReciente
            // 
            lblLibroReciente.BackColor = Color.Honeydew;
            lblLibroReciente.BorderStyle = BorderStyle.FixedSingle;
            lblLibroReciente.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblLibroReciente.ForeColor = Color.DarkGreen;
            lblLibroReciente.Location = new Point(354, 67);
            lblLibroReciente.Name = "lblLibroReciente";
            lblLibroReciente.Padding = new Padding(11, 13, 11, 13);
            lblLibroReciente.Size = new Size(285, 199);
            lblLibroReciente.TabIndex = 1;
            lblLibroReciente.Text = "Más Reciente: \n---";
            lblLibroReciente.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLibroAntiguo
            // 
            lblLibroAntiguo.BackColor = Color.MistyRose;
            lblLibroAntiguo.BorderStyle = BorderStyle.FixedSingle;
            lblLibroAntiguo.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblLibroAntiguo.ForeColor = Color.Maroon;
            lblLibroAntiguo.Location = new Point(46, 67);
            lblLibroAntiguo.Name = "lblLibroAntiguo";
            lblLibroAntiguo.Padding = new Padding(11, 13, 11, 13);
            lblLibroAntiguo.Size = new Size(285, 199);
            lblLibroAntiguo.TabIndex = 0;
            lblLibroAntiguo.Text = "Más Antiguo: \n---";
            lblLibroAntiguo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tabDescripcion
            // 
            tabDescripcion.Controls.Add(lstResultadosDescripcion);
            tabDescripcion.Controls.Add(btnBuscarDescripcion);
            tabDescripcion.Controls.Add(txtDescripcion);
            tabDescripcion.Controls.Add(lblInstruccionDesc);
            tabDescripcion.Location = new Point(4, 29);
            tabDescripcion.Margin = new Padding(3, 4, 3, 4);
            tabDescripcion.Name = "tabDescripcion";
            tabDescripcion.Size = new Size(906, 634);
            tabDescripcion.TabIndex = 4;
            tabDescripcion.Text = "Buscar en Descripción";
            tabDescripcion.UseVisualStyleBackColor = true;
            // 
            // lstResultadosDescripcion
            // 
            lstResultadosDescripcion.FormattingEnabled = true;
            lstResultadosDescripcion.Location = new Point(152, 173);
            lstResultadosDescripcion.Margin = new Padding(3, 4, 3, 4);
            lstResultadosDescripcion.Name = "lstResultadosDescripcion";
            lstResultadosDescripcion.Size = new Size(601, 384);
            lstResultadosDescripcion.TabIndex = 3;
            // 
            // btnBuscarDescripcion
            // 
            btnBuscarDescripcion.BackColor = Color.SlateGray;
            btnBuscarDescripcion.FlatStyle = FlatStyle.Flat;
            btnBuscarDescripcion.ForeColor = Color.White;
            btnBuscarDescripcion.Location = new Point(616, 107);
            btnBuscarDescripcion.Margin = new Padding(3, 4, 3, 4);
            btnBuscarDescripcion.Name = "btnBuscarDescripcion";
            btnBuscarDescripcion.Size = new Size(137, 39);
            btnBuscarDescripcion.TabIndex = 2;
            btnBuscarDescripcion.Text = "Buscar Texto";
            btnBuscarDescripcion.UseVisualStyleBackColor = false;
            btnBuscarDescripcion.Click += btnBuscarDescripcion_Click;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Font = new Font("Segoe UI", 12F);
            txtDescripcion.Location = new Point(152, 107);
            txtDescripcion.Margin = new Padding(3, 4, 3, 4);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.PlaceholderText = "Palabra clave (ej. soledad, política, amor)...";
            txtDescripcion.Size = new Size(457, 34);
            txtDescripcion.TabIndex = 1;
            // 
            // lblInstruccionDesc
            // 
            lblInstruccionDesc.AutoSize = true;
            lblInstruccionDesc.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblInstruccionDesc.Location = new Point(152, 40);
            lblInstruccionDesc.Name = "lblInstruccionDesc";
            lblInstruccionDesc.Size = new Size(410, 32);
            lblInstruccionDesc.TabIndex = 0;
            lblInstruccionDesc.Text = "Búsqueda Parcial en Descripciones";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 667);
            Controls.Add(tabControlPrincipal);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de Búsqueda Bibliotecaria";
            tabControlPrincipal.ResumeLayout(false);
            tabDatos.ResumeLayout(false);
            grpAutores.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAutores).EndInit();
            grpLibros.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvLibros).EndInit();
            tabLineal.ResumeLayout(false);
            tabLineal.PerformLayout();
            tabBinaria.ResumeLayout(false);
            tabBinaria.PerformLayout();
            tabAnalisis.ResumeLayout(false);
            grpResultadosAnalisis.ResumeLayout(false);
            tabDescripcion.ResumeLayout(false);
            tabDescripcion.PerformLayout();
            ResumeLayout(false);

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