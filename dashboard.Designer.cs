
namespace WindowsFormsApp1
{
    partial class dashboard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnPlaceOrder = new Guna.UI.WinForms.GunaButton();
            this.btnAddItems = new Guna.UI.WinForms.GunaButton();
            this.btnUpdateItems = new Guna.UI.WinForms.GunaButton();
            this.btnRemoveItems = new Guna.UI.WinForms.GunaButton();
            this.btnExit = new Guna.UI.WinForms.GunaGradientCircleButton();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaElipse2 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.logoutLink = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.logoutLink);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnRemoveItems);
            this.panel1.Controls.Add(this.btnUpdateItems);
            this.panel1.Controls.Add(this.btnAddItems);
            this.panel1.Controls.Add(this.btnPlaceOrder);
            this.panel1.Location = new System.Drawing.Point(62, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 514);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(260, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(716, 514);
            this.panel2.TabIndex = 1;
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.AnimationHoverSpeed = 0.07F;
            this.btnPlaceOrder.AnimationSpeed = 0.03F;
            this.btnPlaceOrder.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(186)))));
            this.btnPlaceOrder.BorderColor = System.Drawing.Color.Black;
            this.btnPlaceOrder.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPlaceOrder.FocusedColor = System.Drawing.Color.Empty;
            this.btnPlaceOrder.Font = new System.Drawing.Font("MV Boli", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlaceOrder.ForeColor = System.Drawing.Color.White;
            this.btnPlaceOrder.Image = null;
            this.btnPlaceOrder.ImageSize = new System.Drawing.Size(20, 20);
            this.btnPlaceOrder.Location = new System.Drawing.Point(17, 98);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnPlaceOrder.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnPlaceOrder.OnHoverForeColor = System.Drawing.Color.White;
            this.btnPlaceOrder.OnHoverImage = null;
            this.btnPlaceOrder.OnPressedColor = System.Drawing.Color.Black;
            this.btnPlaceOrder.Size = new System.Drawing.Size(202, 41);
            this.btnPlaceOrder.TabIndex = 0;
            this.btnPlaceOrder.Text = "Place Order";
            this.btnPlaceOrder.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnPlaceOrder.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // btnAddItems
            // 
            this.btnAddItems.AnimationHoverSpeed = 0.07F;
            this.btnAddItems.AnimationSpeed = 0.03F;
            this.btnAddItems.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(186)))));
            this.btnAddItems.BorderColor = System.Drawing.Color.Black;
            this.btnAddItems.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddItems.FocusedColor = System.Drawing.Color.Empty;
            this.btnAddItems.Font = new System.Drawing.Font("MV Boli", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItems.ForeColor = System.Drawing.Color.White;
            this.btnAddItems.Image = null;
            this.btnAddItems.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAddItems.Location = new System.Drawing.Point(17, 185);
            this.btnAddItems.Name = "btnAddItems";
            this.btnAddItems.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnAddItems.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAddItems.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAddItems.OnHoverImage = null;
            this.btnAddItems.OnPressedColor = System.Drawing.Color.Black;
            this.btnAddItems.Size = new System.Drawing.Size(202, 41);
            this.btnAddItems.TabIndex = 1;
            this.btnAddItems.Text = "Add Items";
            this.btnAddItems.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddItems.Click += new System.EventHandler(this.gunaButton2_Click);
            // 
            // btnUpdateItems
            // 
            this.btnUpdateItems.AnimationHoverSpeed = 0.07F;
            this.btnUpdateItems.AnimationSpeed = 0.03F;
            this.btnUpdateItems.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(186)))));
            this.btnUpdateItems.BorderColor = System.Drawing.Color.Black;
            this.btnUpdateItems.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnUpdateItems.FocusedColor = System.Drawing.Color.Empty;
            this.btnUpdateItems.Font = new System.Drawing.Font("MV Boli", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateItems.ForeColor = System.Drawing.Color.White;
            this.btnUpdateItems.Image = null;
            this.btnUpdateItems.ImageSize = new System.Drawing.Size(20, 20);
            this.btnUpdateItems.Location = new System.Drawing.Point(17, 284);
            this.btnUpdateItems.Name = "btnUpdateItems";
            this.btnUpdateItems.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnUpdateItems.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnUpdateItems.OnHoverForeColor = System.Drawing.Color.White;
            this.btnUpdateItems.OnHoverImage = null;
            this.btnUpdateItems.OnPressedColor = System.Drawing.Color.Black;
            this.btnUpdateItems.Size = new System.Drawing.Size(202, 41);
            this.btnUpdateItems.TabIndex = 2;
            this.btnUpdateItems.Text = "Update Items";
            this.btnUpdateItems.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnUpdateItems.Click += new System.EventHandler(this.gunaButton3_Click);
            // 
            // btnRemoveItems
            // 
            this.btnRemoveItems.AnimationHoverSpeed = 0.07F;
            this.btnRemoveItems.AnimationSpeed = 0.03F;
            this.btnRemoveItems.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(186)))));
            this.btnRemoveItems.BorderColor = System.Drawing.Color.Black;
            this.btnRemoveItems.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnRemoveItems.FocusedColor = System.Drawing.Color.Empty;
            this.btnRemoveItems.Font = new System.Drawing.Font("MV Boli", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveItems.ForeColor = System.Drawing.Color.White;
            this.btnRemoveItems.Image = null;
            this.btnRemoveItems.ImageSize = new System.Drawing.Size(20, 20);
            this.btnRemoveItems.Location = new System.Drawing.Point(17, 380);
            this.btnRemoveItems.Name = "btnRemoveItems";
            this.btnRemoveItems.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnRemoveItems.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnRemoveItems.OnHoverForeColor = System.Drawing.Color.White;
            this.btnRemoveItems.OnHoverImage = null;
            this.btnRemoveItems.OnPressedColor = System.Drawing.Color.Black;
            this.btnRemoveItems.Size = new System.Drawing.Size(202, 41);
            this.btnRemoveItems.TabIndex = 3;
            this.btnRemoveItems.Text = "Remove Items";
            this.btnRemoveItems.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnRemoveItems.Click += new System.EventHandler(this.gunaButton4_Click);
            // 
            // btnExit
            // 
            this.btnExit.AnimationHoverSpeed = 0.07F;
            this.btnExit.AnimationSpeed = 0.03F;
            this.btnExit.BaseColor1 = System.Drawing.Color.SlateBlue;
            this.btnExit.BaseColor2 = System.Drawing.Color.Fuchsia;
            this.btnExit.BorderColor = System.Drawing.Color.Black;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnExit.FocusedColor = System.Drawing.Color.Empty;
            this.btnExit.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = null;
            this.btnExit.ImageSize = new System.Drawing.Size(52, 52);
            this.btnExit.Location = new System.Drawing.Point(0, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnExit.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnExit.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnExit.OnHoverForeColor = System.Drawing.Color.White;
            this.btnExit.OnHoverImage = null;
            this.btnExit.OnPressedColor = System.Drawing.Color.Black;
            this.btnExit.Size = new System.Drawing.Size(49, 49);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "X";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 30;
            this.gunaElipse1.TargetControl = this;
            // 
            // gunaElipse2
            // 
            this.gunaElipse2.Radius = 30;
            this.gunaElipse2.TargetControl = this.panel2;
            // 
            // logoutLink
            // 
            this.logoutLink.AutoSize = true;
            this.logoutLink.Font = new System.Drawing.Font("MV Boli", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutLink.LinkColor = System.Drawing.Color.Blue;
            this.logoutLink.Location = new System.Drawing.Point(49, 464);
            this.logoutLink.Name = "logoutLink";
            this.logoutLink.Size = new System.Drawing.Size(119, 37);
            this.logoutLink.TabIndex = 0;
            this.logoutLink.TabStop = true;
            this.logoutLink.Text = "LogOut";
            this.logoutLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.logoutLink_LinkClicked);
            // 
            // dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1004, 538);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "dashboard";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaButton btnAddItems;
        private Guna.UI.WinForms.GunaButton btnPlaceOrder;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI.WinForms.GunaButton btnRemoveItems;
        private Guna.UI.WinForms.GunaButton btnUpdateItems;
        private Guna.UI.WinForms.GunaGradientCircleButton btnExit;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaElipse gunaElipse2;
        private System.Windows.Forms.LinkLabel logoutLink;
    }
}