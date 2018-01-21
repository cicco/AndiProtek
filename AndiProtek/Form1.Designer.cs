namespace AndiProtek
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.grid = new System.Windows.Forms.DataGridView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridTables = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.label3 = new System.Windows.Forms.Label();
            this.txtQuery = new System.Windows.Forms.RichTextBox();
            this.btnQuery = new System.Windows.Forms.Button();
            this.dataGridViewQuery = new System.Windows.Forms.DataGridView();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTables)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuery)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Path";
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(195, 18);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(1105, 38);
            this.txtPath.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(195, 70);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(281, 38);
            this.txtPassword.TabIndex = 3;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(1335, 72);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(178, 48);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // grid
            // 
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(3, 3);
            this.grid.Name = "grid";
            this.grid.RowTemplate.Height = 40;
            this.grid.Size = new System.Drawing.Size(1446, 507);
            this.grid.TabIndex = 5;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnClear);
            this.splitContainer1.Panel1.Controls.Add(this.btnBrowse);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.txtPath);
            this.splitContainer1.Panel1.Controls.Add(this.btnConnect);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.txtPassword);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(1656, 933);
            this.splitContainer1.SplitterDistance = 193;
            this.splitContainer1.TabIndex = 6;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1656, 736);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.grid);
            this.tabPage1.Location = new System.Drawing.Point(10, 48);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1636, 738);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "v_LAVORAZIONI_LISTA_AGGREGATA";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridTables);
            this.tabPage2.Location = new System.Drawing.Point(10, 48);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1636, 738);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tables";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridTables
            // 
            this.dataGridTables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridTables.Location = new System.Drawing.Point(3, 3);
            this.dataGridTables.Name = "dataGridTables";
            this.dataGridTables.RowTemplate.Height = 40;
            this.dataGridTables.Size = new System.Drawing.Size(1446, 507);
            this.dataGridTables.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.splitContainer2);
            this.tabPage3.Location = new System.Drawing.Point(10, 48);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1636, 678);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "SQL";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.btnQuery);
            this.splitContainer2.Panel1.Controls.Add(this.txtQuery);
            this.splitContainer2.Panel1.Controls.Add(this.label3);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dataGridViewQuery);
            this.splitContainer2.Size = new System.Drawing.Size(1636, 678);
            this.splitContainer2.SplitterDistance = 140;
            this.splitContainer2.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "sql cmd";
            // 
            // txtQuery
            // 
            this.txtQuery.Location = new System.Drawing.Point(185, 25);
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.Size = new System.Drawing.Size(1170, 100);
            this.txtQuery.TabIndex = 1;
            this.txtQuery.Text = "";
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(1398, 25);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(181, 61);
            this.btnQuery.TabIndex = 2;
            this.btnQuery.Text = "QUERY";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // dataGridViewQuery
            // 
            this.dataGridViewQuery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewQuery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewQuery.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewQuery.Name = "dataGridViewQuery";
            this.dataGridViewQuery.RowTemplate.Height = 40;
            this.dataGridViewQuery.Size = new System.Drawing.Size(1636, 534);
            this.dataGridViewQuery.TabIndex = 0;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(1335, 18);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(178, 48);
            this.btnBrowse.TabIndex = 5;
            this.btnBrowse.Text = "Select DB";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(1335, 136);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(178, 45);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "clear all";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1656, 933);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTables)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuery)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridTables;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.RichTextBox txtQuery;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridViewQuery;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnClear;
    }
}

