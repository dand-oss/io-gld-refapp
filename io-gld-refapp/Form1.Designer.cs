namespace io_gld_refapp
{
    partial class Form1
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
            this.tlForm = new System.Windows.Forms.TableLayoutPanel();
            this.flForm = new System.Windows.Forms.FlowLayoutPanel();
            this.outputBox = new System.Windows.Forms.TextBox();
            this.btnStartGlue = new System.Windows.Forms.Button();
            this.grpWellSelector = new System.Windows.Forms.GroupBox();
            this.tlWellSelector = new System.Windows.Forms.TableLayoutPanel();
            this.cmbStrings = new System.Windows.Forms.ComboBox();
            this.btnDataSources = new System.Windows.Forms.Button();
            this.btnString = new System.Windows.Forms.Button();
            this.btnSelectWell = new System.Windows.Forms.Button();
            this.btnCurrentWell = new System.Windows.Forms.Button();
            this.cmbDataSources = new System.Windows.Forms.ComboBox();
            this.cmbWells = new System.Windows.Forms.ComboBox();
            this.btnFields = new System.Windows.Forms.Button();
            this.btnWells = new System.Windows.Forms.Button();
            this.cmbFields = new System.Windows.Forms.ComboBox();
            this.cmbLeases = new System.Windows.Forms.ComboBox();
            this.btnLeases = new System.Windows.Forms.Button();
            this.grpCurves = new System.Windows.Forms.GroupBox();
            this.tlCurves = new System.Windows.Forms.TableLayoutPanel();
            this.btnGetCurveList = new System.Windows.Forms.Button();
            this.btnGetGraphList = new System.Windows.Forms.Button();
            this.cmbGraphs = new System.Windows.Forms.ComboBox();
            this.cmbCurves = new System.Windows.Forms.ComboBox();
            this.btnGetCurve = new System.Windows.Forms.Button();
            this.grpWellTest = new System.Windows.Forms.GroupBox();
            this.tlWellTest = new System.Windows.Forms.TableLayoutPanel();
            this.btnGetWelltest = new System.Windows.Forms.Button();
            this.btnSetWelltest = new System.Windows.Forms.Button();
            this.tlForm.SuspendLayout();
            this.flForm.SuspendLayout();
            this.grpWellSelector.SuspendLayout();
            this.tlWellSelector.SuspendLayout();
            this.grpCurves.SuspendLayout();
            this.tlCurves.SuspendLayout();
            this.grpWellTest.SuspendLayout();
            this.tlWellTest.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlForm
            // 
            this.tlForm.ColumnCount = 1;
            this.tlForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.07692F));
            this.tlForm.Controls.Add(this.flForm, 0, 0);
            this.tlForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlForm.Location = new System.Drawing.Point(0, 0);
            this.tlForm.Name = "tlForm";
            this.tlForm.RowCount = 1;
            this.tlForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlForm.Size = new System.Drawing.Size(363, 587);
            this.tlForm.TabIndex = 0;
            // 
            // flForm
            // 
            this.flForm.Controls.Add(this.outputBox);
            this.flForm.Controls.Add(this.btnStartGlue);
            this.flForm.Controls.Add(this.grpWellSelector);
            this.flForm.Controls.Add(this.grpCurves);
            this.flForm.Controls.Add(this.grpWellTest);
            this.flForm.Cursor = System.Windows.Forms.Cursors.Default;
            this.flForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flForm.Location = new System.Drawing.Point(3, 3);
            this.flForm.Name = "flForm";
            this.flForm.Size = new System.Drawing.Size(357, 581);
            this.flForm.TabIndex = 0;
            // 
            // outputBox
            // 
            this.outputBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.outputBox.Location = new System.Drawing.Point(3, 3);
            this.outputBox.Multiline = true;
            this.outputBox.Name = "outputBox";
            this.outputBox.ReadOnly = true;
            this.outputBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outputBox.Size = new System.Drawing.Size(282, 86);
            this.outputBox.TabIndex = 1;
            this.outputBox.TextChanged += new System.EventHandler(this.outputBox_TextChanged);
            // 
            // btnStartGlue
            // 
            this.btnStartGlue.AutoSize = true;
            this.btnStartGlue.Location = new System.Drawing.Point(3, 95);
            this.btnStartGlue.Name = "btnStartGlue";
            this.btnStartGlue.Size = new System.Drawing.Size(122, 27);
            this.btnStartGlue.TabIndex = 2;
            this.btnStartGlue.Text = "Start WinGLUE";
            this.btnStartGlue.UseVisualStyleBackColor = true;
            this.btnStartGlue.Click += new System.EventHandler(this.startGlue_Click);
            // 
            // grpWellSelector
            // 
            this.grpWellSelector.Controls.Add(this.tlWellSelector);
            this.grpWellSelector.Location = new System.Drawing.Point(3, 128);
            this.grpWellSelector.Name = "grpWellSelector";
            this.grpWellSelector.Size = new System.Drawing.Size(282, 253);
            this.grpWellSelector.TabIndex = 8;
            this.grpWellSelector.TabStop = false;
            this.grpWellSelector.Text = "Well Selector";
            // 
            // tlWellSelector
            // 
            this.tlWellSelector.ColumnCount = 2;
            this.tlWellSelector.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.08738F));
            this.tlWellSelector.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.91262F));
            this.tlWellSelector.Controls.Add(this.cmbStrings, 1, 4);
            this.tlWellSelector.Controls.Add(this.btnDataSources, 0, 0);
            this.tlWellSelector.Controls.Add(this.btnString, 0, 4);
            this.tlWellSelector.Controls.Add(this.btnSelectWell, 1, 5);
            this.tlWellSelector.Controls.Add(this.btnCurrentWell, 0, 5);
            this.tlWellSelector.Controls.Add(this.cmbDataSources, 1, 0);
            this.tlWellSelector.Controls.Add(this.cmbWells, 1, 3);
            this.tlWellSelector.Controls.Add(this.btnFields, 0, 1);
            this.tlWellSelector.Controls.Add(this.btnWells, 0, 3);
            this.tlWellSelector.Controls.Add(this.cmbFields, 1, 1);
            this.tlWellSelector.Controls.Add(this.cmbLeases, 1, 2);
            this.tlWellSelector.Controls.Add(this.btnLeases, 0, 2);
            this.tlWellSelector.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlWellSelector.Location = new System.Drawing.Point(3, 18);
            this.tlWellSelector.Name = "tlWellSelector";
            this.tlWellSelector.RowCount = 6;
            this.tlWellSelector.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlWellSelector.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlWellSelector.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlWellSelector.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlWellSelector.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlWellSelector.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlWellSelector.Size = new System.Drawing.Size(276, 232);
            this.tlWellSelector.TabIndex = 0;
            // 
            // cmbStrings
            // 
            this.cmbStrings.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStrings.FormattingEnabled = true;
            this.cmbStrings.Location = new System.Drawing.Point(132, 155);
            this.cmbStrings.Name = "cmbStrings";
            this.cmbStrings.Size = new System.Drawing.Size(121, 24);
            this.cmbStrings.TabIndex = 3;
            // 
            // btnDataSources
            // 
            this.btnDataSources.AutoSize = true;
            this.btnDataSources.Location = new System.Drawing.Point(3, 3);
            this.btnDataSources.Name = "btnDataSources";
            this.btnDataSources.Size = new System.Drawing.Size(104, 27);
            this.btnDataSources.TabIndex = 0;
            this.btnDataSources.Text = "Data Sources";
            this.btnDataSources.UseVisualStyleBackColor = true;
            this.btnDataSources.Click += new System.EventHandler(this.btnDataSources_Click);
            // 
            // btnString
            // 
            this.btnString.AutoSize = true;
            this.btnString.Location = new System.Drawing.Point(3, 155);
            this.btnString.Name = "btnString";
            this.btnString.Size = new System.Drawing.Size(104, 27);
            this.btnString.TabIndex = 2;
            this.btnString.Text = "String";
            this.btnString.UseVisualStyleBackColor = true;
            this.btnString.Click += new System.EventHandler(this.btnString_Click);
            // 
            // btnSelectWell
            // 
            this.btnSelectWell.AutoSize = true;
            this.btnSelectWell.Location = new System.Drawing.Point(132, 193);
            this.btnSelectWell.Name = "btnSelectWell";
            this.btnSelectWell.Size = new System.Drawing.Size(88, 27);
            this.btnSelectWell.TabIndex = 10;
            this.btnSelectWell.Text = "Select Well";
            this.btnSelectWell.UseVisualStyleBackColor = true;
            this.btnSelectWell.Click += new System.EventHandler(this.btnSelectWell_Click);
            // 
            // btnCurrentWell
            // 
            this.btnCurrentWell.AutoSize = true;
            this.btnCurrentWell.Location = new System.Drawing.Point(3, 193);
            this.btnCurrentWell.Name = "btnCurrentWell";
            this.btnCurrentWell.Size = new System.Drawing.Size(112, 27);
            this.btnCurrentWell.TabIndex = 9;
            this.btnCurrentWell.Text = "Get Well Sel";
            this.btnCurrentWell.UseVisualStyleBackColor = true;
            this.btnCurrentWell.Click += new System.EventHandler(this.btnCurrentWell_Click);
            // 
            // cmbDataSources
            // 
            this.cmbDataSources.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDataSources.FormattingEnabled = true;
            this.cmbDataSources.Location = new System.Drawing.Point(132, 3);
            this.cmbDataSources.Name = "cmbDataSources";
            this.cmbDataSources.Size = new System.Drawing.Size(121, 24);
            this.cmbDataSources.TabIndex = 1;
            this.cmbDataSources.SelectedIndexChanged += new System.EventHandler(this.cmbDataSources_SelectedIndexChanged);
            // 
            // cmbWells
            // 
            this.cmbWells.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWells.FormattingEnabled = true;
            this.cmbWells.Location = new System.Drawing.Point(132, 117);
            this.cmbWells.Name = "cmbWells";
            this.cmbWells.Size = new System.Drawing.Size(121, 24);
            this.cmbWells.TabIndex = 1;
            // 
            // btnFields
            // 
            this.btnFields.AutoSize = true;
            this.btnFields.Location = new System.Drawing.Point(3, 41);
            this.btnFields.Name = "btnFields";
            this.btnFields.Size = new System.Drawing.Size(104, 27);
            this.btnFields.TabIndex = 0;
            this.btnFields.Text = "Fields";
            this.btnFields.UseVisualStyleBackColor = true;
            this.btnFields.Click += new System.EventHandler(this.btnFields_Click);
            // 
            // btnWells
            // 
            this.btnWells.AutoSize = true;
            this.btnWells.Location = new System.Drawing.Point(3, 117);
            this.btnWells.Name = "btnWells";
            this.btnWells.Size = new System.Drawing.Size(104, 27);
            this.btnWells.TabIndex = 0;
            this.btnWells.Text = "Wells";
            this.btnWells.UseVisualStyleBackColor = true;
            this.btnWells.Click += new System.EventHandler(this.btnWells_Click);
            // 
            // cmbFields
            // 
            this.cmbFields.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFields.FormattingEnabled = true;
            this.cmbFields.Location = new System.Drawing.Point(132, 41);
            this.cmbFields.Name = "cmbFields";
            this.cmbFields.Size = new System.Drawing.Size(121, 24);
            this.cmbFields.TabIndex = 1;
            this.cmbFields.SelectedIndexChanged += new System.EventHandler(this.cmbFields_SelectedIndexChanged);
            // 
            // cmbLeases
            // 
            this.cmbLeases.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLeases.FormattingEnabled = true;
            this.cmbLeases.Location = new System.Drawing.Point(132, 79);
            this.cmbLeases.Name = "cmbLeases";
            this.cmbLeases.Size = new System.Drawing.Size(121, 24);
            this.cmbLeases.TabIndex = 1;
            this.cmbLeases.SelectedIndexChanged += new System.EventHandler(this.cmbLeases_SelectedIndexChanged);
            // 
            // btnLeases
            // 
            this.btnLeases.AutoSize = true;
            this.btnLeases.Location = new System.Drawing.Point(3, 79);
            this.btnLeases.Name = "btnLeases";
            this.btnLeases.Size = new System.Drawing.Size(104, 27);
            this.btnLeases.TabIndex = 0;
            this.btnLeases.Text = "Leases";
            this.btnLeases.UseVisualStyleBackColor = true;
            this.btnLeases.Click += new System.EventHandler(this.btnLeases_Click);
            // 
            // grpCurves
            // 
            this.grpCurves.Controls.Add(this.tlCurves);
            this.grpCurves.Location = new System.Drawing.Point(3, 387);
            this.grpCurves.Name = "grpCurves";
            this.grpCurves.Size = new System.Drawing.Size(282, 135);
            this.grpCurves.TabIndex = 13;
            this.grpCurves.TabStop = false;
            this.grpCurves.Text = "Curves";
            // 
            // tlCurves
            // 
            this.tlCurves.ColumnCount = 2;
            this.tlCurves.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlCurves.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlCurves.Controls.Add(this.btnGetCurveList, 0, 1);
            this.tlCurves.Controls.Add(this.btnGetGraphList, 0, 0);
            this.tlCurves.Controls.Add(this.cmbGraphs, 1, 0);
            this.tlCurves.Controls.Add(this.cmbCurves, 1, 1);
            this.tlCurves.Controls.Add(this.btnGetCurve, 0, 2);
            this.tlCurves.Location = new System.Drawing.Point(3, 18);
            this.tlCurves.Name = "tlCurves";
            this.tlCurves.RowCount = 3;
            this.tlCurves.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlCurves.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlCurves.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlCurves.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlCurves.Size = new System.Drawing.Size(276, 107);
            this.tlCurves.TabIndex = 0;
            // 
            // btnGetCurveList
            // 
            this.btnGetCurveList.AutoSize = true;
            this.btnGetCurveList.Location = new System.Drawing.Point(3, 38);
            this.btnGetCurveList.Name = "btnGetCurveList";
            this.btnGetCurveList.Size = new System.Drawing.Size(108, 27);
            this.btnGetCurveList.TabIndex = 27;
            this.btnGetCurveList.Text = "Get Curve List";
            this.btnGetCurveList.UseVisualStyleBackColor = true;
            this.btnGetCurveList.Click += new System.EventHandler(this.btnGetCurveList_Click);
            // 
            // btnGetGraphList
            // 
            this.btnGetGraphList.AutoSize = true;
            this.btnGetGraphList.Location = new System.Drawing.Point(3, 3);
            this.btnGetGraphList.Name = "btnGetGraphList";
            this.btnGetGraphList.Size = new System.Drawing.Size(111, 27);
            this.btnGetGraphList.TabIndex = 29;
            this.btnGetGraphList.TabStop = false;
            this.btnGetGraphList.Text = "Get Graph List";
            this.btnGetGraphList.UseVisualStyleBackColor = true;
            this.btnGetGraphList.Click += new System.EventHandler(this.btnGetGraphList_Click);
            // 
            // cmbGraphs
            // 
            this.cmbGraphs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGraphs.FormattingEnabled = true;
            this.cmbGraphs.Location = new System.Drawing.Point(141, 3);
            this.cmbGraphs.Name = "cmbGraphs";
            this.cmbGraphs.Size = new System.Drawing.Size(121, 24);
            this.cmbGraphs.TabIndex = 30;
            // 
            // cmbCurves
            // 
            this.cmbCurves.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCurves.FormattingEnabled = true;
            this.cmbCurves.Location = new System.Drawing.Point(141, 38);
            this.cmbCurves.Name = "cmbCurves";
            this.cmbCurves.Size = new System.Drawing.Size(121, 24);
            this.cmbCurves.TabIndex = 31;
            // 
            // btnGetCurve
            // 
            this.btnGetCurve.AutoSize = true;
            this.btnGetCurve.Location = new System.Drawing.Point(3, 73);
            this.btnGetCurve.Name = "btnGetCurve";
            this.btnGetCurve.Size = new System.Drawing.Size(82, 27);
            this.btnGetCurve.TabIndex = 32;
            this.btnGetCurve.Text = "Get Curve";
            this.btnGetCurve.UseVisualStyleBackColor = true;
            this.btnGetCurve.Click += new System.EventHandler(this.btnGetCurve_Click);
            // 
            // grpWellTest
            // 
            this.grpWellTest.Controls.Add(this.tlWellTest);
            this.grpWellTest.Location = new System.Drawing.Point(3, 528);
            this.grpWellTest.Name = "grpWellTest";
            this.grpWellTest.Size = new System.Drawing.Size(279, 63);
            this.grpWellTest.TabIndex = 14;
            this.grpWellTest.TabStop = false;
            this.grpWellTest.Text = "WellTest";
            // 
            // tlWellTest
            // 
            this.tlWellTest.ColumnCount = 2;
            this.tlWellTest.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlWellTest.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlWellTest.Controls.Add(this.btnGetWelltest, 0, 0);
            this.tlWellTest.Controls.Add(this.btnSetWelltest, 1, 0);
            this.tlWellTest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlWellTest.Location = new System.Drawing.Point(3, 18);
            this.tlWellTest.Name = "tlWellTest";
            this.tlWellTest.RowCount = 1;
            this.tlWellTest.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 77.10844F));
            this.tlWellTest.Size = new System.Drawing.Size(273, 42);
            this.tlWellTest.TabIndex = 0;
            // 
            // btnGetWelltest
            // 
            this.btnGetWelltest.AutoSize = true;
            this.btnGetWelltest.Location = new System.Drawing.Point(3, 3);
            this.btnGetWelltest.Name = "btnGetWelltest";
            this.btnGetWelltest.Size = new System.Drawing.Size(95, 27);
            this.btnGetWelltest.TabIndex = 16;
            this.btnGetWelltest.Text = "Get Welltest";
            this.btnGetWelltest.UseVisualStyleBackColor = true;
            this.btnGetWelltest.Click += new System.EventHandler(this.btnGetWelltest_Click);
            // 
            // btnSetWelltest
            // 
            this.btnSetWelltest.AutoSize = true;
            this.btnSetWelltest.Location = new System.Drawing.Point(139, 3);
            this.btnSetWelltest.Name = "btnSetWelltest";
            this.btnSetWelltest.Size = new System.Drawing.Size(98, 27);
            this.btnSetWelltest.TabIndex = 17;
            this.btnSetWelltest.Text = "Set WellTest";
            this.btnSetWelltest.UseVisualStyleBackColor = true;
            this.btnSetWelltest.Click += new System.EventHandler(this.btnSetWelltest_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 587);
            this.Controls.Add(this.tlForm);
            this.Name = "Form1";
            this.Text = "IO GLD Ref App";
            this.tlForm.ResumeLayout(false);
            this.flForm.ResumeLayout(false);
            this.flForm.PerformLayout();
            this.grpWellSelector.ResumeLayout(false);
            this.tlWellSelector.ResumeLayout(false);
            this.tlWellSelector.PerformLayout();
            this.grpCurves.ResumeLayout(false);
            this.tlCurves.ResumeLayout(false);
            this.tlCurves.PerformLayout();
            this.grpWellTest.ResumeLayout(false);
            this.tlWellTest.ResumeLayout(false);
            this.tlWellTest.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlForm;
        private System.Windows.Forms.FlowLayoutPanel flForm;
        private System.Windows.Forms.TextBox outputBox;
        private System.Windows.Forms.Button btnStartGlue;
        private System.Windows.Forms.Button btnDataSources;
        private System.Windows.Forms.ComboBox cmbDataSources;
        private System.Windows.Forms.ComboBox cmbWells;
        private System.Windows.Forms.Button btnWells;
        private System.Windows.Forms.ComboBox cmbLeases;
        private System.Windows.Forms.Button btnLeases;
        private System.Windows.Forms.ComboBox cmbStrings;
        private System.Windows.Forms.Button btnString;
        private System.Windows.Forms.ComboBox cmbFields;
        private System.Windows.Forms.Button btnFields;
        private System.Windows.Forms.GroupBox grpWellSelector;
        private System.Windows.Forms.TableLayoutPanel tlWellSelector;
        private System.Windows.Forms.Button btnCurrentWell;
        private System.Windows.Forms.Button btnSelectWell;
        private System.Windows.Forms.GroupBox grpCurves;
        private System.Windows.Forms.TableLayoutPanel tlCurves;
        private System.Windows.Forms.Button btnGetGraphList;
        private System.Windows.Forms.Button btnGetCurveList;
        private System.Windows.Forms.GroupBox grpWellTest;
        private System.Windows.Forms.TableLayoutPanel tlWellTest;
        private System.Windows.Forms.ComboBox cmbGraphs;
        private System.Windows.Forms.Button btnGetWelltest;
        private System.Windows.Forms.Button btnSetWelltest;
        private System.Windows.Forms.ComboBox cmbCurves;
        private System.Windows.Forms.Button btnGetCurve;
    }
}

