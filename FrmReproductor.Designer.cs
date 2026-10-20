namespace ReproductorMusica
{
    partial class FrmReproductor
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtArtista = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbGenero = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDuracion = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnOrdenarTitulo = new System.Windows.Forms.Button();
            this.btnOrdenarDuracion = new System.Windows.Forms.Button();
            this.btnEjemplo = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblResumen = new System.Windows.Forms.Label();
            this.lblSeccionCatalogo = new System.Windows.Forms.Label();
            this.lstCatalogo = new System.Windows.Forms.ListBox();
            this.btnAgregarLista = new System.Windows.Forms.Button();
            this.lblSeccionLista = new System.Windows.Forms.Label();
            this.lstLista = new System.Windows.Forms.ListBox();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnReproducir = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnQuitarLista = new System.Windows.Forms.Button();
            this.btnAlReves = new System.Windows.Forms.Button();
            this.lblAhora = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(255, 211, 105);
            this.lblTitulo.Location = new System.Drawing.Point(20, 10);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Mi Lista de Reproducción";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(238, 238, 238);
            this.label1.Location = new System.Drawing.Point(20, 68);
            this.label1.Name = "label1";
            this.label1.TabIndex = 1;
            this.label1.Text = "Código:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.Color.FromArgb(57, 62, 70);
            this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigo.ForeColor = System.Drawing.Color.FromArgb(238, 238, 238);
            this.txtCodigo.Location = new System.Drawing.Point(125, 65);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(215, 23);
            this.txtCodigo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(238, 238, 238);
            this.label2.Location = new System.Drawing.Point(20, 103);
            this.label2.Name = "label2";
            this.label2.TabIndex = 3;
            this.label2.Text = "Título:";
            // 
            // txtTitulo
            // 
            this.txtTitulo.BackColor = System.Drawing.Color.FromArgb(57, 62, 70);
            this.txtTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTitulo.ForeColor = System.Drawing.Color.FromArgb(238, 238, 238);
            this.txtTitulo.Location = new System.Drawing.Point(125, 100);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(215, 23);
            this.txtTitulo.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(238, 238, 238);
            this.label3.Location = new System.Drawing.Point(20, 138);
            this.label3.Name = "label3";
            this.label3.TabIndex = 5;
            this.label3.Text = "Artista:";
            // 
            // txtArtista
            // 
            this.txtArtista.BackColor = System.Drawing.Color.FromArgb(57, 62, 70);
            this.txtArtista.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtArtista.ForeColor = System.Drawing.Color.FromArgb(238, 238, 238);
            this.txtArtista.Location = new System.Drawing.Point(125, 135);
            this.txtArtista.Name = "txtArtista";
            this.txtArtista.Size = new System.Drawing.Size(215, 23);
            this.txtArtista.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(238, 238, 238);
            this.label4.Location = new System.Drawing.Point(20, 173);
            this.label4.Name = "label4";
            this.label4.TabIndex = 7;
            this.label4.Text = "Género:";
            // 
            // cmbGenero
            // 
            this.cmbGenero.BackColor = System.Drawing.Color.FromArgb(57, 62, 70);
            this.cmbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGenero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbGenero.ForeColor = System.Drawing.Color.FromArgb(238, 238, 238);
            this.cmbGenero.FormattingEnabled = true;
            this.cmbGenero.Location = new System.Drawing.Point(125, 170);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(215, 23);
            this.cmbGenero.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(238, 238, 238);
            this.label5.Location = new System.Drawing.Point(20, 208);
            this.label5.Name = "label5";
            this.label5.TabIndex = 9;
            this.label5.Text = "Duración (seg):";
            // 
            // txtDuracion
            // 
            this.txtDuracion.BackColor = System.Drawing.Color.FromArgb(57, 62, 70);
            this.txtDuracion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDuracion.ForeColor = System.Drawing.Color.FromArgb(238, 238, 238);
            this.txtDuracion.Location = new System.Drawing.Point(125, 205);
            this.txtDuracion.Name = "txtDuracion";
            this.txtDuracion.Size = new System.Drawing.Size(215, 23);
            this.txtDuracion.TabIndex = 10;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(0, 173, 181);
            this.btnRegistrar.FlatAppearance.BorderSize = 0;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Location = new System.Drawing.Point(20, 245);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(160, 30);
            this.btnRegistrar.TabIndex = 11;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(0, 173, 181);
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Location = new System.Drawing.Point(190, 245);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(150, 30);
            this.btnModificar.TabIndex = 12;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(238, 99, 99);
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Location = new System.Drawing.Point(20, 282);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(160, 30);
            this.btnEliminar.TabIndex = 13;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(0, 173, 181);
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Location = new System.Drawing.Point(190, 282);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(150, 30);
            this.btnLimpiar.TabIndex = 14;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnOrdenarTitulo
            // 
            this.btnOrdenarTitulo.BackColor = System.Drawing.Color.FromArgb(0, 173, 181);
            this.btnOrdenarTitulo.FlatAppearance.BorderSize = 0;
            this.btnOrdenarTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrdenarTitulo.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnOrdenarTitulo.UseVisualStyleBackColor = false;
            this.btnOrdenarTitulo.Location = new System.Drawing.Point(20, 319);
            this.btnOrdenarTitulo.Name = "btnOrdenarTitulo";
            this.btnOrdenarTitulo.Size = new System.Drawing.Size(160, 30);
            this.btnOrdenarTitulo.TabIndex = 15;
            this.btnOrdenarTitulo.Text = "Ordenar por título";
            this.btnOrdenarTitulo.Click += new System.EventHandler(this.btnOrdenarTitulo_Click);
            // 
            // btnOrdenarDuracion
            // 
            this.btnOrdenarDuracion.BackColor = System.Drawing.Color.FromArgb(0, 173, 181);
            this.btnOrdenarDuracion.FlatAppearance.BorderSize = 0;
            this.btnOrdenarDuracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrdenarDuracion.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnOrdenarDuracion.UseVisualStyleBackColor = false;
            this.btnOrdenarDuracion.Location = new System.Drawing.Point(190, 319);
            this.btnOrdenarDuracion.Name = "btnOrdenarDuracion";
            this.btnOrdenarDuracion.Size = new System.Drawing.Size(150, 30);
            this.btnOrdenarDuracion.TabIndex = 16;
            this.btnOrdenarDuracion.Text = "Ordenar por duración";
            this.btnOrdenarDuracion.Click += new System.EventHandler(this.btnOrdenarDuracion_Click);
            // 
            // btnEjemplo
            // 
            this.btnEjemplo.BackColor = System.Drawing.Color.FromArgb(0, 173, 181);
            this.btnEjemplo.FlatAppearance.BorderSize = 0;
            this.btnEjemplo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEjemplo.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnEjemplo.UseVisualStyleBackColor = false;
            this.btnEjemplo.Location = new System.Drawing.Point(20, 356);
            this.btnEjemplo.Name = "btnEjemplo";
            this.btnEjemplo.Size = new System.Drawing.Size(160, 30);
            this.btnEjemplo.TabIndex = 17;
            this.btnEjemplo.Text = "Datos de ejemplo";
            this.btnEjemplo.Click += new System.EventHandler(this.btnEjemplo_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(238, 99, 99);
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Location = new System.Drawing.Point(190, 356);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(150, 30);
            this.btnSalir.TabIndex = 18;
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(238, 238, 238);
            this.label6.Location = new System.Drawing.Point(20, 406);
            this.label6.Name = "label6";
            this.label6.TabIndex = 19;
            this.label6.Text = "Buscar:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.FromArgb(57, 62, 70);
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscar.ForeColor = System.Drawing.Color.FromArgb(238, 238, 238);
            this.txtBuscar.Location = new System.Drawing.Point(80, 403);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(170, 23);
            this.txtBuscar.TabIndex = 20;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(0, 173, 181);
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Location = new System.Drawing.Point(260, 400);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(80, 28);
            this.btnBuscar.TabIndex = 21;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblResumen
            // 
            this.lblResumen.AutoSize = false;
            this.lblResumen.BackColor = System.Drawing.Color.FromArgb(57, 62, 70);
            this.lblResumen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResumen.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblResumen.ForeColor = System.Drawing.Color.FromArgb(0, 173, 181);
            this.lblResumen.Padding = new System.Windows.Forms.Padding(10);
            this.lblResumen.Location = new System.Drawing.Point(20, 445);
            this.lblResumen.Name = "lblResumen";
            this.lblResumen.Size = new System.Drawing.Size(320, 150);
            this.lblResumen.TabIndex = 22;
            // 
            // lblSeccionCatalogo
            // 
            this.lblSeccionCatalogo.AutoSize = true;
            this.lblSeccionCatalogo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSeccionCatalogo.ForeColor = System.Drawing.Color.FromArgb(255, 211, 105);
            this.lblSeccionCatalogo.Location = new System.Drawing.Point(390, 68);
            this.lblSeccionCatalogo.Name = "lblSeccionCatalogo";
            this.lblSeccionCatalogo.TabIndex = 23;
            this.lblSeccionCatalogo.Text = "Catálogo de canciones";
            // 
            // lstCatalogo
            // 
            this.lstCatalogo.BackColor = System.Drawing.Color.FromArgb(57, 62, 70);
            this.lstCatalogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstCatalogo.ForeColor = System.Drawing.Color.FromArgb(238, 238, 238);
            this.lstCatalogo.FormattingEnabled = true;
            this.lstCatalogo.Location = new System.Drawing.Point(390, 92);
            this.lstCatalogo.Name = "lstCatalogo";
            this.lstCatalogo.Size = new System.Drawing.Size(590, 170);
            this.lstCatalogo.TabIndex = 24;
            this.lstCatalogo.SelectedIndexChanged += new System.EventHandler(this.lstCatalogo_SelectedIndexChanged);
            // 
            // btnAgregarLista
            // 
            this.btnAgregarLista.BackColor = System.Drawing.Color.FromArgb(0, 173, 181);
            this.btnAgregarLista.FlatAppearance.BorderSize = 0;
            this.btnAgregarLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarLista.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnAgregarLista.UseVisualStyleBackColor = false;
            this.btnAgregarLista.Location = new System.Drawing.Point(390, 270);
            this.btnAgregarLista.Name = "btnAgregarLista";
            this.btnAgregarLista.Size = new System.Drawing.Size(590, 30);
            this.btnAgregarLista.TabIndex = 25;
            this.btnAgregarLista.Text = "Agregar a la lista de reproducción";
            this.btnAgregarLista.Click += new System.EventHandler(this.btnAgregarLista_Click);
            // 
            // lblSeccionLista
            // 
            this.lblSeccionLista.AutoSize = true;
            this.lblSeccionLista.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSeccionLista.ForeColor = System.Drawing.Color.FromArgb(255, 211, 105);
            this.lblSeccionLista.Location = new System.Drawing.Point(390, 315);
            this.lblSeccionLista.Name = "lblSeccionLista";
            this.lblSeccionLista.TabIndex = 26;
            this.lblSeccionLista.Text = "Lista de reproducción";
            // 
            // lstLista
            // 
            this.lstLista.BackColor = System.Drawing.Color.FromArgb(57, 62, 70);
            this.lstLista.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstLista.ForeColor = System.Drawing.Color.FromArgb(238, 238, 238);
            this.lstLista.FormattingEnabled = true;
            this.lstLista.Location = new System.Drawing.Point(390, 340);
            this.lstLista.Name = "lstLista";
            this.lstLista.Size = new System.Drawing.Size(590, 170);
            this.lstLista.TabIndex = 27;
            // 
            // btnAnterior
            // 
            this.btnAnterior.BackColor = System.Drawing.Color.FromArgb(255, 211, 105);
            this.btnAnterior.FlatAppearance.BorderSize = 0;
            this.btnAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnterior.ForeColor = System.Drawing.Color.FromArgb(34, 40, 49);
            this.btnAnterior.UseVisualStyleBackColor = false;
            this.btnAnterior.Location = new System.Drawing.Point(390, 520);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(100, 34);
            this.btnAnterior.TabIndex = 28;
            this.btnAnterior.Text = "Anterior";
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnReproducir
            // 
            this.btnReproducir.BackColor = System.Drawing.Color.FromArgb(255, 211, 105);
            this.btnReproducir.FlatAppearance.BorderSize = 0;
            this.btnReproducir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReproducir.ForeColor = System.Drawing.Color.FromArgb(34, 40, 49);
            this.btnReproducir.UseVisualStyleBackColor = false;
            this.btnReproducir.Location = new System.Drawing.Point(500, 520);
            this.btnReproducir.Name = "btnReproducir";
            this.btnReproducir.Size = new System.Drawing.Size(100, 34);
            this.btnReproducir.TabIndex = 29;
            this.btnReproducir.Text = "Reproducir";
            this.btnReproducir.Click += new System.EventHandler(this.btnReproducir_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.BackColor = System.Drawing.Color.FromArgb(255, 211, 105);
            this.btnSiguiente.FlatAppearance.BorderSize = 0;
            this.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiguiente.ForeColor = System.Drawing.Color.FromArgb(34, 40, 49);
            this.btnSiguiente.UseVisualStyleBackColor = false;
            this.btnSiguiente.Location = new System.Drawing.Point(610, 520);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(100, 34);
            this.btnSiguiente.TabIndex = 30;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnQuitarLista
            // 
            this.btnQuitarLista.BackColor = System.Drawing.Color.FromArgb(238, 99, 99);
            this.btnQuitarLista.FlatAppearance.BorderSize = 0;
            this.btnQuitarLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitarLista.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnQuitarLista.UseVisualStyleBackColor = false;
            this.btnQuitarLista.Location = new System.Drawing.Point(720, 520);
            this.btnQuitarLista.Name = "btnQuitarLista";
            this.btnQuitarLista.Size = new System.Drawing.Size(125, 34);
            this.btnQuitarLista.TabIndex = 31;
            this.btnQuitarLista.Text = "Quitar";
            this.btnQuitarLista.Click += new System.EventHandler(this.btnQuitarLista_Click);
            // 
            // btnAlReves
            // 
            this.btnAlReves.BackColor = System.Drawing.Color.FromArgb(0, 173, 181);
            this.btnAlReves.FlatAppearance.BorderSize = 0;
            this.btnAlReves.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlReves.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnAlReves.UseVisualStyleBackColor = false;
            this.btnAlReves.Location = new System.Drawing.Point(855, 520);
            this.btnAlReves.Name = "btnAlReves";
            this.btnAlReves.Size = new System.Drawing.Size(125, 34);
            this.btnAlReves.TabIndex = 32;
            this.btnAlReves.Text = "Ver al revés";
            this.btnAlReves.Click += new System.EventHandler(this.btnAlReves_Click);
            // 
            // lblAhora
            // 
            this.lblAhora.AutoSize = false;
            this.lblAhora.BackColor = System.Drawing.Color.FromArgb(255, 211, 105);
            this.lblAhora.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAhora.ForeColor = System.Drawing.Color.FromArgb(34, 40, 49);
            this.lblAhora.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblAhora.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblAhora.Location = new System.Drawing.Point(390, 565);
            this.lblAhora.Name = "lblAhora";
            this.lblAhora.Size = new System.Drawing.Size(590, 45);
            this.lblAhora.TabIndex = 33;
            // 
            // FrmReproductor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(34, 40, 49);
            this.ClientSize = new System.Drawing.Size(1000, 640);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtArtista);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbGenero);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDuracion);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnOrdenarTitulo);
            this.Controls.Add(this.btnOrdenarDuracion);
            this.Controls.Add(this.btnEjemplo);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblResumen);
            this.Controls.Add(this.lblSeccionCatalogo);
            this.Controls.Add(this.lstCatalogo);
            this.Controls.Add(this.btnAgregarLista);
            this.Controls.Add(this.lblSeccionLista);
            this.Controls.Add(this.lstLista);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.btnReproducir);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.btnQuitarLista);
            this.Controls.Add(this.btnAlReves);
            this.Controls.Add(this.lblAhora);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmReproductor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mi lista de reproducción";
            this.Load += new System.EventHandler(this.FrmReproductor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtArtista;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbGenero;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDuracion;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnOrdenarTitulo;
        private System.Windows.Forms.Button btnOrdenarDuracion;
        private System.Windows.Forms.Button btnEjemplo;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblResumen;
        private System.Windows.Forms.Label lblSeccionCatalogo;
        private System.Windows.Forms.ListBox lstCatalogo;
        private System.Windows.Forms.Button btnAgregarLista;
        private System.Windows.Forms.Label lblSeccionLista;
        private System.Windows.Forms.ListBox lstLista;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnReproducir;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnQuitarLista;
        private System.Windows.Forms.Button btnAlReves;
        private System.Windows.Forms.Label lblAhora;
    }
}
