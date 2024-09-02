namespace Inventory_Management
{
    partial class Form2
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
            this.Name_tb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Item_id = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Desc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Rate = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.Weight = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.add_p = new System.Windows.Forms.Button();
            this.Cncl = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Rate)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(143, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADD PRODUCT DETAILS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Name_tb
            // 
            this.Name_tb.Location = new System.Drawing.Point(353, 118);
            this.Name_tb.Name = "Name_tb";
            this.Name_tb.Size = new System.Drawing.Size(183, 22);
            this.Name_tb.TabIndex = 1;
            this.Name_tb.Tag = "";
            this.Name_tb.TextChanged += new System.EventHandler(this.Name_tb_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(350, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Item_id
            // 
            this.Item_id.Location = new System.Drawing.Point(112, 118);
            this.Item_id.Name = "Item_id";
            this.Item_id.Size = new System.Drawing.Size(146, 22);
            this.Item_id.TabIndex = 3;
            this.Item_id.TextChanged += new System.EventHandler(this.Item_id_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Item ID";
            // 
            // Desc
            // 
            this.Desc.Location = new System.Drawing.Point(112, 176);
            this.Desc.Name = "Desc";
            this.Desc.Size = new System.Drawing.Size(424, 22);
            this.Desc.TabIndex = 5;
            this.Desc.TextChanged += new System.EventHandler(this.Desc_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(112, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Description";
            // 
            // Rate
            // 
            this.Rate.Location = new System.Drawing.Point(115, 245);
            this.Rate.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.Rate.Name = "Rate";
            this.Rate.Size = new System.Drawing.Size(146, 22);
            this.Rate.TabIndex = 7;
            this.Rate.ValueChanged += new System.EventHandler(this.Rate_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(112, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Rate pu.";
            // 
            // Weight
            // 
            this.Weight.Location = new System.Drawing.Point(353, 245);
            this.Weight.Name = "Weight";
            this.Weight.Size = new System.Drawing.Size(183, 22);
            this.Weight.TabIndex = 9;
            this.Weight.TextChanged += new System.EventHandler(this.Weight_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(353, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Weight";
            // 
            // add_p
            // 
            this.add_p.Location = new System.Drawing.Point(356, 312);
            this.add_p.Name = "add_p";
            this.add_p.Size = new System.Drawing.Size(113, 23);
            this.add_p.TabIndex = 11;
            this.add_p.Text = "ADD";
            this.add_p.UseVisualStyleBackColor = true;
            this.add_p.Click += new System.EventHandler(this.add_p_Click);
            // 
            // Cncl
            // 
            this.Cncl.Location = new System.Drawing.Point(158, 312);
            this.Cncl.Name = "Cncl";
            this.Cncl.Size = new System.Drawing.Size(103, 23);
            this.Cncl.TabIndex = 12;
            this.Cncl.Text = "Cancel";
            this.Cncl.UseVisualStyleBackColor = true;
            this.Cncl.Click += new System.EventHandler(this.Cncl_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(661, 437);
            this.Controls.Add(this.Cncl);
            this.Controls.Add(this.add_p);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Weight);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Rate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Desc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Item_id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Name_tb);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "New product";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Rate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Name_tb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Item_id;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Desc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown Rate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Weight;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button add_p;
        private System.Windows.Forms.Button Cncl;
    }
}