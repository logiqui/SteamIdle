namespace SteamIdle
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.PicApp = new System.Windows.Forms.PictureBox();
            this.TrayApp = new System.Windows.Forms.NotifyIcon(this.components);
            this.MenuOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ExitButton = new System.Windows.Forms.ToolStripMenuItem();
            this.TextBoxID = new System.Windows.Forms.TextBox();
            this.LabelID = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PicApp)).BeginInit();
            this.MenuOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // PicApp
            // 
            this.PicApp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PicApp.Location = new System.Drawing.Point(-1, 0);
            this.PicApp.Name = "PicApp";
            this.PicApp.Size = new System.Drawing.Size(445, 215);
            this.PicApp.TabIndex = 0;
            this.PicApp.TabStop = false;
            // 
            // TrayApp
            // 
            this.TrayApp.ContextMenuStrip = this.MenuOptions;
            this.TrayApp.Icon = ((System.Drawing.Icon)(resources.GetObject("TrayApp.Icon")));
            this.TrayApp.Text = "Steam Idle";
            this.TrayApp.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.TrayApp_MouseDoubleClick);
            // 
            // MenuOptions
            // 
            this.MenuOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitButton});
            this.MenuOptions.Name = "MenuOptions";
            this.MenuOptions.Size = new System.Drawing.Size(181, 48);
            // 
            // ExitButton
            // 
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(180, 22);
            this.ExitButton.Text = "Exit";
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // TextBoxID
            // 
            this.TextBoxID.Location = new System.Drawing.Point(130, 88);
            this.TextBoxID.Name = "TextBoxID";
            this.TextBoxID.Size = new System.Drawing.Size(201, 20);
            this.TextBoxID.TabIndex = 1;
            this.TextBoxID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxID_KeyPress);
            // 
            // LabelID
            // 
            this.LabelID.AutoSize = true;
            this.LabelID.Location = new System.Drawing.Point(201, 72);
            this.LabelID.Name = "LabelID";
            this.LabelID.Size = new System.Drawing.Size(49, 13);
            this.LabelID.TabIndex = 2;
            this.LabelID.Text = "Game ID";
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(188, 114);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
            this.StartButton.TabIndex = 3;
            this.StartButton.Text = "Start Idle";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 215);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.LabelID);
            this.Controls.Add(this.TextBoxID);
            this.Controls.Add(this.PicApp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Steam Idle";
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.PicApp)).EndInit();
            this.MenuOptions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PicApp;
        private System.Windows.Forms.NotifyIcon TrayApp;
        private System.Windows.Forms.ContextMenuStrip MenuOptions;
        private System.Windows.Forms.ToolStripMenuItem ExitButton;
        private System.Windows.Forms.TextBox TextBoxID;
        private System.Windows.Forms.Label LabelID;
        private System.Windows.Forms.Button StartButton;
    }
}

