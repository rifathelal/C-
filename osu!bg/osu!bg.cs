using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace osu_bg
{
    public enum ModificationType { Blur, Black, Grey, Disable, Colour }
    //public enum ModificationType { Blur, Transparent, Colour}

    public partial class Osu_bg : Form
    {
        //////////////////////////////
        ///// INSTANCE VARIABLES /////
        //////////////////////////////

        
        private Osu osu;
        private ModificationType modificationType = ModificationType.Blur;
        private string dataFile =
            Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
                        , "osu!bg.dat");
        private Image orgPreviewThumb;
        private Image modPreviewThumb;


        //////////////////////////////
        /////    CONSTRUCTOR     /////
        //////////////////////////////


        public Osu_bg()
        {
            InitializeComponent();
        }


        //////////////////////////////
        /////       METHODS      /////
        //////////////////////////////


        private void EnableGUI()
        {
            OsuDirLabel.Text = $"Current osu! directory: ";
            SongCountLabel.Text = $"Songs found: ";

            SearchTextBox.Enabled = false;
            ClearButton.Enabled = false;

            SongListBox.Items.Clear();
            SongListBox.Enabled = false;

            BackgroundListBox.Items.Clear();
            BackgroundListBox.Enabled = false;

            ModificationTypeGroup.Enabled = false;
            BlurGroup.Enabled = false;
            PreviewGroup.Enabled = false;

            ModifyButton.Enabled = false;
            RestoreButton.Enabled = false;

            if (osu != null)
            {
                OsuDirLabel.Text = OsuDirLabel.Text + osu.BaseDirectory;
                SongCountLabel.Text = SongCountLabel.Text + osu.SongCount;

                SearchTextBox.Enabled = true;
                ClearButton.Enabled = true;

                SongListBox.Enabled = true;
                SongListBox.Items.Clear();

                BackgroundListBox.Enabled = true;
                BackgroundListBox.Items.Clear();
            }
        }

        private void InitialiseGameInfo()
        {
            if (!File.Exists(dataFile))
            {
                MessageBox.Show("No osu! directory selected. Please locate osu! directory."
                              , "Information"
                              , MessageBoxButtons.OK
                              , MessageBoxIcon.Information);
                osu = SetNewOsuDirectory();
            }
            else
            {
                FileStream file = new FileStream(dataFile, FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(file);
                string execdir = reader.ReadLine();
                if (execdir != null && File.Exists(execdir.Trim()))
                {
                    osu = new Osu(execdir.Trim());
                    string nextLine = reader.ReadLine();
                    while (nextLine != null)
                    {
                        string songFolderName = nextLine.Trim();
                        string songPath = Path.Combine(osu.SongDirectory, songFolderName);

                        nextLine = reader.ReadLine().Trim();
                        string[] bgNamesList = { };
                        if (nextLine != "") bgNamesList = nextLine.Split('\t');

                        if (Directory.Exists(songPath))
                        {
                            Song song = new Song(songPath, bgNamesList);
                            osu.AppendSong(song);
                        }
                        nextLine = reader.ReadLine();
                    }
                    osu.UpdateSongList();
                }
                else
                {
                    MessageBox.Show("osu! directory invalid. Please locate osu! directory again."
                              , "Warning"
                              , MessageBoxButtons.OK
                              , MessageBoxIcon.Information);

                    osu = SetNewOsuDirectory();
                }
                reader.Close();
            }
            EnableGUI();
        }

        private Osu SetNewOsuDirectory()
        {
            OpenFileDialog fileDialog = new OpenFileDialog
            {
                InitialDirectory = "C:\\",
                Filter = "osu! Executable|osu!.exe",
                FilterIndex = 1
            };

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                Osu temp = new Osu(fileDialog.FileName);
                temp.GenerateSongList();
                return temp;
            }

            else
            {
                return null;
            }
        }

        private void ClearModifyGUI()
        {
            ColourPreviewBox.Image = null;
            ModificationTypeGroup.Enabled = false;
            BlurGroup.Enabled = false;
            PreviewBox.Image = null;
            BackgroundStateLabel.Text = "Current status: ";
            PreviewGroup.Enabled = false;
            ModifyButton.Enabled = false;
            RestoreButton.Enabled = false;
            BackgroundListBox.Items.Clear();
        }

        private void SetColour()
        {
            Image image = new Bitmap(ColourPreviewBox.Size.Width, ColourPreviewBox.Size.Height);
            Graphics graphics = Graphics.FromImage(image);
            graphics.Clear(colourPicker.Color);

            ColourPreviewBox.Image = image;
        }

        private void SetModifyGUI(Background background)
        {
            Image origImage = background.GetImage();
            if (origImage != null) orgPreviewThumb =
                    new Bitmap(origImage,
                    new Size(PreviewBox.Width, (int)((PreviewBox.Width / (double)origImage.Width) * origImage.Height)));

            Image modImage = background.GetModImage();
            if (modImage != null) modPreviewThumb =
                    new Bitmap(modImage,
                    new Size(PreviewBox.Width, (int)((PreviewBox.Width / (double)modImage.Width) * modImage.Height)));

            ModificationTypeGroup.Enabled = false;
            BlurGroup.Enabled = false;
            PreviewGroup.Enabled = true;
            PreviewBox.Image = null;
            BackgroundStateLabel.Text =
                $"Current status: {background.State + (background.State == BackgroundState.Disabled ? " (osu! is ANGRY)" : "")}";
            ModifyButton.Enabled = false;
            RestoreButton.Enabled = false;

            if (background.State == BackgroundState.Normal)
            {
                ModificationTypeGroup.Enabled = true;
                BlurGroup.Enabled = true;
                OriginalRadio.Checked = true;
                PreviewBox.Image = orgPreviewThumb;
                ModifyButton.Enabled = true;
            }
            else if (background.State != BackgroundState.Missing)
            {
                ModifiedRadio.Checked = true;
                PreviewBox.Image = modPreviewThumb;
                RestoreButton.Enabled = true;
            }
        }

        private void UpdateModPreview()
        {
            switch (modificationType)
            {
                case (ModificationType.Blur):
                    modPreviewThumb = ImageProcessing.Blur((Bitmap)orgPreviewThumb, BlurTrack.Value / 5);
                    break;
                case (ModificationType.Disable):
                    modPreviewThumb = Properties.Resources.defaultbg;
                    break;
                case (ModificationType.Colour):
                    Image image = new Bitmap(orgPreviewThumb);
                    Graphics graphics = Graphics.FromImage(image);
                    graphics.Clear(colourPicker.Color);

                    modPreviewThumb = image;
                    break;
            }
            ModifiedRadio.Checked = true;
            PreviewBox.Image = modPreviewThumb;
        }


        //////////////////////////////
        /////       EVENTS       /////
        //////////////////////////////


        private void Osu_bg_Load(object sender, EventArgs e)
        {
            EnableGUI();
        }

        private void Osu_bg_Shown(object sender, EventArgs e)
        {
            InitialiseGameInfo();
        }

        private void ChangeDirButton_Click(object sender, EventArgs e)
        {
            Osu temp = SetNewOsuDirectory();
            if (temp != null)
            {
                osu = temp;
                EnableGUI();
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            ClearModifyGUI();
            SongListBox.Items.Clear();
            string searchText = SearchTextBox.Text.ToLower();
            if (SearchTextBox.Text != string.Empty)
            {
                foreach (Song song in osu.Songs)
                {
                    if (song.Name.ToLower().Contains(searchText)) SongListBox.Items.Add(song);
                }
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearModifyGUI();
            SearchTextBox.Text = string.Empty;
            SongListBox.Items.Clear();
        }

        private void SongListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SongListBox.SelectedItem != null)
            {
                ClearModifyGUI();
                Song song = (Song)SongListBox.SelectedItem;
                try
                {
                    song.ParseSong();
                    foreach (Background background in song.Backgrounds) BackgroundListBox.Items.Add(background);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BackgroundListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (BackgroundListBox.SelectedItem != null)
            {
                Background background = (Background)BackgroundListBox.SelectedItem;
                BackgroundStateLabel.Enabled = true;
                SetModifyGUI(background);
            }
        }

        private void ModificationTypeGroup_EnabledChanged(object sender, EventArgs e)
        {
            if (ModificationTypeGroup.Enabled)
            {
                BlurRadio.Checked = true;
                ColourPreviewBox.Enabled = false;
            }
        }

        private void ModificationTypeChanged(object sender, EventArgs e)
        {
            BlurGroup.Enabled = false;
            ColourPreviewBox.Enabled = false;
            ColourPreviewBox.Image = null;

            if (sender == BlurRadio)
            {
                modificationType = ModificationType.Blur;
                BlurGroup.Enabled = true;
            }
            else if (sender == DisableRadio) modificationType = ModificationType.Disable;
            else
            {
                modificationType = ModificationType.Colour;
                ColourPreviewBox.Enabled = true;
                SetColour();
            }

            UpdateModPreview();
        }

        private void BlurGroup_EnabledChanged(object sender, EventArgs e)
        {
            if (modificationType != ModificationType.Blur)
            {
                BlurGroup.Enabled = false;
            }
        }

        private void BlurTrack_ValueChanged(object sender, EventArgs e)
        {
            int tempValue = 5 * (BlurTrack.Value / 5) + (BlurTrack.Value % 5 >= 3 ? 5 : 0);
            BlurTrack.Value = tempValue;
            UpdateModPreview();
        }

        private void ColourPickerButton_Click(object sender, EventArgs e)
        {
            DialogResult result = colourPicker.ShowDialog();
            if (result == DialogResult.OK)
            {
                SetColour();
                UpdateModPreview();
            }
        }

        private void PreviewMode_CheckedChanged(object sender, EventArgs e)
        {
            if (sender == OriginalRadio) PreviewBox.Image = orgPreviewThumb;
            else PreviewBox.Image = modPreviewThumb;
        }

        private void ModifyButton_Click(object sender, EventArgs e)
        {
            var bg = (Background)BackgroundListBox.SelectedItem;
            try
            {
                switch (modificationType)
                {
                    case (ModificationType.Blur):
                        bg.Blur(BlurTrack.Value);
                        break;
                    case (ModificationType.Disable):
                        bg.Disable();
                        break;
                    case (ModificationType.Colour):
                        bg.Colour(colourPicker.Color);
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to remove background.\n{ex.Message}\n{ex.InnerException.StackTrace}"
                                , "Error"
                                , MessageBoxButtons.OK
                                , MessageBoxIcon.Error);
            }
            SetModifyGUI(bg);
        }

        private void RestoreButton_Click(object sender, EventArgs e)
        {
            var bg = (Background)BackgroundListBox.SelectedItem;
            try { bg.Restore(); }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to restore background.\n{ex.InnerException.Message}\n{ex.InnerException.StackTrace}"
                                , "Error"
                                , MessageBoxButtons.OK
                                , MessageBoxIcon.Error);
            }
            BlurTrack.Value = 0;
            OriginalRadio.Checked = true;
            SetModifyGUI(bg);
        }

        private void Osu_bg_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (osu != null)
            {
                StreamWriter writer = null;
                try
                {
                    if (File.Exists(dataFile)) File.Delete(dataFile);
                    FileStream outputFile = new FileStream(dataFile, FileMode.Create, FileAccess.Write);
                    writer = new StreamWriter(outputFile);
                    writer.WriteLine(Path.Combine(osu.BaseDirectory, "osu!.exe"));
                    foreach (Song song in osu.Songs)
                    {
                        writer.WriteLine(song.FolderName);
                        string bgstring = "";
                        foreach (Background bg in song.Backgrounds)
                        {
                            bgstring += bg.Name;
                            bgstring += "\t";
                        }
                        writer.WriteLine(bgstring);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    writer?.Close();
                }
            }
        }

        private void ColourPreviewBox_Click(object sender, EventArgs e)
        {
            DialogResult result = colourPicker.ShowDialog();
            if (result == DialogResult.OK)
            {
                SetColour();
                UpdateModPreview();
            }
        }
    }
}
