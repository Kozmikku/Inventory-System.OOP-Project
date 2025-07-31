namespace InventoryManagementProject.Forms.Reports
{
    partial class frmProductSelect
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges19 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges20 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            label10 = new Label();
            guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            txtSelectSearch = new Guna.UI2.WinForms.Guna2TextBox();
            btnTransaction = new Guna.UI2.WinForms.Guna2Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 128, 255);
            panel1.Controls.Add(guna2ControlBox2);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(guna2ControlBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(700, 35);
            panel1.TabIndex = 2;
            // 
            // guna2ControlBox2
            // 
            guna2ControlBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2ControlBox2.CustomizableEdges = customizableEdges13;
            guna2ControlBox2.FillColor = Color.FromArgb(128, 128, 255);
            guna2ControlBox2.IconColor = Color.White;
            guna2ControlBox2.Location = new Point(655, 0);
            guna2ControlBox2.Name = "guna2ControlBox2";
            guna2ControlBox2.ShadowDecoration.CustomizableEdges = customizableEdges14;
            guna2ControlBox2.Size = new Size(45, 35);
            guna2ControlBox2.TabIndex = 23;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Roboto Slab Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.White;
            label10.Location = new Point(10, 4);
            label10.Name = "label10";
            label10.Size = new Size(156, 26);
            label10.TabIndex = 22;
            label10.Text = "Select Product";
            // 
            // guna2ControlBox1
            // 
            guna2ControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2ControlBox1.CustomizableEdges = customizableEdges15;
            guna2ControlBox1.FillColor = Color.FromArgb(128, 128, 255);
            guna2ControlBox1.IconColor = Color.White;
            guna2ControlBox1.Location = new Point(1629, 0);
            guna2ControlBox1.Name = "guna2ControlBox1";
            guna2ControlBox1.ShadowDecoration.CustomizableEdges = customizableEdges16;
            guna2ControlBox1.Size = new Size(45, 35);
            guna2ControlBox1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnTransaction);
            panel2.Controls.Add(txtSelectSearch);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 232);
            panel2.Name = "panel2";
            panel2.Size = new Size(700, 50);
            panel2.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 35);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(700, 197);
            dataGridView1.TabIndex = 4;
            // 
            // txtSelectSearch
            // 
            txtSelectSearch.BorderRadius = 10;
            txtSelectSearch.CustomizableEdges = customizableEdges19;
            txtSelectSearch.DefaultText = "";
            txtSelectSearch.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtSelectSearch.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtSelectSearch.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtSelectSearch.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtSelectSearch.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSelectSearch.Font = new Font("Segoe UI", 9F);
            txtSelectSearch.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSelectSearch.Location = new Point(12, 6);
            txtSelectSearch.Name = "txtSelectSearch";
            txtSelectSearch.PlaceholderText = "Search Product";
            txtSelectSearch.SelectedText = "";
            txtSelectSearch.ShadowDecoration.CustomizableEdges = customizableEdges20;
            txtSelectSearch.Size = new Size(190, 36);
            txtSelectSearch.TabIndex = 14;
            // 
            // btnTransaction
            // 
            btnTransaction.BorderRadius = 10;
            btnTransaction.CustomizableEdges = customizableEdges17;
            btnTransaction.DisabledState.BorderColor = Color.DarkGray;
            btnTransaction.DisabledState.CustomBorderColor = Color.DarkGray;
            btnTransaction.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnTransaction.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnTransaction.FillColor = Color.FromArgb(128, 128, 255);
            btnTransaction.Font = new Font("Roboto Slab", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTransaction.ForeColor = Color.White;
            btnTransaction.Location = new Point(221, 6);
            btnTransaction.Name = "btnTransaction";
            btnTransaction.ShadowDecoration.CustomizableEdges = customizableEdges18;
            btnTransaction.Size = new Size(180, 36);
            btnTransaction.TabIndex = 15;
            btnTransaction.Text = "Select Product";
            // 
            // frmProductSelect
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 282);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmProductSelect";
            Text = "frmProductSelect";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Label label10;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Panel panel2;
        private DataGridView dataGridView1;
        private Guna.UI2.WinForms.Guna2TextBox txtSelectSearch;
        private Guna.UI2.WinForms.Guna2Button btnTransaction;
    }
}