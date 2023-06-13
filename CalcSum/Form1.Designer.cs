namespace CalcSum
{
    partial class Form1
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
            this.lb_base = new System.Windows.Forms.Label();
            this.tb_baseCost = new System.Windows.Forms.TextBox();
            this.lb_curLevel = new System.Windows.Forms.Label();
            this.tb_curLvl = new System.Windows.Forms.TextBox();
            this.lb_resource = new System.Windows.Forms.Label();
            this.tb_resource = new System.Windows.Forms.TextBox();
            this.lb_total = new System.Windows.Forms.Label();
            this.tb_total = new System.Windows.Forms.TextBox();
            this.btn_calc = new System.Windows.Forms.Button();
            this.lb_maxLvl = new System.Windows.Forms.Label();
            this.tb_maxLvl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_X = new System.Windows.Forms.TextBox();
            this.btn_calc1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_base
            // 
            this.lb_base.AutoSize = true;
            this.lb_base.Location = new System.Drawing.Point(41, 22);
            this.lb_base.Name = "lb_base";
            this.lb_base.Size = new System.Drawing.Size(51, 13);
            this.lb_base.TabIndex = 0;
            this.lb_base.Text = "baseCost";
            // 
            // tb_baseCost
            // 
            this.tb_baseCost.Location = new System.Drawing.Point(98, 19);
            this.tb_baseCost.Name = "tb_baseCost";
            this.tb_baseCost.Size = new System.Drawing.Size(130, 20);
            this.tb_baseCost.TabIndex = 1;
            this.tb_baseCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lb_curLevel
            // 
            this.lb_curLevel.AutoSize = true;
            this.lb_curLevel.Location = new System.Drawing.Point(41, 56);
            this.lb_curLevel.Name = "lb_curLevel";
            this.lb_curLevel.Size = new System.Drawing.Size(48, 13);
            this.lb_curLevel.TabIndex = 0;
            this.lb_curLevel.Text = "curLevel";
            // 
            // tb_curLvl
            // 
            this.tb_curLvl.Location = new System.Drawing.Point(98, 53);
            this.tb_curLvl.Name = "tb_curLvl";
            this.tb_curLvl.Size = new System.Drawing.Size(130, 20);
            this.tb_curLvl.TabIndex = 1;
            this.tb_curLvl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lb_resource
            // 
            this.lb_resource.AutoSize = true;
            this.lb_resource.Location = new System.Drawing.Point(41, 91);
            this.lb_resource.Name = "lb_resource";
            this.lb_resource.Size = new System.Drawing.Size(48, 13);
            this.lb_resource.TabIndex = 0;
            this.lb_resource.Text = "resource";
            // 
            // tb_resource
            // 
            this.tb_resource.Location = new System.Drawing.Point(98, 88);
            this.tb_resource.Name = "tb_resource";
            this.tb_resource.Size = new System.Drawing.Size(130, 20);
            this.tb_resource.TabIndex = 1;
            this.tb_resource.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lb_total
            // 
            this.lb_total.AutoSize = true;
            this.lb_total.Location = new System.Drawing.Point(41, 191);
            this.lb_total.Name = "lb_total";
            this.lb_total.Size = new System.Drawing.Size(52, 13);
            this.lb_total.TabIndex = 0;
            this.lb_total.Text = "TotalCost";
            // 
            // tb_total
            // 
            this.tb_total.Location = new System.Drawing.Point(98, 188);
            this.tb_total.Name = "tb_total";
            this.tb_total.Size = new System.Drawing.Size(130, 20);
            this.tb_total.TabIndex = 1;
            this.tb_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_calc
            // 
            this.btn_calc.Location = new System.Drawing.Point(75, 233);
            this.btn_calc.Name = "btn_calc";
            this.btn_calc.Size = new System.Drawing.Size(140, 25);
            this.btn_calc.TabIndex = 2;
            this.btn_calc.Text = "Sum";
            this.btn_calc.UseVisualStyleBackColor = true;
            this.btn_calc.Click += new System.EventHandler(this.btn_calc_Click);
            // 
            // lb_maxLvl
            // 
            this.lb_maxLvl.AutoSize = true;
            this.lb_maxLvl.Location = new System.Drawing.Point(41, 156);
            this.lb_maxLvl.Name = "lb_maxLvl";
            this.lb_maxLvl.Size = new System.Drawing.Size(53, 13);
            this.lb_maxLvl.TabIndex = 0;
            this.lb_maxLvl.Text = "MaxLevel";
            // 
            // tb_maxLvl
            // 
            this.tb_maxLvl.Location = new System.Drawing.Point(98, 153);
            this.tb_maxLvl.Name = "tb_maxLvl";
            this.tb_maxLvl.Size = new System.Drawing.Size(130, 20);
            this.tb_maxLvl.TabIndex = 1;
            this.tb_maxLvl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "X";
            // 
            // tb_X
            // 
            this.tb_X.Location = new System.Drawing.Point(98, 120);
            this.tb_X.Name = "tb_X";
            this.tb_X.Size = new System.Drawing.Size(130, 20);
            this.tb_X.TabIndex = 1;
            this.tb_X.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_calc1
            // 
            this.btn_calc1.Location = new System.Drawing.Point(77, 273);
            this.btn_calc1.Name = "btn_calc1";
            this.btn_calc1.Size = new System.Drawing.Size(140, 25);
            this.btn_calc1.TabIndex = 3;
            this.btn_calc1.Text = "Sum(Loop fn)";
            this.btn_calc1.UseVisualStyleBackColor = true;
            this.btn_calc1.Click += new System.EventHandler(this.btn_calc1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 321);
            this.Controls.Add(this.btn_calc1);
            this.Controls.Add(this.btn_calc);
            this.Controls.Add(this.tb_total);
            this.Controls.Add(this.lb_total);
            this.Controls.Add(this.tb_maxLvl);
            this.Controls.Add(this.lb_maxLvl);
            this.Controls.Add(this.tb_X);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_resource);
            this.Controls.Add(this.lb_resource);
            this.Controls.Add(this.tb_curLvl);
            this.Controls.Add(this.lb_curLevel);
            this.Controls.Add(this.tb_baseCost);
            this.Controls.Add(this.lb_base);
            this.Name = "Form1";
            this.Text = "CalcSum";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_base;
        private System.Windows.Forms.TextBox tb_baseCost;
        private System.Windows.Forms.Label lb_curLevel;
        private System.Windows.Forms.TextBox tb_curLvl;
        private System.Windows.Forms.Label lb_resource;
        private System.Windows.Forms.TextBox tb_resource;
        private System.Windows.Forms.Label lb_total;
        private System.Windows.Forms.TextBox tb_total;
        private System.Windows.Forms.Button btn_calc;
        private System.Windows.Forms.Label lb_maxLvl;
        private System.Windows.Forms.TextBox tb_maxLvl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_X;
        private System.Windows.Forms.Button btn_calc1;
    }
}

