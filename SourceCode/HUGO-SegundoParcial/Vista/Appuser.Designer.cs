using System.ComponentModel;

namespace HUGO_SegundoParcial
{
    partial class Appuser
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources =
                new System.ComponentModel.ComponentResourceManager(typeof(Appuser));
            this.Man_Usu = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnModificarD = new System.Windows.Forms.Button();
            this.txtNuevaDi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbDireccion = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEliminarD = new System.Windows.Forms.Button();
            this.cmbEliminarD = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.gbxCrear = new System.Windows.Forms.GroupBox();
            this.btnAgregarDireccion = new System.Windows.Forms.Button();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnEliminarArt = new System.Windows.Forms.Button();
            this.cmbEliPro = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnAgregarNegocio = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Man_Usu.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.gbxCrear.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Man_Usu
            // 
            this.Man_Usu.Controls.Add(this.tabPage1);
            this.Man_Usu.Controls.Add(this.tabPage2);
            this.Man_Usu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Man_Usu.Location = new System.Drawing.Point(0, 0);
            this.Man_Usu.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Man_Usu.Multiline = true;
            this.Man_Usu.Name = "Man_Usu";
            this.Man_Usu.SelectedIndex = 0;
            this.Man_Usu.Size = new System.Drawing.Size(910, 592);
            this.Man_Usu.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("tabPage1.BackgroundImage")));
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.dataGridView2);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.gbxCrear);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tabPage1.Size = new System.Drawing.Size(902, 559);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "DIRECCION ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnModificarD);
            this.groupBox1.Controls.Add(this.txtNuevaDi);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmbDireccion);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(30, 176);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox1.Size = new System.Drawing.Size(507, 178);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MODIFICAR";
            // 
            // btnModificarD
            // 
            this.btnModificarD.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnModificarD.BackColor = System.Drawing.Color.White;
            this.btnModificarD.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnModificarD.ForeColor = System.Drawing.Color.Black;
            this.btnModificarD.Location = new System.Drawing.Point(152, 119);
            this.btnModificarD.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnModificarD.Name = "btnModificarD";
            this.btnModificarD.Size = new System.Drawing.Size(186, 42);
            this.btnModificarD.TabIndex = 10;
            this.btnModificarD.Text = "Modificar";
            this.btnModificarD.UseVisualStyleBackColor = false;
            this.btnModificarD.Click += new System.EventHandler(this.btnModificarD_Click);
            // 
            // txtNuevaDi
            // 
            this.txtNuevaDi.Location = new System.Drawing.Point(105, 70);
            this.txtNuevaDi.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtNuevaDi.Name = "txtNuevaDi";
            this.txtNuevaDi.Size = new System.Drawing.Size(370, 27);
            this.txtNuevaDi.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(0, 69);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 42);
            this.label5.TabIndex = 14;
            this.label5.Text = "Nueva: ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cmbDireccion
            // 
            this.cmbDireccion.BackColor = System.Drawing.Color.White;
            this.cmbDireccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDireccion.FormattingEnabled = true;
            this.cmbDireccion.Location = new System.Drawing.Point(105, 25);
            this.cmbDireccion.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.cmbDireccion.Name = "cmbDireccion";
            this.cmbDireccion.Size = new System.Drawing.Size(370, 28);
            this.cmbDireccion.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(0, 31);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 32);
            this.label4.TabIndex = 13;
            this.label4.Text = "Direccion:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(271, 383);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(351, 152);
            this.dataGridView2.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnEliminarD);
            this.groupBox2.Controls.Add(this.cmbEliminarD);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(569, 91);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox2.Size = new System.Drawing.Size(308, 232);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ELIMINAR";
            // 
            // btnEliminarD
            // 
            this.btnEliminarD.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEliminarD.BackColor = System.Drawing.Color.White;
            this.btnEliminarD.Font = new System.Drawing.Font("Segoe UI Black", 16.2F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnEliminarD.ForeColor = System.Drawing.Color.Red;
            this.btnEliminarD.Location = new System.Drawing.Point(65, 138);
            this.btnEliminarD.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnEliminarD.Name = "btnEliminarD";
            this.btnEliminarD.Size = new System.Drawing.Size(202, 69);
            this.btnEliminarD.TabIndex = 14;
            this.btnEliminarD.Text = "Eliminar";
            this.btnEliminarD.UseVisualStyleBackColor = false;
            this.btnEliminarD.Click += new System.EventHandler(this.btnEliminarD_Click);
            // 
            // cmbEliminarD
            // 
            this.cmbEliminarD.BackColor = System.Drawing.Color.White;
            this.cmbEliminarD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEliminarD.FormattingEnabled = true;
            this.cmbEliminarD.Location = new System.Drawing.Point(98, 61);
            this.cmbEliminarD.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.cmbEliminarD.Name = "cmbEliminarD";
            this.cmbEliminarD.Size = new System.Drawing.Size(193, 28);
            this.cmbEliminarD.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(0, 61);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 32);
            this.label7.TabIndex = 13;
            this.label7.Text = "Direccion:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // gbxCrear
            // 
            this.gbxCrear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbxCrear.BackColor = System.Drawing.Color.Transparent;
            this.gbxCrear.Controls.Add(this.btnAgregarDireccion);
            this.gbxCrear.Controls.Add(this.txtDireccion);
            this.gbxCrear.Controls.Add(this.label1);
            this.gbxCrear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.gbxCrear.ForeColor = System.Drawing.Color.White;
            this.gbxCrear.Location = new System.Drawing.Point(30, 16);
            this.gbxCrear.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.gbxCrear.Name = "gbxCrear";
            this.gbxCrear.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.gbxCrear.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gbxCrear.Size = new System.Drawing.Size(507, 140);
            this.gbxCrear.TabIndex = 0;
            this.gbxCrear.TabStop = false;
            this.gbxCrear.Text = "CREAR";
            // 
            // btnAgregarDireccion
            // 
            this.btnAgregarDireccion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregarDireccion.BackColor = System.Drawing.Color.White;
            this.btnAgregarDireccion.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnAgregarDireccion.ForeColor = System.Drawing.Color.Black;
            this.btnAgregarDireccion.Location = new System.Drawing.Point(137, 72);
            this.btnAgregarDireccion.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnAgregarDireccion.Name = "btnAgregarDireccion";
            this.btnAgregarDireccion.Size = new System.Drawing.Size(186, 48);
            this.btnAgregarDireccion.TabIndex = 7;
            this.btnAgregarDireccion.Text = "Crear";
            this.btnAgregarDireccion.UseVisualStyleBackColor = false;
            this.btnAgregarDireccion.Click += new System.EventHandler(this.btnAgregarDireccion_Click);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(117, 36);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(341, 27);
            this.txtDireccion.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Direccion:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("tabPage2.BackgroundImage")));
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tabPage2.Size = new System.Drawing.Size(902, 559);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "ORDEN";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(177, 325);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(580, 178);
            this.dataGridView1.TabIndex = 4;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnEliminarArt);
            this.groupBox5.Controls.Add(this.cmbEliPro);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.groupBox5.ForeColor = System.Drawing.Color.White;
            this.groupBox5.Location = new System.Drawing.Point(500, 28);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox5.Size = new System.Drawing.Size(350, 219);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "ELIMINAR";
            // 
            // btnEliminarArt
            // 
            this.btnEliminarArt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEliminarArt.ForeColor = System.Drawing.Color.Black;
            this.btnEliminarArt.Location = new System.Drawing.Point(90, 121);
            this.btnEliminarArt.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnEliminarArt.Name = "btnEliminarArt";
            this.btnEliminarArt.Size = new System.Drawing.Size(202, 69);
            this.btnEliminarArt.TabIndex = 9;
            this.btnEliminarArt.Text = "Eliminar";
            this.btnEliminarArt.UseVisualStyleBackColor = true;
            this.btnEliminarArt.Click += new System.EventHandler(this.btnEliminarArt_Click);
            // 
            // cmbEliPro
            // 
            this.cmbEliPro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEliPro.FormattingEnabled = true;
            this.cmbEliPro.Location = new System.Drawing.Point(109, 52);
            this.cmbEliPro.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.cmbEliPro.Name = "cmbEliPro";
            this.cmbEliPro.Size = new System.Drawing.Size(199, 28);
            this.cmbEliPro.TabIndex = 18;
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label16.Location = new System.Drawing.Point(4, 55);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(101, 26);
            this.label16.TabIndex = 18;
            this.label16.Text = "Orden:";
            this.label16.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // groupBox3
            // 
            this.groupBox3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox3.Controls.Add(this.comboBox3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.comboBox2);
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Controls.Add(this.btnAgregarNegocio);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(21, 28);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox3.Size = new System.Drawing.Size(473, 266);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "CREAR";
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(213, 129);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(230, 28);
            this.comboBox3.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label2.Location = new System.Drawing.Point(6, 132);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 26);
            this.label2.TabIndex = 21;
            this.label2.Text = "Direccion: ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(213, 81);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(230, 28);
            this.comboBox2.TabIndex = 20;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(213, 38);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(230, 28);
            this.comboBox1.TabIndex = 19;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnAgregarNegocio
            // 
            this.btnAgregarNegocio.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregarNegocio.ForeColor = System.Drawing.Color.Black;
            this.btnAgregarNegocio.Location = new System.Drawing.Point(156, 190);
            this.btnAgregarNegocio.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnAgregarNegocio.Name = "btnAgregarNegocio";
            this.btnAgregarNegocio.Size = new System.Drawing.Size(176, 48);
            this.btnAgregarNegocio.TabIndex = 8;
            this.btnAgregarNegocio.Text = "Agregar";
            this.btnAgregarNegocio.UseVisualStyleBackColor = true;
            this.btnAgregarNegocio.Click += new System.EventHandler(this.btnAgregarNegocio_Click);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label9.Location = new System.Drawing.Point(6, 84);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(203, 26);
            this.label9.TabIndex = 5;
            this.label9.Text = "Producto. ";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label8.Location = new System.Drawing.Point(6, 41);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(203, 26);
            this.label8.TabIndex = 4;
            this.label8.Text = "Nombre Negocio:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Appuser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Man_Usu);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Appuser";
            this.Size = new System.Drawing.Size(910, 592);
            this.Load += new System.EventHandler(this.Appuser_Load);
            this.Man_Usu.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.gbxCrear.ResumeLayout(false);
            this.gbxCrear.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnAgregarNegocio;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnEliminarArt;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbxCrear;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl Man_Usu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNuevaDi;
        private System.Windows.Forms.Button btnModificarD;
        private System.Windows.Forms.ComboBox cmbDireccion;
        private System.Windows.Forms.Button btnEliminarD;
        private System.Windows.Forms.ComboBox cmbEliminarD;
        private System.Windows.Forms.Button btnAgregarDireccion;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox cmbEliPro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}