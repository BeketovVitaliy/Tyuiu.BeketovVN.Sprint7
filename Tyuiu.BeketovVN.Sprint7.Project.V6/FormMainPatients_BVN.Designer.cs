namespace Tyuiu.BeketovVN.Sprint7.Project.V6
{
    partial class FormMainPatients_BVN
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainPatients_BVN));
            this.dataGridViewPatients_BVN = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SNP_BVN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorSNP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorPosition_BVN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diagnosis_BVN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ambulatoryCare_BVN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.disabilityTime_BVN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dispanser_BVN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notes_BVN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStripMust_BVN = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItemFile_BVN = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemNewTable_BVN = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemOpen_BVN = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemSave_BVN = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemSaveAs_BVN = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemHelp_BVN = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemUserGuide_BVN = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemAbout_BVN = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialogExcel_BVN = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogExcel_BVN = new System.Windows.Forms.SaveFileDialog();
            this.toolTipForButtons_BVN = new System.Windows.Forms.ToolTip(this.components);
            this.buttonDeletePatient_BVN = new System.Windows.Forms.Button();
            this.buttonAddPatient_BVN = new System.Windows.Forms.Button();
            this.buttonGoToPatient_BVN = new System.Windows.Forms.Button();
            this.groupBoxFilters_BVN = new System.Windows.Forms.GroupBox();
            this.labelDispanser_BVN = new System.Windows.Forms.Label();
            this.labelDisabilityTime_BVN = new System.Windows.Forms.Label();
            this.labelAmbulatoryCare_BVN = new System.Windows.Forms.Label();
            this.comboBoxDispanser_BVN = new System.Windows.Forms.ComboBox();
            this.comboBoxAmbulatory_BVN = new System.Windows.Forms.ComboBox();
            this.numericUpDownDisabilityTime_BVN = new System.Windows.Forms.NumericUpDown();
            this.labelSearch_BVN = new System.Windows.Forms.Label();
            this.textBoxSearch_BVN = new System.Windows.Forms.TextBox();
            this.buttonReset_BVN = new System.Windows.Forms.Button();
            this.labelBirthday_BVN = new System.Windows.Forms.Label();
            this.numericUpDownID_BVN = new System.Windows.Forms.NumericUpDown();
            this.dateTimePickerBirthday_BVN = new System.Windows.Forms.DateTimePicker();
            this.labelDiagnosis_BVN = new System.Windows.Forms.Label();
            this.labelDoctorSPN_BVN = new System.Windows.Forms.Label();
            this.labelPatientSPN_BVN = new System.Windows.Forms.Label();
            this.labelID_BVN = new System.Windows.Forms.Label();
            this.textBoxDiagnosis_BVN = new System.Windows.Forms.TextBox();
            this.textBoxDoctorSPN_BVN = new System.Windows.Forms.TextBox();
            this.textBoxPatientSPN_BVN = new System.Windows.Forms.TextBox();
            this.groupBoxInstruments_BVN = new System.Windows.Forms.GroupBox();
            this.panelForTable_BVN = new System.Windows.Forms.Panel();
            this.panelForGroupBoxes_BVN = new System.Windows.Forms.Panel();
            this.panelBetweenGroupBoxes_BVN = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatients_BVN)).BeginInit();
            this.menuStripMust_BVN.SuspendLayout();
            this.groupBoxFilters_BVN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDisabilityTime_BVN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownID_BVN)).BeginInit();
            this.groupBoxInstruments_BVN.SuspendLayout();
            this.panelForTable_BVN.SuspendLayout();
            this.panelForGroupBoxes_BVN.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewPatients_BVN
            // 
            this.dataGridViewPatients_BVN.AllowUserToAddRows = false;
            this.dataGridViewPatients_BVN.AllowUserToDeleteRows = false;
            this.dataGridViewPatients_BVN.AllowUserToResizeColumns = false;
            this.dataGridViewPatients_BVN.AllowUserToResizeRows = false;
            this.dataGridViewPatients_BVN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPatients_BVN.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Fuchsia;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPatients_BVN.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewPatients_BVN.ColumnHeadersHeight = 45;
            this.dataGridViewPatients_BVN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.SNP_BVN,
            this.BirthDate,
            this.doctorSNP,
            this.doctorPosition_BVN,
            this.diagnosis_BVN,
            this.ambulatoryCare_BVN,
            this.disabilityTime_BVN,
            this.dispanser_BVN,
            this.notes_BVN});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewPatients_BVN.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewPatients_BVN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewPatients_BVN.EnableHeadersVisualStyles = false;
            this.dataGridViewPatients_BVN.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewPatients_BVN.Name = "dataGridViewPatients_BVN";
            this.dataGridViewPatients_BVN.RowHeadersVisible = false;
            this.dataGridViewPatients_BVN.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.dataGridViewPatients_BVN.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewPatients_BVN.RowTemplate.Height = 25;
            this.dataGridViewPatients_BVN.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPatients_BVN.Size = new System.Drawing.Size(1258, 415);
            this.dataGridViewPatients_BVN.TabIndex = 0;
            this.dataGridViewPatients_BVN.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewPatients_BVN_CellContentClick);
            this.dataGridViewPatients_BVN.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPatients_BVN_CellEndEdit);
            this.dataGridViewPatients_BVN.SelectionChanged += new System.EventHandler(this.dataGridViewPatients_BVN_SelectionChanged);
            this.dataGridViewPatients_BVN.SortCompare += new System.Windows.Forms.DataGridViewSortCompareEventHandler(this.dataGridViewPatients_BVN_SortCompare);
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Id.HeaderText = "Номер";
            this.Id.Name = "Id";
            this.Id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Id.Width = 85;
            // 
            // SNP_BVN
            // 
            this.SNP_BVN.HeaderText = "ФИО пациента";
            this.SNP_BVN.MinimumWidth = 200;
            this.SNP_BVN.Name = "SNP_BVN";
            this.SNP_BVN.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // BirthDate
            // 
            this.BirthDate.HeaderText = "Дата Рождения";
            this.BirthDate.Name = "BirthDate";
            this.BirthDate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // doctorSNP
            // 
            this.doctorSNP.HeaderText = "ФИО врача";
            this.doctorSNP.Name = "doctorSNP";
            // 
            // doctorPosition_BVN
            // 
            this.doctorPosition_BVN.HeaderText = "Должность врача";
            this.doctorPosition_BVN.Name = "doctorPosition_BVN";
            // 
            // diagnosis_BVN
            // 
            this.diagnosis_BVN.HeaderText = "Диагноз";
            this.diagnosis_BVN.Name = "diagnosis_BVN";
            // 
            // ambulatoryCare_BVN
            // 
            this.ambulatoryCare_BVN.HeaderText = "Амбулаторное лечение";
            this.ambulatoryCare_BVN.Name = "ambulatoryCare_BVN";
            // 
            // disabilityTime_BVN
            // 
            this.disabilityTime_BVN.HeaderText = "Срок потери трудоспособности";
            this.disabilityTime_BVN.Name = "disabilityTime_BVN";
            // 
            // dispanser_BVN
            // 
            this.dispanser_BVN.HeaderText = "Диспансерный учёт";
            this.dispanser_BVN.Name = "dispanser_BVN";
            // 
            // notes_BVN
            // 
            this.notes_BVN.HeaderText = "Примечание";
            this.notes_BVN.Name = "notes_BVN";
            // 
            // menuStripMust_BVN
            // 
            this.menuStripMust_BVN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.menuStripMust_BVN.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemFile_BVN,
            this.ToolStripMenuItemHelp_BVN});
            this.menuStripMust_BVN.Location = new System.Drawing.Point(0, 0);
            this.menuStripMust_BVN.Name = "menuStripMust_BVN";
            this.menuStripMust_BVN.Size = new System.Drawing.Size(1258, 25);
            this.menuStripMust_BVN.TabIndex = 1;
            this.menuStripMust_BVN.Text = "menuStrip1";
            // 
            // ToolStripMenuItemFile_BVN
            // 
            this.ToolStripMenuItemFile_BVN.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemNewTable_BVN,
            this.ToolStripMenuItemOpen_BVN,
            this.ToolStripMenuItemSave_BVN,
            this.ToolStripMenuItemSaveAs_BVN});
            this.ToolStripMenuItemFile_BVN.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToolStripMenuItemFile_BVN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.ToolStripMenuItemFile_BVN.Name = "ToolStripMenuItemFile_BVN";
            this.ToolStripMenuItemFile_BVN.Size = new System.Drawing.Size(50, 21);
            this.ToolStripMenuItemFile_BVN.Text = "Файл";
            // 
            // ToolStripMenuItemNewTable_BVN
            // 
            this.ToolStripMenuItemNewTable_BVN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.ToolStripMenuItemNewTable_BVN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.ToolStripMenuItemNewTable_BVN.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripMenuItemNewTable_BVN.Image")));
            this.ToolStripMenuItemNewTable_BVN.Name = "ToolStripMenuItemNewTable_BVN";
            this.ToolStripMenuItemNewTable_BVN.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItemNewTable_BVN.Text = "Новая таблица";
            this.ToolStripMenuItemNewTable_BVN.Click += new System.EventHandler(this.ToolStripMenuItemNewTable_BVN_Click);
            // 
            // ToolStripMenuItemOpen_BVN
            // 
            this.ToolStripMenuItemOpen_BVN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.ToolStripMenuItemOpen_BVN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.ToolStripMenuItemOpen_BVN.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripMenuItemOpen_BVN.Image")));
            this.ToolStripMenuItemOpen_BVN.Name = "ToolStripMenuItemOpen_BVN";
            this.ToolStripMenuItemOpen_BVN.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItemOpen_BVN.Text = "Открыть...";
            this.ToolStripMenuItemOpen_BVN.Click += new System.EventHandler(this.ToolStripMenuItemOpen_BVN_Click);
            // 
            // ToolStripMenuItemSave_BVN
            // 
            this.ToolStripMenuItemSave_BVN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.ToolStripMenuItemSave_BVN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.ToolStripMenuItemSave_BVN.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripMenuItemSave_BVN.Image")));
            this.ToolStripMenuItemSave_BVN.Name = "ToolStripMenuItemSave_BVN";
            this.ToolStripMenuItemSave_BVN.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItemSave_BVN.Text = "Сохранить";
            this.ToolStripMenuItemSave_BVN.Click += new System.EventHandler(this.ToolStripMenuItemSave_BVN_Click);
            // 
            // ToolStripMenuItemSaveAs_BVN
            // 
            this.ToolStripMenuItemSaveAs_BVN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.ToolStripMenuItemSaveAs_BVN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.ToolStripMenuItemSaveAs_BVN.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripMenuItemSaveAs_BVN.Image")));
            this.ToolStripMenuItemSaveAs_BVN.Name = "ToolStripMenuItemSaveAs_BVN";
            this.ToolStripMenuItemSaveAs_BVN.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItemSaveAs_BVN.Text = "Сохранить как...";
            this.ToolStripMenuItemSaveAs_BVN.Click += new System.EventHandler(this.ToolStripMenuItemSaveAs_BVN_Click);
            // 
            // ToolStripMenuItemHelp_BVN
            // 
            this.ToolStripMenuItemHelp_BVN.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemUserGuide_BVN,
            this.ToolStripMenuItemAbout_BVN});
            this.ToolStripMenuItemHelp_BVN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.ToolStripMenuItemHelp_BVN.Name = "ToolStripMenuItemHelp_BVN";
            this.ToolStripMenuItemHelp_BVN.Size = new System.Drawing.Size(68, 21);
            this.ToolStripMenuItemHelp_BVN.Text = "Помощь";
            // 
            // ToolStripMenuItemUserGuide_BVN
            // 
            this.ToolStripMenuItemUserGuide_BVN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.ToolStripMenuItemUserGuide_BVN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.ToolStripMenuItemUserGuide_BVN.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripMenuItemUserGuide_BVN.Image")));
            this.ToolStripMenuItemUserGuide_BVN.Name = "ToolStripMenuItemUserGuide_BVN";
            this.ToolStripMenuItemUserGuide_BVN.Size = new System.Drawing.Size(223, 22);
            this.ToolStripMenuItemUserGuide_BVN.Text = "Руководство Пользователя";
            this.ToolStripMenuItemUserGuide_BVN.Click += new System.EventHandler(this.ToolStripMenuItemUserGuide_BVN_Click);
            // 
            // ToolStripMenuItemAbout_BVN
            // 
            this.ToolStripMenuItemAbout_BVN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.ToolStripMenuItemAbout_BVN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.ToolStripMenuItemAbout_BVN.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripMenuItemAbout_BVN.Image")));
            this.ToolStripMenuItemAbout_BVN.Name = "ToolStripMenuItemAbout_BVN";
            this.ToolStripMenuItemAbout_BVN.Size = new System.Drawing.Size(223, 22);
            this.ToolStripMenuItemAbout_BVN.Text = "О программме";
            this.ToolStripMenuItemAbout_BVN.Click += new System.EventHandler(this.ToolStripMenuItemAbout_BVN_Click);
            // 
            // openFileDialogExcel_BVN
            // 
            this.openFileDialogExcel_BVN.FileName = "openFileDialog1";
            // 
            // buttonDeletePatient_BVN
            // 
            this.buttonDeletePatient_BVN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.buttonDeletePatient_BVN.Enabled = false;
            this.buttonDeletePatient_BVN.Image = ((System.Drawing.Image)(resources.GetObject("buttonDeletePatient_BVN.Image")));
            this.buttonDeletePatient_BVN.Location = new System.Drawing.Point(193, 41);
            this.buttonDeletePatient_BVN.Name = "buttonDeletePatient_BVN";
            this.buttonDeletePatient_BVN.Size = new System.Drawing.Size(66, 56);
            this.buttonDeletePatient_BVN.TabIndex = 3;
            this.toolTipForButtons_BVN.SetToolTip(this.buttonDeletePatient_BVN, "Удалить строку");
            this.buttonDeletePatient_BVN.UseVisualStyleBackColor = false;
            this.buttonDeletePatient_BVN.Click += new System.EventHandler(this.buttonDeletePatient_BVN_Click);
            // 
            // buttonAddPatient_BVN
            // 
            this.buttonAddPatient_BVN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.buttonAddPatient_BVN.Image = ((System.Drawing.Image)(resources.GetObject("buttonAddPatient_BVN.Image")));
            this.buttonAddPatient_BVN.Location = new System.Drawing.Point(121, 41);
            this.buttonAddPatient_BVN.Name = "buttonAddPatient_BVN";
            this.buttonAddPatient_BVN.Size = new System.Drawing.Size(66, 56);
            this.buttonAddPatient_BVN.TabIndex = 1;
            this.toolTipForButtons_BVN.SetToolTip(this.buttonAddPatient_BVN, "Добавить строку");
            this.buttonAddPatient_BVN.UseVisualStyleBackColor = false;
            this.buttonAddPatient_BVN.Click += new System.EventHandler(this.buttonAddPatient_BVN_Click);
            // 
            // buttonGoToPatient_BVN
            // 
            this.buttonGoToPatient_BVN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.buttonGoToPatient_BVN.Enabled = false;
            this.buttonGoToPatient_BVN.Image = ((System.Drawing.Image)(resources.GetObject("buttonGoToPatient_BVN.Image")));
            this.buttonGoToPatient_BVN.Location = new System.Drawing.Point(16, 35);
            this.buttonGoToPatient_BVN.Name = "buttonGoToPatient_BVN";
            this.buttonGoToPatient_BVN.Size = new System.Drawing.Size(80, 71);
            this.buttonGoToPatient_BVN.TabIndex = 0;
            this.toolTipForButtons_BVN.SetToolTip(this.buttonGoToPatient_BVN, "Перейти к пациенту");
            this.buttonGoToPatient_BVN.UseVisualStyleBackColor = false;
            this.buttonGoToPatient_BVN.Click += new System.EventHandler(this.buttonGoToPAtient_BVN_Click);
            // 
            // groupBoxFilters_BVN
            // 
            this.groupBoxFilters_BVN.Controls.Add(this.labelDispanser_BVN);
            this.groupBoxFilters_BVN.Controls.Add(this.labelDisabilityTime_BVN);
            this.groupBoxFilters_BVN.Controls.Add(this.labelAmbulatoryCare_BVN);
            this.groupBoxFilters_BVN.Controls.Add(this.comboBoxDispanser_BVN);
            this.groupBoxFilters_BVN.Controls.Add(this.comboBoxAmbulatory_BVN);
            this.groupBoxFilters_BVN.Controls.Add(this.numericUpDownDisabilityTime_BVN);
            this.groupBoxFilters_BVN.Controls.Add(this.labelSearch_BVN);
            this.groupBoxFilters_BVN.Controls.Add(this.textBoxSearch_BVN);
            this.groupBoxFilters_BVN.Controls.Add(this.buttonReset_BVN);
            this.groupBoxFilters_BVN.Controls.Add(this.labelBirthday_BVN);
            this.groupBoxFilters_BVN.Controls.Add(this.numericUpDownID_BVN);
            this.groupBoxFilters_BVN.Controls.Add(this.dateTimePickerBirthday_BVN);
            this.groupBoxFilters_BVN.Controls.Add(this.labelDiagnosis_BVN);
            this.groupBoxFilters_BVN.Controls.Add(this.labelDoctorSPN_BVN);
            this.groupBoxFilters_BVN.Controls.Add(this.labelPatientSPN_BVN);
            this.groupBoxFilters_BVN.Controls.Add(this.labelID_BVN);
            this.groupBoxFilters_BVN.Controls.Add(this.textBoxDiagnosis_BVN);
            this.groupBoxFilters_BVN.Controls.Add(this.textBoxDoctorSPN_BVN);
            this.groupBoxFilters_BVN.Controls.Add(this.textBoxPatientSPN_BVN);
            this.groupBoxFilters_BVN.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBoxFilters_BVN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxFilters_BVN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.groupBoxFilters_BVN.Location = new System.Drawing.Point(343, 0);
            this.groupBoxFilters_BVN.Name = "groupBoxFilters_BVN";
            this.groupBoxFilters_BVN.Size = new System.Drawing.Size(915, 144);
            this.groupBoxFilters_BVN.TabIndex = 3;
            this.groupBoxFilters_BVN.TabStop = false;
            this.groupBoxFilters_BVN.Text = "Фильтры";
            // 
            // labelDispanser_BVN
            // 
            this.labelDispanser_BVN.AutoSize = true;
            this.labelDispanser_BVN.Location = new System.Drawing.Point(654, 87);
            this.labelDispanser_BVN.Name = "labelDispanser_BVN";
            this.labelDispanser_BVN.Size = new System.Drawing.Size(145, 18);
            this.labelDispanser_BVN.TabIndex = 20;
            this.labelDispanser_BVN.Text = "Диспансерный учёт";
            // 
            // labelDisabilityTime_BVN
            // 
            this.labelDisabilityTime_BVN.AutoSize = true;
            this.labelDisabilityTime_BVN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.labelDisabilityTime_BVN.Location = new System.Drawing.Point(506, 74);
            this.labelDisabilityTime_BVN.Name = "labelDisabilityTime_BVN";
            this.labelDisabilityTime_BVN.Size = new System.Drawing.Size(139, 36);
            this.labelDisabilityTime_BVN.TabIndex = 19;
            this.labelDisabilityTime_BVN.Text = "Срок потери\r\nтрудоспособности";
            this.labelDisabilityTime_BVN.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelAmbulatoryCare_BVN
            // 
            this.labelAmbulatoryCare_BVN.AutoSize = true;
            this.labelAmbulatoryCare_BVN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.labelAmbulatoryCare_BVN.Location = new System.Drawing.Point(359, 73);
            this.labelAmbulatoryCare_BVN.Name = "labelAmbulatoryCare_BVN";
            this.labelAmbulatoryCare_BVN.Size = new System.Drawing.Size(114, 36);
            this.labelAmbulatoryCare_BVN.TabIndex = 18;
            this.labelAmbulatoryCare_BVN.Text = "Амбулаторное \r\nлечение";
            this.labelAmbulatoryCare_BVN.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // comboBoxDispanser_BVN
            // 
            this.comboBoxDispanser_BVN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.comboBoxDispanser_BVN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDispanser_BVN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.comboBoxDispanser_BVN.FormattingEnabled = true;
            this.comboBoxDispanser_BVN.Items.AddRange(new object[] {
            "Да",
            "Нет"});
            this.comboBoxDispanser_BVN.Location = new System.Drawing.Point(669, 107);
            this.comboBoxDispanser_BVN.Name = "comboBoxDispanser_BVN";
            this.comboBoxDispanser_BVN.Size = new System.Drawing.Size(121, 26);
            this.comboBoxDispanser_BVN.TabIndex = 17;
            this.comboBoxDispanser_BVN.SelectedIndexChanged += new System.EventHandler(this.comboBoxDispanser_BVN_SelectedIndexChanged);
            // 
            // comboBoxAmbulatory_BVN
            // 
            this.comboBoxAmbulatory_BVN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.comboBoxAmbulatory_BVN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAmbulatory_BVN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.comboBoxAmbulatory_BVN.FormattingEnabled = true;
            this.comboBoxAmbulatory_BVN.Items.AddRange(new object[] {
            "Да",
            "Нет"});
            this.comboBoxAmbulatory_BVN.Location = new System.Drawing.Point(352, 109);
            this.comboBoxAmbulatory_BVN.Name = "comboBoxAmbulatory_BVN";
            this.comboBoxAmbulatory_BVN.Size = new System.Drawing.Size(121, 26);
            this.comboBoxAmbulatory_BVN.TabIndex = 16;
            this.comboBoxAmbulatory_BVN.SelectedIndexChanged += new System.EventHandler(this.comboBoxAmbulatory_BVN_SelectedIndexChanged);
            // 
            // numericUpDownDisabilityTime_BVN
            // 
            this.numericUpDownDisabilityTime_BVN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.numericUpDownDisabilityTime_BVN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.numericUpDownDisabilityTime_BVN.Location = new System.Drawing.Point(541, 110);
            this.numericUpDownDisabilityTime_BVN.Name = "numericUpDownDisabilityTime_BVN";
            this.numericUpDownDisabilityTime_BVN.Size = new System.Drawing.Size(67, 24);
            this.numericUpDownDisabilityTime_BVN.TabIndex = 15;
            this.numericUpDownDisabilityTime_BVN.ValueChanged += new System.EventHandler(this.numericUpDownDisabilityTime_BVN_ValueChanged);
            // 
            // labelSearch_BVN
            // 
            this.labelSearch_BVN.AutoSize = true;
            this.labelSearch_BVN.Location = new System.Drawing.Point(21, 20);
            this.labelSearch_BVN.Name = "labelSearch_BVN";
            this.labelSearch_BVN.Size = new System.Drawing.Size(52, 18);
            this.labelSearch_BVN.TabIndex = 14;
            this.labelSearch_BVN.Text = "Поиск";
            // 
            // textBoxSearch_BVN
            // 
            this.textBoxSearch_BVN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.textBoxSearch_BVN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.textBoxSearch_BVN.Location = new System.Drawing.Point(24, 41);
            this.textBoxSearch_BVN.Name = "textBoxSearch_BVN";
            this.textBoxSearch_BVN.Size = new System.Drawing.Size(225, 24);
            this.textBoxSearch_BVN.TabIndex = 13;
            this.textBoxSearch_BVN.TextChanged += new System.EventHandler(this.textBoxSearch_BVN_TextChanged);
            // 
            // buttonReset_BVN
            // 
            this.buttonReset_BVN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.buttonReset_BVN.Location = new System.Drawing.Point(826, 41);
            this.buttonReset_BVN.Name = "buttonReset_BVN";
            this.buttonReset_BVN.Size = new System.Drawing.Size(86, 79);
            this.buttonReset_BVN.TabIndex = 12;
            this.buttonReset_BVN.Text = "Сбросить фильтры";
            this.buttonReset_BVN.UseVisualStyleBackColor = false;
            this.buttonReset_BVN.Click += new System.EventHandler(this.buttonReset_BVN_Click);
            // 
            // labelBirthday_BVN
            // 
            this.labelBirthday_BVN.AutoSize = true;
            this.labelBirthday_BVN.Location = new System.Drawing.Point(556, 20);
            this.labelBirthday_BVN.Name = "labelBirthday_BVN";
            this.labelBirthday_BVN.Size = new System.Drawing.Size(118, 18);
            this.labelBirthday_BVN.TabIndex = 11;
            this.labelBirthday_BVN.Text = "Дата Рождения";
            // 
            // numericUpDownID_BVN
            // 
            this.numericUpDownID_BVN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.numericUpDownID_BVN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.numericUpDownID_BVN.Location = new System.Drawing.Point(279, 41);
            this.numericUpDownID_BVN.Name = "numericUpDownID_BVN";
            this.numericUpDownID_BVN.Size = new System.Drawing.Size(67, 24);
            this.numericUpDownID_BVN.TabIndex = 10;
            this.numericUpDownID_BVN.ValueChanged += new System.EventHandler(this.numericUpDownID_BVN_ValueChanged);
            // 
            // dateTimePickerBirthday_BVN
            // 
            this.dateTimePickerBirthday_BVN.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerBirthday_BVN.Location = new System.Drawing.Point(554, 41);
            this.dateTimePickerBirthday_BVN.Name = "dateTimePickerBirthday_BVN";
            this.dateTimePickerBirthday_BVN.Size = new System.Drawing.Size(120, 24);
            this.dateTimePickerBirthday_BVN.TabIndex = 4;
            this.dateTimePickerBirthday_BVN.ValueChanged += new System.EventHandler(this.dateTimePickerBirthday_BVN_ValueChanged);
            // 
            // labelDiagnosis_BVN
            // 
            this.labelDiagnosis_BVN.AutoSize = true;
            this.labelDiagnosis_BVN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.labelDiagnosis_BVN.Location = new System.Drawing.Point(238, 89);
            this.labelDiagnosis_BVN.Name = "labelDiagnosis_BVN";
            this.labelDiagnosis_BVN.Size = new System.Drawing.Size(67, 18);
            this.labelDiagnosis_BVN.TabIndex = 9;
            this.labelDiagnosis_BVN.Text = "Диагноз";
            // 
            // labelDoctorSPN_BVN
            // 
            this.labelDoctorSPN_BVN.AutoSize = true;
            this.labelDoctorSPN_BVN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.labelDoctorSPN_BVN.Location = new System.Drawing.Point(57, 90);
            this.labelDoctorSPN_BVN.Name = "labelDoctorSPN_BVN";
            this.labelDoctorSPN_BVN.Size = new System.Drawing.Size(88, 18);
            this.labelDoctorSPN_BVN.TabIndex = 8;
            this.labelDoctorSPN_BVN.Text = "ФИО врача";
            // 
            // labelPatientSPN_BVN
            // 
            this.labelPatientSPN_BVN.AutoSize = true;
            this.labelPatientSPN_BVN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.labelPatientSPN_BVN.Location = new System.Drawing.Point(393, 20);
            this.labelPatientSPN_BVN.Name = "labelPatientSPN_BVN";
            this.labelPatientSPN_BVN.Size = new System.Drawing.Size(111, 18);
            this.labelPatientSPN_BVN.TabIndex = 7;
            this.labelPatientSPN_BVN.Text = "ФИО пациента";
            // 
            // labelID_BVN
            // 
            this.labelID_BVN.AutoSize = true;
            this.labelID_BVN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelID_BVN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.labelID_BVN.Location = new System.Drawing.Point(251, 20);
            this.labelID_BVN.Name = "labelID_BVN";
            this.labelID_BVN.Size = new System.Drawing.Size(122, 18);
            this.labelID_BVN.TabIndex = 6;
            this.labelID_BVN.Text = "Номер пациента";
            // 
            // textBoxDiagnosis_BVN
            // 
            this.textBoxDiagnosis_BVN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.textBoxDiagnosis_BVN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.textBoxDiagnosis_BVN.Location = new System.Drawing.Point(205, 111);
            this.textBoxDiagnosis_BVN.Name = "textBoxDiagnosis_BVN";
            this.textBoxDiagnosis_BVN.Size = new System.Drawing.Size(141, 24);
            this.textBoxDiagnosis_BVN.TabIndex = 5;
            this.textBoxDiagnosis_BVN.TextChanged += new System.EventHandler(this.textBoxPatronymic_BVN_TextChanged);
            // 
            // textBoxDoctorSPN_BVN
            // 
            this.textBoxDoctorSPN_BVN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.textBoxDoctorSPN_BVN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.textBoxDoctorSPN_BVN.Location = new System.Drawing.Point(24, 111);
            this.textBoxDoctorSPN_BVN.Name = "textBoxDoctorSPN_BVN";
            this.textBoxDoctorSPN_BVN.Size = new System.Drawing.Size(172, 24);
            this.textBoxDoctorSPN_BVN.TabIndex = 4;
            this.textBoxDoctorSPN_BVN.TextChanged += new System.EventHandler(this.textBoxName_BVN_TextChanged);
            // 
            // textBoxPatientSPN_BVN
            // 
            this.textBoxPatientSPN_BVN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.textBoxPatientSPN_BVN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.textBoxPatientSPN_BVN.Location = new System.Drawing.Point(374, 41);
            this.textBoxPatientSPN_BVN.Name = "textBoxPatientSPN_BVN";
            this.textBoxPatientSPN_BVN.Size = new System.Drawing.Size(145, 24);
            this.textBoxPatientSPN_BVN.TabIndex = 3;
            this.textBoxPatientSPN_BVN.TextChanged += new System.EventHandler(this.textBoxSurname_BVN_TextChanged);
            // 
            // groupBoxInstruments_BVN
            // 
            this.groupBoxInstruments_BVN.Controls.Add(this.buttonDeletePatient_BVN);
            this.groupBoxInstruments_BVN.Controls.Add(this.buttonAddPatient_BVN);
            this.groupBoxInstruments_BVN.Controls.Add(this.buttonGoToPatient_BVN);
            this.groupBoxInstruments_BVN.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxInstruments_BVN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxInstruments_BVN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.groupBoxInstruments_BVN.Location = new System.Drawing.Point(0, 0);
            this.groupBoxInstruments_BVN.Name = "groupBoxInstruments_BVN";
            this.groupBoxInstruments_BVN.Size = new System.Drawing.Size(282, 144);
            this.groupBoxInstruments_BVN.TabIndex = 4;
            this.groupBoxInstruments_BVN.TabStop = false;
            this.groupBoxInstruments_BVN.Text = "Инструменты";
            // 
            // panelForTable_BVN
            // 
            this.panelForTable_BVN.Controls.Add(this.dataGridViewPatients_BVN);
            this.panelForTable_BVN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForTable_BVN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panelForTable_BVN.Location = new System.Drawing.Point(0, 169);
            this.panelForTable_BVN.Name = "panelForTable_BVN";
            this.panelForTable_BVN.Size = new System.Drawing.Size(1258, 415);
            this.panelForTable_BVN.TabIndex = 5;
            // 
            // panelForGroupBoxes_BVN
            // 
            this.panelForGroupBoxes_BVN.Controls.Add(this.panelBetweenGroupBoxes_BVN);
            this.panelForGroupBoxes_BVN.Controls.Add(this.groupBoxInstruments_BVN);
            this.panelForGroupBoxes_BVN.Controls.Add(this.groupBoxFilters_BVN);
            this.panelForGroupBoxes_BVN.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelForGroupBoxes_BVN.Location = new System.Drawing.Point(0, 25);
            this.panelForGroupBoxes_BVN.Name = "panelForGroupBoxes_BVN";
            this.panelForGroupBoxes_BVN.Size = new System.Drawing.Size(1258, 144);
            this.panelForGroupBoxes_BVN.TabIndex = 6;
            // 
            // panelBetweenGroupBoxes_BVN
            // 
            this.panelBetweenGroupBoxes_BVN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBetweenGroupBoxes_BVN.Location = new System.Drawing.Point(282, 0);
            this.panelBetweenGroupBoxes_BVN.Name = "panelBetweenGroupBoxes_BVN";
            this.panelBetweenGroupBoxes_BVN.Size = new System.Drawing.Size(61, 144);
            this.panelBetweenGroupBoxes_BVN.TabIndex = 5;
            // 
            // FormMainPatients_BVN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(1258, 584);
            this.Controls.Add(this.panelForTable_BVN);
            this.Controls.Add(this.panelForGroupBoxes_BVN);
            this.Controls.Add(this.menuStripMust_BVN);
            this.MainMenuStrip = this.menuStripMust_BVN;
            this.MinimumSize = new System.Drawing.Size(1212, 351);
            this.Name = "FormMainPatients_BVN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Список Пациентов";
            this.Load += new System.EventHandler(this.FormMainPatients_BVN_Load);
            this.Resize += new System.EventHandler(this.FormMainPatients_BVN_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatients_BVN)).EndInit();
            this.menuStripMust_BVN.ResumeLayout(false);
            this.menuStripMust_BVN.PerformLayout();
            this.groupBoxFilters_BVN.ResumeLayout(false);
            this.groupBoxFilters_BVN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDisabilityTime_BVN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownID_BVN)).EndInit();
            this.groupBoxInstruments_BVN.ResumeLayout(false);
            this.panelForTable_BVN.ResumeLayout(false);
            this.panelForGroupBoxes_BVN.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPatients_BVN;
        private System.Windows.Forms.MenuStrip menuStripMust_BVN;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemFile_BVN;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemOpen_BVN;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSave_BVN;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSaveAs_BVN;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemHelp_BVN;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemUserGuide_BVN;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemAbout_BVN;
        private System.Windows.Forms.OpenFileDialog openFileDialogExcel_BVN;
        private System.Windows.Forms.SaveFileDialog saveFileDialogExcel_BVN;
        private System.Windows.Forms.ToolTip toolTipForButtons_BVN;
        private System.Windows.Forms.GroupBox groupBoxFilters_BVN;
        private System.Windows.Forms.DateTimePicker dateTimePickerBirthday_BVN;
        private System.Windows.Forms.Label labelDiagnosis_BVN;
        private System.Windows.Forms.Label labelDoctorSPN_BVN;
        private System.Windows.Forms.Label labelPatientSPN_BVN;
        private System.Windows.Forms.Label labelID_BVN;
        private System.Windows.Forms.TextBox textBoxDiagnosis_BVN;
        private System.Windows.Forms.TextBox textBoxDoctorSPN_BVN;
        private System.Windows.Forms.TextBox textBoxPatientSPN_BVN;
        private System.Windows.Forms.GroupBox groupBoxInstruments_BVN;
        private System.Windows.Forms.Button buttonGoToPatient_BVN;
        private System.Windows.Forms.Button buttonDeletePatient_BVN;
        private System.Windows.Forms.Button buttonAddPatient_BVN;
        private System.Windows.Forms.Panel panelForTable_BVN;
        private System.Windows.Forms.Panel panelForGroupBoxes_BVN;
        private System.Windows.Forms.NumericUpDown numericUpDownID_BVN;
        private System.Windows.Forms.Label labelBirthday_BVN;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemNewTable_BVN;
        private System.Windows.Forms.Button buttonReset_BVN;
        private System.Windows.Forms.Panel panelBetweenGroupBoxes_BVN;
        private System.Windows.Forms.Label labelSearch_BVN;
        private System.Windows.Forms.TextBox textBoxSearch_BVN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn SNP_BVN;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirthDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorSNP;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorPosition_BVN;
        private System.Windows.Forms.DataGridViewTextBoxColumn diagnosis_BVN;
        private System.Windows.Forms.DataGridViewTextBoxColumn ambulatoryCare_BVN;
        private System.Windows.Forms.DataGridViewTextBoxColumn disabilityTime_BVN;
        private System.Windows.Forms.DataGridViewTextBoxColumn dispanser_BVN;
        private System.Windows.Forms.DataGridViewTextBoxColumn notes_BVN;
        private System.Windows.Forms.Label labelDispanser_BVN;
        private System.Windows.Forms.Label labelDisabilityTime_BVN;
        private System.Windows.Forms.Label labelAmbulatoryCare_BVN;
        private System.Windows.Forms.ComboBox comboBoxDispanser_BVN;
        private System.Windows.Forms.ComboBox comboBoxAmbulatory_BVN;
        private System.Windows.Forms.NumericUpDown numericUpDownDisabilityTime_BVN;
    }
}

