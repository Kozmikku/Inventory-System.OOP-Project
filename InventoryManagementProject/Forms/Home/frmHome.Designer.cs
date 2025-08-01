namespace InventoryManagementProject.Forms.Home
{
    partial class frmHome
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
            form = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            panel7 = new Panel();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // form
            // 
            form.AnimateWindow = true;
            form.ContainerControl = this;
            form.DockIndicatorTransparencyValue = 0.6D;
            form.TransparentWhileDrag = true;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1036, 80);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Roboto Slab Medium", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(20, 20);
            label1.Name = "label1";
            label1.Size = new Size(149, 36);
            label1.TabIndex = 5;
            label1.Text = "Welcome,";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Control;
            panel2.Controls.Add(panel7);
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel4);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 80);
            panel2.Name = "panel2";
            panel2.Size = new Size(1036, 186);
            panel2.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Controls.Add(dataGridView1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 266);
            panel3.Name = "panel3";
            panel3.Size = new Size(1036, 360);
            panel3.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.Controls.Add(label2);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(241, 186);
            panel4.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.Controls.Add(label3);
            panel5.Dock = DockStyle.Left;
            panel5.Location = new Point(241, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(237, 186);
            panel5.TabIndex = 1;
            // 
            // panel6
            // 
            panel6.Controls.Add(label4);
            panel6.Dock = DockStyle.Left;
            panel6.Location = new Point(478, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(309, 186);
            panel6.TabIndex = 2;
            // 
            // panel7
            // 
            panel7.Controls.Add(label5);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(787, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(249, 186);
            panel7.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Roboto Slab Medium", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(21, 19);
            label2.Name = "label2";
            label2.Size = new Size(217, 36);
            label2.TabIndex = 6;
            label2.Text = "Total Products";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Roboto Slab Medium", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(6, 19);
            label3.Name = "label3";
            label3.Size = new Size(226, 36);
            label3.TabIndex = 7;
            label3.Text = "Total Suppliers";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Roboto Slab Medium", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(6, 19);
            label4.Name = "label4";
            label4.Size = new Size(275, 36);
            label4.TabIndex = 8;
            label4.Text = "Total Transactions";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Roboto Slab Medium", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(19, 19);
            label5.Name = "label5";
            label5.Size = new Size(167, 36);
            label5.TabIndex = 9;
            label5.Text = "Total Sales";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1036, 360);
            dataGridView1.TabIndex = 0;
            // 
            // frmHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1036, 626);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmHome";
            Text = "frmHome";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm form;
        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel7;
        private Label label5;
        private Panel panel6;
        private Label label4;
        private Panel panel5;
        private Label label3;
        private Panel panel4;
        private Label label2;
        private DataGridView dataGridView1;
    }
}