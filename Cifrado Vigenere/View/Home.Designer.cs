﻿namespace Cifrado_Vigenere
{
    partial class formHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formHome));
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpBxCipher = new System.Windows.Forms.GroupBox();
            this.txtBxKey = new System.Windows.Forms.TextBox();
            this.lblKey = new System.Windows.Forms.Label();
            this.btnShowHide = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.radBtnDiscipher = new System.Windows.Forms.RadioButton();
            this.radBtnCipher = new System.Windows.Forms.RadioButton();
            this.cmbBxOptions = new System.Windows.Forms.ComboBox();
            this.lblOptions = new System.Windows.Forms.Label();
            this.cmbBxAbc = new System.Windows.Forms.ComboBox();
            this.lblAbc = new System.Windows.Forms.Label();
            this.toolStripCont = new System.Windows.Forms.ToolStripContainer();
            this.stStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStLblAuthor = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStLblInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContInfo = new System.Windows.Forms.SplitContainer();
            this.richTxtBxAbc = new System.Windows.Forms.RichTextBox();
            this.splitContCesar = new System.Windows.Forms.SplitContainer();
            this.richTxtBxSource = new System.Windows.Forms.RichTextBox();
            this.richTxtBxResult = new System.Windows.Forms.RichTextBox();
            this.grpBxCipher.SuspendLayout();
            this.toolStripCont.BottomToolStripPanel.SuspendLayout();
            this.toolStripCont.ContentPanel.SuspendLayout();
            this.toolStripCont.SuspendLayout();
            this.stStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContInfo)).BeginInit();
            this.splitContInfo.Panel1.SuspendLayout();
            this.splitContInfo.Panel2.SuspendLayout();
            this.splitContInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContCesar)).BeginInit();
            this.splitContCesar.Panel1.SuspendLayout();
            this.splitContCesar.Panel2.SuspendLayout();
            this.splitContCesar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1132, 70);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "CIFRADO VIGENERE";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpBxCipher
            // 
            this.grpBxCipher.Controls.Add(this.txtBxKey);
            this.grpBxCipher.Controls.Add(this.lblKey);
            this.grpBxCipher.Controls.Add(this.btnShowHide);
            this.grpBxCipher.Controls.Add(this.btnCalculate);
            this.grpBxCipher.Controls.Add(this.radBtnDiscipher);
            this.grpBxCipher.Controls.Add(this.radBtnCipher);
            this.grpBxCipher.Controls.Add(this.cmbBxOptions);
            this.grpBxCipher.Controls.Add(this.lblOptions);
            this.grpBxCipher.Controls.Add(this.cmbBxAbc);
            this.grpBxCipher.Controls.Add(this.lblAbc);
            this.grpBxCipher.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpBxCipher.Location = new System.Drawing.Point(0, 70);
            this.grpBxCipher.Margin = new System.Windows.Forms.Padding(0);
            this.grpBxCipher.Name = "grpBxCipher";
            this.grpBxCipher.Size = new System.Drawing.Size(1132, 100);
            this.grpBxCipher.TabIndex = 1;
            this.grpBxCipher.TabStop = false;
            this.grpBxCipher.Text = "Cifrado";
            // 
            // txtBxKey
            // 
            this.txtBxKey.Location = new System.Drawing.Point(511, 65);
            this.txtBxKey.Name = "txtBxKey";
            this.txtBxKey.Size = new System.Drawing.Size(194, 22);
            this.txtBxKey.TabIndex = 9;
            this.txtBxKey.TextChanged += new System.EventHandler(this.TxtBx_TextChanged);
            this.txtBxKey.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBx_KeyPress);
            // 
            // lblKey
            // 
            this.lblKey.AutoSize = true;
            this.lblKey.Location = new System.Drawing.Point(508, 45);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(46, 17);
            this.lblKey.TabIndex = 8;
            this.lblKey.Text = "Llave:";
            // 
            // btnShowHide
            // 
            this.btnShowHide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowHide.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowHide.Location = new System.Drawing.Point(990, 29);
            this.btnShowHide.Name = "btnShowHide";
            this.btnShowHide.Size = new System.Drawing.Size(120, 45);
            this.btnShowHide.TabIndex = 7;
            this.btnShowHide.Text = "OCULTAR";
            this.btnShowHide.UseVisualStyleBackColor = true;
            this.btnShowHide.Click += new System.EventHandler(this.BtnShowHide_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCalculate.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(809, 29);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(130, 45);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "CALCULAR";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // radBtnDiscipher
            // 
            this.radBtnDiscipher.AutoSize = true;
            this.radBtnDiscipher.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radBtnDiscipher.Location = new System.Drawing.Point(348, 62);
            this.radBtnDiscipher.Name = "radBtnDiscipher";
            this.radBtnDiscipher.Size = new System.Drawing.Size(103, 27);
            this.radBtnDiscipher.TabIndex = 5;
            this.radBtnDiscipher.TabStop = true;
            this.radBtnDiscipher.Text = "Descifrar";
            this.radBtnDiscipher.UseVisualStyleBackColor = true;
            // 
            // radBtnCipher
            // 
            this.radBtnCipher.AutoSize = true;
            this.radBtnCipher.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radBtnCipher.Location = new System.Drawing.Point(348, 25);
            this.radBtnCipher.Name = "radBtnCipher";
            this.radBtnCipher.Size = new System.Drawing.Size(74, 27);
            this.radBtnCipher.TabIndex = 4;
            this.radBtnCipher.TabStop = true;
            this.radBtnCipher.Text = "Cifrar";
            this.radBtnCipher.UseVisualStyleBackColor = true;
            // 
            // cmbBxOptions
            // 
            this.cmbBxOptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBxOptions.FormattingEnabled = true;
            this.cmbBxOptions.Items.AddRange(new object[] {
            "Minusculas",
            "Mayusculas",
            "Ambas"});
            this.cmbBxOptions.Location = new System.Drawing.Point(117, 62);
            this.cmbBxOptions.Name = "cmbBxOptions";
            this.cmbBxOptions.Size = new System.Drawing.Size(140, 24);
            this.cmbBxOptions.TabIndex = 3;
            this.cmbBxOptions.SelectedIndexChanged += new System.EventHandler(this.CmbBxOptions_SelectedIndexChanged);
            // 
            // lblOptions
            // 
            this.lblOptions.AutoSize = true;
            this.lblOptions.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOptions.Location = new System.Drawing.Point(15, 65);
            this.lblOptions.Name = "lblOptions";
            this.lblOptions.Size = new System.Drawing.Size(74, 19);
            this.lblOptions.TabIndex = 2;
            this.lblOptions.Text = "Opciones:";
            // 
            // cmbBxAbc
            // 
            this.cmbBxAbc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBxAbc.FormattingEnabled = true;
            this.cmbBxAbc.Items.AddRange(new object[] {
            "Español",
            "Ingles"});
            this.cmbBxAbc.Location = new System.Drawing.Point(117, 26);
            this.cmbBxAbc.Name = "cmbBxAbc";
            this.cmbBxAbc.Size = new System.Drawing.Size(140, 24);
            this.cmbBxAbc.TabIndex = 1;
            this.cmbBxAbc.SelectedIndexChanged += new System.EventHandler(this.CmbBxAbc_SelectedIndexChanged);
            // 
            // lblAbc
            // 
            this.lblAbc.AutoSize = true;
            this.lblAbc.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbc.Location = new System.Drawing.Point(15, 29);
            this.lblAbc.Name = "lblAbc";
            this.lblAbc.Size = new System.Drawing.Size(89, 19);
            this.lblAbc.TabIndex = 0;
            this.lblAbc.Text = "Abecedario:";
            // 
            // toolStripCont
            // 
            // 
            // toolStripCont.BottomToolStripPanel
            // 
            this.toolStripCont.BottomToolStripPanel.Controls.Add(this.stStrip);
            // 
            // toolStripCont.ContentPanel
            // 
            this.toolStripCont.ContentPanel.Controls.Add(this.splitContInfo);
            this.toolStripCont.ContentPanel.Size = new System.Drawing.Size(1132, 484);
            this.toolStripCont.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripCont.Location = new System.Drawing.Point(0, 170);
            this.toolStripCont.Name = "toolStripCont";
            this.toolStripCont.Size = new System.Drawing.Size(1132, 513);
            this.toolStripCont.TabIndex = 2;
            this.toolStripCont.Text = "toolStripContainer1";
            // 
            // stStrip
            // 
            this.stStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.stStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.stStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStLblAuthor,
            this.toolStripStLblInfo});
            this.stStrip.Location = new System.Drawing.Point(0, 0);
            this.stStrip.Name = "stStrip";
            this.stStrip.Size = new System.Drawing.Size(1132, 29);
            this.stStrip.TabIndex = 0;
            // 
            // toolStripStLblAuthor
            // 
            this.toolStripStLblAuthor.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStLblAuthor.Name = "toolStripStLblAuthor";
            this.toolStripStLblAuthor.Size = new System.Drawing.Size(53, 23);
            this.toolStripStLblAuthor.Text = "Autor";
            this.toolStripStLblAuthor.Click += new System.EventHandler(this.ToolStripStLblAuthor_Click);
            // 
            // toolStripStLblInfo
            // 
            this.toolStripStLblInfo.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStLblInfo.Name = "toolStripStLblInfo";
            this.toolStripStLblInfo.Size = new System.Drawing.Size(1064, 23);
            this.toolStripStLblInfo.Spring = true;
            this.toolStripStLblInfo.Text = "Total Caracteres";
            this.toolStripStLblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // splitContInfo
            // 
            this.splitContInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContInfo.Location = new System.Drawing.Point(0, 0);
            this.splitContInfo.Name = "splitContInfo";
            this.splitContInfo.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContInfo.Panel1
            // 
            this.splitContInfo.Panel1.Controls.Add(this.richTxtBxAbc);
            this.splitContInfo.Panel1MinSize = 45;
            // 
            // splitContInfo.Panel2
            // 
            this.splitContInfo.Panel2.Controls.Add(this.splitContCesar);
            this.splitContInfo.Panel2MinSize = 340;
            this.splitContInfo.Size = new System.Drawing.Size(1132, 484);
            this.splitContInfo.SplitterDistance = 120;
            this.splitContInfo.TabIndex = 0;
            // 
            // richTxtBxAbc
            // 
            this.richTxtBxAbc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTxtBxAbc.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTxtBxAbc.Location = new System.Drawing.Point(0, 0);
            this.richTxtBxAbc.Name = "richTxtBxAbc";
            this.richTxtBxAbc.ReadOnly = true;
            this.richTxtBxAbc.Size = new System.Drawing.Size(1132, 120);
            this.richTxtBxAbc.TabIndex = 0;
            this.richTxtBxAbc.Text = "";
            // 
            // splitContCesar
            // 
            this.splitContCesar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContCesar.Location = new System.Drawing.Point(0, 0);
            this.splitContCesar.Name = "splitContCesar";
            // 
            // splitContCesar.Panel1
            // 
            this.splitContCesar.Panel1.Controls.Add(this.richTxtBxSource);
            this.splitContCesar.Panel1MinSize = 400;
            // 
            // splitContCesar.Panel2
            // 
            this.splitContCesar.Panel2.Controls.Add(this.richTxtBxResult);
            this.splitContCesar.Panel2MinSize = 400;
            this.splitContCesar.Size = new System.Drawing.Size(1132, 360);
            this.splitContCesar.SplitterDistance = 553;
            this.splitContCesar.TabIndex = 0;
            // 
            // richTxtBxSource
            // 
            this.richTxtBxSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTxtBxSource.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTxtBxSource.Location = new System.Drawing.Point(0, 0);
            this.richTxtBxSource.Multiline = false;
            this.richTxtBxSource.Name = "richTxtBxSource";
            this.richTxtBxSource.Size = new System.Drawing.Size(553, 360);
            this.richTxtBxSource.TabIndex = 0;
            this.richTxtBxSource.Text = "";
            this.richTxtBxSource.TextChanged += new System.EventHandler(this.TxtBx_TextChanged);
            this.richTxtBxSource.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBx_KeyPress);
            // 
            // richTxtBxResult
            // 
            this.richTxtBxResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTxtBxResult.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTxtBxResult.Location = new System.Drawing.Point(0, 0);
            this.richTxtBxResult.Name = "richTxtBxResult";
            this.richTxtBxResult.ReadOnly = true;
            this.richTxtBxResult.Size = new System.Drawing.Size(575, 360);
            this.richTxtBxResult.TabIndex = 0;
            this.richTxtBxResult.Text = "";
            // 
            // formHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 683);
            this.Controls.Add(this.toolStripCont);
            this.Controls.Add(this.grpBxCipher);
            this.Controls.Add(this.lblTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1150, 730);
            this.Name = "formHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.FormHome_Load);
            this.grpBxCipher.ResumeLayout(false);
            this.grpBxCipher.PerformLayout();
            this.toolStripCont.BottomToolStripPanel.ResumeLayout(false);
            this.toolStripCont.BottomToolStripPanel.PerformLayout();
            this.toolStripCont.ContentPanel.ResumeLayout(false);
            this.toolStripCont.ResumeLayout(false);
            this.toolStripCont.PerformLayout();
            this.stStrip.ResumeLayout(false);
            this.stStrip.PerformLayout();
            this.splitContInfo.Panel1.ResumeLayout(false);
            this.splitContInfo.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContInfo)).EndInit();
            this.splitContInfo.ResumeLayout(false);
            this.splitContCesar.Panel1.ResumeLayout(false);
            this.splitContCesar.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContCesar)).EndInit();
            this.splitContCesar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpBxCipher;
        private System.Windows.Forms.ToolStripContainer toolStripCont;
        private System.Windows.Forms.StatusStrip stStrip;
        private System.Windows.Forms.Button btnShowHide;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.RadioButton radBtnDiscipher;
        private System.Windows.Forms.RadioButton radBtnCipher;
        private System.Windows.Forms.ComboBox cmbBxOptions;
        private System.Windows.Forms.Label lblOptions;
        private System.Windows.Forms.ComboBox cmbBxAbc;
        private System.Windows.Forms.Label lblAbc;
        private System.Windows.Forms.SplitContainer splitContInfo;
        private System.Windows.Forms.RichTextBox richTxtBxAbc;
        private System.Windows.Forms.SplitContainer splitContCesar;
        private System.Windows.Forms.RichTextBox richTxtBxSource;
        private System.Windows.Forms.RichTextBox richTxtBxResult;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStLblInfo;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStLblAuthor;
        private System.Windows.Forms.TextBox txtBxKey;
        private System.Windows.Forms.Label lblKey;
    }
}

