
namespace QuanLyDoanVien
{
    partial class fChiDoan
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
            this.dtgChiDoan = new System.Windows.Forms.DataGridView();
            this.btnCD = new System.Windows.Forms.Button();
            this.btnSuaCD = new System.Windows.Forms.Button();
            this.btnXoaCD = new System.Windows.Forms.Button();
            this.btnThoatCD = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMCD = new System.Windows.Forms.TextBox();
            this.txtTCD = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgChiDoan)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgChiDoan
            // 
            this.dtgChiDoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgChiDoan.Location = new System.Drawing.Point(0, 367);
            this.dtgChiDoan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtgChiDoan.Name = "dtgChiDoan";
            this.dtgChiDoan.RowHeadersWidth = 51;
            this.dtgChiDoan.RowTemplate.Height = 24;
            this.dtgChiDoan.Size = new System.Drawing.Size(1000, 196);
            this.dtgChiDoan.TabIndex = 0;
            // 
            // btnCD
            // 
            this.btnCD.Location = new System.Drawing.Point(43, 324);
            this.btnCD.Name = "btnCD";
            this.btnCD.Size = new System.Drawing.Size(173, 36);
            this.btnCD.TabIndex = 1;
            this.btnCD.Text = "Thêm Chi Đoàn";
            this.btnCD.UseVisualStyleBackColor = true;
            this.btnCD.Click += new System.EventHandler(this.btnCD_Click);
            // 
            // btnSuaCD
            // 
            this.btnSuaCD.Location = new System.Drawing.Point(287, 324);
            this.btnSuaCD.Name = "btnSuaCD";
            this.btnSuaCD.Size = new System.Drawing.Size(173, 36);
            this.btnSuaCD.TabIndex = 2;
            this.btnSuaCD.Text = "Sửa Chi Đoàn";
            this.btnSuaCD.UseVisualStyleBackColor = true;
            this.btnSuaCD.Click += new System.EventHandler(this.btnSuaCD_Click);
            // 
            // btnXoaCD
            // 
            this.btnXoaCD.Location = new System.Drawing.Point(531, 324);
            this.btnXoaCD.Name = "btnXoaCD";
            this.btnXoaCD.Size = new System.Drawing.Size(173, 36);
            this.btnXoaCD.TabIndex = 3;
            this.btnXoaCD.Text = "Xóa Chi Đoàn";
            this.btnXoaCD.UseVisualStyleBackColor = true;
            this.btnXoaCD.Click += new System.EventHandler(this.btnXoaCD_Click);
            // 
            // btnThoatCD
            // 
            this.btnThoatCD.Location = new System.Drawing.Point(774, 324);
            this.btnThoatCD.Name = "btnThoatCD";
            this.btnThoatCD.Size = new System.Drawing.Size(173, 36);
            this.btnThoatCD.TabIndex = 4;
            this.btnThoatCD.Text = "Thoát Chi Đoàn";
            this.btnThoatCD.UseVisualStyleBackColor = true;
            this.btnThoatCD.Click += new System.EventHandler(this.btnThoatCD_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mã Chi Đoàn";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tên Chi Đoàn";
            // 
            // txtMCD
            // 
            this.txtMCD.Location = new System.Drawing.Point(287, 109);
            this.txtMCD.Name = "txtMCD";
            this.txtMCD.Size = new System.Drawing.Size(268, 28);
            this.txtMCD.TabIndex = 7;
            this.txtMCD.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtTCD
            // 
            this.txtTCD.Location = new System.Drawing.Point(287, 165);
            this.txtTCD.Name = "txtTCD";
            this.txtTCD.Size = new System.Drawing.Size(268, 28);
            this.txtTCD.TabIndex = 8;
            // 
            // fChiDoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.txtTCD);
            this.Controls.Add(this.txtMCD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnThoatCD);
            this.Controls.Add(this.btnXoaCD);
            this.Controls.Add(this.btnSuaCD);
            this.Controls.Add(this.btnCD);
            this.Controls.Add(this.dtgChiDoan);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "fChiDoan";
            this.Text = "Chi Doan";
            this.Load += new System.EventHandler(this.fChiDoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgChiDoan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgChiDoan;
        private System.Windows.Forms.Button btnCD;
        private System.Windows.Forms.Button btnSuaCD;
        private System.Windows.Forms.Button btnXoaCD;
        private System.Windows.Forms.Button btnThoatCD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMCD;
        private System.Windows.Forms.TextBox txtTCD;
    }
}

