namespace CurrencyConverterApp
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
            this.FromConvertText = new System.Windows.Forms.TextBox();
            this.ToConvertText = new System.Windows.Forms.TextBox();
            this.ConversionRateLbl = new System.Windows.Forms.Label();
            this.SwapBtn = new System.Windows.Forms.Button();
            this.FromCurrency = new System.Windows.Forms.ComboBox();
            this.ToCurrency = new System.Windows.Forms.ComboBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse4 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RefreshBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuElipse5 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // FromConvertText
            // 
            this.FromConvertText.BackColor = System.Drawing.Color.White;
            this.FromConvertText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FromConvertText.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FromConvertText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FromConvertText.Location = new System.Drawing.Point(89, 168);
            this.FromConvertText.Name = "FromConvertText";
            this.FromConvertText.Size = new System.Drawing.Size(254, 37);
            this.FromConvertText.TabIndex = 0;
            this.FromConvertText.TextChanged += new System.EventHandler(this.FromConvertText_TextChanged);
            this.FromConvertText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FromConvertText_KeyPress);
            // 
            // ToConvertText
            // 
            this.ToConvertText.BackColor = System.Drawing.Color.White;
            this.ToConvertText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ToConvertText.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToConvertText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ToConvertText.Location = new System.Drawing.Point(502, 168);
            this.ToConvertText.Name = "ToConvertText";
            this.ToConvertText.ReadOnly = true;
            this.ToConvertText.Size = new System.Drawing.Size(254, 37);
            this.ToConvertText.TabIndex = 1;
            this.ToConvertText.TextChanged += new System.EventHandler(this.ToConvertText_TextChanged);
            this.ToConvertText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ToConvertText_KeyPress);
            // 
            // ConversionRateLbl
            // 
            this.ConversionRateLbl.AutoSize = true;
            this.ConversionRateLbl.BackColor = System.Drawing.Color.Transparent;
            this.ConversionRateLbl.Font = new System.Drawing.Font("Roboto Lt", 11F);
            this.ConversionRateLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ConversionRateLbl.Location = new System.Drawing.Point(362, 400);
            this.ConversionRateLbl.Name = "ConversionRateLbl";
            this.ConversionRateLbl.Size = new System.Drawing.Size(63, 23);
            this.ConversionRateLbl.TabIndex = 2;
            this.ConversionRateLbl.Text = "Result";
            // 
            // SwapBtn
            // 
            this.SwapBtn.BackColor = System.Drawing.Color.White;
            this.SwapBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SwapBtn.BackgroundImage")));
            this.SwapBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SwapBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.SwapBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SwapBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.SwapBtn.Location = new System.Drawing.Point(388, 197);
            this.SwapBtn.Name = "SwapBtn";
            this.SwapBtn.Size = new System.Drawing.Size(84, 53);
            this.SwapBtn.TabIndex = 3;
            this.SwapBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.SwapBtn.UseVisualStyleBackColor = false;
            this.SwapBtn.Click += new System.EventHandler(this.SwapBtn_Click);
            // 
            // FromCurrency
            // 
            this.FromCurrency.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FromCurrency.Font = new System.Drawing.Font("Roboto", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FromCurrency.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FromCurrency.FormattingEnabled = true;
            this.FromCurrency.Location = new System.Drawing.Point(89, 237);
            this.FromCurrency.MaxDropDownItems = 40;
            this.FromCurrency.Name = "FromCurrency";
            this.FromCurrency.Size = new System.Drawing.Size(254, 41);
            this.FromCurrency.TabIndex = 4;
            this.FromCurrency.SelectedIndexChanged += new System.EventHandler(this.FromCurrency_SelectedIndexChanged_1);
            // 
            // ToCurrency
            // 
            this.ToCurrency.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ToCurrency.Font = new System.Drawing.Font("Roboto", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToCurrency.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ToCurrency.FormattingEnabled = true;
            this.ToCurrency.Location = new System.Drawing.Point(502, 237);
            this.ToCurrency.MaxDropDownItems = 40;
            this.ToCurrency.Name = "ToCurrency";
            this.ToCurrency.Size = new System.Drawing.Size(254, 41);
            this.ToCurrency.TabIndex = 5;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 20;
            this.bunifuElipse2.TargetControl = this.FromConvertText;
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 20;
            this.bunifuElipse3.TargetControl = this.ToConvertText;
            // 
            // bunifuElipse4
            // 
            this.bunifuElipse4.ElipseRadius = 30;
            this.bunifuElipse4.TargetControl = this.SwapBtn;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Roboto Lt", 11F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(180, 400);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Conversion Rate:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Roboto", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(247, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(395, 41);
            this.label2.TabIndex = 7;
            this.label2.Text = "CURRENCY CONVERTER";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(303, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(311, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Convert your currency in real-time";
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.Activecolor = System.Drawing.Color.LightGray;
            this.RefreshBtn.BackColor = System.Drawing.SystemColors.Control;
            this.RefreshBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RefreshBtn.BorderRadius = 0;
            this.RefreshBtn.ButtonText = "Refresh";
            this.RefreshBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RefreshBtn.DisabledColor = System.Drawing.Color.Gray;
            this.RefreshBtn.ForeColor = System.Drawing.Color.Gray;
            this.RefreshBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.RefreshBtn.Iconimage = null;
            this.RefreshBtn.Iconimage_right = null;
            this.RefreshBtn.Iconimage_right_Selected = null;
            this.RefreshBtn.Iconimage_Selected = null;
            this.RefreshBtn.IconMarginLeft = 0;
            this.RefreshBtn.IconMarginRight = 0;
            this.RefreshBtn.IconRightVisible = true;
            this.RefreshBtn.IconRightZoom = 0D;
            this.RefreshBtn.IconVisible = true;
            this.RefreshBtn.IconZoom = 90D;
            this.RefreshBtn.IsTab = false;
            this.RefreshBtn.Location = new System.Drawing.Point(346, 307);
            this.RefreshBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Normalcolor = System.Drawing.SystemColors.Control;
            this.RefreshBtn.OnHovercolor = System.Drawing.Color.Silver;
            this.RefreshBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.RefreshBtn.selected = false;
            this.RefreshBtn.Size = new System.Drawing.Size(174, 52);
            this.RefreshBtn.TabIndex = 9;
            this.RefreshBtn.Text = "Refresh";
            this.RefreshBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RefreshBtn.Textcolor = System.Drawing.Color.DimGray;
            this.RefreshBtn.TextFont = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // bunifuElipse5
            // 
            this.bunifuElipse5.ElipseRadius = 30;
            this.bunifuElipse5.TargetControl = this.RefreshBtn;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(806, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(758, 42);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 4);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(871, 493);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.RefreshBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ToCurrency);
            this.Controls.Add(this.FromCurrency);
            this.Controls.Add(this.SwapBtn);
            this.Controls.Add(this.ConversionRateLbl);
            this.Controls.Add(this.ToConvertText);
            this.Controls.Add(this.FromConvertText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CurrencyConverter";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FromConvertText;
        private System.Windows.Forms.TextBox ToConvertText;
        private System.Windows.Forms.Label ConversionRateLbl;
        private System.Windows.Forms.ComboBox FromCurrency;
        private System.Windows.Forms.ComboBox ToCurrency;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse4;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button SwapBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuFlatButton RefreshBtn;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

