using MaterialSkin;

namespace deltaware2
{
    partial class Information
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
            this.dateTimeLabel = new MaterialSkin.Controls.MaterialLabel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.numaraTextBox = new MaterialSkin.Controls.MaterialTextBox2();
            this.startExamButton = new MaterialSkin.Controls.MaterialButton();
            this.adTextBox = new MaterialSkin.Controls.MaterialTextBox2();
            this.soyadTextBox = new MaterialSkin.Controls.MaterialTextBox2();
            this.gradeComboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.SuspendLayout();
            // 
            // dateTimeLabel
            // 
            this.dateTimeLabel.AutoSize = true;
            this.dateTimeLabel.Depth = 0;
            this.dateTimeLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dateTimeLabel.Location = new System.Drawing.Point(3, 267);
            this.dateTimeLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.dateTimeLabel.Name = "dateTimeLabel";
            this.dateTimeLabel.Size = new System.Drawing.Size(1, 0);
            this.dateTimeLabel.TabIndex = 0;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // numaraTextBox
            // 
            this.numaraTextBox.AnimateReadOnly = true;
            this.numaraTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.numaraTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.numaraTextBox.Depth = 0;
            this.numaraTextBox.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numaraTextBox.HideSelection = true;
            this.numaraTextBox.LeadingIcon = null;
            this.numaraTextBox.LeaveOnEnterKey = true;
            this.numaraTextBox.Location = new System.Drawing.Point(6, 131);
            this.numaraTextBox.MaxLength = 32767;
            this.numaraTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.numaraTextBox.Name = "numaraTextBox";
            this.numaraTextBox.PasswordChar = '\0';
            this.numaraTextBox.PrefixSuffix = MaterialSkin.Controls.MaterialTextBox2.PrefixSuffixTypes.Prefix;
            this.numaraTextBox.PrefixSuffixText = "Numara";
            this.numaraTextBox.ReadOnly = false;
            this.numaraTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numaraTextBox.SelectedText = "";
            this.numaraTextBox.SelectionLength = 0;
            this.numaraTextBox.SelectionStart = 0;
            this.numaraTextBox.ShortcutsEnabled = true;
            this.numaraTextBox.Size = new System.Drawing.Size(162, 48);
            this.numaraTextBox.TabIndex = 2;
            this.numaraTextBox.TabStop = false;
            this.numaraTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.numaraTextBox.TrailingIcon = null;
            this.numaraTextBox.UseSystemPasswordChar = false;
            // 
            // startExamButton
            // 
            this.startExamButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.startExamButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.startExamButton.Depth = 0;
            this.startExamButton.HighEmphasis = true;
            this.startExamButton.Icon = null;
            this.startExamButton.Location = new System.Drawing.Point(111, 196);
            this.startExamButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.startExamButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.startExamButton.Name = "startExamButton";
            this.startExamButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.startExamButton.Size = new System.Drawing.Size(126, 36);
            this.startExamButton.TabIndex = 4;
            this.startExamButton.Text = "Sınavı Başlat";
            this.startExamButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.startExamButton.UseAccentColor = false;
            this.startExamButton.UseVisualStyleBackColor = true;
            this.startExamButton.Click += new System.EventHandler(this.startExamButton_Click);
            // 
            // adTextBox
            // 
            this.adTextBox.AnimateReadOnly = true;
            this.adTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.adTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.adTextBox.Depth = 0;
            this.adTextBox.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.adTextBox.HideSelection = true;
            this.adTextBox.LeadingIcon = null;
            this.adTextBox.LeaveOnEnterKey = true;
            this.adTextBox.Location = new System.Drawing.Point(6, 77);
            this.adTextBox.MaxLength = 32767;
            this.adTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.adTextBox.Name = "adTextBox";
            this.adTextBox.PasswordChar = '\0';
            this.adTextBox.PrefixSuffix = MaterialSkin.Controls.MaterialTextBox2.PrefixSuffixTypes.Prefix;
            this.adTextBox.PrefixSuffixText = "Ad";
            this.adTextBox.ReadOnly = false;
            this.adTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.adTextBox.SelectedText = "";
            this.adTextBox.SelectionLength = 0;
            this.adTextBox.SelectionStart = 0;
            this.adTextBox.ShortcutsEnabled = true;
            this.adTextBox.Size = new System.Drawing.Size(162, 48);
            this.adTextBox.TabIndex = 2;
            this.adTextBox.TabStop = false;
            this.adTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.adTextBox.TrailingIcon = null;
            this.adTextBox.UseSystemPasswordChar = false;
            // 
            // soyadTextBox
            // 
            this.soyadTextBox.AnimateReadOnly = true;
            this.soyadTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.soyadTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.soyadTextBox.Depth = 0;
            this.soyadTextBox.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.soyadTextBox.HideSelection = true;
            this.soyadTextBox.LeadingIcon = null;
            this.soyadTextBox.LeaveOnEnterKey = true;
            this.soyadTextBox.Location = new System.Drawing.Point(174, 77);
            this.soyadTextBox.MaxLength = 32767;
            this.soyadTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.soyadTextBox.Name = "soyadTextBox";
            this.soyadTextBox.PasswordChar = '\0';
            this.soyadTextBox.PrefixSuffix = MaterialSkin.Controls.MaterialTextBox2.PrefixSuffixTypes.Prefix;
            this.soyadTextBox.PrefixSuffixText = "Soyad";
            this.soyadTextBox.ReadOnly = false;
            this.soyadTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.soyadTextBox.SelectedText = "";
            this.soyadTextBox.SelectionLength = 0;
            this.soyadTextBox.SelectionStart = 0;
            this.soyadTextBox.ShortcutsEnabled = true;
            this.soyadTextBox.Size = new System.Drawing.Size(162, 48);
            this.soyadTextBox.TabIndex = 2;
            this.soyadTextBox.TabStop = false;
            this.soyadTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.soyadTextBox.TrailingIcon = null;
            this.soyadTextBox.UseSystemPasswordChar = false;
            // 
            // gradeComboBox
            // 
            this.gradeComboBox.AutoResize = false;
            this.gradeComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gradeComboBox.Depth = 0;
            this.gradeComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.gradeComboBox.DropDownHeight = 174;
            this.gradeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gradeComboBox.DropDownWidth = 121;
            this.gradeComboBox.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.gradeComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gradeComboBox.FormattingEnabled = true;
            this.gradeComboBox.IntegralHeight = false;
            this.gradeComboBox.ItemHeight = 43;
            this.gradeComboBox.Items.AddRange(new object[] {
            "9A",
            "9B",
            "9C",
            "9D"});
            this.gradeComboBox.Location = new System.Drawing.Point(174, 130);
            this.gradeComboBox.MaxDropDownItems = 4;
            this.gradeComboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.gradeComboBox.Name = "gradeComboBox";
            this.gradeComboBox.Size = new System.Drawing.Size(162, 49);
            this.gradeComboBox.StartIndex = 0;
            this.gradeComboBox.TabIndex = 5;
            // 
            // Information
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(344, 288);
            this.Controls.Add(this.gradeComboBox);
            this.Controls.Add(this.startExamButton);
            this.Controls.Add(this.adTextBox);
            this.Controls.Add(this.soyadTextBox);
            this.Controls.Add(this.numaraTextBox);
            this.Controls.Add(this.dateTimeLabel);
            this.MaximizeBox = false;
            this.Name = "Information";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bilgilerinizi Girin";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        public void reDesign()
        {
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Green400, Primary.Green500,
                Primary.Green500, Accent.Green200,
                TextShade.WHITE
            );
        }
        #endregion

        private MaterialSkin.Controls.MaterialLabel dateTimeLabel;
        private System.Windows.Forms.Timer timer;
        private MaterialSkin.Controls.MaterialTextBox2 numaraTextBox;
        private MaterialSkin.Controls.MaterialButton startExamButton;
        private MaterialSkin.Controls.MaterialTextBox2 adTextBox;
        private MaterialSkin.Controls.MaterialTextBox2 soyadTextBox;
        private MaterialSkin.Controls.MaterialComboBox gradeComboBox;
    }
}