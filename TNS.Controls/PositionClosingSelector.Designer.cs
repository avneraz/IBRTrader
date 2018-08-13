namespace TNS.Controls
{
    partial class PositionClosingSelector
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
            this.components = new System.ComponentModel.Container();
            this.lblHeader = new System.Windows.Forms.Label();
            this.grpUNLSummary = new System.Windows.Forms.GroupBox();
            this.lblTotalDeltaLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSingleCount = new System.Windows.Forms.Label();
            this.marginDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblMateCoupleCount = new System.Windows.Forms.Label();
            this.lblTotalDelta = new System.Windows.Forms.Label();
            this.unlTradingDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblMarginPerCouple = new System.Windows.Forms.Label();
            this.lblMargin = new System.Windows.Forms.Label();
            this.lblSingleType = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCouplesToCloseLabel = new System.Windows.Forms.Label();
            this.lblMarginGain = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSubmitCloseCouples = new System.Windows.Forms.Button();
            this.gbxCloseCouples = new System.Windows.Forms.GroupBox();
            this.numCouplesToClose = new System.Windows.Forms.NumericUpDown();
            this.btnCloseAllPositions = new System.Windows.Forms.Button();
            this.comBoxExpiries = new System.Windows.Forms.ComboBox();
            this.lblComboBoxLabel = new System.Windows.Forms.Label();
            this.grpUNLSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.marginDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unlTradingDataBindingSource)).BeginInit();
            this.gbxCloseCouples.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCouplesToClose)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(251)))));
            this.lblHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHeader.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.Blue;
            this.lblHeader.Location = new System.Drawing.Point(0, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(900, 28);
            this.lblHeader.TabIndex = 2;
            this.lblHeader.Text = "AMZN - 971.25 Margin = 112,205";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpUNLSummary
            // 
            this.grpUNLSummary.Controls.Add(this.lblTotalDeltaLabel);
            this.grpUNLSummary.Controls.Add(this.label6);
            this.grpUNLSummary.Controls.Add(this.label4);
            this.grpUNLSummary.Controls.Add(this.label2);
            this.grpUNLSummary.Controls.Add(this.lblSingleCount);
            this.grpUNLSummary.Controls.Add(this.lblMateCoupleCount);
            this.grpUNLSummary.Controls.Add(this.lblTotalDelta);
            this.grpUNLSummary.Controls.Add(this.lblMarginPerCouple);
            this.grpUNLSummary.Controls.Add(this.lblMargin);
            this.grpUNLSummary.Controls.Add(this.lblSingleType);
            this.grpUNLSummary.Controls.Add(this.label3);
            this.grpUNLSummary.Controls.Add(this.label5);
            this.grpUNLSummary.Dock = System.Windows.Forms.DockStyle.Left;
            this.grpUNLSummary.Location = new System.Drawing.Point(0, 28);
            this.grpUNLSummary.Name = "grpUNLSummary";
            this.grpUNLSummary.Size = new System.Drawing.Size(226, 300);
            this.grpUNLSummary.TabIndex = 5;
            this.grpUNLSummary.TabStop = false;
            this.grpUNLSummary.Text = "UNL Summary";
            // 
            // lblTotalDeltaLabel
            // 
            this.lblTotalDeltaLabel.AutoSize = true;
            this.lblTotalDeltaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDeltaLabel.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTotalDeltaLabel.Location = new System.Drawing.Point(6, 136);
            this.lblTotalDeltaLabel.Name = "lblTotalDeltaLabel";
            this.lblTotalDeltaLabel.Size = new System.Drawing.Size(31, 15);
            this.lblTotalDeltaLabel.TabIndex = 3;
            this.lblTotalDeltaLabel.Text = "Σ δ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Green;
            this.label6.Location = new System.Drawing.Point(6, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "Margin Per Couple:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(6, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Single Type:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(6, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mate Couple #:";
            // 
            // lblSingleCount
            // 
            this.lblSingleCount.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblSingleCount.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.marginDataBindingSource, "SingleCount", true));
            this.lblSingleCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSingleCount.ForeColor = System.Drawing.Color.Green;
            this.lblSingleCount.Location = new System.Drawing.Point(150, 60);
            this.lblSingleCount.Name = "lblSingleCount";
            this.lblSingleCount.Size = new System.Drawing.Size(70, 15);
            this.lblSingleCount.TabIndex = 3;
            this.lblSingleCount.Text = "1";
            this.lblSingleCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // marginDataBindingSource
            // 
            this.marginDataBindingSource.DataSource = typeof(TNS.API.ApiDataObjects.MarginData);
            // 
            // lblMateCoupleCount
            // 
            this.lblMateCoupleCount.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblMateCoupleCount.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.marginDataBindingSource, "MateCouplesCount", true));
            this.lblMateCoupleCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMateCoupleCount.ForeColor = System.Drawing.Color.Green;
            this.lblMateCoupleCount.Location = new System.Drawing.Point(150, 41);
            this.lblMateCoupleCount.Name = "lblMateCoupleCount";
            this.lblMateCoupleCount.Size = new System.Drawing.Size(70, 15);
            this.lblMateCoupleCount.TabIndex = 3;
            this.lblMateCoupleCount.Text = "15";
            this.lblMateCoupleCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalDelta
            // 
            this.lblTotalDelta.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblTotalDelta.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.unlTradingDataBindingSource, "DeltaTotal", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0", "N0"));
            this.lblTotalDelta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDelta.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTotalDelta.Location = new System.Drawing.Point(150, 136);
            this.lblTotalDelta.Name = "lblTotalDelta";
            this.lblTotalDelta.Size = new System.Drawing.Size(70, 15);
            this.lblTotalDelta.TabIndex = 3;
            this.lblTotalDelta.Text = "-25";
            this.lblTotalDelta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // unlTradingDataBindingSource
            // 
            this.unlTradingDataBindingSource.DataSource = typeof(TNS.API.ApiDataObjects.UnlTradingData);
            // 
            // lblMarginPerCouple
            // 
            this.lblMarginPerCouple.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblMarginPerCouple.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.marginDataBindingSource, "MarginPerCouple", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N0"));
            this.lblMarginPerCouple.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarginPerCouple.ForeColor = System.Drawing.Color.Green;
            this.lblMarginPerCouple.Location = new System.Drawing.Point(150, 102);
            this.lblMarginPerCouple.Name = "lblMarginPerCouple";
            this.lblMarginPerCouple.Size = new System.Drawing.Size(70, 15);
            this.lblMarginPerCouple.TabIndex = 3;
            this.lblMarginPerCouple.Text = "35,140";
            this.lblMarginPerCouple.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMargin
            // 
            this.lblMargin.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblMargin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.unlTradingDataBindingSource, "Margin", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0", "C0"));
            this.lblMargin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMargin.ForeColor = System.Drawing.Color.Green;
            this.lblMargin.Location = new System.Drawing.Point(150, 19);
            this.lblMargin.Name = "lblMargin";
            this.lblMargin.Size = new System.Drawing.Size(70, 15);
            this.lblMargin.TabIndex = 3;
            this.lblMargin.Text = "112,205";
            this.lblMargin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSingleType
            // 
            this.lblSingleType.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblSingleType.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.marginDataBindingSource, "SingleOptionType", true));
            this.lblSingleType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSingleType.ForeColor = System.Drawing.Color.Green;
            this.lblSingleType.Location = new System.Drawing.Point(150, 81);
            this.lblSingleType.Name = "lblSingleType";
            this.lblSingleType.Size = new System.Drawing.Size(70, 15);
            this.lblSingleType.TabIndex = 3;
            this.lblSingleType.Text = "Call";
            this.lblSingleType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(6, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Single #:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Green;
            this.label5.Location = new System.Drawing.Point(6, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Margin:";
            // 
            // lblCouplesToCloseLabel
            // 
            this.lblCouplesToCloseLabel.AutoSize = true;
            this.lblCouplesToCloseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCouplesToCloseLabel.ForeColor = System.Drawing.Color.Red;
            this.lblCouplesToCloseLabel.Location = new System.Drawing.Point(12, 28);
            this.lblCouplesToCloseLabel.Name = "lblCouplesToCloseLabel";
            this.lblCouplesToCloseLabel.Size = new System.Drawing.Size(119, 15);
            this.lblCouplesToCloseLabel.TabIndex = 3;
            this.lblCouplesToCloseLabel.Text = "Couples to Close:";
            // 
            // lblMarginGain
            // 
            this.lblMarginGain.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblMarginGain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarginGain.ForeColor = System.Drawing.Color.Red;
            this.lblMarginGain.Location = new System.Drawing.Point(224, 81);
            this.lblMarginGain.Name = "lblMarginGain";
            this.lblMarginGain.Size = new System.Drawing.Size(61, 18);
            this.lblMarginGain.TabIndex = 3;
            this.lblMarginGain.Text = "50,000";
            this.lblMarginGain.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(132, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 15);
            this.label9.TabIndex = 3;
            this.label9.Text = "Margin Gain";
            // 
            // btnSubmitCloseCouples
            // 
            this.btnSubmitCloseCouples.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSubmitCloseCouples.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSubmitCloseCouples.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnSubmitCloseCouples.ForeColor = System.Drawing.Color.White;
            this.btnSubmitCloseCouples.Location = new System.Drawing.Point(474, 83);
            this.btnSubmitCloseCouples.Name = "btnSubmitCloseCouples";
            this.btnSubmitCloseCouples.Size = new System.Drawing.Size(148, 23);
            this.btnSubmitCloseCouples.TabIndex = 6;
            this.btnSubmitCloseCouples.Text = "Submit";
            this.btnSubmitCloseCouples.UseVisualStyleBackColor = false;
            this.btnSubmitCloseCouples.Click += new System.EventHandler(this.btnSubmitCloseCouples_Click);
            // 
            // gbxCloseCouples
            // 
            this.gbxCloseCouples.Controls.Add(this.lblComboBoxLabel);
            this.gbxCloseCouples.Controls.Add(this.numCouplesToClose);
            this.gbxCloseCouples.Controls.Add(this.comBoxExpiries);
            this.gbxCloseCouples.Controls.Add(this.btnSubmitCloseCouples);
            this.gbxCloseCouples.Controls.Add(this.label9);
            this.gbxCloseCouples.Controls.Add(this.lblCouplesToCloseLabel);
            this.gbxCloseCouples.Controls.Add(this.lblMarginGain);
            this.gbxCloseCouples.Font = new System.Drawing.Font("Tahoma", 11F);
            this.gbxCloseCouples.ForeColor = System.Drawing.Color.Navy;
            this.gbxCloseCouples.Location = new System.Drawing.Point(232, 37);
            this.gbxCloseCouples.Name = "gbxCloseCouples";
            this.gbxCloseCouples.Size = new System.Drawing.Size(642, 122);
            this.gbxCloseCouples.TabIndex = 9;
            this.gbxCloseCouples.TabStop = false;
            this.gbxCloseCouples.Text = "Close Couples";
            // 
            // numCouplesToClose
            // 
            this.numCouplesToClose.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.numCouplesToClose.Location = new System.Drawing.Point(137, 23);
            this.numCouplesToClose.Name = "numCouplesToClose";
            this.numCouplesToClose.Size = new System.Drawing.Size(53, 25);
            this.numCouplesToClose.TabIndex = 10;
            this.numCouplesToClose.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCouplesToClose.ValueChanged += new System.EventHandler(this.numCouplesToClose_ValueChanged);
            // 
            // btnCloseAllPositions
            // 
            this.btnCloseAllPositions.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnCloseAllPositions.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCloseAllPositions.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnCloseAllPositions.ForeColor = System.Drawing.Color.White;
            this.btnCloseAllPositions.Location = new System.Drawing.Point(706, 217);
            this.btnCloseAllPositions.Name = "btnCloseAllPositions";
            this.btnCloseAllPositions.Size = new System.Drawing.Size(148, 23);
            this.btnCloseAllPositions.TabIndex = 6;
            this.btnCloseAllPositions.Text = "Close All Positions";
            this.btnCloseAllPositions.UseVisualStyleBackColor = false;
            this.btnCloseAllPositions.Click += new System.EventHandler(this.btnCloseAllPositions_Click);
            // 
            // comBoxExpiries
            // 
            this.comBoxExpiries.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comBoxExpiries.FormattingEnabled = true;
            this.comBoxExpiries.Location = new System.Drawing.Point(310, 21);
            this.comBoxExpiries.Name = "comBoxExpiries";
            this.comBoxExpiries.Size = new System.Drawing.Size(88, 26);
            this.comBoxExpiries.TabIndex = 16;
            // 
            // lblComboBoxLabel
            // 
            this.lblComboBoxLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblComboBoxLabel.AutoSize = true;
            this.lblComboBoxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComboBoxLabel.ForeColor = System.Drawing.Color.Red;
            this.lblComboBoxLabel.Location = new System.Drawing.Point(241, 27);
            this.lblComboBoxLabel.Name = "lblComboBoxLabel";
            this.lblComboBoxLabel.Size = new System.Drawing.Size(63, 15);
            this.lblComboBoxLabel.TabIndex = 17;
            this.lblComboBoxLabel.Text = "Expiries:";
            // 
            // PositionClosingSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.Controls.Add(this.gbxCloseCouples);
            this.Controls.Add(this.grpUNLSummary);
            this.Controls.Add(this.btnCloseAllPositions);
            this.Controls.Add(this.lblHeader);
            this.Name = "PositionClosingSelector";
            this.Size = new System.Drawing.Size(900, 328);
            this.Load += new System.EventHandler(this.PositionClosingSelector_Load);
            this.grpUNLSummary.ResumeLayout(false);
            this.grpUNLSummary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.marginDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unlTradingDataBindingSource)).EndInit();
            this.gbxCloseCouples.ResumeLayout(false);
            this.gbxCloseCouples.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCouplesToClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.GroupBox grpUNLSummary;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSingleCount;
        private System.Windows.Forms.Label lblMateCoupleCount;
        private System.Windows.Forms.Label lblMarginPerCouple;
        private System.Windows.Forms.Label lblMargin;
        private System.Windows.Forms.Label lblSingleType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTotalDeltaLabel;
        private System.Windows.Forms.Label lblTotalDelta;
        private System.Windows.Forms.Label lblCouplesToCloseLabel;
        private System.Windows.Forms.Label lblMarginGain;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSubmitCloseCouples;
        private System.Windows.Forms.GroupBox gbxCloseCouples;
        private System.Windows.Forms.NumericUpDown numCouplesToClose;
        private System.Windows.Forms.BindingSource unlTradingDataBindingSource;
        private System.Windows.Forms.BindingSource marginDataBindingSource;
        private System.Windows.Forms.Button btnCloseAllPositions;
        private System.Windows.Forms.ComboBox comBoxExpiries;
        private System.Windows.Forms.Label lblComboBoxLabel;
    }
}
