﻿namespace Y.Test.Views
{
    partial class MainForm
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
            this.ChineseCalendarForm = new System.Windows.Forms.Button();
            this.TestComputerInfoForm = new System.Windows.Forms.Button();
            this.TestUpdateForm = new System.Windows.Forms.Button();
            this.TestPackForm = new System.Windows.Forms.Button();
            this.TestIconGroupForm = new System.Windows.Forms.Button();
            this.TestShadowForm = new System.Windows.Forms.Button();
            this.TestIrrForm = new System.Windows.Forms.Button();
            this.BTCheckYUtils = new System.Windows.Forms.Button();
            this.TestCrossForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ChineseCalendarForm
            // 
            this.ChineseCalendarForm.Location = new System.Drawing.Point(12, 12);
            this.ChineseCalendarForm.Name = "ChineseCalendarForm";
            this.ChineseCalendarForm.Size = new System.Drawing.Size(262, 23);
            this.ChineseCalendarForm.TabIndex = 0;
            this.ChineseCalendarForm.Text = "ChineseCalendarForm";
            this.ChineseCalendarForm.UseVisualStyleBackColor = true;
            this.ChineseCalendarForm.Click += new System.EventHandler(this.ChineseCalendarForm_Click);
            // 
            // TestComputerInfoForm
            // 
            this.TestComputerInfoForm.Location = new System.Drawing.Point(12, 41);
            this.TestComputerInfoForm.Name = "TestComputerInfoForm";
            this.TestComputerInfoForm.Size = new System.Drawing.Size(262, 23);
            this.TestComputerInfoForm.TabIndex = 1;
            this.TestComputerInfoForm.Text = "TestComputerInfoForm";
            this.TestComputerInfoForm.UseVisualStyleBackColor = true;
            this.TestComputerInfoForm.Click += new System.EventHandler(this.TestComputerInfoForm_Click);
            // 
            // TestUpdateForm
            // 
            this.TestUpdateForm.Location = new System.Drawing.Point(12, 70);
            this.TestUpdateForm.Name = "TestUpdateForm";
            this.TestUpdateForm.Size = new System.Drawing.Size(262, 23);
            this.TestUpdateForm.TabIndex = 2;
            this.TestUpdateForm.Text = "TestUpdateForm";
            this.TestUpdateForm.UseVisualStyleBackColor = true;
            this.TestUpdateForm.Click += new System.EventHandler(this.TestUpdateForm_Click);
            // 
            // TestPackForm
            // 
            this.TestPackForm.Location = new System.Drawing.Point(12, 99);
            this.TestPackForm.Name = "TestPackForm";
            this.TestPackForm.Size = new System.Drawing.Size(262, 23);
            this.TestPackForm.TabIndex = 3;
            this.TestPackForm.Text = "TestPackForm";
            this.TestPackForm.UseVisualStyleBackColor = true;
            this.TestPackForm.Click += new System.EventHandler(this.TestPackForm_Click);
            // 
            // TestIconGroupForm
            // 
            this.TestIconGroupForm.Location = new System.Drawing.Point(12, 128);
            this.TestIconGroupForm.Name = "TestIconGroupForm";
            this.TestIconGroupForm.Size = new System.Drawing.Size(262, 23);
            this.TestIconGroupForm.TabIndex = 4;
            this.TestIconGroupForm.Text = "TestIconGroupForm";
            this.TestIconGroupForm.UseVisualStyleBackColor = true;
            this.TestIconGroupForm.Click += new System.EventHandler(this.TestIconGroupForm_Click);
            // 
            // TestShadowForm
            // 
            this.TestShadowForm.Location = new System.Drawing.Point(12, 157);
            this.TestShadowForm.Name = "TestShadowForm";
            this.TestShadowForm.Size = new System.Drawing.Size(262, 23);
            this.TestShadowForm.TabIndex = 5;
            this.TestShadowForm.Text = "TestShadowForm";
            this.TestShadowForm.UseVisualStyleBackColor = true;
            this.TestShadowForm.Click += new System.EventHandler(this.TestShadowForm_Click);
            // 
            // TestIrrForm
            // 
            this.TestIrrForm.Location = new System.Drawing.Point(12, 186);
            this.TestIrrForm.Name = "TestIrrForm";
            this.TestIrrForm.Size = new System.Drawing.Size(262, 23);
            this.TestIrrForm.TabIndex = 6;
            this.TestIrrForm.Text = "TestIrrForm";
            this.TestIrrForm.UseVisualStyleBackColor = true;
            this.TestIrrForm.Click += new System.EventHandler(this.TestIrrForm_Click);
            // 
            // BTCheckYUtils
            // 
            this.BTCheckYUtils.Location = new System.Drawing.Point(465, 12);
            this.BTCheckYUtils.Name = "BTCheckYUtils";
            this.BTCheckYUtils.Size = new System.Drawing.Size(75, 23);
            this.BTCheckYUtils.TabIndex = 7;
            this.BTCheckYUtils.Text = "检查工具类";
            this.BTCheckYUtils.UseVisualStyleBackColor = true;
            this.BTCheckYUtils.Click += new System.EventHandler(this.BTCheckYUtils_Click);
            // 
            // TestCrossForm
            // 
            this.TestCrossForm.Location = new System.Drawing.Point(13, 216);
            this.TestCrossForm.Name = "TestCrossForm";
            this.TestCrossForm.Size = new System.Drawing.Size(261, 23);
            this.TestCrossForm.TabIndex = 8;
            this.TestCrossForm.Text = "TestCrossForm";
            this.TestCrossForm.UseVisualStyleBackColor = true;
            this.TestCrossForm.Click += new System.EventHandler(this.TestCrossForm_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 427);
            this.Controls.Add(this.TestCrossForm);
            this.Controls.Add(this.BTCheckYUtils);
            this.Controls.Add(this.TestIrrForm);
            this.Controls.Add(this.TestShadowForm);
            this.Controls.Add(this.TestIconGroupForm);
            this.Controls.Add(this.TestPackForm);
            this.Controls.Add(this.TestUpdateForm);
            this.Controls.Add(this.TestComputerInfoForm);
            this.Controls.Add(this.ChineseCalendarForm);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ChineseCalendarForm;
        private System.Windows.Forms.Button TestComputerInfoForm;
        private System.Windows.Forms.Button TestUpdateForm;
        private System.Windows.Forms.Button TestPackForm;
        private System.Windows.Forms.Button TestIconGroupForm;
        private System.Windows.Forms.Button TestShadowForm;
        private System.Windows.Forms.Button TestIrrForm;
        private System.Windows.Forms.Button BTCheckYUtils;
        private System.Windows.Forms.Button TestCrossForm;
    }
}