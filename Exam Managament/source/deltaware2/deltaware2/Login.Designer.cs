using MaterialSkin;

namespace deltaware2
{
    partial class Login
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dateTimeLabel = new MaterialSkin.Controls.MaterialLabel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.informationButton = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // dateTimeLabel
            // 
            this.dateTimeLabel.AutoSize = true;
            this.dateTimeLabel.Depth = 0;
            this.dateTimeLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dateTimeLabel.Location = new System.Drawing.Point(6, 391);
            this.dateTimeLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.dateTimeLabel.Name = "dateTimeLabel";
            this.dateTimeLabel.Size = new System.Drawing.Size(1, 0);
            this.dateTimeLabel.TabIndex = 0;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(443, 391);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(161, 20);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Created by Team Delta";
            this.materialLabel1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto Medium", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.materialLabel2.Location = new System.Drawing.Point(6, 80);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(302, 17);
            this.materialLabel2.TabIndex = 2;
            this.materialLabel2.Text = "\"Bilgi Giriş\" butonuna basarak bilgilerinizi girin.";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.materialLabel3.Location = new System.Drawing.Point(6, 97);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(427, 17);
            this.materialLabel3.TabIndex = 2;
            this.materialLabel3.Text = "Bilgilerinizi girdikten sonra otomatik olarak  sınavınız indirilecektir.";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.materialLabel4.Location = new System.Drawing.Point(6, 114);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(347, 17);
            this.materialLabel4.TabIndex = 2;
            this.materialLabel4.Text = "Sınavınız indirildikten sonra ekran kaydı başlayacaktır.";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.FontType = MaterialSkin.MaterialSkinManager.fontType.SubtleEmphasis;
            this.materialLabel5.Location = new System.Drawing.Point(6, 131);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(52, 14);
            this.materialLabel5.TabIndex = 2;
            this.materialLabel5.Text = "Başarılar..";
            // 
            // informationButton
            // 
            this.informationButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.informationButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.informationButton.Depth = 0;
            this.informationButton.HighEmphasis = true;
            this.informationButton.Icon = null;
            this.informationButton.Location = new System.Drawing.Point(7, 151);
            this.informationButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.informationButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.informationButton.Name = "informationButton";
            this.informationButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.informationButton.Size = new System.Drawing.Size(105, 36);
            this.informationButton.TabIndex = 3;
            this.informationButton.Text = "Bilgi Giriş";
            this.informationButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.informationButton.UseAccentColor = false;
            this.informationButton.UseVisualStyleBackColor = true;
            this.informationButton.Click += new System.EventHandler(this.informationButton_Click);
            // 
            // Login
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(610, 414);
            this.Controls.Add(this.informationButton);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.dateTimeLabel);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bilgi Giriş Butonuna Basın";
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
                Primary.Orange400, Primary.Orange500,
                Primary.Orange500, Accent.Yellow200,
                TextShade.WHITE
            );
        }
        #endregion

        private MaterialSkin.Controls.MaterialLabel dateTimeLabel;
        private System.Windows.Forms.Timer timer;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialButton informationButton;
    }
}

