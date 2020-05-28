using System.ComponentModel;

namespace HUGO_SegundoParcial
{
    partial class Administrador
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
                new System.ComponentModel.ComponentResourceManager(typeof(Administrador));
            this.Man_Usu = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.combNombreElim = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.gbxCrear = new System.Windows.Forms.GroupBox();
            this.txtUsernameC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAgregarUsuario = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.rdioNo = new System.Windows.Forms.RadioButton();
            this.rdioYes = new System.Windows.Forms.RadioButton();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnEliminarArt = new System.Windows.Forms.Button();
            this.cmbNombreNegEli = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtNegocio = new System.Windows.Forms.TextBox();
            this.btnAgregarNegocio = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.cmbPEli = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbVerNP = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.Man_Usu.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.gbxCrear.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView3)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // Man_Usu
            // 
            this.Man_Usu.Controls.Add(this.tabPage1);
            this.Man_Usu.Controls.Add(this.tabPage2);
            this.Man_Usu.Controls.Add(this.tabPage6);
            this.Man_Usu.Controls.Add(this.tabPage3);
            this.Man_Usu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Man_Usu.Location = new System.Drawing.Point(0, 0);
            this.Man_Usu.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Man_Usu.Multiline = true;
            this.Man_Usu.Name = "Man_Usu";
            this.Man_Usu.SelectedIndex = 0;
            this.Man_Usu.Size = new System.Drawing.Size(910, 592);
            this.Man_Usu.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("tabPage1.BackgroundImage")));
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.dataGridView2);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.gbxCrear);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tabPage1.Size = new System.Drawing.Size(902, 559);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "USUARIOS";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(94, 298);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(720, 242);
            this.dataGridView2.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnEliminar);
            this.groupBox2.Controls.Add(this.combNombreElim);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(559, 38);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox2.Size = new System.Drawing.Size(308, 232);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ELIMINAR";
            // 
            // btnEliminar
            // 
            this.btnEliminar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEliminar.BackColor = System.Drawing.Color.White;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI Black", 16.2F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.Red;
            this.btnEliminar.Location = new System.Drawing.Point(65, 138);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(202, 69);
            this.btnEliminar.TabIndex = 14;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // combNombreElim
            // 
            this.combNombreElim.BackColor = System.Drawing.Color.White;
            this.combNombreElim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combNombreElim.FormattingEnabled = true;
            this.combNombreElim.Location = new System.Drawing.Point(98, 61);
            this.combNombreElim.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.combNombreElim.Name = "combNombreElim";
            this.combNombreElim.Size = new System.Drawing.Size(193, 28);
            this.combNombreElim.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(4, 60);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 32);
            this.label7.TabIndex = 13;
            this.label7.Text = "Usuario : ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // gbxCrear
            // 
            this.gbxCrear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbxCrear.BackColor = System.Drawing.Color.Transparent;
            this.gbxCrear.Controls.Add(this.txtUsernameC);
            this.gbxCrear.Controls.Add(this.label2);
            this.gbxCrear.Controls.Add(this.btnAgregarUsuario);
            this.gbxCrear.Controls.Add(this.label3);
            this.gbxCrear.Controls.Add(this.rdioNo);
            this.gbxCrear.Controls.Add(this.rdioYes);
            this.gbxCrear.Controls.Add(this.textNombre);
            this.gbxCrear.Controls.Add(this.label1);
            this.gbxCrear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.gbxCrear.ForeColor = System.Drawing.Color.White;
            this.gbxCrear.Location = new System.Drawing.Point(30, 38);
            this.gbxCrear.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.gbxCrear.Name = "gbxCrear";
            this.gbxCrear.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.gbxCrear.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gbxCrear.Size = new System.Drawing.Size(507, 232);
            this.gbxCrear.TabIndex = 0;
            this.gbxCrear.TabStop = false;
            this.gbxCrear.Text = "CREAR";
            // 
            // txtUsernameC
            // 
            this.txtUsernameC.Location = new System.Drawing.Point(188, 84);
            this.txtUsernameC.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtUsernameC.Name = "txtUsernameC";
            this.txtUsernameC.Size = new System.Drawing.Size(299, 27);
            this.txtUsernameC.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(28, 88);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 32);
            this.label2.TabIndex = 8;
            this.label2.Text = "Username:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnAgregarUsuario
            // 
            this.btnAgregarUsuario.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregarUsuario.BackColor = System.Drawing.Color.White;
            this.btnAgregarUsuario.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnAgregarUsuario.ForeColor = System.Drawing.Color.Black;
            this.btnAgregarUsuario.Location = new System.Drawing.Point(301, 148);
            this.btnAgregarUsuario.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnAgregarUsuario.Name = "btnAgregarUsuario";
            this.btnAgregarUsuario.Size = new System.Drawing.Size(186, 58);
            this.btnAgregarUsuario.TabIndex = 7;
            this.btnAgregarUsuario.Text = "Crear";
            this.btnAgregarUsuario.UseVisualStyleBackColor = false;
            this.btnAgregarUsuario.Click += new System.EventHandler(this.btnAgregarUsuario_Click);
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(27, 138);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 30);
            this.label3.TabIndex = 6;
            this.label3.Text = "Administrador :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // rdioNo
            // 
            this.rdioNo.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdioNo.ForeColor = System.Drawing.Color.White;
            this.rdioNo.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.rdioNo.Location = new System.Drawing.Point(53, 199);
            this.rdioNo.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.rdioNo.Name = "rdioNo";
            this.rdioNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdioNo.Size = new System.Drawing.Size(102, 31);
            this.rdioNo.TabIndex = 5;
            this.rdioNo.Text = "No";
            this.rdioNo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rdioNo.UseVisualStyleBackColor = true;
            // 
            // rdioYes
            // 
            this.rdioYes.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdioYes.Checked = true;
            this.rdioYes.ForeColor = System.Drawing.Color.White;
            this.rdioYes.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.rdioYes.Location = new System.Drawing.Point(64, 169);
            this.rdioYes.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.rdioYes.Name = "rdioYes";
            this.rdioYes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdioYes.Size = new System.Drawing.Size(82, 31);
            this.rdioYes.TabIndex = 4;
            this.rdioYes.TabStop = true;
            this.rdioYes.Text = "Si";
            this.rdioYes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rdioYes.UseVisualStyleBackColor = true;
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(188, 38);
            this.textNombre.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(299, 27);
            this.textNombre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(26, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de Usuario:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("tabPage2.BackgroundImage")));
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tabPage2.Size = new System.Drawing.Size(902, 563);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "NEGOCIOS";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage =
                ((System.Drawing.Image) (resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(550, 290);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(274, 242);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(38, 290);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(456, 242);
            this.dataGridView1.TabIndex = 4;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnEliminarArt);
            this.groupBox5.Controls.Add(this.cmbNombreNegEli);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.groupBox5.ForeColor = System.Drawing.Color.White;
            this.groupBox5.Location = new System.Drawing.Point(500, 28);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox5.Size = new System.Drawing.Size(350, 239);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "ELIMINAR";
            // 
            // btnEliminarArt
            // 
            this.btnEliminarArt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEliminarArt.ForeColor = System.Drawing.Color.Black;
            this.btnEliminarArt.Location = new System.Drawing.Point(98, 141);
            this.btnEliminarArt.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnEliminarArt.Name = "btnEliminarArt";
            this.btnEliminarArt.Size = new System.Drawing.Size(202, 69);
            this.btnEliminarArt.TabIndex = 9;
            this.btnEliminarArt.Text = "Eliminar";
            this.btnEliminarArt.UseVisualStyleBackColor = true;
            this.btnEliminarArt.Click += new System.EventHandler(this.btnEliminarArt_Click);
            // 
            // cmbNombreNegEli
            // 
            this.cmbNombreNegEli.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNombreNegEli.FormattingEnabled = true;
            this.cmbNombreNegEli.Location = new System.Drawing.Point(109, 76);
            this.cmbNombreNegEli.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.cmbNombreNegEli.Name = "cmbNombreNegEli";
            this.cmbNombreNegEli.Size = new System.Drawing.Size(199, 28);
            this.cmbNombreNegEli.TabIndex = 18;
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label16.Location = new System.Drawing.Point(4, 78);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(101, 26);
            this.label16.TabIndex = 18;
            this.label16.Text = "Negocio:";
            this.label16.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // groupBox3
            // 
            this.groupBox3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox3.Controls.Add(this.txtNegocio);
            this.groupBox3.Controls.Add(this.btnAgregarNegocio);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtDescripcion);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(21, 28);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox3.Size = new System.Drawing.Size(473, 239);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "CREAR";
            // 
            // txtNegocio
            // 
            this.txtNegocio.Location = new System.Drawing.Point(216, 41);
            this.txtNegocio.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtNegocio.Name = "txtNegocio";
            this.txtNegocio.Size = new System.Drawing.Size(227, 27);
            this.txtNegocio.TabIndex = 9;
            // 
            // btnAgregarNegocio
            // 
            this.btnAgregarNegocio.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregarNegocio.ForeColor = System.Drawing.Color.Black;
            this.btnAgregarNegocio.Location = new System.Drawing.Point(267, 151);
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
            this.label9.Text = "Descripcion:";
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
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(216, 81);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(227, 27);
            this.txtDescripcion.TabIndex = 1;
            // 
            // tabPage6
            // 
            this.tabPage6.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("tabPage6.BackgroundImage")));
            this.tabPage6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage6.Controls.Add(this.pictureBox2);
            this.tabPage6.Controls.Add(this.dataGridView3);
            this.tabPage6.Controls.Add(this.groupBox4);
            this.tabPage6.Controls.Add(this.groupBox1);
            this.tabPage6.Location = new System.Drawing.Point(4, 29);
            this.tabPage6.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tabPage6.Size = new System.Drawing.Size(902, 559);
            this.tabPage6.TabIndex = 2;
            this.tabPage6.Text = "PRODUCTO";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage =
                ((System.Drawing.Image) (resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(70, 284);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(274, 242);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 35;
            this.pictureBox2.TabStop = false;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(422, 284);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(434, 242);
            this.dataGridView3.TabIndex = 4;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Controls.Add(this.cmbPEli);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(516, 28);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox4.Size = new System.Drawing.Size(340, 166);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "ELIMINAR";
            // 
            // button2
            // 
            this.button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(69, 85);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(202, 69);
            this.button2.TabIndex = 9;
            this.button2.Text = "Eliminar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cmbPEli
            // 
            this.cmbPEli.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPEli.FormattingEnabled = true;
            this.cmbPEli.Location = new System.Drawing.Point(105, 38);
            this.cmbPEli.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.cmbPEli.Name = "cmbPEli";
            this.cmbPEli.Size = new System.Drawing.Size(199, 28);
            this.cmbPEli.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label4.Location = new System.Drawing.Point(0, 42);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 26);
            this.label4.TabIndex = 18;
            this.label4.Text = "Producto:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cmbVerNP);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtProducto);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(30, 28);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(454, 235);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CREAR";
            // 
            // cmbVerNP
            // 
            this.cmbVerNP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVerNP.FormattingEnabled = true;
            this.cmbVerNP.Location = new System.Drawing.Point(162, 48);
            this.cmbVerNP.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.cmbVerNP.Name = "cmbVerNP";
            this.cmbVerNP.Size = new System.Drawing.Size(266, 28);
            this.cmbVerNP.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(0, 42);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 32);
            this.label5.TabIndex = 8;
            this.label5.Text = "Negocio:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // button1
            // 
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(141, 158);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 58);
            this.button1.TabIndex = 7;
            this.button1.Text = "Crear";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(162, 106);
            this.txtProducto.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(266, 27);
            this.txtProducto.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(0, 100);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 32);
            this.label6.TabIndex = 0;
            this.label6.Text = "Producto:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tabPage3
            // 
            this.tabPage3.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("tabPage3.BackgroundImage")));
            this.tabPage3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage3.Controls.Add(this.dataGridView4);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(902, 559);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "ORDENES";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(103, 161);
            this.dataGridView4.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowTemplate.Height = 24;
            this.dataGridView4.Size = new System.Drawing.Size(711, 340);
            this.dataGridView4.TabIndex = 5;
            // 
            // Administrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Man_Usu);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Administrador";
            this.Size = new System.Drawing.Size(910, 592);
            this.Load += new System.EventHandler(this.Administrador_Load);
            this.Man_Usu.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.gbxCrear.ResumeLayout(false);
            this.gbxCrear.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView3)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView4)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnEliminarArt;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.RadioButton rdioYes;
        private System.Windows.Forms.RadioButton rdioNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAgregarUsuario;
        private System.Windows.Forms.GroupBox gbxCrear;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox combNombreElim;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl Man_Usu;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsernameC;
        private System.Windows.Forms.Button btnAgregarNegocio;
        private System.Windows.Forms.TextBox txtNegocio;
        private System.Windows.Forms.ComboBox cmbNombreNegEli;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cmbPEli;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbVerNP;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridView4;
    }
}