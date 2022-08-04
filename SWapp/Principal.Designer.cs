namespace SWapp
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LogoInicial = new System.Windows.Forms.PictureBox();
            this.BtnAyuda = new System.Windows.Forms.PictureBox();
            this.Cerrar = new System.Windows.Forms.PictureBox();
            this.Maximizar = new System.Windows.Forms.PictureBox();
            this.Minimizar = new System.Windows.Forms.PictureBox();
            this.TLpanelPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.LabelCountCircuits = new System.Windows.Forms.Label();
            this.DataGridCircuitos = new System.Windows.Forms.DataGridView();
            this.TxtBoxTicketId = new System.Windows.Forms.TextBox();
            this.TextBoxDescripcion = new System.Windows.Forms.TextBox();
            this.ComboBoxTipo = new System.Windows.Forms.ComboBox();
            this.ComboBoxImpacto = new System.Windows.Forms.ComboBox();
            this.TextBoxImpacTime = new System.Windows.Forms.TextBox();
            this.TextBoxLocation = new System.Windows.Forms.TextBox();
            this.TextBoxSchedule = new System.Windows.Forms.TextBox();
            this.TextBoxScheduleUpdate = new System.Windows.Forms.TextBox();
            this.CheckBoxUpdate = new System.Windows.Forms.CheckBox();
            this.TxtBoxCorreo = new System.Windows.Forms.TextBox();
            this.DataGridCorreos = new System.Windows.Forms.DataGridView();
            this.WebCorreo = new System.Windows.Forms.WebBrowser();
            this.RichTextAlertas = new System.Windows.Forms.RichTextBox();
            this.BtnAlerta = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.LabelEstado = new System.Windows.Forms.Label();
            this.Pendientes = new System.Windows.Forms.Button();
            this.TxtBoxSWid = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnDesplegable = new System.Windows.Forms.Button();
            this.LabelPWID = new System.Windows.Forms.Label();
            this.BtnNotificar = new System.Windows.Forms.Button();
            this.BtnFreeze = new System.Windows.Forms.Button();
            this.BtnCalendario = new System.Windows.Forms.Button();
            this.BtnCorreos = new System.Windows.Forms.Button();
            this.BtnCircuitosBL = new System.Windows.Forms.Button();
            this.BtnVerificar = new System.Windows.Forms.Button();
            this.BtnCopiar = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SegundoPlano = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoInicial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnAyuda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).BeginInit();
            this.TLpanelPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridCircuitos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridCorreos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnAlerta)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.LogoInicial);
            this.panel1.Controls.Add(this.BtnAyuda);
            this.panel1.Controls.Add(this.Cerrar);
            this.panel1.Controls.Add(this.Maximizar);
            this.panel1.Controls.Add(this.Minimizar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(909, 35);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDoubleClick);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // LogoInicial
            // 
            this.LogoInicial.Image = ((System.Drawing.Image)(resources.GetObject("LogoInicial.Image")));
            this.LogoInicial.Location = new System.Drawing.Point(12, 9);
            this.LogoInicial.Name = "LogoInicial";
            this.LogoInicial.Size = new System.Drawing.Size(100, 20);
            this.LogoInicial.TabIndex = 4;
            this.LogoInicial.TabStop = false;
            // 
            // BtnAyuda
            // 
            this.BtnAyuda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAyuda.Image = ((System.Drawing.Image)(resources.GetObject("BtnAyuda.Image")));
            this.BtnAyuda.Location = new System.Drawing.Point(784, 7);
            this.BtnAyuda.Name = "BtnAyuda";
            this.BtnAyuda.Size = new System.Drawing.Size(25, 25);
            this.BtnAyuda.TabIndex = 3;
            this.BtnAyuda.TabStop = false;
            this.BtnAyuda.Click += new System.EventHandler(this.BtnAyuda_Click);
            // 
            // Cerrar
            // 
            this.Cerrar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Cerrar.Image = ((System.Drawing.Image)(resources.GetObject("Cerrar.Image")));
            this.Cerrar.InitialImage = null;
            this.Cerrar.Location = new System.Drawing.Point(877, 7);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(25, 25);
            this.Cerrar.TabIndex = 2;
            this.Cerrar.TabStop = false;
            this.Cerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // Maximizar
            // 
            this.Maximizar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Maximizar.Image = ((System.Drawing.Image)(resources.GetObject("Maximizar.Image")));
            this.Maximizar.InitialImage = null;
            this.Maximizar.Location = new System.Drawing.Point(846, 7);
            this.Maximizar.Name = "Maximizar";
            this.Maximizar.Size = new System.Drawing.Size(25, 25);
            this.Maximizar.TabIndex = 2;
            this.Maximizar.TabStop = false;
            this.Maximizar.Click += new System.EventHandler(this.Maximizar_Click);
            // 
            // Minimizar
            // 
            this.Minimizar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Minimizar.Image = ((System.Drawing.Image)(resources.GetObject("Minimizar.Image")));
            this.Minimizar.InitialImage = null;
            this.Minimizar.Location = new System.Drawing.Point(815, 7);
            this.Minimizar.Name = "Minimizar";
            this.Minimizar.Size = new System.Drawing.Size(25, 25);
            this.Minimizar.TabIndex = 1;
            this.Minimizar.TabStop = false;
            this.Minimizar.Click += new System.EventHandler(this.Minimizar_Click);
            // 
            // TLpanelPrincipal
            // 
            this.TLpanelPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TLpanelPrincipal.ColumnCount = 23;
            this.TLpanelPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.TLpanelPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.TLpanelPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.TLpanelPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.TLpanelPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.TLpanelPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.TLpanelPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.TLpanelPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TLpanelPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.TLpanelPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TLpanelPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TLpanelPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TLpanelPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TLpanelPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TLpanelPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TLpanelPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TLpanelPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TLpanelPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TLpanelPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TLpanelPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TLpanelPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TLpanelPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.TLpanelPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.TLpanelPrincipal.Controls.Add(this.LabelCountCircuits, 0, 0);
            this.TLpanelPrincipal.Controls.Add(this.DataGridCircuitos, 0, 1);
            this.TLpanelPrincipal.Controls.Add(this.TxtBoxTicketId, 0, 11);
            this.TLpanelPrincipal.Controls.Add(this.TextBoxDescripcion, 0, 12);
            this.TLpanelPrincipal.Controls.Add(this.ComboBoxTipo, 3, 11);
            this.TLpanelPrincipal.Controls.Add(this.ComboBoxImpacto, 0, 13);
            this.TLpanelPrincipal.Controls.Add(this.TextBoxImpacTime, 2, 13);
            this.TLpanelPrincipal.Controls.Add(this.TextBoxLocation, 0, 14);
            this.TLpanelPrincipal.Controls.Add(this.TextBoxSchedule, 0, 15);
            this.TLpanelPrincipal.Controls.Add(this.TextBoxScheduleUpdate, 0, 17);
            this.TLpanelPrincipal.Controls.Add(this.CheckBoxUpdate, 0, 19);
            this.TLpanelPrincipal.Controls.Add(this.TxtBoxCorreo, 9, 6);
            this.TLpanelPrincipal.Controls.Add(this.DataGridCorreos, 0, 6);
            this.TLpanelPrincipal.Controls.Add(this.WebCorreo, 9, 1);
            this.TLpanelPrincipal.Controls.Add(this.RichTextAlertas, 6, 11);
            this.TLpanelPrincipal.Controls.Add(this.BtnAlerta, 5, 19);
            this.TLpanelPrincipal.Controls.Add(this.progressBar1, 6, 20);
            this.TLpanelPrincipal.Controls.Add(this.LabelEstado, 3, 20);
            this.TLpanelPrincipal.Controls.Add(this.Pendientes, 2, 19);
            this.TLpanelPrincipal.Location = new System.Drawing.Point(161, 41);
            this.TLpanelPrincipal.Name = "TLpanelPrincipal";
            this.TLpanelPrincipal.RowCount = 21;
            this.TLpanelPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.TLpanelPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.TLpanelPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.TLpanelPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.TLpanelPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.TLpanelPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.TLpanelPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.TLpanelPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.TLpanelPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.TLpanelPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.TLpanelPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TLpanelPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.TLpanelPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.TLpanelPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.TLpanelPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.TLpanelPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.TLpanelPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.TLpanelPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.TLpanelPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.TLpanelPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.44444F));
            this.TLpanelPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.TLpanelPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TLpanelPrincipal.Size = new System.Drawing.Size(736, 489);
            this.TLpanelPrincipal.TabIndex = 1;
            // 
            // LabelCountCircuits
            // 
            this.LabelCountCircuits.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelCountCircuits.AutoSize = true;
            this.TLpanelPrincipal.SetColumnSpan(this.LabelCountCircuits, 2);
            this.LabelCountCircuits.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCountCircuits.Location = new System.Drawing.Point(3, 0);
            this.LabelCountCircuits.Name = "LabelCountCircuits";
            this.LabelCountCircuits.Size = new System.Drawing.Size(67, 15);
            this.LabelCountCircuits.TabIndex = 3;
            this.LabelCountCircuits.Text = "Resultados";
            // 
            // DataGridCircuitos
            // 
            this.DataGridCircuitos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridCircuitos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridCircuitos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(198)))), ((int)(((byte)(193)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(198)))), ((int)(((byte)(193)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridCircuitos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridCircuitos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TLpanelPrincipal.SetColumnSpan(this.DataGridCircuitos, 9);
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(198)))), ((int)(((byte)(193)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridCircuitos.DefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridCircuitos.Location = new System.Drawing.Point(3, 18);
            this.DataGridCircuitos.Name = "DataGridCircuitos";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridCircuitos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.TLpanelPrincipal.SetRowSpan(this.DataGridCircuitos, 5);
            this.DataGridCircuitos.Size = new System.Drawing.Size(418, 100);
            this.DataGridCircuitos.TabIndex = 1;
            // 
            // TxtBoxTicketId
            // 
            this.TLpanelPrincipal.SetColumnSpan(this.TxtBoxTicketId, 3);
            this.TxtBoxTicketId.Location = new System.Drawing.Point(3, 239);
            this.TxtBoxTicketId.Name = "TxtBoxTicketId";
            this.TxtBoxTicketId.Size = new System.Drawing.Size(144, 20);
            this.TxtBoxTicketId.TabIndex = 8;
            // 
            // TextBoxDescripcion
            // 
            this.TLpanelPrincipal.SetColumnSpan(this.TextBoxDescripcion, 6);
            this.TextBoxDescripcion.Location = new System.Drawing.Point(3, 264);
            this.TextBoxDescripcion.MaxLength = 40000;
            this.TextBoxDescripcion.Name = "TextBoxDescripcion";
            this.TextBoxDescripcion.Size = new System.Drawing.Size(294, 20);
            this.TextBoxDescripcion.TabIndex = 10;
            // 
            // ComboBoxTipo
            // 
            this.TLpanelPrincipal.SetColumnSpan(this.ComboBoxTipo, 3);
            this.ComboBoxTipo.FormattingEnabled = true;
            this.ComboBoxTipo.Items.AddRange(new object[] {
            "Normal",
            "Emergency // Emergencia",
            "Cancelled // Cancelado"});
            this.ComboBoxTipo.Location = new System.Drawing.Point(153, 239);
            this.ComboBoxTipo.Name = "ComboBoxTipo";
            this.ComboBoxTipo.Size = new System.Drawing.Size(144, 21);
            this.ComboBoxTipo.TabIndex = 9;
            this.ComboBoxTipo.Text = "Normal";
            // 
            // ComboBoxImpacto
            // 
            this.TLpanelPrincipal.SetColumnSpan(this.ComboBoxImpacto, 2);
            this.ComboBoxImpacto.FormattingEnabled = true;
            this.ComboBoxImpacto.Items.AddRange(new object[] {
            "O",
            "SH",
            "PL",
            "*"});
            this.ComboBoxImpacto.Location = new System.Drawing.Point(3, 289);
            this.ComboBoxImpacto.Name = "ComboBoxImpacto";
            this.ComboBoxImpacto.Size = new System.Drawing.Size(94, 21);
            this.ComboBoxImpacto.TabIndex = 11;
            this.ComboBoxImpacto.Text = "O";
            this.ComboBoxImpacto.SelectedIndexChanged += new System.EventHandler(this.ComboBoxImpacto_SelectedIndexChanged);
            // 
            // TextBoxImpacTime
            // 
            this.TLpanelPrincipal.SetColumnSpan(this.TextBoxImpacTime, 4);
            this.TextBoxImpacTime.Location = new System.Drawing.Point(103, 289);
            this.TextBoxImpacTime.Name = "TextBoxImpacTime";
            this.TextBoxImpacTime.Size = new System.Drawing.Size(194, 20);
            this.TextBoxImpacTime.TabIndex = 12;
            this.TextBoxImpacTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxImpacTime_KeyPress);
            // 
            // TextBoxLocation
            // 
            this.TLpanelPrincipal.SetColumnSpan(this.TextBoxLocation, 6);
            this.TextBoxLocation.Location = new System.Drawing.Point(3, 314);
            this.TextBoxLocation.Name = "TextBoxLocation";
            this.TextBoxLocation.Size = new System.Drawing.Size(294, 20);
            this.TextBoxLocation.TabIndex = 13;
            // 
            // TextBoxSchedule
            // 
            this.TLpanelPrincipal.SetColumnSpan(this.TextBoxSchedule, 6);
            this.TextBoxSchedule.Location = new System.Drawing.Point(3, 339);
            this.TextBoxSchedule.Multiline = true;
            this.TextBoxSchedule.Name = "TextBoxSchedule";
            this.TLpanelPrincipal.SetRowSpan(this.TextBoxSchedule, 2);
            this.TextBoxSchedule.Size = new System.Drawing.Size(294, 44);
            this.TextBoxSchedule.TabIndex = 14;
            // 
            // TextBoxScheduleUpdate
            // 
            this.TLpanelPrincipal.SetColumnSpan(this.TextBoxScheduleUpdate, 6);
            this.TextBoxScheduleUpdate.Enabled = false;
            this.TextBoxScheduleUpdate.Location = new System.Drawing.Point(3, 389);
            this.TextBoxScheduleUpdate.Multiline = true;
            this.TextBoxScheduleUpdate.Name = "TextBoxScheduleUpdate";
            this.TLpanelPrincipal.SetRowSpan(this.TextBoxScheduleUpdate, 2);
            this.TextBoxScheduleUpdate.Size = new System.Drawing.Size(294, 44);
            this.TextBoxScheduleUpdate.TabIndex = 15;
            // 
            // CheckBoxUpdate
            // 
            this.CheckBoxUpdate.AutoSize = true;
            this.TLpanelPrincipal.SetColumnSpan(this.CheckBoxUpdate, 2);
            this.CheckBoxUpdate.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBoxUpdate.Location = new System.Drawing.Point(3, 439);
            this.CheckBoxUpdate.Name = "CheckBoxUpdate";
            this.CheckBoxUpdate.Size = new System.Drawing.Size(66, 21);
            this.CheckBoxUpdate.TabIndex = 16;
            this.CheckBoxUpdate.Text = "Update";
            this.CheckBoxUpdate.UseVisualStyleBackColor = true;
            this.CheckBoxUpdate.CheckedChanged += new System.EventHandler(this.CheckBoxUpdate_CheckedChanged);
            // 
            // TxtBoxCorreo
            // 
            this.TxtBoxCorreo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TLpanelPrincipal.SetColumnSpan(this.TxtBoxCorreo, 13);
            this.TxtBoxCorreo.Location = new System.Drawing.Point(427, 124);
            this.TxtBoxCorreo.MaxLength = 40000;
            this.TxtBoxCorreo.Multiline = true;
            this.TxtBoxCorreo.Name = "TxtBoxCorreo";
            this.TLpanelPrincipal.SetRowSpan(this.TxtBoxCorreo, 5);
            this.TxtBoxCorreo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtBoxCorreo.Size = new System.Drawing.Size(282, 109);
            this.TxtBoxCorreo.TabIndex = 7;
            // 
            // DataGridCorreos
            // 
            this.DataGridCorreos.AllowUserToAddRows = false;
            this.DataGridCorreos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridCorreos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridCorreos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(198)))), ((int)(((byte)(193)))));
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(198)))), ((int)(((byte)(193)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridCorreos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridCorreos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TLpanelPrincipal.SetColumnSpan(this.DataGridCorreos, 9);
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(198)))), ((int)(((byte)(193)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridCorreos.DefaultCellStyle = dataGridViewCellStyle5;
            this.DataGridCorreos.Location = new System.Drawing.Point(3, 124);
            this.DataGridCorreos.Name = "DataGridCorreos";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridCorreos.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.TLpanelPrincipal.SetRowSpan(this.DataGridCorreos, 5);
            this.DataGridCorreos.Size = new System.Drawing.Size(418, 109);
            this.DataGridCorreos.TabIndex = 17;
            this.DataGridCorreos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridCorreos_CellDoubleClick);
            // 
            // WebCorreo
            // 
            this.WebCorreo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TLpanelPrincipal.SetColumnSpan(this.WebCorreo, 13);
            this.WebCorreo.Location = new System.Drawing.Point(427, 18);
            this.WebCorreo.MinimumSize = new System.Drawing.Size(20, 20);
            this.WebCorreo.Name = "WebCorreo";
            this.TLpanelPrincipal.SetRowSpan(this.WebCorreo, 5);
            this.WebCorreo.Size = new System.Drawing.Size(282, 100);
            this.WebCorreo.TabIndex = 18;
            this.WebCorreo.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.WebCorreo_DocumentCompleted);
            // 
            // RichTextAlertas
            // 
            this.RichTextAlertas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TLpanelPrincipal.SetColumnSpan(this.RichTextAlertas, 16);
            this.RichTextAlertas.Location = new System.Drawing.Point(303, 239);
            this.RichTextAlertas.Name = "RichTextAlertas";
            this.RichTextAlertas.ReadOnly = true;
            this.TLpanelPrincipal.SetRowSpan(this.RichTextAlertas, 9);
            this.RichTextAlertas.Size = new System.Drawing.Size(406, 230);
            this.RichTextAlertas.TabIndex = 19;
            this.RichTextAlertas.Text = "";
            this.RichTextAlertas.TextChanged += new System.EventHandler(this.RichTextAlertas_TextChanged);
            // 
            // BtnAlerta
            // 
            this.BtnAlerta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAlerta.Image = ((System.Drawing.Image)(resources.GetObject("BtnAlerta.Image")));
            this.BtnAlerta.Location = new System.Drawing.Point(267, 439);
            this.BtnAlerta.Name = "BtnAlerta";
            this.BtnAlerta.Size = new System.Drawing.Size(30, 30);
            this.BtnAlerta.TabIndex = 20;
            this.BtnAlerta.TabStop = false;
            this.BtnAlerta.Click += new System.EventHandler(this.BtnAlerta_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TLpanelPrincipal.SetColumnSpan(this.progressBar1, 16);
            this.progressBar1.Location = new System.Drawing.Point(303, 475);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(406, 11);
            this.progressBar1.TabIndex = 21;
            // 
            // LabelEstado
            // 
            this.LabelEstado.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LabelEstado.AutoSize = true;
            this.TLpanelPrincipal.SetColumnSpan(this.LabelEstado, 3);
            this.LabelEstado.Location = new System.Drawing.Point(257, 474);
            this.LabelEstado.Name = "LabelEstado";
            this.LabelEstado.Size = new System.Drawing.Size(40, 13);
            this.LabelEstado.TabIndex = 22;
            this.LabelEstado.Text = "Estado";
            // 
            // Pendientes
            // 
            this.TLpanelPrincipal.SetColumnSpan(this.Pendientes, 2);
            this.Pendientes.Enabled = false;
            this.Pendientes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Pendientes.Location = new System.Drawing.Point(103, 439);
            this.Pendientes.Name = "Pendientes";
            this.Pendientes.Size = new System.Drawing.Size(94, 23);
            this.Pendientes.TabIndex = 23;
            this.Pendientes.Text = "Pendientes";
            this.Pendientes.UseVisualStyleBackColor = true;
            this.Pendientes.Click += new System.EventHandler(this.Pendientes_Click);
            // 
            // TxtBoxSWid
            // 
            this.TxtBoxSWid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBoxSWid.Location = new System.Drawing.Point(16, 29);
            this.TxtBoxSWid.Name = "TxtBoxSWid";
            this.TxtBoxSWid.Size = new System.Drawing.Size(129, 23);
            this.TxtBoxSWid.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.BtnDesplegable);
            this.panel2.Controls.Add(this.LabelPWID);
            this.panel2.Controls.Add(this.BtnNotificar);
            this.panel2.Controls.Add(this.BtnFreeze);
            this.panel2.Controls.Add(this.BtnCalendario);
            this.panel2.Controls.Add(this.BtnCorreos);
            this.panel2.Controls.Add(this.BtnCircuitosBL);
            this.panel2.Controls.Add(this.BtnVerificar);
            this.panel2.Controls.Add(this.BtnCopiar);
            this.panel2.Controls.Add(this.BtnLimpiar);
            this.panel2.Controls.Add(this.TxtBoxSWid);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(155, 507);
            this.panel2.TabIndex = 2;
            // 
            // BtnDesplegable
            // 
            this.BtnDesplegable.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnDesplegable.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDesplegable.ForeColor = System.Drawing.Color.White;
            this.BtnDesplegable.Image = ((System.Drawing.Image)(resources.GetObject("BtnDesplegable.Image")));
            this.BtnDesplegable.Location = new System.Drawing.Point(0, 111);
            this.BtnDesplegable.Name = "BtnDesplegable";
            this.BtnDesplegable.Size = new System.Drawing.Size(155, 15);
            this.BtnDesplegable.TabIndex = 12;
            this.BtnDesplegable.UseVisualStyleBackColor = true;
            this.BtnDesplegable.Click += new System.EventHandler(this.BtnDesplegable_Click);
            // 
            // LabelPWID
            // 
            this.LabelPWID.AutoSize = true;
            this.LabelPWID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPWID.ForeColor = System.Drawing.Color.White;
            this.LabelPWID.Location = new System.Drawing.Point(13, 9);
            this.LabelPWID.Name = "LabelPWID";
            this.LabelPWID.Size = new System.Drawing.Size(104, 17);
            this.LabelPWID.TabIndex = 11;
            this.LabelPWID.Text = "PlannedWorkId";
            // 
            // BtnNotificar
            // 
            this.BtnNotificar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.BtnNotificar.FlatAppearance.BorderSize = 0;
            this.BtnNotificar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.BtnNotificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.BtnNotificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnNotificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNotificar.ForeColor = System.Drawing.Color.White;
            this.BtnNotificar.Image = ((System.Drawing.Image)(resources.GetObject("BtnNotificar.Image")));
            this.BtnNotificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnNotificar.Location = new System.Drawing.Point(0, 441);
            this.BtnNotificar.Name = "BtnNotificar";
            this.BtnNotificar.Size = new System.Drawing.Size(155, 55);
            this.BtnNotificar.TabIndex = 10;
            this.BtnNotificar.Text = "Notificar    ";
            this.BtnNotificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnNotificar.UseVisualStyleBackColor = true;
            this.BtnNotificar.Click += new System.EventHandler(this.BtnNotificar_Click);
            // 
            // BtnFreeze
            // 
            this.BtnFreeze.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.BtnFreeze.FlatAppearance.BorderSize = 0;
            this.BtnFreeze.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.BtnFreeze.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.BtnFreeze.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnFreeze.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFreeze.ForeColor = System.Drawing.Color.White;
            this.BtnFreeze.Image = ((System.Drawing.Image)(resources.GetObject("BtnFreeze.Image")));
            this.BtnFreeze.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnFreeze.Location = new System.Drawing.Point(0, 386);
            this.BtnFreeze.Name = "BtnFreeze";
            this.BtnFreeze.Size = new System.Drawing.Size(155, 55);
            this.BtnFreeze.TabIndex = 9;
            this.BtnFreeze.Text = "Freeze      ";
            this.BtnFreeze.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnFreeze.UseVisualStyleBackColor = true;
            this.BtnFreeze.Click += new System.EventHandler(this.BtnFreeze_Click);
            // 
            // BtnCalendario
            // 
            this.BtnCalendario.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.BtnCalendario.FlatAppearance.BorderSize = 0;
            this.BtnCalendario.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.BtnCalendario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.BtnCalendario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCalendario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCalendario.ForeColor = System.Drawing.Color.White;
            this.BtnCalendario.Image = ((System.Drawing.Image)(resources.GetObject("BtnCalendario.Image")));
            this.BtnCalendario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCalendario.Location = new System.Drawing.Point(0, 331);
            this.BtnCalendario.Name = "BtnCalendario";
            this.BtnCalendario.Size = new System.Drawing.Size(155, 55);
            this.BtnCalendario.TabIndex = 8;
            this.BtnCalendario.Text = "Calendario ";
            this.BtnCalendario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCalendario.UseVisualStyleBackColor = true;
            this.BtnCalendario.Click += new System.EventHandler(this.BtnCalendario_Click);
            // 
            // BtnCorreos
            // 
            this.BtnCorreos.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.BtnCorreos.FlatAppearance.BorderSize = 0;
            this.BtnCorreos.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.BtnCorreos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.BtnCorreos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCorreos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCorreos.ForeColor = System.Drawing.Color.White;
            this.BtnCorreos.Image = ((System.Drawing.Image)(resources.GetObject("BtnCorreos.Image")));
            this.BtnCorreos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCorreos.Location = new System.Drawing.Point(0, 276);
            this.BtnCorreos.Name = "BtnCorreos";
            this.BtnCorreos.Size = new System.Drawing.Size(155, 55);
            this.BtnCorreos.TabIndex = 7;
            this.BtnCorreos.Text = "Correos     ";
            this.BtnCorreos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCorreos.UseVisualStyleBackColor = true;
            this.BtnCorreos.Click += new System.EventHandler(this.BtnCorreos_Click);
            // 
            // BtnCircuitosBL
            // 
            this.BtnCircuitosBL.FlatAppearance.BorderColor = System.Drawing.Color.MediumBlue;
            this.BtnCircuitosBL.FlatAppearance.BorderSize = 0;
            this.BtnCircuitosBL.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.BtnCircuitosBL.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnCircuitosBL.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumBlue;
            this.BtnCircuitosBL.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCircuitosBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCircuitosBL.ForeColor = System.Drawing.Color.White;
            this.BtnCircuitosBL.Image = ((System.Drawing.Image)(resources.GetObject("BtnCircuitosBL.Image")));
            this.BtnCircuitosBL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCircuitosBL.Location = new System.Drawing.Point(0, 56);
            this.BtnCircuitosBL.Name = "BtnCircuitosBL";
            this.BtnCircuitosBL.Size = new System.Drawing.Size(155, 55);
            this.BtnCircuitosBL.TabIndex = 2;
            this.BtnCircuitosBL.Text = "BulkLoader ";
            this.BtnCircuitosBL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCircuitosBL.UseVisualStyleBackColor = true;
            this.BtnCircuitosBL.Click += new System.EventHandler(this.BtnCircuitosBL_Click);
            // 
            // BtnVerificar
            // 
            this.BtnVerificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnVerificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVerificar.ForeColor = System.Drawing.Color.White;
            this.BtnVerificar.Image = ((System.Drawing.Image)(resources.GetObject("BtnVerificar.Image")));
            this.BtnVerificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnVerificar.Location = new System.Drawing.Point(0, 126);
            this.BtnVerificar.Name = "BtnVerificar";
            this.BtnVerificar.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.BtnVerificar.Size = new System.Drawing.Size(155, 50);
            this.BtnVerificar.TabIndex = 4;
            this.BtnVerificar.Text = "Verificar   ";
            this.BtnVerificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnVerificar.UseVisualStyleBackColor = true;
            this.BtnVerificar.Visible = false;
            this.BtnVerificar.Click += new System.EventHandler(this.BtnVerificar_Click);
            // 
            // BtnCopiar
            // 
            this.BtnCopiar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.BtnCopiar.FlatAppearance.BorderSize = 0;
            this.BtnCopiar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.BtnCopiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.BtnCopiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCopiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCopiar.ForeColor = System.Drawing.Color.White;
            this.BtnCopiar.Image = ((System.Drawing.Image)(resources.GetObject("BtnCopiar.Image")));
            this.BtnCopiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCopiar.Location = new System.Drawing.Point(0, 176);
            this.BtnCopiar.Name = "BtnCopiar";
            this.BtnCopiar.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.BtnCopiar.Size = new System.Drawing.Size(155, 50);
            this.BtnCopiar.TabIndex = 5;
            this.BtnCopiar.Text = "Copiar     ";
            this.BtnCopiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCopiar.UseVisualStyleBackColor = true;
            this.BtnCopiar.Visible = false;
            this.BtnCopiar.Click += new System.EventHandler(this.BtnCopiar_Click);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.BtnLimpiar.FlatAppearance.BorderSize = 0;
            this.BtnLimpiar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.BtnLimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpiar.ForeColor = System.Drawing.Color.White;
            this.BtnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("BtnLimpiar.Image")));
            this.BtnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLimpiar.Location = new System.Drawing.Point(0, 226);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.BtnLimpiar.Size = new System.Drawing.Size(155, 50);
            this.BtnLimpiar.TabIndex = 6;
            this.BtnLimpiar.Text = "Limpiar    ";
            this.BtnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Visible = false;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // SegundoPlano
            // 
            this.SegundoPlano.WorkerReportsProgress = true;
            this.SegundoPlano.WorkerSupportsCancellation = true;
            this.SegundoPlano.DoWork += new System.ComponentModel.DoWorkEventHandler(this.SegundoPlano_DoWork);
            this.SegundoPlano.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.SegundoPlano_ProgressChanged);
            this.SegundoPlano.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.SegundoPlano_RunWorkerCompleted);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(198)))), ((int)(((byte)(193)))));
            this.ClientSize = new System.Drawing.Size(909, 542);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.TLpanelPrincipal);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(909, 542);
            this.Name = "Principal";
            this.Text = "SWapp";
            this.Activated += new System.EventHandler(this.Principal_Activated);
            this.Deactivate += new System.EventHandler(this.Principal_Deactivate);
            this.Load += new System.EventHandler(this.Principal_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LogoInicial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnAyuda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).EndInit();
            this.TLpanelPrincipal.ResumeLayout(false);
            this.TLpanelPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridCircuitos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridCorreos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnAlerta)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Minimizar;
        private System.Windows.Forms.PictureBox Cerrar;
        private System.Windows.Forms.PictureBox Maximizar;
        private System.Windows.Forms.TableLayoutPanel TLpanelPrincipal;
        private System.Windows.Forms.TextBox TxtBoxSWid;
        private System.Windows.Forms.DataGridView DataGridCircuitos;
        private System.Windows.Forms.Button BtnCircuitosBL;
        private System.Windows.Forms.Label LabelCountCircuits;
        private System.Windows.Forms.Button BtnVerificar;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.TextBox TxtBoxCorreo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnCopiar;
        private System.Windows.Forms.Button BtnNotificar;
        private System.Windows.Forms.Button BtnFreeze;
        private System.Windows.Forms.Button BtnCalendario;
        private System.Windows.Forms.Button BtnCorreos;
        private System.Windows.Forms.TextBox TxtBoxTicketId;
        private System.Windows.Forms.TextBox TextBoxDescripcion;
        private System.Windows.Forms.ComboBox ComboBoxTipo;
        private System.Windows.Forms.ComboBox ComboBoxImpacto;
        private System.Windows.Forms.TextBox TextBoxImpacTime;
        private System.Windows.Forms.TextBox TextBoxLocation;
        private System.Windows.Forms.TextBox TextBoxSchedule;
        private System.Windows.Forms.TextBox TextBoxScheduleUpdate;
        private System.Windows.Forms.CheckBox CheckBoxUpdate;
        private System.Windows.Forms.DataGridView DataGridCorreos;
        private System.Windows.Forms.WebBrowser WebCorreo;
        private System.Windows.Forms.RichTextBox RichTextAlertas;
        private System.Windows.Forms.Label LabelPWID;
        private System.Windows.Forms.PictureBox BtnAyuda;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox BtnAlerta;
        private System.ComponentModel.BackgroundWorker SegundoPlano;
        private System.Windows.Forms.PictureBox LogoInicial;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label LabelEstado;
        private System.Windows.Forms.Button BtnDesplegable;
        private System.Windows.Forms.Button Pendientes;
    }
}

