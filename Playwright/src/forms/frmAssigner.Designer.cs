namespace Playwright.src.forms
{
    partial class frmAssigner
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
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.boxDefine = new System.Windows.Forms.GroupBox();
            this.lbSeries = new System.Windows.Forms.Label();
            this.lbAuthor = new System.Windows.Forms.Label();
            this.tbSeriesInput = new System.Windows.Forms.TextBox();
            this.tbAuthorInput = new System.Windows.Forms.TextBox();
            this.tbNameInput = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.cbPartOf = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.boxDefine.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConfirm
            // 
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnConfirm.Location = new System.Drawing.Point(377, 286);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 0;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnClose.Location = new System.Drawing.Point(296, 286);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // boxDefine
            // 
            this.boxDefine.Controls.Add(this.label1);
            this.boxDefine.Controls.Add(this.cbPartOf);
            this.boxDefine.Controls.Add(this.lbSeries);
            this.boxDefine.Controls.Add(this.lbAuthor);
            this.boxDefine.Controls.Add(this.tbSeriesInput);
            this.boxDefine.Controls.Add(this.tbAuthorInput);
            this.boxDefine.Controls.Add(this.tbNameInput);
            this.boxDefine.Controls.Add(this.lbName);
            this.boxDefine.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.boxDefine.Location = new System.Drawing.Point(12, 12);
            this.boxDefine.Name = "boxDefine";
            this.boxDefine.Size = new System.Drawing.Size(440, 268);
            this.boxDefine.TabIndex = 2;
            this.boxDefine.TabStop = false;
            this.boxDefine.Text = "Define";
            // 
            // lbSeries
            // 
            this.lbSeries.AutoSize = true;
            this.lbSeries.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lbSeries.Location = new System.Drawing.Point(6, 84);
            this.lbSeries.Name = "lbSeries";
            this.lbSeries.Size = new System.Drawing.Size(42, 13);
            this.lbSeries.TabIndex = 5;
            this.lbSeries.Text = "[Series]";
            // 
            // lbAuthor
            // 
            this.lbAuthor.AutoSize = true;
            this.lbAuthor.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lbAuthor.Location = new System.Drawing.Point(6, 58);
            this.lbAuthor.Name = "lbAuthor";
            this.lbAuthor.Size = new System.Drawing.Size(44, 13);
            this.lbAuthor.TabIndex = 4;
            this.lbAuthor.Text = "[Author]";
            // 
            // tbSeriesInput
            // 
            this.tbSeriesInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSeriesInput.Location = new System.Drawing.Point(98, 82);
            this.tbSeriesInput.Name = "tbSeriesInput";
            this.tbSeriesInput.Size = new System.Drawing.Size(336, 20);
            this.tbSeriesInput.TabIndex = 3;
            // 
            // tbAuthorInput
            // 
            this.tbAuthorInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbAuthorInput.Location = new System.Drawing.Point(98, 56);
            this.tbAuthorInput.Name = "tbAuthorInput";
            this.tbAuthorInput.Size = new System.Drawing.Size(336, 20);
            this.tbAuthorInput.TabIndex = 2;
            // 
            // tbNameInput
            // 
            this.tbNameInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNameInput.Location = new System.Drawing.Point(98, 30);
            this.tbNameInput.Name = "tbNameInput";
            this.tbNameInput.Size = new System.Drawing.Size(336, 20);
            this.tbNameInput.TabIndex = 1;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lbName.Location = new System.Drawing.Point(6, 33);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(41, 13);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "[Name]";
            // 
            // cbPartOf
            // 
            this.cbPartOf.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbPartOf.FormattingEnabled = true;
            this.cbPartOf.Location = new System.Drawing.Point(98, 108);
            this.cbPartOf.Name = "cbPartOf";
            this.cbPartOf.Size = new System.Drawing.Size(336, 21);
            this.cbPartOf.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Location = new System.Drawing.Point(6, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "[Part Of]";
            // 
            // frmAssigner
            // 
            this.AcceptButton = this.btnConfirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(464, 321);
            this.Controls.Add(this.boxDefine);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnConfirm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAssigner";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmAssigner_Load);
            this.boxDefine.ResumeLayout(false);
            this.boxDefine.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox boxDefine;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox tbNameInput;
        private System.Windows.Forms.TextBox tbSeriesInput;
        private System.Windows.Forms.TextBox tbAuthorInput;
        private System.Windows.Forms.Label lbAuthor;
        private System.Windows.Forms.Label lbSeries;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbPartOf;
    }
}