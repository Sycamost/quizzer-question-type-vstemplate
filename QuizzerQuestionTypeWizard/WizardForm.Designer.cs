
namespace QuizzerQuestionTypeWizard
{
    partial class WizardForm
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
            this.tableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutTop = new System.Windows.Forms.TableLayoutPanel();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblIssueName = new System.Windows.Forms.Label();
            this.lblDispSingular = new System.Windows.Forms.Label();
            this.txtDispSingular = new System.Windows.Forms.TextBox();
            this.chkbxDefaultDispSingular = new System.Windows.Forms.CheckBox();
            this.lblIssueDispSingular = new System.Windows.Forms.Label();
            this.lblDispPlural = new System.Windows.Forms.Label();
            this.txtDispPlural = new System.Windows.Forms.TextBox();
            this.chkbxDefaultDispPlural = new System.Windows.Forms.CheckBox();
            this.lblIssueDispPlural = new System.Windows.Forms.Label();
            this.lblEnumCode = new System.Windows.Forms.Label();
            this.txtEnumCode = new System.Windows.Forms.TextBox();
            this.lblIssueEnumCode = new System.Windows.Forms.Label();
            this.chkbxDefaultEnumCode = new System.Windows.Forms.CheckBox();
            this.tableLayoutFields = new System.Windows.Forms.TableLayoutPanel();
            this.listViewFields = new System.Windows.Forms.ListView();
            this.colFieldType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFieldName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFieldDisp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFieldDefaultValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFieldEnumCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutEditField = new System.Windows.Forms.TableLayoutPanel();
            this.lblEditFieldType = new System.Windows.Forms.Label();
            this.txtEditFieldType = new System.Windows.Forms.TextBox();
            this.lblEditFieldName = new System.Windows.Forms.Label();
            this.txtEditFieldName = new System.Windows.Forms.TextBox();
            this.lblEditFieldDisp = new System.Windows.Forms.Label();
            this.txtEditFieldDisp = new System.Windows.Forms.TextBox();
            this.lblEditFieldDefaultValue = new System.Windows.Forms.Label();
            this.txtEditFieldDefaultValue = new System.Windows.Forms.TextBox();
            this.lblEditFieldEnumCode = new System.Windows.Forms.Label();
            this.txtEditFieldEnumCode = new System.Windows.Forms.TextBox();
            this.lblIssueEditFieldType = new System.Windows.Forms.Label();
            this.lblIssueEditFieldName = new System.Windows.Forms.Label();
            this.lblIssueEditFieldDisp = new System.Windows.Forms.Label();
            this.lblIssueEditFieldDefaultValue = new System.Windows.Forms.Label();
            this.lblIssueEditFieldEnumCode = new System.Windows.Forms.Label();
            this.chkbxDefaultFieldDisp = new System.Windows.Forms.CheckBox();
            this.chkbxDefaultFieldDefaultValue = new System.Windows.Forms.CheckBox();
            this.chkbxDefaultFieldEnumCode = new System.Windows.Forms.CheckBox();
            this.lblIssueFields = new System.Windows.Forms.Label();
            this.btnAddField = new System.Windows.Forms.Button();
            this.btnUpdateField = new System.Windows.Forms.Button();
            this.btnDeleteField = new System.Windows.Forms.Button();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tableLayout.SuspendLayout();
            this.tableLayoutTop.SuspendLayout();
            this.tableLayoutFields.SuspendLayout();
            this.tableLayoutEditField.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayout
            // 
            this.tableLayout.AutoScroll = true;
            this.tableLayout.ColumnCount = 1;
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayout.Controls.Add(this.tableLayoutTop, 0, 0);
            this.tableLayout.Controls.Add(this.tableLayoutFields, 0, 1);
            this.tableLayout.Controls.Add(this.pnlButtons, 0, 2);
            this.tableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayout.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayout.Location = new System.Drawing.Point(0, 0);
            this.tableLayout.Name = "tableLayout";
            this.tableLayout.RowCount = 3;
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayout.Size = new System.Drawing.Size(709, 648);
            this.tableLayout.TabIndex = 19;
            // 
            // tableLayoutTop
            // 
            this.tableLayoutTop.ColumnCount = 2;
            this.tableLayoutTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutTop.Controls.Add(this.lblName, 0, 0);
            this.tableLayoutTop.Controls.Add(this.txtName, 1, 0);
            this.tableLayoutTop.Controls.Add(this.lblIssueName, 1, 1);
            this.tableLayoutTop.Controls.Add(this.lblDispSingular, 0, 2);
            this.tableLayoutTop.Controls.Add(this.txtDispSingular, 1, 2);
            this.tableLayoutTop.Controls.Add(this.chkbxDefaultDispSingular, 2, 2);
            this.tableLayoutTop.Controls.Add(this.lblIssueDispSingular, 1, 3);
            this.tableLayoutTop.Controls.Add(this.lblDispPlural, 0, 4);
            this.tableLayoutTop.Controls.Add(this.txtDispPlural, 1, 4);
            this.tableLayoutTop.Controls.Add(this.chkbxDefaultDispPlural, 2, 4);
            this.tableLayoutTop.Controls.Add(this.lblIssueDispPlural, 1, 5);
            this.tableLayoutTop.Controls.Add(this.lblEnumCode, 0, 6);
            this.tableLayoutTop.Controls.Add(this.txtEnumCode, 1, 6);
            this.tableLayoutTop.Controls.Add(this.lblIssueEnumCode, 1, 7);
            this.tableLayoutTop.Controls.Add(this.chkbxDefaultEnumCode, 2, 6);
            this.tableLayoutTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutTop.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            this.tableLayoutTop.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutTop.Name = "tableLayoutTop";
            this.tableLayoutTop.RowCount = 8;
            this.tableLayoutTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutTop.Size = new System.Drawing.Size(703, 178);
            this.tableLayoutTop.TabIndex = 20;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(3, 3);
            this.lblName.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(41, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name: ";
            // 
            // txtName
            // 
            this.txtName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(103, 0);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(500, 20);
            this.txtName.TabIndex = 0;
            this.txtName.Text = "NewQuestionType";
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            this.txtName.Leave += new System.EventHandler(this.txtName_Leave);
            // 
            // lblIssueName
            // 
            this.lblIssueName.AutoSize = true;
            this.tableLayoutTop.SetColumnSpan(this.lblIssueName, 2);
            this.lblIssueName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblIssueName.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblIssueName.Location = new System.Drawing.Point(103, 25);
            this.lblIssueName.Margin = new System.Windows.Forms.Padding(3);
            this.lblIssueName.Name = "lblIssueName";
            this.lblIssueName.Size = new System.Drawing.Size(47, 13);
            this.lblIssueName.TabIndex = 6;
            this.lblIssueName.Text = "warning!";
            // 
            // lblDispSingular
            // 
            this.lblDispSingular.AutoSize = true;
            this.lblDispSingular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDispSingular.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblDispSingular.Location = new System.Drawing.Point(3, 47);
            this.lblDispSingular.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.lblDispSingular.Name = "lblDispSingular";
            this.lblDispSingular.Size = new System.Drawing.Size(92, 13);
            this.lblDispSingular.TabIndex = 2;
            this.lblDispSingular.Text = "Display (singular): ";
            // 
            // txtDispSingular
            // 
            this.txtDispSingular.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDispSingular.Enabled = false;
            this.txtDispSingular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDispSingular.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtDispSingular.Location = new System.Drawing.Point(103, 44);
            this.txtDispSingular.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.txtDispSingular.Name = "txtDispSingular";
            this.txtDispSingular.Size = new System.Drawing.Size(500, 20);
            this.txtDispSingular.TabIndex = 3;
            this.txtDispSingular.Text = "new question type";
            this.txtDispSingular.TextChanged += new System.EventHandler(this.txtDispSingular_TextChanged);
            this.txtDispSingular.Leave += new System.EventHandler(this.txtDispSingular_Leave);
            // 
            // chkbxDefaultDispSingular
            // 
            this.chkbxDefaultDispSingular.AutoSize = true;
            this.chkbxDefaultDispSingular.Checked = true;
            this.chkbxDefaultDispSingular.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkbxDefaultDispSingular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbxDefaultDispSingular.Location = new System.Drawing.Point(606, 47);
            this.chkbxDefaultDispSingular.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.chkbxDefaultDispSingular.Name = "chkbxDefaultDispSingular";
            this.chkbxDefaultDispSingular.Size = new System.Drawing.Size(80, 17);
            this.chkbxDefaultDispSingular.TabIndex = 20;
            this.chkbxDefaultDispSingular.Text = "Use default";
            this.chkbxDefaultDispSingular.UseVisualStyleBackColor = true;
            this.chkbxDefaultDispSingular.CheckedChanged += new System.EventHandler(this.chkbxDefaultDispSingular_CheckedChanged);
            // 
            // lblIssueDispSingular
            // 
            this.lblIssueDispSingular.AutoSize = true;
            this.tableLayoutTop.SetColumnSpan(this.lblIssueDispSingular, 2);
            this.lblIssueDispSingular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIssueDispSingular.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblIssueDispSingular.Location = new System.Drawing.Point(103, 69);
            this.lblIssueDispSingular.Margin = new System.Windows.Forms.Padding(3);
            this.lblIssueDispSingular.Name = "lblIssueDispSingular";
            this.lblIssueDispSingular.Size = new System.Drawing.Size(47, 13);
            this.lblIssueDispSingular.TabIndex = 7;
            this.lblIssueDispSingular.Text = "warning!";
            // 
            // lblDispPlural
            // 
            this.lblDispPlural.AutoSize = true;
            this.lblDispPlural.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDispPlural.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblDispPlural.Location = new System.Drawing.Point(3, 91);
            this.lblDispPlural.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.lblDispPlural.Name = "lblDispPlural";
            this.lblDispPlural.Size = new System.Drawing.Size(81, 13);
            this.lblDispPlural.TabIndex = 4;
            this.lblDispPlural.Text = "Display (plural): ";
            // 
            // txtDispPlural
            // 
            this.txtDispPlural.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDispPlural.Enabled = false;
            this.txtDispPlural.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDispPlural.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtDispPlural.Location = new System.Drawing.Point(103, 88);
            this.txtDispPlural.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.txtDispPlural.Name = "txtDispPlural";
            this.txtDispPlural.Size = new System.Drawing.Size(500, 20);
            this.txtDispPlural.TabIndex = 5;
            this.txtDispPlural.Text = "new question type";
            this.txtDispPlural.TextChanged += new System.EventHandler(this.txtDispPlural_TextChanged);
            this.txtDispPlural.Leave += new System.EventHandler(this.txtDispPlural_Leave);
            // 
            // chkbxDefaultDispPlural
            // 
            this.chkbxDefaultDispPlural.AutoSize = true;
            this.chkbxDefaultDispPlural.Checked = true;
            this.chkbxDefaultDispPlural.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkbxDefaultDispPlural.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbxDefaultDispPlural.Location = new System.Drawing.Point(606, 91);
            this.chkbxDefaultDispPlural.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.chkbxDefaultDispPlural.Name = "chkbxDefaultDispPlural";
            this.chkbxDefaultDispPlural.Size = new System.Drawing.Size(80, 17);
            this.chkbxDefaultDispPlural.TabIndex = 9;
            this.chkbxDefaultDispPlural.Text = "Use default";
            this.chkbxDefaultDispPlural.UseVisualStyleBackColor = true;
            this.chkbxDefaultDispPlural.CheckedChanged += new System.EventHandler(this.chkbxDefaultDispPlural_CheckedChanged);
            // 
            // lblIssueDispPlural
            // 
            this.lblIssueDispPlural.AutoSize = true;
            this.tableLayoutTop.SetColumnSpan(this.lblIssueDispPlural, 2);
            this.lblIssueDispPlural.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIssueDispPlural.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblIssueDispPlural.Location = new System.Drawing.Point(103, 113);
            this.lblIssueDispPlural.Margin = new System.Windows.Forms.Padding(3);
            this.lblIssueDispPlural.Name = "lblIssueDispPlural";
            this.lblIssueDispPlural.Size = new System.Drawing.Size(47, 13);
            this.lblIssueDispPlural.TabIndex = 8;
            this.lblIssueDispPlural.Text = "warning!";
            // 
            // lblEnumCode
            // 
            this.lblEnumCode.AutoSize = true;
            this.lblEnumCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnumCode.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblEnumCode.Location = new System.Drawing.Point(3, 135);
            this.lblEnumCode.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.lblEnumCode.Name = "lblEnumCode";
            this.lblEnumCode.Size = new System.Drawing.Size(67, 13);
            this.lblEnumCode.TabIndex = 10;
            this.lblEnumCode.Text = "Enum code: ";
            // 
            // txtEnumCode
            // 
            this.txtEnumCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEnumCode.Enabled = false;
            this.txtEnumCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnumCode.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtEnumCode.Location = new System.Drawing.Point(103, 132);
            this.txtEnumCode.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.txtEnumCode.Name = "txtEnumCode";
            this.txtEnumCode.Size = new System.Drawing.Size(500, 20);
            this.txtEnumCode.TabIndex = 11;
            this.txtEnumCode.Text = "NEW_QUESTION_TYPE";
            this.txtEnumCode.TextChanged += new System.EventHandler(this.txtEnumCode_TextChanged);
            this.txtEnumCode.Leave += new System.EventHandler(this.txtEnumCode_Leave);
            // 
            // lblIssueEnumCode
            // 
            this.lblIssueEnumCode.AutoSize = true;
            this.tableLayoutTop.SetColumnSpan(this.lblIssueEnumCode, 2);
            this.lblIssueEnumCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIssueEnumCode.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblIssueEnumCode.Location = new System.Drawing.Point(103, 157);
            this.lblIssueEnumCode.Margin = new System.Windows.Forms.Padding(3);
            this.lblIssueEnumCode.Name = "lblIssueEnumCode";
            this.lblIssueEnumCode.Size = new System.Drawing.Size(47, 13);
            this.lblIssueEnumCode.TabIndex = 12;
            this.lblIssueEnumCode.Text = "warning!";
            // 
            // chkbxDefaultEnumCode
            // 
            this.chkbxDefaultEnumCode.AutoSize = true;
            this.chkbxDefaultEnumCode.Checked = true;
            this.chkbxDefaultEnumCode.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkbxDefaultEnumCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbxDefaultEnumCode.Location = new System.Drawing.Point(606, 135);
            this.chkbxDefaultEnumCode.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.chkbxDefaultEnumCode.Name = "chkbxDefaultEnumCode";
            this.chkbxDefaultEnumCode.Size = new System.Drawing.Size(80, 17);
            this.chkbxDefaultEnumCode.TabIndex = 13;
            this.chkbxDefaultEnumCode.Text = "Use default";
            this.chkbxDefaultEnumCode.UseVisualStyleBackColor = true;
            this.chkbxDefaultEnumCode.CheckedChanged += new System.EventHandler(this.chkbxDefaultEnumCode_CheckedChanged);
            // 
            // tableLayoutFields
            // 
            this.tableLayoutFields.ColumnCount = 3;
            this.tableLayoutFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.34F));
            this.tableLayoutFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutFields.Controls.Add(this.listViewFields, 0, 0);
            this.tableLayoutFields.Controls.Add(this.tableLayoutEditField, 0, 2);
            this.tableLayoutFields.Controls.Add(this.lblIssueFields, 1, 0);
            this.tableLayoutFields.Controls.Add(this.btnAddField, 0, 3);
            this.tableLayoutFields.Controls.Add(this.btnUpdateField, 1, 3);
            this.tableLayoutFields.Controls.Add(this.btnDeleteField, 2, 3);
            this.tableLayoutFields.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutFields.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            this.tableLayoutFields.Location = new System.Drawing.Point(2, 186);
            this.tableLayoutFields.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutFields.MinimumSize = new System.Drawing.Size(100, 370);
            this.tableLayoutFields.Name = "tableLayoutFields";
            this.tableLayoutFields.RowCount = 4;
            this.tableLayoutFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 230F));
            this.tableLayoutFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutFields.Size = new System.Drawing.Size(705, 425);
            this.tableLayoutFields.TabIndex = 1;
            // 
            // listViewFields
            // 
            this.listViewFields.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colFieldType,
            this.colFieldName,
            this.colFieldDisp,
            this.colFieldDefaultValue,
            this.colFieldEnumCode});
            this.tableLayoutFields.SetColumnSpan(this.listViewFields, 3);
            this.listViewFields.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewFields.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.listViewFields.FullRowSelect = true;
            this.listViewFields.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewFields.HideSelection = false;
            this.listViewFields.Location = new System.Drawing.Point(4, 5);
            this.listViewFields.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listViewFields.MinimumSize = new System.Drawing.Size(248, 64);
            this.listViewFields.Name = "listViewFields";
            this.listViewFields.Size = new System.Drawing.Size(697, 130);
            this.listViewFields.TabIndex = 0;
            this.listViewFields.UseCompatibleStateImageBehavior = false;
            this.listViewFields.View = System.Windows.Forms.View.Details;
            this.listViewFields.SelectedIndexChanged += new System.EventHandler(this.listViewFields_SelectedIndexChanged);
            this.listViewFields.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listViewFields_OnKeyDown);
            // 
            // colFieldType
            // 
            this.colFieldType.Text = "Type";
            this.colFieldType.Width = 116;
            // 
            // colFieldName
            // 
            this.colFieldName.Text = "Name";
            this.colFieldName.Width = 127;
            // 
            // colFieldDisp
            // 
            this.colFieldDisp.Text = "Display";
            this.colFieldDisp.Width = 154;
            // 
            // colFieldDefaultValue
            // 
            this.colFieldDefaultValue.Text = "Default value";
            this.colFieldDefaultValue.Width = 154;
            // 
            // colFieldEnumCode
            // 
            this.colFieldEnumCode.Text = "Enum Code";
            this.colFieldEnumCode.Width = 142;
            // 
            // tableLayoutEditField
            // 
            this.tableLayoutEditField.ColumnCount = 3;
            this.tableLayoutFields.SetColumnSpan(this.tableLayoutEditField, 3);
            this.tableLayoutEditField.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutEditField.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutEditField.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutEditField.Controls.Add(this.lblEditFieldType, 0, 0);
            this.tableLayoutEditField.Controls.Add(this.txtEditFieldType, 1, 0);
            this.tableLayoutEditField.Controls.Add(this.lblEditFieldName, 0, 2);
            this.tableLayoutEditField.Controls.Add(this.txtEditFieldName, 1, 2);
            this.tableLayoutEditField.Controls.Add(this.lblEditFieldDisp, 0, 4);
            this.tableLayoutEditField.Controls.Add(this.txtEditFieldDisp, 1, 4);
            this.tableLayoutEditField.Controls.Add(this.lblEditFieldDefaultValue, 0, 6);
            this.tableLayoutEditField.Controls.Add(this.txtEditFieldDefaultValue, 1, 6);
            this.tableLayoutEditField.Controls.Add(this.lblEditFieldEnumCode, 0, 8);
            this.tableLayoutEditField.Controls.Add(this.txtEditFieldEnumCode, 1, 8);
            this.tableLayoutEditField.Controls.Add(this.lblIssueEditFieldType, 1, 1);
            this.tableLayoutEditField.Controls.Add(this.lblIssueEditFieldName, 1, 3);
            this.tableLayoutEditField.Controls.Add(this.lblIssueEditFieldDisp, 1, 5);
            this.tableLayoutEditField.Controls.Add(this.lblIssueEditFieldDefaultValue, 1, 7);
            this.tableLayoutEditField.Controls.Add(this.lblIssueEditFieldEnumCode, 1, 9);
            this.tableLayoutEditField.Controls.Add(this.chkbxDefaultFieldDisp, 2, 4);
            this.tableLayoutEditField.Controls.Add(this.chkbxDefaultFieldDefaultValue, 2, 6);
            this.tableLayoutEditField.Controls.Add(this.chkbxDefaultFieldEnumCode, 2, 8);
            this.tableLayoutEditField.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutEditField.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutEditField.Location = new System.Drawing.Point(3, 166);
            this.tableLayoutEditField.Name = "tableLayoutEditField";
            this.tableLayoutEditField.RowCount = 10;
            this.tableLayoutEditField.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutEditField.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutEditField.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutEditField.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutEditField.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutEditField.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutEditField.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutEditField.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutEditField.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutEditField.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutEditField.Size = new System.Drawing.Size(699, 224);
            this.tableLayoutEditField.TabIndex = 23;
            // 
            // lblEditFieldType
            // 
            this.lblEditFieldType.AutoSize = true;
            this.lblEditFieldType.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblEditFieldType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditFieldType.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblEditFieldType.Location = new System.Drawing.Point(3, 3);
            this.lblEditFieldType.Margin = new System.Windows.Forms.Padding(3);
            this.lblEditFieldType.Name = "lblEditFieldType";
            this.lblEditFieldType.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.lblEditFieldType.Size = new System.Drawing.Size(37, 16);
            this.lblEditFieldType.TabIndex = 0;
            this.lblEditFieldType.Text = "Type: ";
            // 
            // txtEditFieldType
            // 
            this.txtEditFieldType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEditFieldType.Enabled = false;
            this.txtEditFieldType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditFieldType.Location = new System.Drawing.Point(82, 0);
            this.txtEditFieldType.Margin = new System.Windows.Forms.Padding(3, 0, 0, 3);
            this.txtEditFieldType.Name = "txtEditFieldType";
            this.txtEditFieldType.Size = new System.Drawing.Size(517, 20);
            this.txtEditFieldType.TabIndex = 1;
            this.txtEditFieldType.TextChanged += new System.EventHandler(this.txtEditFieldType_TextChanged);
            this.txtEditFieldType.Enter += new System.EventHandler(this.txtEditFieldType_Enter);
            this.txtEditFieldType.Leave += new System.EventHandler(this.txtEditType_Leave);
            // 
            // lblEditFieldName
            // 
            this.lblEditFieldName.AutoSize = true;
            this.lblEditFieldName.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblEditFieldName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditFieldName.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblEditFieldName.Location = new System.Drawing.Point(3, 47);
            this.lblEditFieldName.Margin = new System.Windows.Forms.Padding(3);
            this.lblEditFieldName.Name = "lblEditFieldName";
            this.lblEditFieldName.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.lblEditFieldName.Size = new System.Drawing.Size(41, 16);
            this.lblEditFieldName.TabIndex = 0;
            this.lblEditFieldName.Text = "Name: ";
            // 
            // txtEditFieldName
            // 
            this.txtEditFieldName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEditFieldName.Enabled = false;
            this.txtEditFieldName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditFieldName.Location = new System.Drawing.Point(82, 44);
            this.txtEditFieldName.Margin = new System.Windows.Forms.Padding(3, 0, 0, 3);
            this.txtEditFieldName.Name = "txtEditFieldName";
            this.txtEditFieldName.Size = new System.Drawing.Size(517, 20);
            this.txtEditFieldName.TabIndex = 1;
            this.txtEditFieldName.TextChanged += new System.EventHandler(this.txtEditFieldName_TextChanged);
            this.txtEditFieldName.Enter += new System.EventHandler(this.txtEditFieldName_Enter);
            this.txtEditFieldName.Leave += new System.EventHandler(this.txtEditFieldName_Leave);
            // 
            // lblEditFieldDisp
            // 
            this.lblEditFieldDisp.AutoSize = true;
            this.lblEditFieldDisp.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblEditFieldDisp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditFieldDisp.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblEditFieldDisp.Location = new System.Drawing.Point(3, 91);
            this.lblEditFieldDisp.Margin = new System.Windows.Forms.Padding(3);
            this.lblEditFieldDisp.Name = "lblEditFieldDisp";
            this.lblEditFieldDisp.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.lblEditFieldDisp.Size = new System.Drawing.Size(50, 16);
            this.lblEditFieldDisp.TabIndex = 2;
            this.lblEditFieldDisp.Text = "Display:  ";
            // 
            // txtEditFieldDisp
            // 
            this.txtEditFieldDisp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEditFieldDisp.Enabled = false;
            this.txtEditFieldDisp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditFieldDisp.Location = new System.Drawing.Point(82, 88);
            this.txtEditFieldDisp.Margin = new System.Windows.Forms.Padding(3, 0, 0, 3);
            this.txtEditFieldDisp.Name = "txtEditFieldDisp";
            this.txtEditFieldDisp.Size = new System.Drawing.Size(517, 20);
            this.txtEditFieldDisp.TabIndex = 3;
            this.txtEditFieldDisp.TextChanged += new System.EventHandler(this.txtEditFieldDisp_TextChanged);
            this.txtEditFieldDisp.Enter += new System.EventHandler(this.txtEditFieldDisp_Enter);
            this.txtEditFieldDisp.Leave += new System.EventHandler(this.txtEditFieldDisp_Leave);
            // 
            // lblEditFieldDefaultValue
            // 
            this.lblEditFieldDefaultValue.AutoSize = true;
            this.lblEditFieldDefaultValue.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblEditFieldDefaultValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditFieldDefaultValue.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblEditFieldDefaultValue.Location = new System.Drawing.Point(3, 135);
            this.lblEditFieldDefaultValue.Margin = new System.Windows.Forms.Padding(3);
            this.lblEditFieldDefaultValue.Name = "lblEditFieldDefaultValue";
            this.lblEditFieldDefaultValue.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.lblEditFieldDefaultValue.Size = new System.Drawing.Size(73, 16);
            this.lblEditFieldDefaultValue.TabIndex = 0;
            this.lblEditFieldDefaultValue.Text = "Default value:";
            // 
            // txtEditFieldDefaultValue
            // 
            this.txtEditFieldDefaultValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEditFieldDefaultValue.Enabled = false;
            this.txtEditFieldDefaultValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditFieldDefaultValue.Location = new System.Drawing.Point(82, 132);
            this.txtEditFieldDefaultValue.Margin = new System.Windows.Forms.Padding(3, 0, 0, 3);
            this.txtEditFieldDefaultValue.Name = "txtEditFieldDefaultValue";
            this.txtEditFieldDefaultValue.Size = new System.Drawing.Size(517, 20);
            this.txtEditFieldDefaultValue.TabIndex = 1;
            this.txtEditFieldDefaultValue.TextChanged += new System.EventHandler(this.txtEditFieldDefaultValue_TextChanged);
            this.txtEditFieldDefaultValue.Enter += new System.EventHandler(this.txtEditFieldDefaultValue_Enter);
            this.txtEditFieldDefaultValue.Leave += new System.EventHandler(this.txtEditFieldDefaultValue_Leave);
            // 
            // lblEditFieldEnumCode
            // 
            this.lblEditFieldEnumCode.AutoSize = true;
            this.lblEditFieldEnumCode.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblEditFieldEnumCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditFieldEnumCode.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblEditFieldEnumCode.Location = new System.Drawing.Point(3, 179);
            this.lblEditFieldEnumCode.Margin = new System.Windows.Forms.Padding(3);
            this.lblEditFieldEnumCode.Name = "lblEditFieldEnumCode";
            this.lblEditFieldEnumCode.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.lblEditFieldEnumCode.Size = new System.Drawing.Size(64, 16);
            this.lblEditFieldEnumCode.TabIndex = 0;
            this.lblEditFieldEnumCode.Text = "Enum code:";
            // 
            // txtEditFieldEnumCode
            // 
            this.txtEditFieldEnumCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEditFieldEnumCode.Enabled = false;
            this.txtEditFieldEnumCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditFieldEnumCode.Location = new System.Drawing.Point(82, 176);
            this.txtEditFieldEnumCode.Margin = new System.Windows.Forms.Padding(3, 0, 0, 3);
            this.txtEditFieldEnumCode.Name = "txtEditFieldEnumCode";
            this.txtEditFieldEnumCode.Size = new System.Drawing.Size(517, 20);
            this.txtEditFieldEnumCode.TabIndex = 1;
            this.txtEditFieldEnumCode.TextChanged += new System.EventHandler(this.txtEditFieldEnumCode_TextChanged);
            this.txtEditFieldEnumCode.Enter += new System.EventHandler(this.txtEditFieldEnumCode_Enter);
            this.txtEditFieldEnumCode.Leave += new System.EventHandler(this.txtEditFieldEnumCode_Leave);
            // 
            // lblIssueEditFieldType
            // 
            this.lblIssueEditFieldType.AutoSize = true;
            this.lblIssueEditFieldType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIssueEditFieldType.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblIssueEditFieldType.Location = new System.Drawing.Point(82, 25);
            this.lblIssueEditFieldType.Margin = new System.Windows.Forms.Padding(3);
            this.lblIssueEditFieldType.Name = "lblIssueEditFieldType";
            this.lblIssueEditFieldType.Size = new System.Drawing.Size(47, 13);
            this.lblIssueEditFieldType.TabIndex = 7;
            this.lblIssueEditFieldType.Text = "warning!";
            // 
            // lblIssueEditFieldName
            // 
            this.lblIssueEditFieldName.AutoSize = true;
            this.lblIssueEditFieldName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIssueEditFieldName.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblIssueEditFieldName.Location = new System.Drawing.Point(82, 69);
            this.lblIssueEditFieldName.Margin = new System.Windows.Forms.Padding(3);
            this.lblIssueEditFieldName.Name = "lblIssueEditFieldName";
            this.lblIssueEditFieldName.Size = new System.Drawing.Size(47, 13);
            this.lblIssueEditFieldName.TabIndex = 8;
            this.lblIssueEditFieldName.Text = "warning!";
            // 
            // lblIssueEditFieldDisp
            // 
            this.lblIssueEditFieldDisp.AutoSize = true;
            this.lblIssueEditFieldDisp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIssueEditFieldDisp.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblIssueEditFieldDisp.Location = new System.Drawing.Point(82, 113);
            this.lblIssueEditFieldDisp.Margin = new System.Windows.Forms.Padding(3);
            this.lblIssueEditFieldDisp.Name = "lblIssueEditFieldDisp";
            this.lblIssueEditFieldDisp.Size = new System.Drawing.Size(47, 13);
            this.lblIssueEditFieldDisp.TabIndex = 9;
            this.lblIssueEditFieldDisp.Text = "warning!";
            // 
            // lblIssueEditFieldDefaultValue
            // 
            this.lblIssueEditFieldDefaultValue.AutoSize = true;
            this.lblIssueEditFieldDefaultValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIssueEditFieldDefaultValue.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblIssueEditFieldDefaultValue.Location = new System.Drawing.Point(82, 157);
            this.lblIssueEditFieldDefaultValue.Margin = new System.Windows.Forms.Padding(3);
            this.lblIssueEditFieldDefaultValue.Name = "lblIssueEditFieldDefaultValue";
            this.lblIssueEditFieldDefaultValue.Size = new System.Drawing.Size(47, 13);
            this.lblIssueEditFieldDefaultValue.TabIndex = 10;
            this.lblIssueEditFieldDefaultValue.Text = "warning!";
            // 
            // lblIssueEditFieldEnumCode
            // 
            this.lblIssueEditFieldEnumCode.AutoSize = true;
            this.lblIssueEditFieldEnumCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIssueEditFieldEnumCode.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblIssueEditFieldEnumCode.Location = new System.Drawing.Point(82, 201);
            this.lblIssueEditFieldEnumCode.Margin = new System.Windows.Forms.Padding(3);
            this.lblIssueEditFieldEnumCode.Name = "lblIssueEditFieldEnumCode";
            this.lblIssueEditFieldEnumCode.Size = new System.Drawing.Size(47, 13);
            this.lblIssueEditFieldEnumCode.TabIndex = 11;
            this.lblIssueEditFieldEnumCode.Text = "warning!";
            // 
            // chkbxDefaultFieldDisp
            // 
            this.chkbxDefaultFieldDisp.AutoSize = true;
            this.chkbxDefaultFieldDisp.Checked = true;
            this.chkbxDefaultFieldDisp.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkbxDefaultFieldDisp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbxDefaultFieldDisp.Location = new System.Drawing.Point(602, 91);
            this.chkbxDefaultFieldDisp.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.chkbxDefaultFieldDisp.Name = "chkbxDefaultFieldDisp";
            this.chkbxDefaultFieldDisp.Size = new System.Drawing.Size(80, 17);
            this.chkbxDefaultFieldDisp.TabIndex = 21;
            this.chkbxDefaultFieldDisp.Text = "Use default";
            this.chkbxDefaultFieldDisp.UseVisualStyleBackColor = true;
            this.chkbxDefaultFieldDisp.CheckedChanged += new System.EventHandler(this.chkbxDefaultFieldDisp_CheckedChanged);
            // 
            // chkbxDefaultFieldDefaultValue
            // 
            this.chkbxDefaultFieldDefaultValue.AutoSize = true;
            this.chkbxDefaultFieldDefaultValue.Checked = true;
            this.chkbxDefaultFieldDefaultValue.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkbxDefaultFieldDefaultValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbxDefaultFieldDefaultValue.Location = new System.Drawing.Point(602, 135);
            this.chkbxDefaultFieldDefaultValue.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.chkbxDefaultFieldDefaultValue.Name = "chkbxDefaultFieldDefaultValue";
            this.chkbxDefaultFieldDefaultValue.Size = new System.Drawing.Size(80, 17);
            this.chkbxDefaultFieldDefaultValue.TabIndex = 22;
            this.chkbxDefaultFieldDefaultValue.Text = "Use default";
            this.chkbxDefaultFieldDefaultValue.UseVisualStyleBackColor = true;
            this.chkbxDefaultFieldDefaultValue.CheckedChanged += new System.EventHandler(this.chkbxDefaultFieldDefaultValue_CheckedChanged);
            // 
            // chkbxDefaultFieldEnumCode
            // 
            this.chkbxDefaultFieldEnumCode.AutoSize = true;
            this.chkbxDefaultFieldEnumCode.Checked = true;
            this.chkbxDefaultFieldEnumCode.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkbxDefaultFieldEnumCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbxDefaultFieldEnumCode.Location = new System.Drawing.Point(602, 179);
            this.chkbxDefaultFieldEnumCode.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.chkbxDefaultFieldEnumCode.Name = "chkbxDefaultFieldEnumCode";
            this.chkbxDefaultFieldEnumCode.Size = new System.Drawing.Size(80, 17);
            this.chkbxDefaultFieldEnumCode.TabIndex = 23;
            this.chkbxDefaultFieldEnumCode.Text = "Use default";
            this.chkbxDefaultFieldEnumCode.UseVisualStyleBackColor = true;
            this.chkbxDefaultFieldEnumCode.CheckedChanged += new System.EventHandler(this.chkbxDefaultFieldEnumCode_CheckedChanged);
            // 
            // lblIssueFields
            // 
            this.lblIssueFields.AutoSize = true;
            this.tableLayoutFields.SetColumnSpan(this.lblIssueFields, 3);
            this.lblIssueFields.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIssueFields.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblIssueFields.Location = new System.Drawing.Point(3, 143);
            this.lblIssueFields.Margin = new System.Windows.Forms.Padding(3);
            this.lblIssueFields.Name = "lblIssueFields";
            this.lblIssueFields.Size = new System.Drawing.Size(47, 13);
            this.lblIssueFields.TabIndex = 12;
            this.lblIssueFields.Text = "warning!";
            // 
            // btnAddField
            // 
            this.btnAddField.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddField.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddField.Location = new System.Drawing.Point(3, 396);
            this.btnAddField.Name = "btnAddField";
            this.btnAddField.Size = new System.Drawing.Size(229, 25);
            this.btnAddField.TabIndex = 20;
            this.btnAddField.Text = "&Add Field";
            this.btnAddField.UseVisualStyleBackColor = true;
            this.btnAddField.Click += new System.EventHandler(this.btnAddField_Click);
            // 
            // btnUpdateField
            // 
            this.btnUpdateField.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdateField.Enabled = false;
            this.btnUpdateField.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateField.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btnUpdateField.Location = new System.Drawing.Point(238, 396);
            this.btnUpdateField.Name = "btnUpdateField";
            this.btnUpdateField.Size = new System.Drawing.Size(228, 25);
            this.btnUpdateField.TabIndex = 21;
            this.btnUpdateField.Text = "&Update Field";
            this.btnUpdateField.UseVisualStyleBackColor = true;
            this.btnUpdateField.Click += new System.EventHandler(this.btnUpdateField_Click);
            // 
            // btnDeleteField
            // 
            this.btnDeleteField.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteField.Enabled = false;
            this.btnDeleteField.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteField.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btnDeleteField.Location = new System.Drawing.Point(472, 396);
            this.btnDeleteField.Name = "btnDeleteField";
            this.btnDeleteField.Size = new System.Drawing.Size(230, 25);
            this.btnDeleteField.TabIndex = 22;
            this.btnDeleteField.Text = "Delete Field/s";
            this.btnDeleteField.UseVisualStyleBackColor = true;
            this.btnDeleteField.Click += new System.EventHandler(this.btnDeleteField_Click);
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.btnAdd);
            this.pnlButtons.Controls.Add(this.btnCancel);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlButtons.Location = new System.Drawing.Point(3, 616);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(703, 29);
            this.pnlButtons.TabIndex = 18;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(547, 4);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(622, 4);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // WizardForm
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(709, 648);
            this.Controls.Add(this.tableLayout);
            this.Name = "WizardForm";
            this.Text = "Add New Quizzer Question Type";
            this.tableLayout.ResumeLayout(false);
            this.tableLayoutTop.ResumeLayout(false);
            this.tableLayoutTop.PerformLayout();
            this.tableLayoutFields.ResumeLayout(false);
            this.tableLayoutFields.PerformLayout();
            this.tableLayoutEditField.ResumeLayout(false);
            this.tableLayoutEditField.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayout;
        private System.Windows.Forms.TableLayoutPanel tableLayoutTop;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDispSingular;
        private System.Windows.Forms.Label lblDispPlural;
        private System.Windows.Forms.Label lblEnumCode;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDispSingular;
        private System.Windows.Forms.TextBox txtDispPlural;
        private System.Windows.Forms.TextBox txtEnumCode;
        private System.Windows.Forms.CheckBox chkbxDefaultDispSingular;
        private System.Windows.Forms.CheckBox chkbxDefaultDispPlural;
        private System.Windows.Forms.CheckBox chkbxDefaultEnumCode;
        private System.Windows.Forms.Label lblIssueName;
        private System.Windows.Forms.Label lblIssueDispSingular;
        private System.Windows.Forms.Label lblIssueDispPlural;
        //private System.Windows.Forms.Panel pnlFields;
        private System.Windows.Forms.TableLayoutPanel tableLayoutFields;
        private System.Windows.Forms.ListView listViewFields;
        private System.Windows.Forms.ColumnHeader colFieldType;
        private System.Windows.Forms.ColumnHeader colFieldName;
        private System.Windows.Forms.ColumnHeader colFieldDisp;
        private System.Windows.Forms.ColumnHeader colFieldDefaultValue;
        private System.Windows.Forms.ColumnHeader colFieldEnumCode;
        private System.Windows.Forms.Label lblIssueFields;
        private System.Windows.Forms.TableLayoutPanel tableLayoutEditField;
        private System.Windows.Forms.Label lblEditFieldType;
        private System.Windows.Forms.Label lblEditFieldName;
        private System.Windows.Forms.Label lblEditFieldDisp;
        private System.Windows.Forms.Label lblEditFieldDefaultValue;
        private System.Windows.Forms.Label lblEditFieldEnumCode;
        private System.Windows.Forms.TextBox txtEditFieldType;
        private System.Windows.Forms.TextBox txtEditFieldName;
        private System.Windows.Forms.TextBox txtEditFieldDisp;
        private System.Windows.Forms.TextBox txtEditFieldDefaultValue;
        private System.Windows.Forms.TextBox txtEditFieldEnumCode;
        private System.Windows.Forms.Button btnAddField;
        private System.Windows.Forms.Button btnUpdateField;
        private System.Windows.Forms.Button btnDeleteField;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblIssueEditFieldType;
        private System.Windows.Forms.Label lblIssueEditFieldName;
        private System.Windows.Forms.Label lblIssueEditFieldDisp;
        private System.Windows.Forms.Label lblIssueEditFieldDefaultValue;
        private System.Windows.Forms.Label lblIssueEditFieldEnumCode;
        private System.Windows.Forms.CheckBox chkbxDefaultFieldDisp;
        private System.Windows.Forms.CheckBox chkbxDefaultFieldDefaultValue;
        private System.Windows.Forms.CheckBox chkbxDefaultFieldEnumCode;
        private System.Windows.Forms.Label lblIssueEnumCode;
    }
}