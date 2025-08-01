namespace InventoryManagementProject.Forms.Suppliers
{
    partial class frmSupplier
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            btnAddSupplier = new Guna.UI2.WinForms.Guna2Button();
            txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            btnRefresh = new Guna.UI2.WinForms.Guna2Button();
            btnDelete = new Guna.UI2.WinForms.Guna2Button();
            btnEdit = new Guna.UI2.WinForms.Guna2Button();
            form = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnAddSupplier);
            panel1.Controls.Add(txtSearch);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1036, 80);
            panel1.TabIndex = 1;
            // 
            // btnAddSupplier
            // 
            btnAddSupplier.BorderRadius = 10;
            btnAddSupplier.CustomizableEdges = customizableEdges1;
            btnAddSupplier.DisabledState.BorderColor = Color.DarkGray;
            btnAddSupplier.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAddSupplier.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAddSupplier.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAddSupplier.FillColor = Color.FromArgb(128, 128, 255);
            btnAddSupplier.Font = new Font("Roboto Slab", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddSupplier.ForeColor = Color.White;
            btnAddSupplier.Location = new Point(523, 20);
            btnAddSupplier.Name = "btnAddSupplier";
            btnAddSupplier.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnAddSupplier.Size = new Size(168, 36);
            btnAddSupplier.TabIndex = 7;
            btnAddSupplier.Text = "Add Supplier";
            // 
            // txtSearch
            // 
            txtSearch.BorderRadius = 20;
            txtSearch.CustomizableEdges = customizableEdges3;
            txtSearch.DefaultText = "";
            txtSearch.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtSearch.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtSearch.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtSearch.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtSearch.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSearch.Font = new Font("Segoe UI", 9F);
            txtSearch.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSearch.Location = new Point(282, 20);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search";
            txtSearch.SelectedText = "";
            txtSearch.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtSearch.Size = new Size(200, 36);
            txtSearch.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Roboto Slab Medium", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(20, 20);
            label1.Name = "label1";
            label1.Size = new Size(193, 36);
            label1.TabIndex = 5;
            label1.Text = "Supplier List";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 80);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1036, 546);
            dataGridView1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnRefresh);
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(btnEdit);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 549);
            panel2.Name = "panel2";
            panel2.Size = new Size(1036, 77);
            panel2.TabIndex = 3;
            // 
            // btnRefresh
            // 
            btnRefresh.BorderRadius = 20;
            btnRefresh.CustomizableEdges = customizableEdges5;
            btnRefresh.DisabledState.BorderColor = Color.DarkGray;
            btnRefresh.DisabledState.CustomBorderColor = Color.DarkGray;
            btnRefresh.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnRefresh.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnRefresh.FillColor = Color.FromArgb(128, 128, 255);
            btnRefresh.Font = new Font("Roboto Slab", 9F);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(323, 16);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnRefresh.Size = new Size(93, 45);
            btnRefresh.TabIndex = 6;
            btnRefresh.Text = "Refresh";
            // 
            // btnDelete
            // 
            btnDelete.BorderRadius = 20;
            btnDelete.CustomizableEdges = customizableEdges7;
            btnDelete.DisabledState.BorderColor = Color.DarkGray;
            btnDelete.DisabledState.CustomBorderColor = Color.DarkGray;
            btnDelete.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnDelete.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnDelete.FillColor = Color.FromArgb(128, 128, 255);
            btnDelete.Font = new Font("Roboto Slab", 9F);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(174, 16);
            btnDelete.Name = "btnDelete";
            btnDelete.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnDelete.Size = new Size(93, 45);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Delete";
            // 
            // btnEdit
            // 
            btnEdit.BorderRadius = 20;
            btnEdit.CustomizableEdges = customizableEdges9;
            btnEdit.DisabledState.BorderColor = Color.DarkGray;
            btnEdit.DisabledState.CustomBorderColor = Color.DarkGray;
            btnEdit.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnEdit.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnEdit.FillColor = Color.FromArgb(128, 128, 255);
            btnEdit.Font = new Font("Roboto Slab", 9F);
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(33, 16);
            btnEdit.Name = "btnEdit";
            btnEdit.ShadowDecoration.CustomizableEdges = customizableEdges10;
            btnEdit.Size = new Size(93, 45);
            btnEdit.TabIndex = 4;
            btnEdit.Text = "Edit";
            // 
            // form
            // 
            form.AnimateWindow = true;
            form.ContainerControl = this;
            form.DockIndicatorTransparencyValue = 0.6D;
            form.TransparentWhileDrag = true;
            // 
            // frmSupplier
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1036, 626);
            Controls.Add(panel2);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmSupplier";
            Text = "frmSupplier";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Label label1;
        private Guna.UI2.WinForms.Guna2Button btnAddSupplier;
        private DataGridView dataGridView1;
        private Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btnRefresh;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2Button btnEdit;
        private Guna.UI2.WinForms.Guna2BorderlessForm form;
    }
}