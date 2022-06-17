using MaterialSkin;

namespace deltaware2
{
    partial class Exam
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
            this.examTimer = new System.Windows.Forms.Timer(this.components);
            this.finishExam = new MaterialSkin.Controls.MaterialButton();
            this.infoLabel = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // dateTimeLabel
            // 
            this.dateTimeLabel.AutoSize = true;
            this.dateTimeLabel.Depth = 0;
            this.dateTimeLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dateTimeLabel.Location = new System.Drawing.Point(3, 268);
            this.dateTimeLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.dateTimeLabel.Name = "dateTimeLabel";
            this.dateTimeLabel.Size = new System.Drawing.Size(1, 0);
            this.dateTimeLabel.TabIndex = 0;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // examTimer
            // 
            this.examTimer.Tick += new System.EventHandler(this.examTimer_Tick);
            // 
            // finishExam
            // 
            this.finishExam.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.finishExam.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.finishExam.Depth = 0;
            this.finishExam.HighEmphasis = true;
            this.finishExam.Icon = null;
            this.finishExam.Location = new System.Drawing.Point(107, 152);
            this.finishExam.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.finishExam.MouseState = MaterialSkin.MouseState.HOVER;
            this.finishExam.Name = "finishExam";
            this.finishExam.NoAccentTextColor = System.Drawing.Color.Empty;
            this.finishExam.Size = new System.Drawing.Size(107, 36);
            this.finishExam.TabIndex = 1;
            this.finishExam.Text = "Sınavı Bitir";
            this.finishExam.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.finishExam.UseAccentColor = false;
            this.finishExam.UseVisualStyleBackColor = true;
            this.finishExam.Click += new System.EventHandler(this.finishExam_Click);
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Depth = 0;
            this.infoLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.infoLabel.Location = new System.Drawing.Point(15, 127);
            this.infoLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(319, 19);
            this.infoLabel.TabIndex = 2;
            this.infoLabel.Text = "Sınavınız Bittiyse Sınav Bitir Butonuna Basın.";
            this.infoLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Exam
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(344, 288);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.finishExam);
            this.Controls.Add(this.dateTimeLabel);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_56;
            this.MaximizeBox = false;
            this.Name = "Exam";
            this.Padding = new System.Windows.Forms.Padding(3, 80, 3, 3);
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kalan Süre: ";
            this.Load += new System.EventHandler(this.Exam_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        public void reDesign()
        {
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Red400, Primary.Red500,
                Primary.Red500, Accent.Orange200,
                TextShade.WHITE
            );
        }
        #endregion

        private MaterialSkin.Controls.MaterialLabel dateTimeLabel;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Timer examTimer;
        private MaterialSkin.Controls.MaterialButton finishExam;
        private MaterialSkin.Controls.MaterialLabel infoLabel;
    }
}