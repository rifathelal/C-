namespace osu_bg
{
    partial class Osu_bg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Osu_bg));
            this.GameInfoGroup = new System.Windows.Forms.GroupBox();
            this.osuIcon = new System.Windows.Forms.PictureBox();
            this.SongCountLabel = new System.Windows.Forms.Label();
            this.OsuDirLabel = new System.Windows.Forms.Label();
            this.ChangeDirButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.SongListBox = new System.Windows.Forms.ListBox();
            this.BackgroundListBox = new System.Windows.Forms.ListBox();
            this.PreviewGroup = new System.Windows.Forms.GroupBox();
            this.ModifiedRadio = new System.Windows.Forms.RadioButton();
            this.OriginalRadio = new System.Windows.Forms.RadioButton();
            this.BackgroundStateLabel = new System.Windows.Forms.Label();
            this.PreviewBox = new System.Windows.Forms.PictureBox();
            this.BlurTrack = new System.Windows.Forms.TrackBar();
            this.RestoreButton = new System.Windows.Forms.Button();
            this.ModifyButton = new System.Windows.Forms.Button();
            this.ModificationTypeGroup = new System.Windows.Forms.GroupBox();
            this.ColourRadio = new System.Windows.Forms.RadioButton();
            this.ColourPreviewBox = new System.Windows.Forms.PictureBox();
            this.BlurRadio = new System.Windows.Forms.RadioButton();
            this.DisableRadio = new System.Windows.Forms.RadioButton();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.BlurGroup = new System.Windows.Forms.GroupBox();
            this.BlurTrackLabel2 = new System.Windows.Forms.Label();
            this.BlurTrackLabel3 = new System.Windows.Forms.Label();
            this.BlurTrackLabel1 = new System.Windows.Forms.Label();
            this.colourPicker = new System.Windows.Forms.ColorDialog();
            this.ClearButton = new System.Windows.Forms.Button();
            this.GameInfoGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.osuIcon)).BeginInit();
            this.PreviewGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PreviewBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlurTrack)).BeginInit();
            this.ModificationTypeGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ColourPreviewBox)).BeginInit();
            this.BlurGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // GameInfoGroup
            // 
            this.GameInfoGroup.Controls.Add(this.osuIcon);
            this.GameInfoGroup.Controls.Add(this.SongCountLabel);
            this.GameInfoGroup.Controls.Add(this.OsuDirLabel);
            this.GameInfoGroup.Location = new System.Drawing.Point(12, 12);
            this.GameInfoGroup.Name = "GameInfoGroup";
            this.GameInfoGroup.Size = new System.Drawing.Size(562, 92);
            this.GameInfoGroup.TabIndex = 6;
            this.GameInfoGroup.TabStop = false;
            // 
            // osuIcon
            // 
            this.osuIcon.Image = ((System.Drawing.Image)(resources.GetObject("osuIcon.Image")));
            this.osuIcon.Location = new System.Drawing.Point(6, 14);
            this.osuIcon.Name = "osuIcon";
            this.osuIcon.Size = new System.Drawing.Size(68, 71);
            this.osuIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.osuIcon.TabIndex = 13;
            this.osuIcon.TabStop = false;
            // 
            // SongCountLabel
            // 
            this.SongCountLabel.AutoEllipsis = true;
            this.SongCountLabel.Location = new System.Drawing.Point(80, 56);
            this.SongCountLabel.Name = "SongCountLabel";
            this.SongCountLabel.Size = new System.Drawing.Size(476, 17);
            this.SongCountLabel.TabIndex = 8;
            this.SongCountLabel.Text = "Songs found:";
            this.SongCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // OsuDirLabel
            // 
            this.OsuDirLabel.AutoEllipsis = true;
            this.OsuDirLabel.Location = new System.Drawing.Point(80, 30);
            this.OsuDirLabel.Name = "OsuDirLabel";
            this.OsuDirLabel.Size = new System.Drawing.Size(476, 17);
            this.OsuDirLabel.TabIndex = 6;
            this.OsuDirLabel.Text = "Current osu! directory:";
            this.OsuDirLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ChangeDirButton
            // 
            this.ChangeDirButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ChangeDirButton.Location = new System.Drawing.Point(583, 19);
            this.ChangeDirButton.Name = "ChangeDirButton";
            this.ChangeDirButton.Size = new System.Drawing.Size(157, 86);
            this.ChangeDirButton.TabIndex = 12;
            this.ChangeDirButton.Text = "Change osu!  Directory";
            this.ChangeDirButton.UseVisualStyleBackColor = true;
            this.ChangeDirButton.Click += new System.EventHandler(this.ChangeDirButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(747, 19);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(160, 86);
            this.ExitButton.TabIndex = 13;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTextBox.Location = new System.Drawing.Point(12, 124);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(483, 22);
            this.SearchTextBox.TabIndex = 14;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // SongListBox
            // 
            this.SongListBox.FormattingEnabled = true;
            this.SongListBox.ItemHeight = 16;
            this.SongListBox.Location = new System.Drawing.Point(12, 154);
            this.SongListBox.Name = "SongListBox";
            this.SongListBox.Size = new System.Drawing.Size(324, 500);
            this.SongListBox.Sorted = true;
            this.SongListBox.TabIndex = 19;
            this.SongListBox.SelectedIndexChanged += new System.EventHandler(this.SongListBox_SelectedIndexChanged);
            // 
            // BackgroundListBox
            // 
            this.BackgroundListBox.FormattingEnabled = true;
            this.BackgroundListBox.ItemHeight = 16;
            this.BackgroundListBox.Location = new System.Drawing.Point(343, 154);
            this.BackgroundListBox.Name = "BackgroundListBox";
            this.BackgroundListBox.Size = new System.Drawing.Size(232, 500);
            this.BackgroundListBox.TabIndex = 20;
            this.BackgroundListBox.SelectedIndexChanged += new System.EventHandler(this.BackgroundListBox_SelectedIndexChanged);
            // 
            // PreviewGroup
            // 
            this.PreviewGroup.Controls.Add(this.ModifiedRadio);
            this.PreviewGroup.Controls.Add(this.OriginalRadio);
            this.PreviewGroup.Controls.Add(this.BackgroundStateLabel);
            this.PreviewGroup.Controls.Add(this.PreviewBox);
            this.PreviewGroup.Location = new System.Drawing.Point(583, 329);
            this.PreviewGroup.Name = "PreviewGroup";
            this.PreviewGroup.Size = new System.Drawing.Size(324, 285);
            this.PreviewGroup.TabIndex = 22;
            this.PreviewGroup.TabStop = false;
            this.PreviewGroup.Text = "Preview";
            // 
            // ModifiedRadio
            // 
            this.ModifiedRadio.AutoSize = true;
            this.ModifiedRadio.Location = new System.Drawing.Point(122, 21);
            this.ModifiedRadio.Name = "ModifiedRadio";
            this.ModifiedRadio.Size = new System.Drawing.Size(82, 21);
            this.ModifiedRadio.TabIndex = 3;
            this.ModifiedRadio.Text = "Modified";
            this.ModifiedRadio.UseVisualStyleBackColor = true;
            this.ModifiedRadio.CheckedChanged += new System.EventHandler(this.PreviewMode_CheckedChanged);
            // 
            // OriginalRadio
            // 
            this.OriginalRadio.AutoSize = true;
            this.OriginalRadio.Checked = true;
            this.OriginalRadio.Location = new System.Drawing.Point(12, 21);
            this.OriginalRadio.Name = "OriginalRadio";
            this.OriginalRadio.Size = new System.Drawing.Size(78, 21);
            this.OriginalRadio.TabIndex = 2;
            this.OriginalRadio.TabStop = true;
            this.OriginalRadio.Text = "Original";
            this.OriginalRadio.UseVisualStyleBackColor = true;
            this.OriginalRadio.CheckedChanged += new System.EventHandler(this.PreviewMode_CheckedChanged);
            // 
            // BackgroundStateLabel
            // 
            this.BackgroundStateLabel.AutoSize = true;
            this.BackgroundStateLabel.Enabled = false;
            this.BackgroundStateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackgroundStateLabel.Location = new System.Drawing.Point(4, 258);
            this.BackgroundStateLabel.Name = "BackgroundStateLabel";
            this.BackgroundStateLabel.Size = new System.Drawing.Size(101, 17);
            this.BackgroundStateLabel.TabIndex = 1;
            this.BackgroundStateLabel.Text = "Current status:";
            // 
            // PreviewBox
            // 
            this.PreviewBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PreviewBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PreviewBox.Location = new System.Drawing.Point(5, 46);
            this.PreviewBox.Name = "PreviewBox";
            this.PreviewBox.Size = new System.Drawing.Size(315, 200);
            this.PreviewBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PreviewBox.TabIndex = 0;
            this.PreviewBox.TabStop = false;
            // 
            // BlurTrack
            // 
            this.BlurTrack.AutoSize = false;
            this.BlurTrack.Location = new System.Drawing.Point(9, 21);
            this.BlurTrack.Maximum = 30;
            this.BlurTrack.Name = "BlurTrack";
            this.BlurTrack.Size = new System.Drawing.Size(309, 32);
            this.BlurTrack.SmallChange = 5;
            this.BlurTrack.TabIndex = 23;
            this.BlurTrack.TickFrequency = 5;
            this.BlurTrack.ValueChanged += new System.EventHandler(this.BlurTrack_ValueChanged);
            // 
            // RestoreButton
            // 
            this.RestoreButton.Location = new System.Drawing.Point(747, 620);
            this.RestoreButton.Name = "RestoreButton";
            this.RestoreButton.Size = new System.Drawing.Size(160, 34);
            this.RestoreButton.TabIndex = 26;
            this.RestoreButton.Text = "Restore";
            this.RestoreButton.UseVisualStyleBackColor = true;
            this.RestoreButton.Click += new System.EventHandler(this.RestoreButton_Click);
            // 
            // ModifyButton
            // 
            this.ModifyButton.Location = new System.Drawing.Point(583, 620);
            this.ModifyButton.Name = "ModifyButton";
            this.ModifyButton.Size = new System.Drawing.Size(157, 34);
            this.ModifyButton.TabIndex = 25;
            this.ModifyButton.Text = "Modify";
            this.ModifyButton.UseVisualStyleBackColor = true;
            this.ModifyButton.Click += new System.EventHandler(this.ModifyButton_Click);
            // 
            // ModificationTypeGroup
            // 
            this.ModificationTypeGroup.Controls.Add(this.ColourRadio);
            this.ModificationTypeGroup.Controls.Add(this.ColourPreviewBox);
            this.ModificationTypeGroup.Controls.Add(this.BlurRadio);
            this.ModificationTypeGroup.Controls.Add(this.DisableRadio);
            this.ModificationTypeGroup.Location = new System.Drawing.Point(583, 111);
            this.ModificationTypeGroup.Name = "ModificationTypeGroup";
            this.ModificationTypeGroup.Size = new System.Drawing.Size(324, 105);
            this.ModificationTypeGroup.TabIndex = 27;
            this.ModificationTypeGroup.TabStop = false;
            this.ModificationTypeGroup.Text = "Modification Type";
            this.ModificationTypeGroup.EnabledChanged += new System.EventHandler(this.ModificationTypeGroup_EnabledChanged);
            // 
            // ColourRadio
            // 
            this.ColourRadio.AutoSize = true;
            this.ColourRadio.Location = new System.Drawing.Point(12, 75);
            this.ColourRadio.Name = "ColourRadio";
            this.ColourRadio.Size = new System.Drawing.Size(105, 21);
            this.ColourRadio.TabIndex = 4;
            this.ColourRadio.Text = "Solid Colour";
            this.ColourRadio.UseVisualStyleBackColor = true;
            this.ColourRadio.CheckedChanged += new System.EventHandler(this.ModificationTypeChanged);
            // 
            // ColourPreviewBox
            // 
            this.ColourPreviewBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ColourPreviewBox.Location = new System.Drawing.Point(118, 72);
            this.ColourPreviewBox.Name = "ColourPreviewBox";
            this.ColourPreviewBox.Size = new System.Drawing.Size(25, 25);
            this.ColourPreviewBox.TabIndex = 6;
            this.ColourPreviewBox.TabStop = false;
            this.ColourPreviewBox.Click += new System.EventHandler(this.ColourPreviewBox_Click);
            // 
            // BlurRadio
            // 
            this.BlurRadio.AutoSize = true;
            this.BlurRadio.Checked = true;
            this.BlurRadio.Location = new System.Drawing.Point(12, 21);
            this.BlurRadio.Name = "BlurRadio";
            this.BlurRadio.Size = new System.Drawing.Size(54, 21);
            this.BlurRadio.TabIndex = 5;
            this.BlurRadio.TabStop = true;
            this.BlurRadio.Text = "Blur";
            this.BlurRadio.UseVisualStyleBackColor = true;
            this.BlurRadio.CheckedChanged += new System.EventHandler(this.ModificationTypeChanged);
            // 
            // DisableRadio
            // 
            this.DisableRadio.AutoSize = true;
            this.DisableRadio.Location = new System.Drawing.Point(12, 48);
            this.DisableRadio.Name = "DisableRadio";
            this.DisableRadio.Size = new System.Drawing.Size(76, 21);
            this.DisableRadio.TabIndex = 1;
            this.DisableRadio.Text = "Disable";
            this.DisableRadio.UseVisualStyleBackColor = true;
            this.DisableRadio.CheckedChanged += new System.EventHandler(this.ModificationTypeChanged);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Location = new System.Drawing.Point(0, 662);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(916, 22);
            this.statusStrip.TabIndex = 28;
            this.statusStrip.Text = "statusStrip1";
            // 
            // BlurGroup
            // 
            this.BlurGroup.Controls.Add(this.BlurTrackLabel2);
            this.BlurGroup.Controls.Add(this.BlurTrackLabel3);
            this.BlurGroup.Controls.Add(this.BlurTrackLabel1);
            this.BlurGroup.Controls.Add(this.BlurTrack);
            this.BlurGroup.Location = new System.Drawing.Point(583, 232);
            this.BlurGroup.Name = "BlurGroup";
            this.BlurGroup.Size = new System.Drawing.Size(324, 79);
            this.BlurGroup.TabIndex = 30;
            this.BlurGroup.TabStop = false;
            this.BlurGroup.Text = "Blur Radius";
            this.BlurGroup.EnabledChanged += new System.EventHandler(this.BlurGroup_EnabledChanged);
            // 
            // BlurTrackLabel2
            // 
            this.BlurTrackLabel2.AutoSize = true;
            this.BlurTrackLabel2.Location = new System.Drawing.Point(153, 56);
            this.BlurTrackLabel2.Name = "BlurTrackLabel2";
            this.BlurTrackLabel2.Size = new System.Drawing.Size(24, 17);
            this.BlurTrackLabel2.TabIndex = 26;
            this.BlurTrackLabel2.Text = "15";
            // 
            // BlurTrackLabel3
            // 
            this.BlurTrackLabel3.AutoSize = true;
            this.BlurTrackLabel3.Location = new System.Drawing.Point(289, 56);
            this.BlurTrackLabel3.Name = "BlurTrackLabel3";
            this.BlurTrackLabel3.Size = new System.Drawing.Size(24, 17);
            this.BlurTrackLabel3.TabIndex = 25;
            this.BlurTrackLabel3.Text = "30";
            // 
            // BlurTrackLabel1
            // 
            this.BlurTrackLabel1.AutoSize = true;
            this.BlurTrackLabel1.Location = new System.Drawing.Point(19, 56);
            this.BlurTrackLabel1.Name = "BlurTrackLabel1";
            this.BlurTrackLabel1.Size = new System.Drawing.Size(16, 17);
            this.BlurTrackLabel1.TabIndex = 24;
            this.BlurTrackLabel1.Text = "0";
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(501, 121);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(74, 26);
            this.ClearButton.TabIndex = 31;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // Osu_bg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 684);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.BlurGroup);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.ModificationTypeGroup);
            this.Controls.Add(this.RestoreButton);
            this.Controls.Add(this.ModifyButton);
            this.Controls.Add(this.PreviewGroup);
            this.Controls.Add(this.BackgroundListBox);
            this.Controls.Add(this.SongListBox);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ChangeDirButton);
            this.Controls.Add(this.GameInfoGroup);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Osu_bg";
            this.Text = "osu! Background Modification Tool";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Osu_bg_FormClosing);
            this.Load += new System.EventHandler(this.Osu_bg_Load);
            this.Shown += new System.EventHandler(this.Osu_bg_Shown);
            this.GameInfoGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.osuIcon)).EndInit();
            this.PreviewGroup.ResumeLayout(false);
            this.PreviewGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PreviewBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlurTrack)).EndInit();
            this.ModificationTypeGroup.ResumeLayout(false);
            this.ModificationTypeGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ColourPreviewBox)).EndInit();
            this.BlurGroup.ResumeLayout(false);
            this.BlurGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GameInfoGroup;
        private System.Windows.Forms.PictureBox osuIcon;
        private System.Windows.Forms.Label SongCountLabel;
        private System.Windows.Forms.Label OsuDirLabel;
        private System.Windows.Forms.Button ChangeDirButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.ListBox SongListBox;
        private System.Windows.Forms.ListBox BackgroundListBox;
        private System.Windows.Forms.GroupBox PreviewGroup;
        private System.Windows.Forms.Label BackgroundStateLabel;
        private System.Windows.Forms.PictureBox PreviewBox;
        private System.Windows.Forms.TrackBar BlurTrack;
        private System.Windows.Forms.Button RestoreButton;
        private System.Windows.Forms.Button ModifyButton;
        private System.Windows.Forms.GroupBox ModificationTypeGroup;
        private System.Windows.Forms.RadioButton ColourRadio;
        private System.Windows.Forms.RadioButton DisableRadio;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.RadioButton BlurRadio;
        private System.Windows.Forms.GroupBox BlurGroup;
        private System.Windows.Forms.Label BlurTrackLabel2;
        private System.Windows.Forms.Label BlurTrackLabel3;
        private System.Windows.Forms.Label BlurTrackLabel1;
        private System.Windows.Forms.ColorDialog colourPicker;
        private System.Windows.Forms.PictureBox ColourPreviewBox;
        private System.Windows.Forms.RadioButton ModifiedRadio;
        private System.Windows.Forms.RadioButton OriginalRadio;
        private System.Windows.Forms.Button ClearButton;
    }
}