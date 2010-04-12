namespace QuizEditor
{
    partial class Editor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editor));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conectarBDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarCambiosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.herramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editorDeCategoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.elementosFijosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.buttonSaveQuestion = new System.Windows.Forms.ToolStripButton();
            this.buttonSaveAllQuestion = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.questionList = new System.Windows.Forms.ListBox();
            this.splitContainer8 = new System.Windows.Forms.SplitContainer();
            this.newQuestion = new System.Windows.Forms.Button();
            this.deleteQuestion = new System.Windows.Forms.Button();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxQuestion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.trackBarDifficulty = new System.Windows.Forms.TrackBar();
            this.labelDifficulty = new System.Windows.Forms.Label();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.textBoxImageRute = new System.Windows.Forms.TextBox();
            this.buttonImage = new System.Windows.Forms.Button();
            this.splitContainer6 = new System.Windows.Forms.SplitContainer();
            this.textBoxSoundRute = new System.Windows.Forms.TextBox();
            this.buttonSound = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.splitContainer7 = new System.Windows.Forms.SplitContainer();
            this.answersList = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonCreateAnswer = new System.Windows.Forms.Button();
            this.buttonEditAnswer = new System.Windows.Forms.Button();
            this.buttonDeleteAnswer = new System.Windows.Forms.Button();
            this.openImageFile = new System.Windows.Forms.OpenFileDialog();
            this.openSoundFile = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.splitContainer8.Panel1.SuspendLayout();
            this.splitContainer8.Panel2.SuspendLayout();
            this.splitContainer8.SuspendLayout();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDifficulty)).BeginInit();
            this.splitContainer5.Panel1.SuspendLayout();
            this.splitContainer5.Panel2.SuspendLayout();
            this.splitContainer5.SuspendLayout();
            this.splitContainer6.Panel1.SuspendLayout();
            this.splitContainer6.Panel2.SuspendLayout();
            this.splitContainer6.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.splitContainer7.Panel1.SuspendLayout();
            this.splitContainer7.Panel2.SuspendLayout();
            this.splitContainer7.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.herramientasToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(706, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.conectarBDToolStripMenuItem,
            this.guardarCambiosToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // conectarBDToolStripMenuItem
            // 
            this.conectarBDToolStripMenuItem.Name = "conectarBDToolStripMenuItem";
            this.conectarBDToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.conectarBDToolStripMenuItem.Text = "Conectar BD";
            // 
            // guardarCambiosToolStripMenuItem
            // 
            this.guardarCambiosToolStripMenuItem.Name = "guardarCambiosToolStripMenuItem";
            this.guardarCambiosToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.guardarCambiosToolStripMenuItem.Text = "Guardar Cambios";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // herramientasToolStripMenuItem
            // 
            this.herramientasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editorDeCategoriasToolStripMenuItem,
            this.elementosFijosToolStripMenuItem});
            this.herramientasToolStripMenuItem.Name = "herramientasToolStripMenuItem";
            this.herramientasToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.herramientasToolStripMenuItem.Text = "Herramientas";
            // 
            // editorDeCategoriasToolStripMenuItem
            // 
            this.editorDeCategoriasToolStripMenuItem.Name = "editorDeCategoriasToolStripMenuItem";
            this.editorDeCategoriasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editorDeCategoriasToolStripMenuItem.Text = "Editor de Categorias";
            this.editorDeCategoriasToolStripMenuItem.Click += new System.EventHandler(this.editorDeCategoriasToolStripMenuItem_Click);
            // 
            // elementosFijosToolStripMenuItem
            // 
            this.elementosFijosToolStripMenuItem.Name = "elementosFijosToolStripMenuItem";
            this.elementosFijosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.elementosFijosToolStripMenuItem.Text = "Elementos fijos";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonSaveQuestion,
            this.buttonSaveAllQuestion});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(706, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // buttonSaveQuestion
            // 
            this.buttonSaveQuestion.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonSaveQuestion.Image = ((System.Drawing.Image)(resources.GetObject("buttonSaveQuestion.Image")));
            this.buttonSaveQuestion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonSaveQuestion.Name = "buttonSaveQuestion";
            this.buttonSaveQuestion.Size = new System.Drawing.Size(23, 22);
            this.buttonSaveQuestion.Text = "Guardar Cambios en la pregunta";
            this.buttonSaveQuestion.Click += new System.EventHandler(this.SaveChange);
            // 
            // buttonSaveAllQuestion
            // 
            this.buttonSaveAllQuestion.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonSaveAllQuestion.Image = ((System.Drawing.Image)(resources.GetObject("buttonSaveAllQuestion.Image")));
            this.buttonSaveAllQuestion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonSaveAllQuestion.Name = "buttonSaveAllQuestion";
            this.buttonSaveAllQuestion.Size = new System.Drawing.Size(23, 22);
            this.buttonSaveAllQuestion.Text = "Guardar todos los cambios";
            this.buttonSaveAllQuestion.Click += new System.EventHandler(this.SaveAllChanges);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 49);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer1.Size = new System.Drawing.Size(706, 399);
            this.splitContainer1.SplitterDistance = 229;
            this.splitContainer1.TabIndex = 2;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.questionList);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer8);
            this.splitContainer2.Size = new System.Drawing.Size(229, 399);
            this.splitContainer2.SplitterDistance = 353;
            this.splitContainer2.TabIndex = 0;
            // 
            // questionList
            // 
            this.questionList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.questionList.FormattingEnabled = true;
            this.questionList.Location = new System.Drawing.Point(0, 0);
            this.questionList.Name = "questionList";
            this.questionList.Size = new System.Drawing.Size(229, 355);
            this.questionList.TabIndex = 0;
            this.questionList.SelectedIndexChanged += new System.EventHandler(this.questionList_SelectedIndexChanged);
            // 
            // splitContainer8
            // 
            this.splitContainer8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer8.Location = new System.Drawing.Point(0, 0);
            this.splitContainer8.Name = "splitContainer8";
            // 
            // splitContainer8.Panel1
            // 
            this.splitContainer8.Panel1.Controls.Add(this.newQuestion);
            // 
            // splitContainer8.Panel2
            // 
            this.splitContainer8.Panel2.Controls.Add(this.deleteQuestion);
            this.splitContainer8.Size = new System.Drawing.Size(229, 42);
            this.splitContainer8.SplitterDistance = 108;
            this.splitContainer8.TabIndex = 0;
            // 
            // newQuestion
            // 
            this.newQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.newQuestion.Location = new System.Drawing.Point(4, 5);
            this.newQuestion.Name = "newQuestion";
            this.newQuestion.Size = new System.Drawing.Size(101, 34);
            this.newQuestion.TabIndex = 0;
            this.newQuestion.Text = "Nueva Pregunta";
            this.newQuestion.UseVisualStyleBackColor = true;
            this.newQuestion.Click += new System.EventHandler(this.ButtonAddQuestion);
            // 
            // deleteQuestion
            // 
            this.deleteQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteQuestion.Enabled = false;
            this.deleteQuestion.Location = new System.Drawing.Point(4, 4);
            this.deleteQuestion.Name = "deleteQuestion";
            this.deleteQuestion.Size = new System.Drawing.Size(111, 35);
            this.deleteQuestion.TabIndex = 0;
            this.deleteQuestion.Text = "Borrar Pregunta";
            this.deleteQuestion.UseVisualStyleBackColor = true;
            this.deleteQuestion.Click += new System.EventHandler(this.ButtonDeleteQuestion);
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer3.Size = new System.Drawing.Size(473, 399);
            this.splitContainer3.SplitterDistance = 224;
            this.splitContainer3.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(473, 221);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pregunta";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.textBoxQuestion, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxCategory, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.splitContainer4, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.splitContainer5, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.splitContainer6, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(461, 196);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // textBoxQuestion
            // 
            this.textBoxQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxQuestion.Enabled = false;
            this.textBoxQuestion.Location = new System.Drawing.Point(103, 3);
            this.textBoxQuestion.Multiline = true;
            this.textBoxQuestion.Name = "textBoxQuestion";
            this.textBoxQuestion.Size = new System.Drawing.Size(355, 33);
            this.textBoxQuestion.TabIndex = 0;
            this.textBoxQuestion.TextChanged += new System.EventHandler(this.ChangeQuestionText);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Categoría";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Dificultad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Imagen/Video";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Sonido/Música";
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxCategory.Enabled = false;
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(103, 42);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(355, 21);
            this.comboBoxCategory.TabIndex = 6;
            this.comboBoxCategory.SelectedIndexChanged += new System.EventHandler(this.ChangeCategoryQuestion);
            // 
            // splitContainer4
            // 
            this.splitContainer4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer4.Location = new System.Drawing.Point(103, 81);
            this.splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.trackBarDifficulty);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.labelDifficulty);
            this.splitContainer4.Size = new System.Drawing.Size(355, 33);
            this.splitContainer4.SplitterDistance = 294;
            this.splitContainer4.TabIndex = 7;
            // 
            // trackBarDifficulty
            // 
            this.trackBarDifficulty.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarDifficulty.Enabled = false;
            this.trackBarDifficulty.LargeChange = 1;
            this.trackBarDifficulty.Location = new System.Drawing.Point(0, 0);
            this.trackBarDifficulty.Maximum = 4;
            this.trackBarDifficulty.Name = "trackBarDifficulty";
            this.trackBarDifficulty.Size = new System.Drawing.Size(291, 45);
            this.trackBarDifficulty.TabIndex = 0;
            this.trackBarDifficulty.ValueChanged += new System.EventHandler(this.ChangeTextDifficulty);
            // 
            // labelDifficulty
            // 
            this.labelDifficulty.AutoSize = true;
            this.labelDifficulty.Enabled = false;
            this.labelDifficulty.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDifficulty.Location = new System.Drawing.Point(15, 4);
            this.labelDifficulty.Name = "labelDifficulty";
            this.labelDifficulty.Size = new System.Drawing.Size(20, 22);
            this.labelDifficulty.TabIndex = 0;
            this.labelDifficulty.Text = "1";
            // 
            // splitContainer5
            // 
            this.splitContainer5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer5.Location = new System.Drawing.Point(103, 120);
            this.splitContainer5.Name = "splitContainer5";
            // 
            // splitContainer5.Panel1
            // 
            this.splitContainer5.Panel1.Controls.Add(this.textBoxImageRute);
            // 
            // splitContainer5.Panel2
            // 
            this.splitContainer5.Panel2.Controls.Add(this.buttonImage);
            this.splitContainer5.Size = new System.Drawing.Size(355, 33);
            this.splitContainer5.SplitterDistance = 254;
            this.splitContainer5.TabIndex = 8;
            // 
            // textBoxImageRute
            // 
            this.textBoxImageRute.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxImageRute.Enabled = false;
            this.textBoxImageRute.Location = new System.Drawing.Point(4, 8);
            this.textBoxImageRute.Name = "textBoxImageRute";
            this.textBoxImageRute.Size = new System.Drawing.Size(247, 20);
            this.textBoxImageRute.TabIndex = 0;
            // 
            // buttonImage
            // 
            this.buttonImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonImage.Enabled = false;
            this.buttonImage.Location = new System.Drawing.Point(4, 3);
            this.buttonImage.Name = "buttonImage";
            this.buttonImage.Size = new System.Drawing.Size(90, 27);
            this.buttonImage.TabIndex = 0;
            this.buttonImage.Text = "Archivo";
            this.buttonImage.UseVisualStyleBackColor = true;
            this.buttonImage.Click += new System.EventHandler(this.OpenFileImage);
            // 
            // splitContainer6
            // 
            this.splitContainer6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer6.Location = new System.Drawing.Point(103, 159);
            this.splitContainer6.Name = "splitContainer6";
            // 
            // splitContainer6.Panel1
            // 
            this.splitContainer6.Panel1.Controls.Add(this.textBoxSoundRute);
            // 
            // splitContainer6.Panel2
            // 
            this.splitContainer6.Panel2.Controls.Add(this.buttonSound);
            this.splitContainer6.Size = new System.Drawing.Size(355, 34);
            this.splitContainer6.SplitterDistance = 254;
            this.splitContainer6.TabIndex = 9;
            // 
            // textBoxSoundRute
            // 
            this.textBoxSoundRute.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSoundRute.Enabled = false;
            this.textBoxSoundRute.Location = new System.Drawing.Point(3, 8);
            this.textBoxSoundRute.Name = "textBoxSoundRute";
            this.textBoxSoundRute.Size = new System.Drawing.Size(247, 20);
            this.textBoxSoundRute.TabIndex = 0;
            // 
            // buttonSound
            // 
            this.buttonSound.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSound.Enabled = false;
            this.buttonSound.Location = new System.Drawing.Point(4, 4);
            this.buttonSound.Name = "buttonSound";
            this.buttonSound.Size = new System.Drawing.Size(90, 27);
            this.buttonSound.TabIndex = 0;
            this.buttonSound.Text = "Archivo";
            this.buttonSound.UseVisualStyleBackColor = true;
            this.buttonSound.Click += new System.EventHandler(this.OpenFileSound);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pregunta";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.splitContainer7);
            this.groupBox2.Location = new System.Drawing.Point(0, -1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(473, 172);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Respuestas";
            // 
            // splitContainer7
            // 
            this.splitContainer7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer7.Location = new System.Drawing.Point(3, 16);
            this.splitContainer7.Name = "splitContainer7";
            // 
            // splitContainer7.Panel1
            // 
            this.splitContainer7.Panel1.Controls.Add(this.answersList);
            // 
            // splitContainer7.Panel2
            // 
            this.splitContainer7.Panel2.Controls.Add(this.tableLayoutPanel2);
            this.splitContainer7.Size = new System.Drawing.Size(467, 153);
            this.splitContainer7.SplitterDistance = 338;
            this.splitContainer7.TabIndex = 0;
            // 
            // answersList
            // 
            this.answersList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.answersList.FormattingEnabled = true;
            this.answersList.Location = new System.Drawing.Point(0, 0);
            this.answersList.Name = "answersList";
            this.answersList.Size = new System.Drawing.Size(335, 160);
            this.answersList.TabIndex = 0;
            this.answersList.SelectedIndexChanged += new System.EventHandler(this.SelectAnswer);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.buttonCreateAnswer, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonEditAnswer, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.buttonDeleteAnswer, 0, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(-1, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(126, 153);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // buttonCreateAnswer
            // 
            this.buttonCreateAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCreateAnswer.Enabled = false;
            this.buttonCreateAnswer.Location = new System.Drawing.Point(3, 3);
            this.buttonCreateAnswer.Name = "buttonCreateAnswer";
            this.buttonCreateAnswer.Size = new System.Drawing.Size(120, 45);
            this.buttonCreateAnswer.TabIndex = 0;
            this.buttonCreateAnswer.Text = "Añadir";
            this.buttonCreateAnswer.UseVisualStyleBackColor = true;
            this.buttonCreateAnswer.Click += new System.EventHandler(this.AñadirRespuesta);
            // 
            // buttonEditAnswer
            // 
            this.buttonEditAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEditAnswer.Enabled = false;
            this.buttonEditAnswer.Location = new System.Drawing.Point(3, 54);
            this.buttonEditAnswer.Name = "buttonEditAnswer";
            this.buttonEditAnswer.Size = new System.Drawing.Size(120, 45);
            this.buttonEditAnswer.TabIndex = 1;
            this.buttonEditAnswer.Text = "Editar";
            this.buttonEditAnswer.UseVisualStyleBackColor = true;
            this.buttonEditAnswer.Click += new System.EventHandler(this.EditarRespuesta);
            // 
            // buttonDeleteAnswer
            // 
            this.buttonDeleteAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDeleteAnswer.Enabled = false;
            this.buttonDeleteAnswer.Location = new System.Drawing.Point(3, 105);
            this.buttonDeleteAnswer.Name = "buttonDeleteAnswer";
            this.buttonDeleteAnswer.Size = new System.Drawing.Size(120, 45);
            this.buttonDeleteAnswer.TabIndex = 2;
            this.buttonDeleteAnswer.Text = "Borrar";
            this.buttonDeleteAnswer.UseVisualStyleBackColor = true;
            // 
            // openImageFile
            // 
            this.openImageFile.FileName = "openFileDialog1";
            // 
            // openSoundFile
            // 
            this.openSoundFile.FileName = "openFileDialog2";
            // 
            // Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 448);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Editor";
            this.Text = "QuizEditor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer8.Panel1.ResumeLayout(false);
            this.splitContainer8.Panel2.ResumeLayout(false);
            this.splitContainer8.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel1.PerformLayout();
            this.splitContainer4.Panel2.ResumeLayout(false);
            this.splitContainer4.Panel2.PerformLayout();
            this.splitContainer4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDifficulty)).EndInit();
            this.splitContainer5.Panel1.ResumeLayout(false);
            this.splitContainer5.Panel1.PerformLayout();
            this.splitContainer5.Panel2.ResumeLayout(false);
            this.splitContainer5.ResumeLayout(false);
            this.splitContainer6.Panel1.ResumeLayout(false);
            this.splitContainer6.Panel1.PerformLayout();
            this.splitContainer6.Panel2.ResumeLayout(false);
            this.splitContainer6.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.splitContainer7.Panel1.ResumeLayout(false);
            this.splitContainer7.Panel2.ResumeLayout(false);
            this.splitContainer7.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ListBox questionList;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem herramientasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editorDeCategoriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem elementosFijosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBoxQuestion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.TrackBar trackBarDifficulty;
        private System.Windows.Forms.Label labelDifficulty;
        private System.Windows.Forms.SplitContainer splitContainer5;
        private System.Windows.Forms.TextBox textBoxImageRute;
        private System.Windows.Forms.Button buttonImage;
        private System.Windows.Forms.SplitContainer splitContainer6;
        private System.Windows.Forms.TextBox textBoxSoundRute;
        private System.Windows.Forms.Button buttonSound;
        private System.Windows.Forms.SplitContainer splitContainer7;
        private System.Windows.Forms.ListBox answersList;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.SplitContainer splitContainer8;
        private System.Windows.Forms.Button newQuestion;
        private System.Windows.Forms.Button deleteQuestion;
        private System.Windows.Forms.Button buttonEditAnswer;
        private System.Windows.Forms.Button buttonDeleteAnswer;
        private System.Windows.Forms.Button buttonCreateAnswer;
        private System.Windows.Forms.ToolStripMenuItem conectarBDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openImageFile;
        private System.Windows.Forms.OpenFileDialog openSoundFile;
        private System.Windows.Forms.ToolStripMenuItem guardarCambiosToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton buttonSaveQuestion;
        private System.Windows.Forms.ToolStripButton buttonSaveAllQuestion;
    }
}