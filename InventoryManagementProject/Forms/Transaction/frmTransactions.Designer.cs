namespace InventoryManagementProject.Forms.Reports
{
    partial class frmTransactions
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
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            txtTransSearch = new Guna.UI2.WinForms.Guna2TextBox();
            cmbTrans = new Guna.UI2.WinForms.Guna2ComboBox();
            dtpTrans = new Guna.UI2.WinForms.Guna2DateTimePicker();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            btnTransaction = new Guna.UI2.WinForms.Guna2Button();
            form = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(txtTransSearch);
            panel1.Controls.Add(cmbTrans);
            panel1.Controls.Add(dtpTrans);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1029, 80);
            panel1.TabIndex = 0;
            // 
            // txtTransSearch
            // 
            txtTransSearch.BorderRadius = 10;
            txtTransSearch.CustomizableEdges = customizableEdges1;
            txtTransSearch.DefaultText = "";
            txtTransSearch.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtTransSearch.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtTransSearch.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtTransSearch.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtTransSearch.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtTransSearch.Font = new Font("Segoe UI", 9F);
            txtTransSearch.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtTransSearch.Location = new Point(398, 20);
            txtTransSearch.Name = "txtTransSearch";
            txtTransSearch.PlaceholderText = "Search";
            txtTransSearch.SelectedText = "";
            txtTransSearch.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtTransSearch.Size = new Size(190, 36);
            txtTransSearch.TabIndex = 9;
            // 
            // cmbTrans
            // 
            cmbTrans.BackColor = Color.Transparent;
            cmbTrans.BorderRadius = 10;
            cmbTrans.CustomizableEdges = customizableEdges3;
            cmbTrans.DrawMode = DrawMode.OwnerDrawFixed;
            cmbTrans.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTrans.FocusedColor = Color.FromArgb(94, 148, 255);
            cmbTrans.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cmbTrans.Font = new Font("Segoe UI", 10F);
            cmbTrans.ForeColor = Color.FromArgb(68, 88, 112);
            cmbTrans.ItemHeight = 30;
            cmbTrans.Location = new Point(605, 20);
            cmbTrans.Name = "cmbTrans";
            cmbTrans.ShadowDecoration.CustomizableEdges = customizableEdges4;
            cmbTrans.Size = new Size(179, 36);
            cmbTrans.TabIndex = 8;
            // 
            // dtpTrans
            // 
            dtpTrans.BorderRadius = 10;
            dtpTrans.Checked = true;
            dtpTrans.CustomizableEdges = customizableEdges5;
            dtpTrans.FillColor = Color.FromArgb(128, 128, 255);
            dtpTrans.Font = new Font("Roboto Slab", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpTrans.ForeColor = Color.White;
            dtpTrans.Format = DateTimePickerFormat.Long;
            dtpTrans.Location = new Point(803, 20);
            dtpTrans.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            dtpTrans.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dtpTrans.Name = "dtpTrans";
            dtpTrans.ShadowDecoration.CustomizableEdges = customizableEdges6;
            dtpTrans.Size = new Size(204, 36);
            dtpTrans.TabIndex = 7;
            dtpTrans.Value = new DateTime(2025, 7, 30, 20, 17, 10, 274);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Roboto Slab Medium", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(29, 20);
            label1.Name = "label1";
            label1.Size = new Size(257, 36);
            label1.TabIndex = 6;
            label1.Text = "Transactions List";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 80);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1029, 546);
            dataGridView1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(btnTransaction);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 574);
            panel2.Name = "panel2";
            panel2.Size = new Size(1029, 52);
            panel2.TabIndex = 2;
            // 
            // btnTransaction
            // 
            btnTransaction.BorderRadius = 10;
            btnTransaction.CustomizableEdges = customizableEdges7;
            btnTransaction.DisabledState.BorderColor = Color.DarkGray;
            btnTransaction.DisabledState.CustomBorderColor = Color.DarkGray;
            btnTransaction.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnTransaction.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnTransaction.FillColor = Color.FromArgb(128, 128, 255);
            btnTransaction.Font = new Font("Roboto Slab", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTransaction.ForeColor = Color.White;
            btnTransaction.Location = new Point(32, 8);
            btnTransaction.Name = "btnTransaction";
            btnTransaction.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnTransaction.Size = new Size(180, 32);
            btnTransaction.TabIndex = 0;
            btnTransaction.Text = "New Transactions";
            // 
            // form
            // 
            form.AnimateWindow = true;
            form.ContainerControl = this;
            form.DockIndicatorTransparencyValue = 0.6D;
            form.TransparentWhileDrag = true;
            // 
            // frmTransactions
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 626);
            Controls.Add(panel2);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmTransactions";
            Text = "frmTransactions";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpTrans;
        private Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtTransSearch;
        private Guna.UI2.WinForms.Guna2ComboBox cmbTrans;
        private DataGridView dataGridView1;
        private Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btnTransaction;
        private Guna.UI2.WinForms.Guna2BorderlessForm form;
    }
}