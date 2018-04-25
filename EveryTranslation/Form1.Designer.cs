namespace EveryTranslation
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.ButtonStartRecognition = new System.Windows.Forms.Button();
            this.LabelTextRecognition = new System.Windows.Forms.Label();
            this.GroupTranslation = new System.Windows.Forms.GroupBox();
            this.LabelTextItalian = new System.Windows.Forms.Label();
            this.LabelTextSpanish = new System.Windows.Forms.Label();
            this.LabelTextGerman = new System.Windows.Forms.Label();
            this.LabelTextEnglish = new System.Windows.Forms.Label();
            this.LabelTitleItalian = new System.Windows.Forms.Label();
            this.LabelTitleSpanish = new System.Windows.Forms.Label();
            this.LabelTitleGerman = new System.Windows.Forms.Label();
            this.LabelTitleEnglish = new System.Windows.Forms.Label();
            this.ButtonStartTranslation = new System.Windows.Forms.Button();
            this.GroupTranslation.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonStartRecognition
            // 
            this.ButtonStartRecognition.Location = new System.Drawing.Point(50, 50);
            this.ButtonStartRecognition.Name = "ButtonStartRecognition";
            this.ButtonStartRecognition.Size = new System.Drawing.Size(200, 50);
            this.ButtonStartRecognition.TabIndex = 0;
            this.ButtonStartRecognition.Text = "しゃべる";
            this.ButtonStartRecognition.UseVisualStyleBackColor = true;
            this.ButtonStartRecognition.Click += new System.EventHandler(this.ButtonStartRecognition_Click);
            // 
            // LabelTextRecognition
            // 
            this.LabelTextRecognition.AutoSize = true;
            this.LabelTextRecognition.Location = new System.Drawing.Point(300, 63);
            this.LabelTextRecognition.Name = "LabelTextRecognition";
            this.LabelTextRecognition.Size = new System.Drawing.Size(318, 24);
            this.LabelTextRecognition.TabIndex = 1;
            this.LabelTextRecognition.Text = "音声認識の結果が出力されます";
            // 
            // GroupTranslation
            // 
            this.GroupTranslation.Controls.Add(this.LabelTextItalian);
            this.GroupTranslation.Controls.Add(this.LabelTextSpanish);
            this.GroupTranslation.Controls.Add(this.LabelTextGerman);
            this.GroupTranslation.Controls.Add(this.LabelTextEnglish);
            this.GroupTranslation.Controls.Add(this.LabelTitleItalian);
            this.GroupTranslation.Controls.Add(this.LabelTitleSpanish);
            this.GroupTranslation.Controls.Add(this.LabelTitleGerman);
            this.GroupTranslation.Controls.Add(this.LabelTitleEnglish);
            this.GroupTranslation.Controls.Add(this.ButtonStartTranslation);
            this.GroupTranslation.Location = new System.Drawing.Point(50, 150);
            this.GroupTranslation.Name = "GroupTranslation";
            this.GroupTranslation.Size = new System.Drawing.Size(850, 550);
            this.GroupTranslation.TabIndex = 2;
            this.GroupTranslation.TabStop = false;
            this.GroupTranslation.Text = "翻訳結果";
            // 
            // LabelTextItalian
            // 
            this.LabelTextItalian.AutoSize = true;
            this.LabelTextItalian.Location = new System.Drawing.Point(200, 450);
            this.LabelTextItalian.Name = "LabelTextItalian";
            this.LabelTextItalian.Size = new System.Drawing.Size(216, 24);
            this.LabelTextItalian.TabIndex = 8;
            this.LabelTextItalian.Text = "イタリア語の翻訳結果";
            // 
            // LabelTextSpanish
            // 
            this.LabelTextSpanish.AutoSize = true;
            this.LabelTextSpanish.Location = new System.Drawing.Point(200, 350);
            this.LabelTextSpanish.Name = "LabelTextSpanish";
            this.LabelTextSpanish.Size = new System.Drawing.Size(223, 24);
            this.LabelTextSpanish.TabIndex = 7;
            this.LabelTextSpanish.Text = "スペイン語の翻訳結果";
            // 
            // LabelTextGerman
            // 
            this.LabelTextGerman.AutoSize = true;
            this.LabelTextGerman.Location = new System.Drawing.Point(200, 250);
            this.LabelTextGerman.Name = "LabelTextGerman";
            this.LabelTextGerman.Size = new System.Drawing.Size(202, 24);
            this.LabelTextGerman.TabIndex = 6;
            this.LabelTextGerman.Text = "ドイツ語の翻訳結果";
            // 
            // LabelTextEnglish
            // 
            this.LabelTextEnglish.AutoSize = true;
            this.LabelTextEnglish.Location = new System.Drawing.Point(200, 150);
            this.LabelTextEnglish.Name = "LabelTextEnglish";
            this.LabelTextEnglish.Size = new System.Drawing.Size(174, 24);
            this.LabelTextEnglish.TabIndex = 5;
            this.LabelTextEnglish.Text = "英語の翻訳結果";
            // 
            // LabelTitleItalian
            // 
            this.LabelTitleItalian.AutoSize = true;
            this.LabelTitleItalian.Location = new System.Drawing.Point(50, 450);
            this.LabelTitleItalian.Name = "LabelTitleItalian";
            this.LabelTitleItalian.Size = new System.Drawing.Size(100, 24);
            this.LabelTitleItalian.TabIndex = 4;
            this.LabelTitleItalian.Text = "イタリア語";
            // 
            // LabelTitleSpanish
            // 
            this.LabelTitleSpanish.AutoSize = true;
            this.LabelTitleSpanish.Location = new System.Drawing.Point(50, 350);
            this.LabelTitleSpanish.Name = "LabelTitleSpanish";
            this.LabelTitleSpanish.Size = new System.Drawing.Size(107, 24);
            this.LabelTitleSpanish.TabIndex = 3;
            this.LabelTitleSpanish.Text = "スペイン語";
            // 
            // LabelTitleGerman
            // 
            this.LabelTitleGerman.AutoSize = true;
            this.LabelTitleGerman.Location = new System.Drawing.Point(50, 250);
            this.LabelTitleGerman.Name = "LabelTitleGerman";
            this.LabelTitleGerman.Size = new System.Drawing.Size(86, 24);
            this.LabelTitleGerman.TabIndex = 2;
            this.LabelTitleGerman.Text = "ドイツ語";
            // 
            // LabelTitleEnglish
            // 
            this.LabelTitleEnglish.AutoSize = true;
            this.LabelTitleEnglish.Location = new System.Drawing.Point(50, 150);
            this.LabelTitleEnglish.Name = "LabelTitleEnglish";
            this.LabelTitleEnglish.Size = new System.Drawing.Size(58, 24);
            this.LabelTitleEnglish.TabIndex = 1;
            this.LabelTitleEnglish.Text = "英語";
            // 
            // ButtonStartTranslation
            // 
            this.ButtonStartTranslation.Location = new System.Drawing.Point(50, 50);
            this.ButtonStartTranslation.Name = "ButtonStartTranslation";
            this.ButtonStartTranslation.Size = new System.Drawing.Size(200, 50);
            this.ButtonStartTranslation.TabIndex = 0;
            this.ButtonStartTranslation.Text = "あらゆる翻訳～";
            this.ButtonStartTranslation.UseVisualStyleBackColor = true;
            this.ButtonStartTranslation.Click += new System.EventHandler(this.ButtonStartTranslation_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 729);
            this.Controls.Add(this.GroupTranslation);
            this.Controls.Add(this.LabelTextRecognition);
            this.Controls.Add(this.ButtonStartRecognition);
            this.Name = "Form1";
            this.Text = "あらゆる翻訳";
            this.GroupTranslation.ResumeLayout(false);
            this.GroupTranslation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonStartRecognition;
        private System.Windows.Forms.Label LabelTextRecognition;
        private System.Windows.Forms.GroupBox GroupTranslation;
        private System.Windows.Forms.Button ButtonStartTranslation;
        private System.Windows.Forms.Label LabelTitleGerman;
        private System.Windows.Forms.Label LabelTitleEnglish;
        private System.Windows.Forms.Label LabelTitleSpanish;
        private System.Windows.Forms.Label LabelTitleItalian;
        private System.Windows.Forms.Label LabelTextEnglish;
        private System.Windows.Forms.Label LabelTextGerman;
        private System.Windows.Forms.Label LabelTextSpanish;
        private System.Windows.Forms.Label LabelTextItalian;
    }
}

