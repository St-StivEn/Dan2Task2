namespace Dan2Task2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.PanelBody = new Guna.UI2.WinForms.Guna2Panel();
            this.EncodingPanel = new System.Windows.Forms.Panel();
            this.AESPanel = new System.Windows.Forms.Panel();
            this.HashingPanel = new System.Windows.Forms.Panel();
            this.guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButton2 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButton3 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2DragControl2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2DragControl3 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2DragControl4 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.guna2GradientPanel1.SuspendLayout();
            this.PanelBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 8;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.guna2GradientPanel1.Controls.Add(this.guna2ControlBox2);
            this.guna2GradientPanel1.Controls.Add(this.guna2ControlBox1);
            this.guna2GradientPanel1.Controls.Add(this.guna2GradientButton3);
            this.guna2GradientPanel1.Controls.Add(this.guna2GradientButton2);
            this.guna2GradientPanel1.Controls.Add(this.guna2GradientButton1);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.guna2GradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(1064, 111);
            this.guna2GradientPanel1.TabIndex = 0;
            // 
            // PanelBody
            // 
            this.PanelBody.AutoScroll = true;
            this.PanelBody.Controls.Add(this.HashingPanel);
            this.PanelBody.Controls.Add(this.AESPanel);
            this.PanelBody.Controls.Add(this.EncodingPanel);
            this.PanelBody.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelBody.Location = new System.Drawing.Point(0, 110);
            this.PanelBody.Name = "PanelBody";
            this.PanelBody.Size = new System.Drawing.Size(1064, 583);
            this.PanelBody.TabIndex = 1;
            this.PanelBody.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelBody_Paint);
            // 
            // EncodingPanel
            // 
            this.EncodingPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.EncodingPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.EncodingPanel.Location = new System.Drawing.Point(0, 0);
            this.EncodingPanel.Name = "EncodingPanel";
            this.EncodingPanel.Size = new System.Drawing.Size(1047, 583);
            this.EncodingPanel.TabIndex = 0;
            // 
            // AESPanel
            // 
            this.AESPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.AESPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.AESPanel.Location = new System.Drawing.Point(0, 583);
            this.AESPanel.Name = "AESPanel";
            this.AESPanel.Size = new System.Drawing.Size(1047, 583);
            this.AESPanel.TabIndex = 1;
            // 
            // HashingPanel
            // 
            this.HashingPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.HashingPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HashingPanel.Location = new System.Drawing.Point(0, 1166);
            this.HashingPanel.Name = "HashingPanel";
            this.HashingPanel.Size = new System.Drawing.Size(1047, 583);
            this.HashingPanel.TabIndex = 2;
            // 
            // guna2GradientButton1
            // 
            this.guna2GradientButton1.Animated = true;
            this.guna2GradientButton1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton1.BorderRadius = 8;
            this.guna2GradientButton1.BorderThickness = 2;
            this.guna2GradientButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(9)))), ((int)(((byte)(121)))));
            this.guna2GradientButton1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.guna2GradientButton1.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.guna2GradientButton1.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.guna2GradientButton1.HoverState.FillColor = System.Drawing.Color.Fuchsia;
            this.guna2GradientButton1.HoverState.FillColor2 = System.Drawing.Color.Black;
            this.guna2GradientButton1.HoverState.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guna2GradientButton1.HoverState.ForeColor = System.Drawing.Color.Black;
            this.guna2GradientButton1.Location = new System.Drawing.Point(263, 59);
            this.guna2GradientButton1.Name = "guna2GradientButton1";
            this.guna2GradientButton1.Size = new System.Drawing.Size(180, 45);
            this.guna2GradientButton1.TabIndex = 0;
            this.guna2GradientButton1.Text = "Encoding";
            this.guna2GradientButton1.UseTransparentBackground = true;
            // 
            // guna2GradientButton2
            // 
            this.guna2GradientButton2.Animated = true;
            this.guna2GradientButton2.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton2.BorderRadius = 8;
            this.guna2GradientButton2.BorderThickness = 2;
            this.guna2GradientButton2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton2.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(9)))), ((int)(((byte)(121)))));
            this.guna2GradientButton2.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.guna2GradientButton2.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.guna2GradientButton2.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton2.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.guna2GradientButton2.HoverState.FillColor = System.Drawing.Color.Fuchsia;
            this.guna2GradientButton2.HoverState.FillColor2 = System.Drawing.Color.Black;
            this.guna2GradientButton2.HoverState.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guna2GradientButton2.HoverState.ForeColor = System.Drawing.Color.Black;
            this.guna2GradientButton2.Location = new System.Drawing.Point(449, 59);
            this.guna2GradientButton2.Name = "guna2GradientButton2";
            this.guna2GradientButton2.Size = new System.Drawing.Size(130, 45);
            this.guna2GradientButton2.TabIndex = 1;
            this.guna2GradientButton2.Text = "AES";
            this.guna2GradientButton2.UseTransparentBackground = true;
            // 
            // guna2GradientButton3
            // 
            this.guna2GradientButton3.Animated = true;
            this.guna2GradientButton3.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton3.BorderRadius = 8;
            this.guna2GradientButton3.BorderThickness = 2;
            this.guna2GradientButton3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton3.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(9)))), ((int)(((byte)(121)))));
            this.guna2GradientButton3.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.guna2GradientButton3.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.guna2GradientButton3.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton3.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.guna2GradientButton3.HoverState.FillColor = System.Drawing.Color.Fuchsia;
            this.guna2GradientButton3.HoverState.FillColor2 = System.Drawing.Color.Black;
            this.guna2GradientButton3.HoverState.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guna2GradientButton3.HoverState.ForeColor = System.Drawing.Color.Black;
            this.guna2GradientButton3.Location = new System.Drawing.Point(585, 59);
            this.guna2GradientButton3.Name = "guna2GradientButton3";
            this.guna2GradientButton3.Size = new System.Drawing.Size(180, 45);
            this.guna2GradientButton3.TabIndex = 2;
            this.guna2GradientButton3.Text = "Hashing";
            this.guna2GradientButton3.UseTransparentBackground = true;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.BorderRadius = 8;
            this.guna2ControlBox1.BorderThickness = 2;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(1018, 12);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(34, 29);
            this.guna2ControlBox1.TabIndex = 3;
            this.guna2ControlBox1.UseTransparentBackground = true;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.BorderRadius = 8;
            this.guna2ControlBox2.BorderThickness = 2;
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.HoverState.FillColor = System.Drawing.Color.Black;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.Location = new System.Drawing.Point(978, 12);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(34, 29);
            this.guna2ControlBox2.TabIndex = 4;
            this.guna2ControlBox2.UseTransparentBackground = true;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.guna2GradientPanel1;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // guna2DragControl2
            // 
            this.guna2DragControl2.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl2.TargetControl = this.EncodingPanel;
            this.guna2DragControl2.UseTransparentDrag = true;
            // 
            // guna2DragControl3
            // 
            this.guna2DragControl3.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl3.TargetControl = this.AESPanel;
            this.guna2DragControl3.UseTransparentDrag = true;
            // 
            // guna2DragControl4
            // 
            this.guna2DragControl4.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl4.TargetControl = this.HashingPanel;
            this.guna2DragControl4.UseTransparentDrag = true;
            // 
            // guna2ShadowForm1
            // 
            this.guna2ShadowForm1.ShadowColor = System.Drawing.Color.Fuchsia;
            this.guna2ShadowForm1.TargetForm = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 693);
            this.Controls.Add(this.PanelBody);
            this.Controls.Add(this.guna2GradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.guna2GradientPanel1.ResumeLayout(false);
            this.PanelBody.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel PanelBody;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private System.Windows.Forms.Panel AESPanel;
        private System.Windows.Forms.Panel EncodingPanel;
        private System.Windows.Forms.Panel HashingPanel;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton3;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl2;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl3;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl4;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
    }
}

