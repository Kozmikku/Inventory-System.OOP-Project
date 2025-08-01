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
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label1 = new Label();
            panel = new Panel();
            cmbSupplier = new Guna.UI2.WinForms.Guna2ComboBox();
            cmbCategory = new Guna.UI2.WinForms.Guna2ComboBox();
            label2 = new Label();
            lblTotalCount = new Label();
            form = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            dgvInventory = new DataGridView();
            label3 = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInventory).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1036, 80);
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
            // panel
            // 
            panel.Controls.Add(label4);
            panel.Controls.Add(label3);
            panel.Controls.Add(cmbSupplier);
            panel.Controls.Add(cmbCategory);
            panel.Controls.Add(label2);
            panel.Controls.Add(lblTotalCount);
            panel.Dock = DockStyle.Top;
            panel.Location = new Point(0, 80);
            panel.Name = "panel";
            panel.Size = new Size(1036, 80);
            panel.TabIndex = 1;
            // 
            // cmbSupplier
            // 
            cmbSupplier.BackColor = Color.Transparent;
            cmbSupplier.CustomizableEdges = customizableEdges1;
            cmbSupplier.DrawMode = DrawMode.OwnerDrawFixed;
            cmbSupplier.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSupplier.FocusedColor = Color.FromArgb(94, 148, 255);
            cmbSupplier.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cmbSupplier.Font = new Font("Segoe UI", 10F);
            cmbSupplier.ForeColor = Color.Black;
            cmbSupplier.ItemHeight = 30;
            cmbSupplier.Location = new Point(413, 20);
            cmbSupplier.Name = "cmbSupplier";
            cmbSupplier.ShadowDecoration.CustomizableEdges = customizableEdges2;
            cmbSupplier.Size = new Size(177, 36);
            cmbSupplier.TabIndex = 16;
            // 
            // cmbCategory
            // 
            cmbCategory.BackColor = Color.Transparent;
            cmbCategory.CustomizableEdges = customizableEdges3;
            cmbCategory.DrawMode = DrawMode.OwnerDrawFixed;
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.FocusedColor = Color.FromArgb(94, 148, 255);
            cmbCategory.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cmbCategory.Font = new Font("Segoe UI", 10F);
            cmbCategory.ForeColor = Color.Black;
            cmbCategory.ItemHeight = 30;
            cmbCategory.Location = new Point(129, 20);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.ShadowDecoration.CustomizableEdges = customizableEdges4;
            cmbCategory.Size = new Size(178, 36);
            cmbCategory.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Roboto Slab", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(641, 25);
            label2.Name = "label2";
            label2.Size = new Size(102, 22);
            label2.TabIndex = 5;
            label2.Text = "Total Count:";
            // 
            // lblTotalCount
            // 
            lblTotalCount.AutoSize = true;
            lblTotalCount.Font = new Font("Roboto Slab", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalCount.Location = new Point(767, 25);
            lblTotalCount.Name = "lblTotalCount";
            lblTotalCount.Size = new Size(139, 22);
            lblTotalCount.TabIndex = 4;
            lblTotalCount.Text = "Showing X items";
            // 
            // form
            // 
            form.AnimateWindow = true;
            form.ContainerControl = this;
            form.DockIndicatorTransparencyValue = 0.6D;
            form.TransparentWhileDrag = true;
            // 
            // dgvInventory
            // 
            dgvInventory.AllowUserToAddRows = false;
            dgvInventory.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvInventory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvInventory.BackgroundColor = Color.White;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Roboto Slab", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(128, 128, 255);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvInventory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(128, 128, 255);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvInventory.DefaultCellStyle = dataGridViewCellStyle3;
            dgvInventory.Dock = DockStyle.Fill;
            dgvInventory.GridColor = Color.Black;
            dgvInventory.Location = new Point(0, 160);
            dgvInventory.Name = "dgvInventory";
            dgvInventory.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Roboto Slab", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(128, 128, 255);
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvInventory.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Font = new Font("Roboto Slab", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgvInventory.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvInventory.Size = new Size(1036, 466);
            dgvInventory.TabIndex = 4;
            dgvInventory.CellContentClick += dgvInventory_CellContentClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Roboto Slab", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(31, 25);
            label3.Name = "label3";
            label3.Size = new Size(92, 22);
            label3.TabIndex = 17;
            label3.Text = "Categories:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Roboto Slab", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(332, 25);
            label4.Name = "label4";
            label4.Size = new Size(75, 22);
            label4.TabIndex = 18;
            label4.Text = "Supplier:";
            // 
            // frmInventory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1036, 626);
            Controls.Add(dgvInventory);
            Controls.Add(panel);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmInventory";
            Text = "frmInventory";
            Load += frmInventory_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel.ResumeLayout(false);
            panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInventory).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel;
        private Label lblTotalCount;
        private Label label2;
        private Guna.UI2.WinForms.Guna2BorderlessForm form;
        private Guna.UI2.WinForms.Guna2ComboBox cmbCategory;
        private Guna.UI2.WinForms.Guna2ComboBox cmbSupplier;
        private DataGridView dgvInventory;
        private Label label4;
        private Label label3;
    }
}