
namespace List_Detail
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tboxDataInsert = new System.Windows.Forms.TextBox();
            this.numPosition = new System.Windows.Forms.NumericUpDown();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lboxNo = new System.Windows.Forms.ListBox();
            this.lboxList = new System.Windows.Forms.ListBox();
            this.lboxChangeList = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tboxChangeOld = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tboxChangeNew = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.tboxDetail_Change = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tboxDetail = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnChange = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numPosition)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "입력값";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "위치";
            // 
            // tboxDataInsert
            // 
            this.tboxDataInsert.Location = new System.Drawing.Point(64, 18);
            this.tboxDataInsert.Name = "tboxDataInsert";
            this.tboxDataInsert.Size = new System.Drawing.Size(152, 25);
            this.tboxDataInsert.TabIndex = 2;
            // 
            // numPosition
            // 
            this.numPosition.Location = new System.Drawing.Point(64, 67);
            this.numPosition.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numPosition.Name = "numPosition";
            this.numPosition.Size = new System.Drawing.Size(73, 25);
            this.numPosition.TabIndex = 3;
            this.numPosition.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(16, 114);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 31);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "추가";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(124, 114);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(92, 31);
            this.btnRemove.TabIndex = 5;
            this.btnRemove.Text = "삭제";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "원본List";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(254, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 15);
            this.label4.TabIndex = 7;
            // 
            // lboxNo
            // 
            this.lboxNo.FormattingEnabled = true;
            this.lboxNo.ItemHeight = 15;
            this.lboxNo.Location = new System.Drawing.Point(16, 226);
            this.lboxNo.Name = "lboxNo";
            this.lboxNo.Size = new System.Drawing.Size(42, 259);
            this.lboxNo.TabIndex = 8;
            // 
            // lboxList
            // 
            this.lboxList.FormattingEnabled = true;
            this.lboxList.ItemHeight = 15;
            this.lboxList.Location = new System.Drawing.Point(64, 226);
            this.lboxList.Name = "lboxList";
            this.lboxList.Size = new System.Drawing.Size(177, 259);
            this.lboxList.TabIndex = 9;
            // 
            // lboxChangeList
            // 
            this.lboxChangeList.FormattingEnabled = true;
            this.lboxChangeList.ItemHeight = 15;
            this.lboxChangeList.Location = new System.Drawing.Point(257, 226);
            this.lboxChangeList.Name = "lboxChangeList";
            this.lboxChangeList.Size = new System.Drawing.Size(177, 259);
            this.lboxChangeList.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(254, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "검색";
            // 
            // tboxChangeOld
            // 
            this.tboxChangeOld.Location = new System.Drawing.Point(305, 18);
            this.tboxChangeOld.Name = "tboxChangeOld";
            this.tboxChangeOld.Size = new System.Drawing.Size(129, 25);
            this.tboxChangeOld.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(254, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "수정값";
            // 
            // tboxChangeNew
            // 
            this.tboxChangeNew.Location = new System.Drawing.Point(305, 66);
            this.tboxChangeNew.Name = "tboxChangeNew";
            this.tboxChangeNew.Size = new System.Drawing.Size(129, 25);
            this.tboxChangeNew.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Location = new System.Drawing.Point(451, 16);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(3, 469);
            this.panel1.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(468, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "원본List_Detail";
            // 
            // tboxDetail_Change
            // 
            this.tboxDetail_Change.Location = new System.Drawing.Point(471, 285);
            this.tboxDetail_Change.Multiline = true;
            this.tboxDetail_Change.Name = "tboxDetail_Change";
            this.tboxDetail_Change.Size = new System.Drawing.Size(231, 200);
            this.tboxDetail_Change.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(468, 258);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 15);
            this.label8.TabIndex = 18;
            this.label8.Text = "수정List_Detail";
            // 
            // tboxDetail
            // 
            this.tboxDetail.Location = new System.Drawing.Point(471, 45);
            this.tboxDetail.Multiline = true;
            this.tboxDetail.Name = "tboxDetail";
            this.tboxDetail.Size = new System.Drawing.Size(231, 200);
            this.tboxDetail.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(254, 195);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 15);
            this.label9.TabIndex = 21;
            this.label9.Text = "수정List";
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(305, 114);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(92, 31);
            this.btnChange.TabIndex = 22;
            this.btnChange.Text = "변경";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 501);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tboxDetail);
            this.Controls.Add(this.tboxDetail_Change);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tboxChangeNew);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tboxChangeOld);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lboxChangeList);
            this.Controls.Add(this.lboxList);
            this.Controls.Add(this.lboxNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.numPosition);
            this.Controls.Add(this.tboxDataInsert);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numPosition)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tboxDataInsert;
        private System.Windows.Forms.NumericUpDown numPosition;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lboxNo;
        private System.Windows.Forms.ListBox lboxList;
        private System.Windows.Forms.ListBox lboxChangeList;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tboxChangeOld;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tboxChangeNew;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tboxDetail_Change;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tboxDetail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnChange;
    }
}

