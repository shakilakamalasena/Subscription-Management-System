namespace Subscription_Management_System.Views
{
    partial class Home
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
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            cmb_plan = new ComboBox();
            txt_userCount = new TextBox();
            txt_period = new TextBox();
            btn_submit = new Button();
            groupBox1 = new GroupBox();
            txt_features = new RichTextBox();
            label8 = new Label();
            lbl_cost = new Label();
            lbl_period = new Label();
            lbl_userCount = new Label();
            lbt_plan = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(54, 61);
            label2.Name = "label2";
            label2.Size = new Size(192, 31);
            label2.TabIndex = 1;
            label2.Text = "Subscription Plan";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(54, 209);
            label1.Name = "label1";
            label1.Size = new Size(213, 31);
            label1.TabIndex = 2;
            label1.Text = "Subscription Period";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(54, 133);
            label3.Name = "label3";
            label3.Size = new Size(137, 31);
            label3.TabIndex = 3;
            label3.Text = "No. of Users";
            // 
            // cmb_plan
            // 
            cmb_plan.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmb_plan.FormattingEnabled = true;
            cmb_plan.Items.AddRange(new object[] { "Basic", "Premium", "Family" });
            cmb_plan.Location = new Point(348, 61);
            cmb_plan.Name = "cmb_plan";
            cmb_plan.Size = new Size(191, 31);
            cmb_plan.TabIndex = 4;
            cmb_plan.SelectedIndexChanged += cmb_plan_SelectedIndexChanged;
            // 
            // txt_userCount
            // 
            txt_userCount.BorderStyle = BorderStyle.FixedSingle;
            txt_userCount.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_userCount.Location = new Point(348, 136);
            txt_userCount.Name = "txt_userCount";
            txt_userCount.Size = new Size(191, 30);
            txt_userCount.TabIndex = 5;
            // 
            // txt_period
            // 
            txt_period.BorderStyle = BorderStyle.FixedSingle;
            txt_period.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_period.Location = new Point(348, 212);
            txt_period.Name = "txt_period";
            txt_period.Size = new Size(191, 30);
            txt_period.TabIndex = 6;
            // 
            // btn_submit
            // 
            btn_submit.Cursor = Cursors.Hand;
            btn_submit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_submit.Location = new Point(247, 303);
            btn_submit.Name = "btn_submit";
            btn_submit.Size = new Size(118, 55);
            btn_submit.TabIndex = 7;
            btn_submit.Text = "Submit";
            btn_submit.UseVisualStyleBackColor = true;
            btn_submit.Click += btn_submit_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txt_features);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(lbl_cost);
            groupBox1.Controls.Add(lbl_period);
            groupBox1.Controls.Add(lbl_userCount);
            groupBox1.Controls.Add(lbt_plan);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(54, 431);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(485, 332);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Selected Plan";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // txt_features
            // 
            txt_features.BackColor = SystemColors.Control;
            txt_features.BorderStyle = BorderStyle.None;
            txt_features.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_features.Location = new Point(246, 220);
            txt_features.Name = "txt_features";
            txt_features.Size = new Size(212, 87);
            txt_features.TabIndex = 16;
            txt_features.Text = "";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(29, 217);
            label8.Name = "label8";
            label8.Size = new Size(154, 25);
            label8.TabIndex = 15;
            label8.Text = "Available Features";
            // 
            // lbl_cost
            // 
            lbl_cost.AutoSize = true;
            lbl_cost.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_cost.ForeColor = Color.Red;
            lbl_cost.Location = new Point(248, 164);
            lbl_cost.Name = "lbl_cost";
            lbl_cost.Size = new Size(37, 25);
            lbl_cost.TabIndex = 14;
            lbl_cost.Text = "$ 0";
            // 
            // lbl_period
            // 
            lbl_period.AutoSize = true;
            lbl_period.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_period.ForeColor = Color.Red;
            lbl_period.Location = new Point(248, 119);
            lbl_period.Name = "lbl_period";
            lbl_period.Size = new Size(0, 25);
            lbl_period.TabIndex = 13;
            // 
            // lbl_userCount
            // 
            lbl_userCount.AutoSize = true;
            lbl_userCount.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_userCount.ForeColor = Color.Red;
            lbl_userCount.Location = new Point(248, 76);
            lbl_userCount.Name = "lbl_userCount";
            lbl_userCount.Size = new Size(0, 25);
            lbl_userCount.TabIndex = 12;
            // 
            // lbt_plan
            // 
            lbt_plan.AutoSize = true;
            lbt_plan.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbt_plan.ForeColor = Color.Red;
            lbt_plan.Location = new Point(248, 35);
            lbt_plan.Name = "lbt_plan";
            lbt_plan.Size = new Size(0, 25);
            lbt_plan.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(29, 164);
            label7.Name = "label7";
            label7.Size = new Size(96, 25);
            label7.TabIndex = 10;
            label7.Text = "Total Cost";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(29, 119);
            label6.Name = "label6";
            label6.Size = new Size(166, 25);
            label6.TabIndex = 9;
            label6.Text = "Subscription Period";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(29, 76);
            label5.Name = "label5";
            label5.Size = new Size(110, 25);
            label5.TabIndex = 9;
            label5.Text = "No. of Users";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(29, 35);
            label4.Name = "label4";
            label4.Size = new Size(149, 25);
            label4.TabIndex = 9;
            label4.Text = "Subscription Plan";
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(606, 819);
            Controls.Add(groupBox1);
            Controls.Add(btn_submit);
            Controls.Add(txt_period);
            Controls.Add(txt_userCount);
            Controls.Add(cmb_plan);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Label label3;
        private ComboBox cmb_plan;
        private TextBox txt_userCount;
        private TextBox txt_period;
        private Button btn_submit;
        private GroupBox groupBox1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label7;
        private Label lbl_cost;
        private Label lbl_period;
        private Label lbl_userCount;
        private Label lbt_plan;
        private RichTextBox txt_features;
        private Label label8;
    }
}