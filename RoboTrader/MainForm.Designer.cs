﻿namespace TNS.RoboTrader
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
            this.txtMessages = new System.Windows.Forms.TextBox();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xPageAPIMessages = new DevExpress.XtraTab.XtraTabPage();
            this.apiMesagesView = new TNS.Controls.APIMesagesView();
            this.xPagePositions = new DevExpress.XtraTab.XtraTabPage();
            this.positionsView1 = new TNS.Controls.PositionsView();
            this.xtraPageMainSecurities = new DevExpress.XtraTab.XtraTabPage();
            this.mainSecuritiesView1 = new TNS.Controls.MainSecuritiesView();
            this.xtraPageOrders = new DevExpress.XtraTab.XtraTabPage();
            this.ordersView1 = new TNS.Controls.OrdersView();
            this.btnRegisterForData = new System.Windows.Forms.Button();
            this.btnSendOrder = new System.Windows.Forms.Button();
            this.xtraPageOptions = new DevExpress.XtraTab.XtraTabPage();
            this.optionsView1 = new TNS.Controls.OptionsView();
            this.xtraPageUnlDataTrading = new DevExpress.XtraTab.XtraTabPage();
            this.unlTradingView1 = new TNS.Controls.UnlTradingView();
            this.btnBnsLocal = new System.Windows.Forms.Button();
            this.btnCancelOrder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xPageAPIMessages.SuspendLayout();
            this.xPagePositions.SuspendLayout();
            this.xtraPageMainSecurities.SuspendLayout();
            this.xtraPageOrders.SuspendLayout();
            this.xtraPageOptions.SuspendLayout();
            this.xtraPageUnlDataTrading.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMessages
            // 
            this.txtMessages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMessages.Location = new System.Drawing.Point(0, 0);
            this.txtMessages.Multiline = true;
            this.txtMessages.Name = "txtMessages";
            this.txtMessages.Size = new System.Drawing.Size(1061, 492);
            this.txtMessages.TabIndex = 0;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xtraTabControl1.Location = new System.Drawing.Point(-1, 65);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xPageAPIMessages;
            this.xtraTabControl1.Size = new System.Drawing.Size(1067, 520);
            this.xtraTabControl1.TabIndex = 1;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xPageAPIMessages,
            this.xPagePositions,
            this.xtraPageMainSecurities,
            this.xtraPageOrders,
            this.xtraPageOptions,
            this.xtraPageUnlDataTrading});
            // 
            // xPageAPIMessages
            // 
            this.xPageAPIMessages.Controls.Add(this.apiMesagesView);
            this.xPageAPIMessages.Name = "xPageAPIMessages";
            this.xPageAPIMessages.Size = new System.Drawing.Size(1061, 492);
            this.xPageAPIMessages.Text = "API Messages";
            // 
            // apiMesagesView
            // 
            this.apiMesagesView.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.apiMesagesView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.apiMesagesView.Location = new System.Drawing.Point(0, 0);
            this.apiMesagesView.Name = "apiMesagesView";
            this.apiMesagesView.Size = new System.Drawing.Size(1061, 492);
            this.apiMesagesView.TabIndex = 0;
            // 
            // xPagePositions
            // 
            this.xPagePositions.Controls.Add(this.positionsView1);
            this.xPagePositions.Controls.Add(this.txtMessages);
            this.xPagePositions.Name = "xPagePositions";
            this.xPagePositions.Size = new System.Drawing.Size(1061, 492);
            this.xPagePositions.Text = "Positions";
            // 
            // positionsView1
            // 
            this.positionsView1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.positionsView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.positionsView1.Location = new System.Drawing.Point(0, 0);
            this.positionsView1.Name = "positionsView1";
            this.positionsView1.Size = new System.Drawing.Size(1061, 492);
            this.positionsView1.TabIndex = 1;
            // 
            // xtraPageMainSecurities
            // 
            this.xtraPageMainSecurities.Controls.Add(this.mainSecuritiesView1);
            this.xtraPageMainSecurities.Name = "xtraPageMainSecurities";
            this.xtraPageMainSecurities.Size = new System.Drawing.Size(1061, 492);
            this.xtraPageMainSecurities.Text = "Main Securities";
            // 
            // mainSecuritiesView1
            // 
            this.mainSecuritiesView1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mainSecuritiesView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainSecuritiesView1.Location = new System.Drawing.Point(0, 0);
            this.mainSecuritiesView1.Name = "mainSecuritiesView1";
            this.mainSecuritiesView1.Size = new System.Drawing.Size(1061, 492);
            this.mainSecuritiesView1.TabIndex = 0;
            // 
            // xtraPageOrders
            // 
            this.xtraPageOrders.Controls.Add(this.ordersView1);
            this.xtraPageOrders.Controls.Add(this.btnRegisterForData);
            this.xtraPageOrders.Controls.Add(this.btnCancelOrder);
            this.xtraPageOrders.Controls.Add(this.btnSendOrder);
            this.xtraPageOrders.Name = "xtraPageOrders";
            this.xtraPageOrders.Size = new System.Drawing.Size(1061, 492);
            this.xtraPageOrders.Text = "Orders";
            // 
            // ordersView1
            // 
            this.ordersView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ordersView1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ordersView1.Location = new System.Drawing.Point(3, 43);
            this.ordersView1.Name = "ordersView1";
            this.ordersView1.Size = new System.Drawing.Size(1055, 465);
            this.ordersView1.TabIndex = 1;
            // 
            // btnRegisterForData
            // 
            this.btnRegisterForData.Location = new System.Drawing.Point(11, 14);
            this.btnRegisterForData.Name = "btnRegisterForData";
            this.btnRegisterForData.Size = new System.Drawing.Size(102, 23);
            this.btnRegisterForData.TabIndex = 0;
            this.btnRegisterForData.Text = "Register For Data";
            this.btnRegisterForData.UseVisualStyleBackColor = true;
            this.btnRegisterForData.Click += new System.EventHandler(this.btnRegisterForData_Click);
            // 
            // btnSendOrder
            // 
            this.btnSendOrder.Location = new System.Drawing.Point(217, 14);
            this.btnSendOrder.Name = "btnSendOrder";
            this.btnSendOrder.Size = new System.Drawing.Size(75, 23);
            this.btnSendOrder.TabIndex = 0;
            this.btnSendOrder.Text = "Send Order";
            this.btnSendOrder.UseVisualStyleBackColor = true;
            this.btnSendOrder.Click += new System.EventHandler(this.btnSendOrder_Click);
            // 
            // xtraPageOptions
            // 
            this.xtraPageOptions.Controls.Add(this.optionsView1);
            this.xtraPageOptions.Name = "xtraPageOptions";
            this.xtraPageOptions.Size = new System.Drawing.Size(1061, 492);
            this.xtraPageOptions.Text = "Options";
            // 
            // optionsView1
            // 
            this.optionsView1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.optionsView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.optionsView1.Location = new System.Drawing.Point(0, 0);
            this.optionsView1.Name = "optionsView1";
            this.optionsView1.Size = new System.Drawing.Size(1061, 492);
            this.optionsView1.TabIndex = 0;
            // 
            // xtraPageUnlDataTrading
            // 
            this.xtraPageUnlDataTrading.Controls.Add(this.unlTradingView1);
            this.xtraPageUnlDataTrading.Name = "xtraPageUnlDataTrading";
            this.xtraPageUnlDataTrading.Size = new System.Drawing.Size(1061, 492);
            this.xtraPageUnlDataTrading.Text = "Unl. Trading Data";
            // 
            // unlTradingView1
            // 
            this.unlTradingView1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.unlTradingView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.unlTradingView1.Location = new System.Drawing.Point(0, 0);
            this.unlTradingView1.Name = "unlTradingView1";
            this.unlTradingView1.Size = new System.Drawing.Size(1061, 492);
            this.unlTradingView1.TabIndex = 0;
            // 
            // btnBnsLocal
            // 
            this.btnBnsLocal.Location = new System.Drawing.Point(13, 13);
            this.btnBnsLocal.Name = "btnBnsLocal";
            this.btnBnsLocal.Size = new System.Drawing.Size(75, 23);
            this.btnBnsLocal.TabIndex = 2;
            this.btnBnsLocal.Text = "B n S Local ";
            this.btnBnsLocal.UseVisualStyleBackColor = true;
            this.btnBnsLocal.Click += new System.EventHandler(this.btnBnsLocal_Click);
            // 
            // btnCancelOrder
            // 
            this.btnCancelOrder.Location = new System.Drawing.Point(361, 14);
            this.btnCancelOrder.Name = "btnCancelOrder";
            this.btnCancelOrder.Size = new System.Drawing.Size(136, 23);
            this.btnCancelOrder.TabIndex = 0;
            this.btnCancelOrder.Text = "Cancel Selected Order";
            this.btnCancelOrder.UseVisualStyleBackColor = true;
            this.btnCancelOrder.Click += new System.EventHandler(this.btnCancelOrder_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 585);
            this.Controls.Add(this.btnBnsLocal);
            this.Controls.Add(this.xtraTabControl1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xPageAPIMessages.ResumeLayout(false);
            this.xPagePositions.ResumeLayout(false);
            this.xPagePositions.PerformLayout();
            this.xtraPageMainSecurities.ResumeLayout(false);
            this.xtraPageOrders.ResumeLayout(false);
            this.xtraPageOptions.ResumeLayout(false);
            this.xtraPageUnlDataTrading.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtMessages;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xPageAPIMessages;
        private Controls.APIMesagesView apiMesagesView;
        private DevExpress.XtraTab.XtraTabPage xPagePositions;
        private DevExpress.XtraTab.XtraTabPage xtraPageMainSecurities;
        private Controls.MainSecuritiesView mainSecuritiesView1;
        private DevExpress.XtraTab.XtraTabPage xtraPageOrders;
        private System.Windows.Forms.Button btnSendOrder;
        private Controls.OrdersView ordersView1;
        private System.Windows.Forms.Button btnRegisterForData;
        private DevExpress.XtraTab.XtraTabPage xtraPageOptions;
        private Controls.OptionsView optionsView1;
        private DevExpress.XtraTab.XtraTabPage xtraPageUnlDataTrading;
        private Controls.UnlTradingView unlTradingView1;
        private Controls.PositionsView positionsView1;
        private System.Windows.Forms.Button btnBnsLocal;
        private System.Windows.Forms.Button btnCancelOrder;
    }
}

