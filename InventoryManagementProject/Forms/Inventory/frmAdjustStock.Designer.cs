namespace InventoryManagementProject.Forms.Inventory
{
    partial class frmAdjustStock
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            lblCurrentQty = new Label();
            btnSave = new Guna.UI2.WinForms.Guna2Button();
            txtNewQty = new Guna.UI2.WinForms.Guna2TextBox();
            SuspendLayout();
            // 
            // lblCurrentQty
            // 
            lblCurrentQty.AutoSize = true;
            lblCurrentQty.Font = new Font("Roboto Slab Medium", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCurrentQty.ForeColor = SystemColors.ActiveCaptionText;
            lblCurrentQty.Location = new Point(42, 34);
            lblCurrentQty.Name = "lblCurrentQty";
            lblCurrentQty.Size = new Size(338, 36);
            lblCurrentQty.TabIndex = 6;
            lblCurrentQty.Text = "Inventory Management";
            // 
            // btnSave
            // 
            btnSave.BorderRadius = 20;
            btnSave.CustomizableEdges = customizableEdges1;
            btnSave.DisabledState.BorderColor = Color.DarkGray;
            btnSave.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSave.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSave.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSave.FillColor = Color.FromArgb(128, 128, 255);
            btnSave.Font = new Font("Roboto Slab", 9F);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(171, 172);
            btnSave.Name = "btnSave";
            btnSave.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnSave.Size = new Size(93, 45);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.Click += btnSave_Click;
            // 
            // txtNewQty
            // 
            txtNewQty.CustomizableEdges = customizableEdges3;
            txtNewQty.DefaultText = "";
            txtNewQty.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtNewQty.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtNewQty.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtNewQty.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtNewQty.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtNewQty.Font = new Font("Segoe UI", 9F);
            txtNewQty.ForeColor = Color.Black;
            txtNewQty.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtNewQty.Location = new Point(123, 123);
            txtNewQty.Name = "txtNewQty";
            txtNewQty.PlaceholderText = "";
            txtNewQty.SelectedText = "";
            txtNewQty.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtNewQty.Size = new Size(278, 32);
            txtNewQty.TabIndex = 9;
            // 
            // frmAdjustStock
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtNewQty);
            Controls.Add(btnSave);
            Controls.Add(lblCurrentQty);
            Name = "frmAdjustStock";
            Text = "frmAdjustStock";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCurrentQty;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2TextBox txtNewQty;
    }
}