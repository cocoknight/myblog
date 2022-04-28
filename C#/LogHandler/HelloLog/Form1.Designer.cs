namespace HelloLog
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
            this.txtLog = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnControl = new System.Windows.Forms.Button();
            this.btnConsole = new System.Windows.Forms.Button();
            this.btnDebug = new System.Windows.Forms.Button();
            this.btnRelease = new System.Windows.Forms.Button();
            this.btnMessage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(166, 47);
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(306, 25);
            this.txtLog.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "로그:";
            // 
            // btnControl
            // 
            this.btnControl.Location = new System.Drawing.Point(166, 117);
            this.btnControl.Name = "btnControl";
            this.btnControl.Size = new System.Drawing.Size(306, 42);
            this.btnControl.TabIndex = 2;
            this.btnControl.Text = "로그 텍스트박스 출력";
            this.btnControl.UseVisualStyleBackColor = true;
            this.btnControl.Click += new System.EventHandler(this.btnControl_Click);
            // 
            // btnConsole
            // 
            this.btnConsole.Location = new System.Drawing.Point(166, 257);
            this.btnConsole.Name = "btnConsole";
            this.btnConsole.Size = new System.Drawing.Size(306, 42);
            this.btnConsole.TabIndex = 3;
            this.btnConsole.Text = "로그 콘솔\' 출력 (디버그모드 실행)";
            this.btnConsole.UseVisualStyleBackColor = true;
            this.btnConsole.Click += new System.EventHandler(this.btnConsole_Click);
            // 
            // btnDebug
            // 
            this.btnDebug.Location = new System.Drawing.Point(166, 327);
            this.btnDebug.Name = "btnDebug";
            this.btnDebug.Size = new System.Drawing.Size(306, 42);
            this.btnDebug.TabIndex = 4;
            this.btnDebug.Text = "로그 파일 출력(디버그모드 실행)";
            this.btnDebug.UseVisualStyleBackColor = true;
            this.btnDebug.Click += new System.EventHandler(this.btnDebug_Click);
            // 
            // btnRelease
            // 
            this.btnRelease.Location = new System.Drawing.Point(166, 396);
            this.btnRelease.Name = "btnRelease";
            this.btnRelease.Size = new System.Drawing.Size(306, 42);
            this.btnRelease.TabIndex = 5;
            this.btnRelease.Text = "로그 파일 출력(릴리즈모드 실행)";
            this.btnRelease.UseVisualStyleBackColor = true;
            this.btnRelease.Click += new System.EventHandler(this.btnRelease_Click);
            // 
            // btnMessage
            // 
            this.btnMessage.Location = new System.Drawing.Point(166, 190);
            this.btnMessage.Name = "btnMessage";
            this.btnMessage.Size = new System.Drawing.Size(306, 42);
            this.btnMessage.TabIndex = 6;
            this.btnMessage.Text = "로그 메시지박스 출력";
            this.btnMessage.UseVisualStyleBackColor = true;
            this.btnMessage.Click += new System.EventHandler(this.btnMessage_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 499);
            this.Controls.Add(this.btnMessage);
            this.Controls.Add(this.btnRelease);
            this.Controls.Add(this.btnDebug);
            this.Controls.Add(this.btnConsole);
            this.Controls.Add(this.btnControl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLog);
            this.Name = "Form1";
            this.Text = "로그 출력 테스트";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnControl;
        private System.Windows.Forms.Button btnConsole;
        private System.Windows.Forms.Button btnDebug;
        private System.Windows.Forms.Button btnRelease;
        private System.Windows.Forms.Button btnMessage;
    }
}

