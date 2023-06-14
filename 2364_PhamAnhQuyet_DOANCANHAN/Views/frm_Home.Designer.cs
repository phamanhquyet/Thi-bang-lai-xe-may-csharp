namespace _2364_PhamAnhQuyet_DOANCANHAN
{
    partial class frm_Home
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Deso4 = new System.Windows.Forms.Button();
            this.btn_Deso3 = new System.Windows.Forms.Button();
            this.btn_Deso2 = new System.Windows.Forms.Button();
            this.btn_Deso1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_DangXuat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Deso4);
            this.groupBox1.Controls.Add(this.btn_Deso3);
            this.groupBox1.Controls.Add(this.btn_Deso2);
            this.groupBox1.Controls.Add(this.btn_Deso1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(30, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(177, 310);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn đề bài";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btn_Deso4
            // 
            this.btn_Deso4.Location = new System.Drawing.Point(34, 230);
            this.btn_Deso4.Name = "btn_Deso4";
            this.btn_Deso4.Size = new System.Drawing.Size(103, 48);
            this.btn_Deso4.TabIndex = 3;
            this.btn_Deso4.Text = "Đề số 4";
            this.btn_Deso4.UseVisualStyleBackColor = true;
            this.btn_Deso4.Click += new System.EventHandler(this.btn_Deso4_Click);
            // 
            // btn_Deso3
            // 
            this.btn_Deso3.Location = new System.Drawing.Point(34, 165);
            this.btn_Deso3.Name = "btn_Deso3";
            this.btn_Deso3.Size = new System.Drawing.Size(103, 48);
            this.btn_Deso3.TabIndex = 2;
            this.btn_Deso3.Text = "Đề số 3";
            this.btn_Deso3.UseVisualStyleBackColor = true;
            this.btn_Deso3.Click += new System.EventHandler(this.btn_Deso3_Click);
            // 
            // btn_Deso2
            // 
            this.btn_Deso2.Location = new System.Drawing.Point(34, 100);
            this.btn_Deso2.Name = "btn_Deso2";
            this.btn_Deso2.Size = new System.Drawing.Size(103, 48);
            this.btn_Deso2.TabIndex = 1;
            this.btn_Deso2.Text = "Đề số 2";
            this.btn_Deso2.UseVisualStyleBackColor = true;
            this.btn_Deso2.Click += new System.EventHandler(this.btn_Deso2_Click);
            // 
            // btn_Deso1
            // 
            this.btn_Deso1.Location = new System.Drawing.Point(34, 36);
            this.btn_Deso1.Name = "btn_Deso1";
            this.btn_Deso1.Size = new System.Drawing.Size(103, 48);
            this.btn_Deso1.TabIndex = 0;
            this.btn_Deso1.Text = "Đề số 1";
            this.btn_Deso1.UseVisualStyleBackColor = true;
            this.btn_Deso1.Click += new System.EventHandler(this.btn_Deso1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(239, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(488, 310);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lịch sử làm bài";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(476, 281);
            this.dataGridView1.TabIndex = 0;
            // 
            // btn_DangXuat
            // 
            this.btn_DangXuat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_DangXuat.Location = new System.Drawing.Point(631, 405);
            this.btn_DangXuat.Name = "btn_DangXuat";
            this.btn_DangXuat.Size = new System.Drawing.Size(90, 33);
            this.btn_DangXuat.TabIndex = 5;
            this.btn_DangXuat.Text = "Đăng Xuất";
            this.btn_DangXuat.UseVisualStyleBackColor = true;
            // 
            // frm_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 450);
            this.Controls.Add(this.btn_DangXuat);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.frm_Home_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Deso2;
        private System.Windows.Forms.Button btn_Deso1;
        private System.Windows.Forms.Button btn_Deso4;
        private System.Windows.Forms.Button btn_Deso3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_DangXuat;
    }
}