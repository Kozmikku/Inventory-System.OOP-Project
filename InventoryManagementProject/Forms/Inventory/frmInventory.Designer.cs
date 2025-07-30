namespace InventoryManagementProject.Forms.Inventory
{
    partial class frmInventory
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges21 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges22 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges29 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges30 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges27 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges28 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges25 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges26 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges23 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges24 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            label1 = new Label();
            txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            panel2 = new Panel();
            btnAdd = new Guna.UI2.WinForms.Guna2Button();
            btnEdit = new Guna.UI2.WinForms.Guna2Button();
            btnDelete = new Guna.UI2.WinForms.Guna2Button();
            btnRefresh = new Guna.UI2.WinForms.Guna2Button();
            dgvProducts = new DataGridView();
            lblTotalCount = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(txtSearch);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1029, 80);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Roboto Slab Medium", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(20, 20);
            label1.Name = "label1";
            label1.Size = new Size(338, 36);
            label1.TabIndex = 5;
            label1.Text = "Inventory Management";
            // 
            // txtSearch
            // 
            txtSearch.BorderRadius = 20;
            txtSearch.CustomizableEdges = customizableEdges21;
            txtSearch.DefaultText = "";
            txtSearch.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtSearch.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtSearch.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtSearch.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtSearch.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSearch.Font = new Font("Segoe UI", 9F);
            txtSearch.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSearch.Location = new Point(791, 20);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search";
            txtSearch.SelectedText = "";
            txtSearch.ShadowDecoration.CustomizableEdges = customizableEdges22;
            txtSearch.Size = new Size(200, 36);
            txtSearch.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Controls.Add(lblTotalCount);
            panel2.Controls.Add(btnRefresh);
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(btnEdit);
            panel2.Controls.Add(btnAdd);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 80);
            panel2.Name = "panel2";
            panel2.Size = new Size(1029, 80);
            panel2.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.BorderRadius = 20;
            btnAdd.CustomizableEdges = customizableEdges29;
            btnAdd.DisabledState.BorderColor = Color.DarkGray;
            btnAdd.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAdd.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAdd.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAdd.FillColor = Color.FromArgb(128, 128, 255);
            btnAdd.Font = new Font("Roboto Slab", 9F);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(30, 17);
            btnAdd.Name = "btnAdd";
            btnAdd.ShadowDecoration.CustomizableEdges = customizableEdges30;
            btnAdd.Size = new Size(93, 45);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            // 
            // btnEdit
            // 
            btnEdit.BorderRadius = 20;
            btnEdit.CustomizableEdges = customizableEdges27;
            btnEdit.DisabledState.BorderColor = Color.DarkGray;
            btnEdit.DisabledState.CustomBorderColor = Color.DarkGray;
            btnEdit.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnEdit.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnEdit.FillColor = Color.FromArgb(128, 128, 255);
            btnEdit.Font = new Font("Roboto Slab", 9F);
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(160, 17);
            btnEdit.Name = "btnEdit";
            btnEdit.ShadowDecoration.CustomizableEdges = customizableEdges28;
            btnEdit.Size = new Size(93, 45);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Edit";
            // 
            // btnDelete
            // 
            btnDelete.BorderRadius = 20;
            btnDelete.CustomizableEdges = customizableEdges25;
            btnDelete.DisabledState.BorderColor = Color.DarkGray;
            btnDelete.DisabledState.CustomBorderColor = Color.DarkGray;
            btnDelete.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnDelete.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnDelete.FillColor = Color.FromArgb(128, 128, 255);
            btnDelete.Font = new Font("Roboto Slab", 9F);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(301, 17);
            btnDelete.Name = "btnDelete";
            btnDelete.ShadowDecoration.CustomizableEdges = customizableEdges26;
            btnDelete.Size = new Size(93, 45);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            // 
            // btnRefresh
            // 
            btnRefresh.BorderRadius = 20;
            btnRefresh.CustomizableEdges = customizableEdges23;
            btnRefresh.DisabledState.BorderColor = Color.DarkGray;
            btnRefresh.DisabledState.CustomBorderColor = Color.DarkGray;
            btnRefresh.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnRefresh.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnRefresh.FillColor = Color.FromArgb(128, 128, 255);
            btnRefresh.Font = new Font("Roboto Slab", 9F);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(437, 17);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.ShadowDecoration.CustomizableEdges = customizableEdges24;
            btnRefresh.Size = new Size(93, 45);
            btnRefresh.TabIndex = 3;
            btnRefresh.Text = "Refresh";
            // 
            // dgvProducts
            // 
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Dock = DockStyle.Fill;
            dgvProducts.Location = new Point(0, 160);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.Size = new Size(1029, 466);
            dgvProducts.TabIndex = 2;
            // 
            // lblTotalCount
            // 
            lblTotalCount.AutoSize = true;
            lblTotalCount.Font = new Font("Roboto Slab", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalCount.Location = new Point(778, 26);
            lblTotalCount.Name = "lblTotalCount";
            lblTotalCount.Size = new Size(139, 22);
            lblTotalCount.TabIndex = 4;
            lblTotalCount.Text = "Showing X items";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Roboto Slab", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(670, 26);
            label2.Name = "label2";
            label2.Size = new Size(102, 22);
            label2.TabIndex = 5;
            label2.Text = "Total Count:";
            // 
            // frmInventory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 626);
            Controls.Add(dgvProducts);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmInventory";
            Text = "frmInventory";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btnRefresh;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2Button btnEdit;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private DataGridView dgvProducts;
        private Label lblTotalCount;
        private Label label2;
    }
}