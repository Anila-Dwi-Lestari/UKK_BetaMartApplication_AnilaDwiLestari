namespace betaMartApplication
{
    partial class FormBetaMart
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
            System.Windows.Forms.Label nama_BarangLabel;
            System.Windows.Forms.Label kategoriLabel;
            System.Windows.Forms.Label brandLabel;
            System.Windows.Forms.Label hargaLabel;
            System.Windows.Forms.Label stokLabel;
            System.Windows.Forms.Label iD_BarangLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBetaMart));
            this.panel1 = new System.Windows.Forms.Panel();
            this.barangTersediaCheckBox = new System.Windows.Forms.CheckBox();
            this.barangBetaMartBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.betaMartDatabaseDataSet = new betaMartApplication.betaMartDatabaseDataSet();
            this.btnPrintDataGridView = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.chooseImageButton = new System.Windows.Forms.Button();
            this.clearImageButton = new System.Windows.Forms.Button();
            this.KeywordTextBox = new System.Windows.Forms.TextBox();
            this.photoPictureBox = new System.Windows.Forms.PictureBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDBarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaBarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kategoriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.iD_BarangTextBox = new System.Windows.Forms.TextBox();
            this.stokTextBox = new System.Windows.Forms.TextBox();
            this.hargaTextBox = new System.Windows.Forms.TextBox();
            this.brandTextBox = new System.Windows.Forms.TextBox();
            this.kategoriTextBox = new System.Windows.Forms.TextBox();
            this.nama_BarangTextBox = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonRefresh = new System.Windows.Forms.ToolStripButton();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonAddNew = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.barangBetaMartTableAdapter = new betaMartApplication.betaMartDatabaseDataSetTableAdapters.barangBetaMartTableAdapter();
            this.tableAdapterManager = new betaMartApplication.betaMartDatabaseDataSetTableAdapters.TableAdapterManager();
            this.printDocumentDataGridView = new System.Drawing.Printing.PrintDocument();
            nama_BarangLabel = new System.Windows.Forms.Label();
            kategoriLabel = new System.Windows.Forms.Label();
            brandLabel = new System.Windows.Forms.Label();
            hargaLabel = new System.Windows.Forms.Label();
            stokLabel = new System.Windows.Forms.Label();
            iD_BarangLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barangBetaMartBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.betaMartDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nama_BarangLabel
            // 
            nama_BarangLabel.AutoSize = true;
            nama_BarangLabel.Location = new System.Drawing.Point(32, 101);
            nama_BarangLabel.Name = "nama_BarangLabel";
            nama_BarangLabel.Size = new System.Drawing.Size(127, 20);
            nama_BarangLabel.TabIndex = 6;
            nama_BarangLabel.Text = "Nama Barang  :";
            // 
            // kategoriLabel
            // 
            kategoriLabel.AutoSize = true;
            kategoriLabel.Location = new System.Drawing.Point(32, 149);
            kategoriLabel.Name = "kategoriLabel";
            kategoriLabel.Size = new System.Drawing.Size(126, 20);
            kategoriLabel.TabIndex = 8;
            kategoriLabel.Text = "Kategori          :";
            // 
            // brandLabel
            // 
            brandLabel.AutoSize = true;
            brandLabel.Location = new System.Drawing.Point(32, 195);
            brandLabel.Name = "brandLabel";
            brandLabel.Size = new System.Drawing.Size(124, 20);
            brandLabel.TabIndex = 10;
            brandLabel.Text = "Brand             :";
            // 
            // hargaLabel
            // 
            hargaLabel.AutoSize = true;
            hargaLabel.Location = new System.Drawing.Point(32, 240);
            hargaLabel.Name = "hargaLabel";
            hargaLabel.Size = new System.Drawing.Size(125, 20);
            hargaLabel.TabIndex = 12;
            hargaLabel.Text = "Harga             :";
            // 
            // stokLabel
            // 
            stokLabel.AutoSize = true;
            stokLabel.Location = new System.Drawing.Point(32, 287);
            stokLabel.Name = "stokLabel";
            stokLabel.Size = new System.Drawing.Size(122, 20);
            stokLabel.TabIndex = 14;
            stokLabel.Text = "Stok               :";
            // 
            // iD_BarangLabel
            // 
            iD_BarangLabel.AutoSize = true;
            iD_BarangLabel.Location = new System.Drawing.Point(32, 57);
            iD_BarangLabel.Name = "iD_BarangLabel";
            iD_BarangLabel.Size = new System.Drawing.Size(130, 20);
            iD_BarangLabel.TabIndex = 16;
            iD_BarangLabel.Text = "ID Barang        :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.barangTersediaCheckBox);
            this.panel1.Controls.Add(this.btnPrintDataGridView);
            this.panel1.Controls.Add(this.buttonUpdate);
            this.panel1.Controls.Add(this.chooseImageButton);
            this.panel1.Controls.Add(this.clearImageButton);
            this.panel1.Controls.Add(this.KeywordTextBox);
            this.panel1.Controls.Add(this.photoPictureBox);
            this.panel1.Controls.Add(this.buttonSearch);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.statusStrip1);
            this.panel1.Controls.Add(this.bindingNavigator1);
            this.panel1.Controls.Add(this.buttonExit);
            this.panel1.Controls.Add(this.buttonDelete);
            this.panel1.Controls.Add(this.buttonPrevious);
            this.panel1.Controls.Add(this.buttonSave);
            this.panel1.Controls.Add(this.buttonAddNew);
            this.panel1.Controls.Add(this.buttonNext);
            this.panel1.Location = new System.Drawing.Point(-2, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1519, 1058);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // barangTersediaCheckBox
            // 
            this.barangTersediaCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.barangBetaMartBindingSource, "BarangTersedia", true));
            this.barangTersediaCheckBox.Font = new System.Drawing.Font("Montserrat SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.barangTersediaCheckBox.Location = new System.Drawing.Point(1260, 191);
            this.barangTersediaCheckBox.Name = "barangTersediaCheckBox";
            this.barangTersediaCheckBox.Size = new System.Drawing.Size(206, 34);
            this.barangTersediaCheckBox.TabIndex = 21;
            this.barangTersediaCheckBox.Text = "Barang Tersedia";
            this.barangTersediaCheckBox.UseVisualStyleBackColor = true;
            // 
            // barangBetaMartBindingSource
            // 
            this.barangBetaMartBindingSource.DataMember = "barangBetaMart";
            this.barangBetaMartBindingSource.DataSource = this.betaMartDatabaseDataSet;
            // 
            // betaMartDatabaseDataSet
            // 
            this.betaMartDatabaseDataSet.DataSetName = "betaMartDatabaseDataSet";
            this.betaMartDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnPrintDataGridView
            // 
            this.btnPrintDataGridView.BackColor = System.Drawing.Color.White;
            this.btnPrintDataGridView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrintDataGridView.FlatAppearance.BorderSize = 0;
            this.btnPrintDataGridView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintDataGridView.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintDataGridView.Image = global::betaMartApplication.Properties.Resources.icon_print;
            this.btnPrintDataGridView.Location = new System.Drawing.Point(821, 406);
            this.btnPrintDataGridView.Name = "btnPrintDataGridView";
            this.btnPrintDataGridView.Size = new System.Drawing.Size(145, 57);
            this.btnPrintDataGridView.TabIndex = 14;
            this.btnPrintDataGridView.Text = "PRINT";
            this.btnPrintDataGridView.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrintDataGridView.UseVisualStyleBackColor = false;
            this.btnPrintDataGridView.Click += new System.EventHandler(this.btnPrintDataGridView_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.White;
            this.buttonUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonUpdate.FlatAppearance.BorderSize = 0;
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdate.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.Image = global::betaMartApplication.Properties.Resources.icon_update2;
            this.buttonUpdate.Location = new System.Drawing.Point(634, 406);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(145, 56);
            this.buttonUpdate.TabIndex = 13;
            this.buttonUpdate.Text = "UPDATE";
            this.buttonUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // chooseImageButton
            // 
            this.chooseImageButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chooseImageButton.BackColor = System.Drawing.Color.White;
            this.chooseImageButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.chooseImageButton.FlatAppearance.BorderSize = 0;
            this.chooseImageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chooseImageButton.Font = new System.Drawing.Font("Montserrat SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseImageButton.ForeColor = System.Drawing.Color.Black;
            this.chooseImageButton.Image = global::betaMartApplication.Properties.Resources.icon_chooseFile;
            this.chooseImageButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.chooseImageButton.Location = new System.Drawing.Point(1197, 548);
            this.chooseImageButton.Name = "chooseImageButton";
            this.chooseImageButton.Size = new System.Drawing.Size(269, 51);
            this.chooseImageButton.TabIndex = 12;
            this.chooseImageButton.Text = "CHOOSE IMAGE";
            this.chooseImageButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.chooseImageButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chooseImageButton.UseVisualStyleBackColor = false;
            this.chooseImageButton.Click += new System.EventHandler(this.chooseImageButton_Click);
            // 
            // clearImageButton
            // 
            this.clearImageButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clearImageButton.BackColor = System.Drawing.Color.White;
            this.clearImageButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.clearImageButton.FlatAppearance.BorderSize = 0;
            this.clearImageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearImageButton.Font = new System.Drawing.Font("Montserrat SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearImageButton.ForeColor = System.Drawing.Color.Black;
            this.clearImageButton.Image = global::betaMartApplication.Properties.Resources.icon_clear;
            this.clearImageButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clearImageButton.Location = new System.Drawing.Point(1197, 481);
            this.clearImageButton.Name = "clearImageButton";
            this.clearImageButton.Size = new System.Drawing.Size(269, 51);
            this.clearImageButton.TabIndex = 11;
            this.clearImageButton.Text = "CLEAR IMAGE";
            this.clearImageButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clearImageButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.clearImageButton.UseVisualStyleBackColor = false;
            this.clearImageButton.Click += new System.EventHandler(this.clearImageButton_Click);
            // 
            // KeywordTextBox
            // 
            this.KeywordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.KeywordTextBox.BackColor = System.Drawing.Color.White;
            this.KeywordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.KeywordTextBox.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeywordTextBox.Location = new System.Drawing.Point(634, 542);
            this.KeywordTextBox.Multiline = true;
            this.KeywordTextBox.Name = "KeywordTextBox";
            this.KeywordTextBox.Size = new System.Drawing.Size(320, 53);
            this.KeywordTextBox.TabIndex = 7;
            // 
            // photoPictureBox
            // 
            this.photoPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.photoPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.barangBetaMartBindingSource, "Photo", true));
            this.photoPictureBox.Location = new System.Drawing.Point(1197, 241);
            this.photoPictureBox.Name = "photoPictureBox";
            this.photoPictureBox.Size = new System.Drawing.Size(269, 215);
            this.photoPictureBox.TabIndex = 10;
            this.photoPictureBox.TabStop = false;
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.White;
            this.buttonSearch.FlatAppearance.BorderSize = 0;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.Image = global::betaMartApplication.Properties.Resources.icon_search;
            this.buttonSearch.Location = new System.Drawing.Point(978, 542);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(182, 53);
            this.buttonSearch.TabIndex = 6;
            this.buttonSearch.Text = "SEARCH";
            this.buttonSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::betaMartApplication.Properties.Resources.logo2;
            this.pictureBox1.Location = new System.Drawing.Point(99, 110);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(381, 101);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(15)))), ((int)(((byte)(23)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1519, 73);
            this.panel2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat ExtraBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(422, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(738, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "WELCOME TO FAST MOVING GOODS BETAMART";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(51, 619);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1415, 384);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "BetaMart List :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDBarangDataGridViewTextBoxColumn,
            this.namaBarangDataGridViewTextBoxColumn,
            this.kategoriDataGridViewTextBoxColumn,
            this.brandDataGridViewTextBoxColumn,
            this.hargaDataGridViewTextBoxColumn,
            this.stokDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.barangBetaMartBindingSource;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView1.GridColor = System.Drawing.Color.Black;
            this.dataGridView1.Location = new System.Drawing.Point(36, 48);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1343, 307);
            this.dataGridView1.TabIndex = 0;
            // 
            // iDBarangDataGridViewTextBoxColumn
            // 
            this.iDBarangDataGridViewTextBoxColumn.DataPropertyName = "ID_Barang";
            this.iDBarangDataGridViewTextBoxColumn.HeaderText = "ID_Barang";
            this.iDBarangDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDBarangDataGridViewTextBoxColumn.Name = "iDBarangDataGridViewTextBoxColumn";
            this.iDBarangDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDBarangDataGridViewTextBoxColumn.Visible = false;
            // 
            // namaBarangDataGridViewTextBoxColumn
            // 
            this.namaBarangDataGridViewTextBoxColumn.DataPropertyName = "Nama_Barang";
            this.namaBarangDataGridViewTextBoxColumn.HeaderText = "Nama_Barang";
            this.namaBarangDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namaBarangDataGridViewTextBoxColumn.Name = "namaBarangDataGridViewTextBoxColumn";
            this.namaBarangDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kategoriDataGridViewTextBoxColumn
            // 
            this.kategoriDataGridViewTextBoxColumn.DataPropertyName = "Kategori";
            this.kategoriDataGridViewTextBoxColumn.HeaderText = "Kategori";
            this.kategoriDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kategoriDataGridViewTextBoxColumn.Name = "kategoriDataGridViewTextBoxColumn";
            this.kategoriDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // brandDataGridViewTextBoxColumn
            // 
            this.brandDataGridViewTextBoxColumn.DataPropertyName = "Brand";
            this.brandDataGridViewTextBoxColumn.HeaderText = "Brand";
            this.brandDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.brandDataGridViewTextBoxColumn.Name = "brandDataGridViewTextBoxColumn";
            this.brandDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hargaDataGridViewTextBoxColumn
            // 
            this.hargaDataGridViewTextBoxColumn.DataPropertyName = "Harga";
            this.hargaDataGridViewTextBoxColumn.HeaderText = "Harga";
            this.hargaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hargaDataGridViewTextBoxColumn.Name = "hargaDataGridViewTextBoxColumn";
            this.hargaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stokDataGridViewTextBoxColumn
            // 
            this.stokDataGridViewTextBoxColumn.DataPropertyName = "Stok";
            this.stokDataGridViewTextBoxColumn.HeaderText = "Stok";
            this.stokDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stokDataGridViewTextBoxColumn.Name = "stokDataGridViewTextBoxColumn";
            this.stokDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(iD_BarangLabel);
            this.groupBox1.Controls.Add(this.iD_BarangTextBox);
            this.groupBox1.Controls.Add(stokLabel);
            this.groupBox1.Controls.Add(this.stokTextBox);
            this.groupBox1.Controls.Add(hargaLabel);
            this.groupBox1.Controls.Add(this.hargaTextBox);
            this.groupBox1.Controls.Add(brandLabel);
            this.groupBox1.Controls.Add(this.brandTextBox);
            this.groupBox1.Controls.Add(kategoriLabel);
            this.groupBox1.Controls.Add(this.kategoriTextBox);
            this.groupBox1.Controls.Add(nama_BarangLabel);
            this.groupBox1.Controls.Add(this.nama_BarangTextBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(51, 241);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(550, 354);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BetaMart Info :";
            // 
            // iD_BarangTextBox
            // 
            this.iD_BarangTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.barangBetaMartBindingSource, "ID_Barang", true));
            this.iD_BarangTextBox.Location = new System.Drawing.Point(175, 54);
            this.iD_BarangTextBox.Name = "iD_BarangTextBox";
            this.iD_BarangTextBox.Size = new System.Drawing.Size(345, 27);
            this.iD_BarangTextBox.TabIndex = 17;
            // 
            // stokTextBox
            // 
            this.stokTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.barangBetaMartBindingSource, "Stok", true));
            this.stokTextBox.Location = new System.Drawing.Point(175, 287);
            this.stokTextBox.Name = "stokTextBox";
            this.stokTextBox.Size = new System.Drawing.Size(345, 27);
            this.stokTextBox.TabIndex = 15;
            // 
            // hargaTextBox
            // 
            this.hargaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.barangBetaMartBindingSource, "Harga", true));
            this.hargaTextBox.Location = new System.Drawing.Point(175, 240);
            this.hargaTextBox.Name = "hargaTextBox";
            this.hargaTextBox.Size = new System.Drawing.Size(345, 27);
            this.hargaTextBox.TabIndex = 13;
            // 
            // brandTextBox
            // 
            this.brandTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.barangBetaMartBindingSource, "Brand", true));
            this.brandTextBox.Location = new System.Drawing.Point(175, 195);
            this.brandTextBox.Name = "brandTextBox";
            this.brandTextBox.Size = new System.Drawing.Size(345, 27);
            this.brandTextBox.TabIndex = 11;
            // 
            // kategoriTextBox
            // 
            this.kategoriTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.barangBetaMartBindingSource, "Kategori", true));
            this.kategoriTextBox.Location = new System.Drawing.Point(175, 146);
            this.kategoriTextBox.Name = "kategoriTextBox";
            this.kategoriTextBox.Size = new System.Drawing.Size(345, 27);
            this.kategoriTextBox.TabIndex = 9;
            // 
            // nama_BarangTextBox
            // 
            this.nama_BarangTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.barangBetaMartBindingSource, "Nama_Barang", true));
            this.nama_BarangTextBox.Location = new System.Drawing.Point(175, 98);
            this.nama_BarangTextBox.Name = "nama_BarangTextBox";
            this.nama_BarangTextBox.Size = new System.Drawing.Size(345, 27);
            this.nama_BarangTextBox.TabIndex = 7;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.White;
            this.statusStrip1.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 1032);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1519, 26);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "Status :";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.Color.White;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(74, 20);
            this.toolStripStatusLabel1.Text = "Status :";
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BindingSource = this.barangBetaMartBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.toolStripButtonSaveItem,
            this.toolStripButtonRefresh});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(1519, 27);
            this.bindingNavigator1.TabIndex = 0;
            this.bindingNavigator1.Text = "bindingNavigator1";
            this.bindingNavigator1.RefreshItems += new System.EventHandler(this.bindingNavigator1_RefreshItems);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bindingNavigatorAddNewItem.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.bindingNavigatorAddNewItem.Image = global::betaMartApplication.Properties.Resources.icon_insert;
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(95, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.Font = new System.Drawing.Font("Montserrat", 7.8F);
            this.bindingNavigatorDeleteItem.ForeColor = System.Drawing.Color.Red;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(80, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // toolStripButtonSaveItem
            // 
            this.toolStripButtonSaveItem.Font = new System.Drawing.Font("Montserrat", 7.8F);
            this.toolStripButtonSaveItem.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.toolStripButtonSaveItem.Image = global::betaMartApplication.Properties.Resources.icon_update;
            this.toolStripButtonSaveItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSaveItem.Name = "toolStripButtonSaveItem";
            this.toolStripButtonSaveItem.Size = new System.Drawing.Size(70, 24);
            this.toolStripButtonSaveItem.Text = "Save ";
            this.toolStripButtonSaveItem.Click += new System.EventHandler(this.toolStripButtonUpdateItem_Click);
            // 
            // toolStripButtonRefresh
            // 
            this.toolStripButtonRefresh.Font = new System.Drawing.Font("Montserrat", 7.8F);
            this.toolStripButtonRefresh.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.toolStripButtonRefresh.Image = global::betaMartApplication.Properties.Resources.icon_refresh;
            this.toolStripButtonRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRefresh.Name = "toolStripButtonRefresh";
            this.toolStripButtonRefresh.Size = new System.Drawing.Size(87, 24);
            this.toolStripButtonRefresh.Text = "Refresh";
            this.toolStripButtonRefresh.Click += new System.EventHandler(this.toolStripButtonRefresh_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.White;
            this.buttonExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.Color.Black;
            this.buttonExit.Image = global::betaMartApplication.Properties.Resources.icon_exit;
            this.buttonExit.Location = new System.Drawing.Point(1011, 325);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(145, 56);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.Text = "EXIT";
            this.buttonExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.White;
            this.buttonDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonDelete.FlatAppearance.BorderSize = 0;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.ForeColor = System.Drawing.Color.Black;
            this.buttonDelete.Image = global::betaMartApplication.Properties.Resources.icon_delete;
            this.buttonDelete.Location = new System.Drawing.Point(821, 325);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(145, 56);
            this.buttonDelete.TabIndex = 4;
            this.buttonDelete.Text = "DELETE";
            this.buttonDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.BackColor = System.Drawing.Color.White;
            this.buttonPrevious.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPrevious.FlatAppearance.BorderSize = 0;
            this.buttonPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrevious.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrevious.ForeColor = System.Drawing.Color.Black;
            this.buttonPrevious.Image = global::betaMartApplication.Properties.Resources.icon_previous;
            this.buttonPrevious.Location = new System.Drawing.Point(634, 241);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(145, 56);
            this.buttonPrevious.TabIndex = 0;
            this.buttonPrevious.Text = "PREVIOUS";
            this.buttonPrevious.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonPrevious.UseVisualStyleBackColor = false;
            this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.White;
            this.buttonSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSave.FlatAppearance.BorderSize = 0;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.ForeColor = System.Drawing.Color.Black;
            this.buttonSave.Image = global::betaMartApplication.Properties.Resources.icon_save;
            this.buttonSave.Location = new System.Drawing.Point(634, 325);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(145, 56);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "SAVE";
            this.buttonSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonAddNew
            // 
            this.buttonAddNew.BackColor = System.Drawing.Color.White;
            this.buttonAddNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAddNew.FlatAppearance.BorderSize = 0;
            this.buttonAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddNew.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddNew.ForeColor = System.Drawing.Color.Black;
            this.buttonAddNew.Image = global::betaMartApplication.Properties.Resources.icon_add;
            this.buttonAddNew.Location = new System.Drawing.Point(821, 241);
            this.buttonAddNew.Name = "buttonAddNew";
            this.buttonAddNew.Size = new System.Drawing.Size(145, 56);
            this.buttonAddNew.TabIndex = 1;
            this.buttonAddNew.Text = "ADD";
            this.buttonAddNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAddNew.UseVisualStyleBackColor = false;
            this.buttonAddNew.Click += new System.EventHandler(this.buttonAddNew_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.BackColor = System.Drawing.Color.White;
            this.buttonNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonNext.FlatAppearance.BorderSize = 0;
            this.buttonNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNext.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNext.ForeColor = System.Drawing.Color.Black;
            this.buttonNext.Image = global::betaMartApplication.Properties.Resources.icon_next;
            this.buttonNext.Location = new System.Drawing.Point(1011, 241);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(145, 56);
            this.buttonNext.TabIndex = 2;
            this.buttonNext.Text = "NEXT";
            this.buttonNext.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonNext.UseVisualStyleBackColor = false;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // barangBetaMartTableAdapter
            // 
            this.barangBetaMartTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.barangBetaMartTableAdapter = this.barangBetaMartTableAdapter;
            this.tableAdapterManager.UpdateOrder = betaMartApplication.betaMartDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // printDocumentDataGridView
            // 
            this.printDocumentDataGridView.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocumentDataGridView_PrintPage);
            // 
            // FormBetaMart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1559, 1055);
            this.Controls.Add(this.panel1);
            this.Name = "FormBetaMart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fast Moving Goods BetaMart";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormBetaMart_FormClosing);
            this.Load += new System.EventHandler(this.FormBetaMart_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barangBetaMartBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.betaMartDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton toolStripButtonSaveItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonAddNew;
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private betaMartDatabaseDataSet betaMartDatabaseDataSet;
        private System.Windows.Forms.BindingSource barangBetaMartBindingSource;
        private betaMartDatabaseDataSetTableAdapters.barangBetaMartTableAdapter barangBetaMartTableAdapter;
        private betaMartDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox stokTextBox;
        private System.Windows.Forms.TextBox hargaTextBox;
        private System.Windows.Forms.TextBox brandTextBox;
        private System.Windows.Forms.TextBox kategoriTextBox;
        private System.Windows.Forms.TextBox nama_BarangTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripButton toolStripButtonRefresh;
        private System.Windows.Forms.TextBox KeywordTextBox;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox iD_BarangTextBox;
        private System.Windows.Forms.PictureBox photoPictureBox;
        private System.Windows.Forms.Button chooseImageButton;
        private System.Windows.Forms.Button clearImageButton;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button btnPrintDataGridView;
        private System.Drawing.Printing.PrintDocument printDocumentDataGridView;
        private System.Windows.Forms.CheckBox barangTersediaCheckBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDBarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaBarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kategoriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokDataGridViewTextBoxColumn;
    }
}

