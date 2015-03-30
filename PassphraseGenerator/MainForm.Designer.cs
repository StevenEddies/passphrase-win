namespace PassphraseGenerator.UI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.DictionaryTrackBar = new System.Windows.Forms.TrackBar();
            this.CaptionLabel1 = new System.Windows.Forms.Label();
            this.LengthTrackBar = new System.Windows.Forms.TrackBar();
            this.CaptionLabel2 = new System.Windows.Forms.Label();
            this.MainToolStrip = new System.Windows.Forms.ToolStrip();
            this.GenerateToolbarButton = new System.Windows.Forms.ToolStripButton();
            this.ClearToolbarButton = new System.Windows.Forms.ToolStripButton();
            this.HelpToolbarButton = new System.Windows.Forms.ToolStripButton();
            this.MainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.PhraseTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DictionaryTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LengthTrackBar)).BeginInit();
            this.MainToolStrip.SuspendLayout();
            this.MainStatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // DictionaryTrackBar
            // 
            this.DictionaryTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DictionaryTrackBar.LargeChange = 1;
            this.DictionaryTrackBar.Location = new System.Drawing.Point(108, 42);
            this.DictionaryTrackBar.Maximum = 6;
            this.DictionaryTrackBar.Name = "DictionaryTrackBar";
            this.DictionaryTrackBar.Size = new System.Drawing.Size(469, 45);
            this.DictionaryTrackBar.TabIndex = 0;
            this.DictionaryTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.DictionaryTrackBar.ValueChanged += new System.EventHandler(this.DictionaryTrackBar_ValueChanged);
            // 
            // CaptionLabel1
            // 
            this.CaptionLabel1.AutoSize = true;
            this.CaptionLabel1.Location = new System.Drawing.Point(24, 44);
            this.CaptionLabel1.Name = "CaptionLabel1";
            this.CaptionLabel1.Size = new System.Drawing.Size(78, 13);
            this.CaptionLabel1.TabIndex = 3;
            this.CaptionLabel1.Text = "Dictionary size:";
            this.CaptionLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LengthTrackBar
            // 
            this.LengthTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LengthTrackBar.LargeChange = 1;
            this.LengthTrackBar.Location = new System.Drawing.Point(108, 82);
            this.LengthTrackBar.Maximum = 8;
            this.LengthTrackBar.Name = "LengthTrackBar";
            this.LengthTrackBar.Size = new System.Drawing.Size(469, 45);
            this.LengthTrackBar.TabIndex = 4;
            this.LengthTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.LengthTrackBar.ValueChanged += new System.EventHandler(this.LengthTrackBar_ValueChanged);
            // 
            // CaptionLabel2
            // 
            this.CaptionLabel2.AutoSize = true;
            this.CaptionLabel2.Location = new System.Drawing.Point(12, 84);
            this.CaptionLabel2.Name = "CaptionLabel2";
            this.CaptionLabel2.Size = new System.Drawing.Size(90, 13);
            this.CaptionLabel2.TabIndex = 5;
            this.CaptionLabel2.Text = "Number of words:";
            this.CaptionLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MainToolStrip
            // 
            this.MainToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.MainToolStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.MainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GenerateToolbarButton,
            this.ClearToolbarButton,
            this.HelpToolbarButton});
            this.MainToolStrip.Location = new System.Drawing.Point(0, 0);
            this.MainToolStrip.Name = "MainToolStrip";
            this.MainToolStrip.Size = new System.Drawing.Size(589, 39);
            this.MainToolStrip.TabIndex = 9;
            this.MainToolStrip.TabStop = true;
            // 
            // GenerateToolbarButton
            // 
            this.GenerateToolbarButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.GenerateToolbarButton.Image = ((System.Drawing.Image)(resources.GetObject("GenerateToolbarButton.Image")));
            this.GenerateToolbarButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.GenerateToolbarButton.Name = "GenerateToolbarButton";
            this.GenerateToolbarButton.Size = new System.Drawing.Size(36, 36);
            this.GenerateToolbarButton.Text = "Generate";
            this.GenerateToolbarButton.Click += new System.EventHandler(this.GenerateToolbarButton_Click);
            // 
            // ClearToolbarButton
            // 
            this.ClearToolbarButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ClearToolbarButton.Image = ((System.Drawing.Image)(resources.GetObject("ClearToolbarButton.Image")));
            this.ClearToolbarButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ClearToolbarButton.Name = "ClearToolbarButton";
            this.ClearToolbarButton.Size = new System.Drawing.Size(36, 36);
            this.ClearToolbarButton.Text = "Clear";
            this.ClearToolbarButton.Click += new System.EventHandler(this.ClearToolbarButton_Click);
            // 
            // HelpToolbarButton
            // 
            this.HelpToolbarButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.HelpToolbarButton.Image = ((System.Drawing.Image)(resources.GetObject("HelpToolbarButton.Image")));
            this.HelpToolbarButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.HelpToolbarButton.Name = "HelpToolbarButton";
            this.HelpToolbarButton.Size = new System.Drawing.Size(36, 36);
            this.HelpToolbarButton.Text = "Help";
            this.HelpToolbarButton.Click += new System.EventHandler(this.HelpToolbarButton_Click);
            // 
            // MainStatusStrip
            // 
            this.MainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel});
            this.MainStatusStrip.Location = new System.Drawing.Point(0, 156);
            this.MainStatusStrip.Name = "MainStatusStrip";
            this.MainStatusStrip.Size = new System.Drawing.Size(589, 22);
            this.MainStatusStrip.SizingGrip = false;
            this.MainStatusStrip.TabIndex = 10;
            // 
            // StatusLabel
            // 
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // PhraseTextBox
            // 
            this.PhraseTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhraseTextBox.Location = new System.Drawing.Point(12, 122);
            this.PhraseTextBox.Name = "PhraseTextBox";
            this.PhraseTextBox.ReadOnly = true;
            this.PhraseTextBox.Size = new System.Drawing.Size(565, 22);
            this.PhraseTextBox.TabIndex = 11;
            this.PhraseTextBox.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 178);
            this.Controls.Add(this.PhraseTextBox);
            this.Controls.Add(this.MainStatusStrip);
            this.Controls.Add(this.MainToolStrip);
            this.Controls.Add(this.CaptionLabel2);
            this.Controls.Add(this.LengthTrackBar);
            this.Controls.Add(this.CaptionLabel1);
            this.Controls.Add(this.DictionaryTrackBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Passphrase Generator";
            ((System.ComponentModel.ISupportInitialize)(this.DictionaryTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LengthTrackBar)).EndInit();
            this.MainToolStrip.ResumeLayout(false);
            this.MainToolStrip.PerformLayout();
            this.MainStatusStrip.ResumeLayout(false);
            this.MainStatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar DictionaryTrackBar;
        private System.Windows.Forms.Label CaptionLabel1;
        private System.Windows.Forms.TrackBar LengthTrackBar;
        private System.Windows.Forms.Label CaptionLabel2;
        private System.Windows.Forms.ToolStrip MainToolStrip;
        private System.Windows.Forms.ToolStripButton GenerateToolbarButton;
        private System.Windows.Forms.ToolStripButton ClearToolbarButton;
        private System.Windows.Forms.ToolStripButton HelpToolbarButton;
        private System.Windows.Forms.StatusStrip MainStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
        private System.Windows.Forms.TextBox PhraseTextBox;
    }
}

