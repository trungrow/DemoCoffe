namespace DemoCoffe
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.flayout = new System.Windows.Forms.FlowLayoutPanel();
            this.btnStatistic = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnCoffeTables = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.flayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // flayout
            // 
            this.flayout.Controls.Add(this.btnStatistic);
            this.flayout.Controls.Add(this.btnUsers);
            this.flayout.Controls.Add(this.btnCoffeTables);
            this.flayout.Controls.Add(this.btnProducts);
            this.flayout.Controls.Add(this.btnOrder);
            this.flayout.Controls.Add(this.btnLogout);
            this.flayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flayout.Location = new System.Drawing.Point(0, 0);
            this.flayout.Name = "flayout";
            this.flayout.Size = new System.Drawing.Size(272, 412);
            this.flayout.TabIndex = 3;
            // 
            // btnStatistic
            // 
            this.btnStatistic.Image = global::DemoCoffe.Properties.Resources.statistic;
            this.btnStatistic.Location = new System.Drawing.Point(3, 3);
            this.btnStatistic.Name = "btnStatistic";
            this.btnStatistic.Size = new System.Drawing.Size(130, 131);
            this.btnStatistic.TabIndex = 1;
            this.btnStatistic.UseVisualStyleBackColor = false;
            this.btnStatistic.Click += new System.EventHandler(this.btnStatistic_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.Image = global::DemoCoffe.Properties.Resources.users;
            this.btnUsers.Location = new System.Drawing.Point(139, 3);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(130, 131);
            this.btnUsers.TabIndex = 2;
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Click += new System.EventHandler(this.btnStatistic_Click);
            // 
            // btnCoffeTables
            // 
            this.btnCoffeTables.Image = global::DemoCoffe.Properties.Resources.table;
            this.btnCoffeTables.Location = new System.Drawing.Point(3, 140);
            this.btnCoffeTables.Name = "btnCoffeTables";
            this.btnCoffeTables.Size = new System.Drawing.Size(130, 131);
            this.btnCoffeTables.TabIndex = 3;
            this.btnCoffeTables.UseVisualStyleBackColor = true;
            this.btnCoffeTables.Click += new System.EventHandler(this.btnStatistic_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.Image = global::DemoCoffe.Properties.Resources.product;
            this.btnProducts.Location = new System.Drawing.Point(139, 140);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(130, 131);
            this.btnProducts.TabIndex = 5;
            this.btnProducts.UseVisualStyleBackColor = false;
            this.btnProducts.Click += new System.EventHandler(this.btnStatistic_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Image = global::DemoCoffe.Properties.Resources.order;
            this.btnOrder.Location = new System.Drawing.Point(3, 277);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(130, 131);
            this.btnOrder.TabIndex = 6;
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnStatistic_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Image = global::DemoCoffe.Properties.Resources.turnoff;
            this.btnLogout.Location = new System.Drawing.Point(139, 277);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(130, 131);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnStatistic_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(272, 412);
            this.Controls.Add(this.flayout);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Super Coffe";
            this.flayout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.FlowLayoutPanel flayout;
        private System.Windows.Forms.Button btnStatistic;
        private System.Windows.Forms.Button btnCoffeTables;
    }
}

