namespace FormsTarget
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
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
            this._buttonModaless = new System.Windows.Forms.Button();
            this._buttonModal = new System.Windows.Forms.Button();
            this._buttonModalCatena = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _buttonModaless
            // 
            this._buttonModaless.Location = new System.Drawing.Point(12, 12);
            this._buttonModaless.Name = "_buttonModaless";
            this._buttonModaless.Size = new System.Drawing.Size(75, 23);
            this._buttonModaless.TabIndex = 0;
            this._buttonModaless.Text = "モーダレス";
            this._buttonModaless.UseVisualStyleBackColor = true;
            this._buttonModaless.Click += new System.EventHandler(this.ButtonModalessClick);
            // 
            // _buttonModal
            // 
            this._buttonModal.Location = new System.Drawing.Point(93, 12);
            this._buttonModal.Name = "_buttonModal";
            this._buttonModal.Size = new System.Drawing.Size(75, 23);
            this._buttonModal.TabIndex = 1;
            this._buttonModal.Text = "モーダル";
            this._buttonModal.UseVisualStyleBackColor = true;
            this._buttonModal.Click += new System.EventHandler(this.ButtonModalClick);
            // 
            // _buttonModalCatena
            // 
            this._buttonModalCatena.Location = new System.Drawing.Point(174, 12);
            this._buttonModalCatena.Name = "_buttonModalCatena";
            this._buttonModalCatena.Size = new System.Drawing.Size(75, 23);
            this._buttonModalCatena.TabIndex = 2;
            this._buttonModalCatena.Text = "モーダル連続";
            this._buttonModalCatena.UseVisualStyleBackColor = true;
            this._buttonModalCatena.Click += new System.EventHandler(this.ButtonModalCatenaClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 50);
            this.Controls.Add(this._buttonModalCatena);
            this.Controls.Add(this._buttonModal);
            this.Controls.Add(this._buttonModaless);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _buttonModaless;
        private System.Windows.Forms.Button _buttonModal;
        private System.Windows.Forms.Button _buttonModalCatena;
    }
}

