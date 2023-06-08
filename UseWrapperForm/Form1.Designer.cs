namespace UseWrapperForm
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.numValueA = new System.Windows.Forms.NumericUpDown();
            this.lbValueA = new System.Windows.Forms.Label();
            this.lbValueB = new System.Windows.Forms.Label();
            this.numValueB = new System.Windows.Forms.NumericUpDown();
            this.lbResult = new System.Windows.Forms.Label();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnSubstract = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numValueA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numValueB)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(157, 17);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "더하기";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // numValueA
            // 
            this.numValueA.Location = new System.Drawing.Point(59, 17);
            this.numValueA.Name = "numValueA";
            this.numValueA.Size = new System.Drawing.Size(73, 21);
            this.numValueA.TabIndex = 1;
            // 
            // lbValueA
            // 
            this.lbValueA.AutoSize = true;
            this.lbValueA.Location = new System.Drawing.Point(12, 21);
            this.lbValueA.Name = "lbValueA";
            this.lbValueA.Size = new System.Drawing.Size(29, 12);
            this.lbValueA.TabIndex = 2;
            this.lbValueA.Text = "값 A";
            // 
            // lbValueB
            // 
            this.lbValueB.AutoSize = true;
            this.lbValueB.Location = new System.Drawing.Point(12, 53);
            this.lbValueB.Name = "lbValueB";
            this.lbValueB.Size = new System.Drawing.Size(29, 12);
            this.lbValueB.TabIndex = 3;
            this.lbValueB.Text = "값 B";
            // 
            // numValueB
            // 
            this.numValueB.Location = new System.Drawing.Point(59, 49);
            this.numValueB.Name = "numValueB";
            this.numValueB.Size = new System.Drawing.Size(73, 21);
            this.numValueB.TabIndex = 4;
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Location = new System.Drawing.Point(12, 85);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(29, 12);
            this.lbResult.TabIndex = 5;
            this.lbResult.Text = "결과";
            // 
            // tbResult
            // 
            this.tbResult.Location = new System.Drawing.Point(59, 81);
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(73, 21);
            this.tbResult.TabIndex = 6;
            // 
            // btnMultiply
            // 
            this.btnMultiply.Location = new System.Drawing.Point(157, 53);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(75, 23);
            this.btnMultiply.TabIndex = 7;
            this.btnMultiply.Text = "곱하기";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // btnSubstract
            // 
            this.btnSubstract.Location = new System.Drawing.Point(243, 17);
            this.btnSubstract.Name = "btnSubstract";
            this.btnSubstract.Size = new System.Drawing.Size(75, 23);
            this.btnSubstract.TabIndex = 8;
            this.btnSubstract.Text = "빼기";
            this.btnSubstract.UseVisualStyleBackColor = true;
            this.btnSubstract.Click += new System.EventHandler(this.btnSubstract_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.Location = new System.Drawing.Point(243, 53);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(75, 23);
            this.btnDivide.TabIndex = 9;
            this.btnDivide.Text = "나누기";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(157, 111);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(161, 23);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "닫기";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 146);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnSubstract);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.numValueB);
            this.Controls.Add(this.lbValueB);
            this.Controls.Add(this.lbValueA);
            this.Controls.Add(this.numValueA);
            this.Controls.Add(this.btnAdd);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numValueA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numValueB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.NumericUpDown numValueA;
        private System.Windows.Forms.Label lbValueA;
        private System.Windows.Forms.Label lbValueB;
        private System.Windows.Forms.NumericUpDown numValueB;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnSubstract;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnClose;
    }
}

