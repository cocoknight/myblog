namespace HelloWorker
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmdStart = new System.Windows.Forms.Button();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.cmdHello = new System.Windows.Forms.Button();
            this.cmdNotWorker = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdStart
            // 
            this.cmdStart.Location = new System.Drawing.Point(61, 70);
            this.cmdStart.Name = "cmdStart";
            this.cmdStart.Size = new System.Drawing.Size(169, 36);
            this.cmdStart.TabIndex = 2;
            this.cmdStart.Text = "Start Worker";
            this.cmdStart.UseVisualStyleBackColor = true;
            this.cmdStart.Click += new System.EventHandler(this.cmdStart_Click);
            // 
            // cmdCancel
            // 
            this.cmdCancel.Location = new System.Drawing.Point(500, 70);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(169, 36);
            this.cmdCancel.TabIndex = 3;
            this.cmdCancel.Text = "Cancel Worker";
            this.cmdCancel.UseVisualStyleBackColor = true;
            // 
            // cmdHello
            // 
            this.cmdHello.Location = new System.Drawing.Point(712, 72);
            this.cmdHello.Name = "cmdHello";
            this.cmdHello.Size = new System.Drawing.Size(160, 34);
            this.cmdHello.TabIndex = 4;
            this.cmdHello.Text = "Hello Me";
            this.cmdHello.UseVisualStyleBackColor = true;
            this.cmdHello.Click += new System.EventHandler(this.cmdHello_Click);
            // 
            // cmdNotWorker
            // 
            this.cmdNotWorker.Location = new System.Drawing.Point(282, 70);
            this.cmdNotWorker.Name = "cmdNotWorker";
            this.cmdNotWorker.Size = new System.Drawing.Size(169, 36);
            this.cmdNotWorker.TabIndex = 5;
            this.cmdNotWorker.Text = "Without Worker";
            this.cmdNotWorker.UseVisualStyleBackColor = true;
            this.cmdNotWorker.Click += new System.EventHandler(this.cmdNotWorker_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 173);
            this.Controls.Add(this.cmdNotWorker);
            this.Controls.Add(this.cmdHello);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdStart);
            this.Name = "Form1";
            this.Text = "Hello Worker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button cmdStart;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Button cmdHello;
        private System.Windows.Forms.Button cmdNotWorker;
    }
}

