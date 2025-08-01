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
            panel1 = new Panel();
            label1 = new Label();
            panel = new Panel();
            label2 = new Label();
            lblTotalCount = new Label();
            btnRefresh = new Guna.UI2.WinForms.Guna2Button();
            btnAdjustStock = new Guna.UI2.WinForms.Guna2Button();
            dgvInventory = new DataGridView();
            form = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
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
            panel.Controls.Add(label2);
            panel.Controls.Add(lblTotalCount);
            panel.Controls.Add(btnRefresh);
            panel.Controls.Add(btnAdjustStock);
            panel.Dock = DockStyle.Top;
            panel.Location = new Point(0, 80);
            panel.Name = "panel";
            panel.Size = new Size(1036, 80);
            panel.TabIndex = 1;
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
            // btnRefresh
            // 
            btnRefresh.BorderRadius = 20;
            btnRefresh.CustomizableEdges = customizableEdges1;
            btnRefresh.DisabledState.BorderColor = Color.DarkGray;
            btnRefresh.DisabledState.CustomBorderColor = Color.DarkGray;
            btnRefresh.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnRefresh.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnRefresh.FillColor = Color.FromArgb(128, 128, 255);
            btnRefresh.Font = new Font("Roboto Slab", 9F);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(194, 17);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnRefresh.Size = new Size(93, 45);
            btnRefresh.TabIndex = 3;
            btnRefresh.Text = "Refresh";
            // 
            // btnAdjustStock
            // 
            btnAdjustStock.BorderRadius = 20;
            btnAdjustStock.CustomizableEdges = customizableEdges3;
            btnAdjustStock.DisabledState.BorderColor = Color.DarkGray;
            btnAdjustStock.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAdjustStock.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAdjustStock.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAdjustStock.FillColor = Color.FromArgb(128, 128, 255);
            btnAdjustStock.Font = new Font("Roboto Slab", 9F);
            btnAdjustStock.ForeColor = Color.White;
            btnAdjustStock.Location = new Point(30, 17);
            btnAdjustStock.Name = "btnAdjustStock";
            btnAdjustStock.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnAdjustStock.Size = new Size(123, 45);
            btnAdjustStock.TabIndex = 0;
            btnAdjustStock.Text = "Adjust Stock";
            btnAdjustStock.Click += btnAdjustStock_Click;
            // 
            // dgvInventory
            // 
            dgvInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInventory.Dock = DockStyle.Fill;
            dgvInventory.Location = new Point(0, 160);
            dgvInventory.Name = "dgvInventory";
            dgvInventory.Size = new Size(1036, 466);
            dgvInventory.TabIndex = 2;
            // 
            // form
            // 
            form.AnimateWindow = true;
            form.ContainerControl = this;
            form.DockIndicatorTransparencyValue = 0.6D;
            form.TransparentWhileDrag = true;
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
        private Guna.UI2.WinForms.Guna2Button btnRefresh;
        private Guna.UI2.WinForms.Guna2Button btnAdjustStock;
        private DataGridView dgvInventory;
        private Label lblTotalCount;
        private Label label2;
        private Guna.UI2.WinForms.Guna2BorderlessForm form;
    }
}