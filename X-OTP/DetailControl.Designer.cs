namespace XOTP
{
    partial class DetailControl
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            label_CaptchaOutput = new Label();
            label_timeOutput = new Label();
            button_delete = new Button();
            label_TotpHashMode = new Label();
            comboBox_OtpHashMode = new ComboBox();
            label_Username = new Label();
            textBox_Username = new TextBox();
            label_Corp = new Label();
            textBox_Corp = new TextBox();
            numericUpDown_step = new NumericUpDown();
            label_step = new Label();
            label_secret_key = new Label();
            textBox_secret_key = new TextBox();
            button_copy = new Button();
            button_save = new Button();
            label_time = new Label();
            label_Captcha = new Label();
            timer_Otp = new System.Windows.Forms.Timer(components);
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_step).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label_CaptchaOutput);
            groupBox1.Controls.Add(label_timeOutput);
            groupBox1.Controls.Add(button_delete);
            groupBox1.Controls.Add(label_TotpHashMode);
            groupBox1.Controls.Add(comboBox_OtpHashMode);
            groupBox1.Controls.Add(label_Username);
            groupBox1.Controls.Add(textBox_Username);
            groupBox1.Controls.Add(label_Corp);
            groupBox1.Controls.Add(textBox_Corp);
            groupBox1.Controls.Add(numericUpDown_step);
            groupBox1.Controls.Add(label_step);
            groupBox1.Controls.Add(label_secret_key);
            groupBox1.Controls.Add(textBox_secret_key);
            groupBox1.Controls.Add(button_copy);
            groupBox1.Controls.Add(button_save);
            groupBox1.Controls.Add(label_time);
            groupBox1.Controls.Add(label_Captcha);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(538, 690);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "详情";
            // 
            // label_CaptchaOutput
            // 
            label_CaptchaOutput.BackColor = SystemColors.Control;
            label_CaptchaOutput.BorderStyle = BorderStyle.FixedSingle;
            label_CaptchaOutput.Cursor = Cursors.Hand;
            label_CaptchaOutput.Font = new Font("Microsoft YaHei UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label_CaptchaOutput.Location = new Point(21, 78);
            label_CaptchaOutput.Name = "label_CaptchaOutput";
            label_CaptchaOutput.Size = new Size(212, 58);
            label_CaptchaOutput.TabIndex = 32;
            label_CaptchaOutput.Text = "999999";
            label_CaptchaOutput.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label_timeOutput
            // 
            label_timeOutput.BackColor = SystemColors.Control;
            label_timeOutput.BorderStyle = BorderStyle.FixedSingle;
            label_timeOutput.Cursor = Cursors.Hand;
            label_timeOutput.Font = new Font("Microsoft YaHei UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label_timeOutput.Location = new Point(21, 190);
            label_timeOutput.Name = "label_timeOutput";
            label_timeOutput.Size = new Size(212, 58);
            label_timeOutput.TabIndex = 31;
            label_timeOutput.Text = "120";
            label_timeOutput.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button_delete
            // 
            button_delete.Location = new Point(340, 609);
            button_delete.Name = "button_delete";
            button_delete.Size = new Size(131, 55);
            button_delete.TabIndex = 29;
            button_delete.Text = "删除";
            button_delete.UseVisualStyleBackColor = true;
            button_delete.Click += button_delete_Click;
            // 
            // label_TotpHashMode
            // 
            label_TotpHashMode.AutoSize = true;
            label_TotpHashMode.Location = new Point(301, 154);
            label_TotpHashMode.Name = "label_TotpHashMode";
            label_TotpHashMode.Size = new Size(54, 20);
            label_TotpHashMode.TabIndex = 28;
            label_TotpHashMode.Text = "算法：";
            // 
            // comboBox_OtpHashMode
            // 
            comboBox_OtpHashMode.Font = new Font("Microsoft YaHei UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox_OtpHashMode.FormattingEnabled = true;
            comboBox_OtpHashMode.Location = new Point(301, 190);
            comboBox_OtpHashMode.Name = "comboBox_OtpHashMode";
            comboBox_OtpHashMode.Size = new Size(170, 43);
            comboBox_OtpHashMode.TabIndex = 27;
            // 
            // label_Username
            // 
            label_Username.AutoSize = true;
            label_Username.Location = new Point(21, 375);
            label_Username.Name = "label_Username";
            label_Username.Size = new Size(69, 20);
            label_Username.TabIndex = 26;
            label_Username.Text = "用户名：";
            // 
            // textBox_Username
            // 
            textBox_Username.BorderStyle = BorderStyle.FixedSingle;
            textBox_Username.Font = new Font("Microsoft YaHei UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_Username.Location = new Point(21, 411);
            textBox_Username.Name = "textBox_Username";
            textBox_Username.Size = new Size(450, 41);
            textBox_Username.TabIndex = 25;
            textBox_Username.TextAlign = HorizontalAlignment.Center;
            // 
            // label_Corp
            // 
            label_Corp.AutoSize = true;
            label_Corp.Location = new Point(21, 270);
            label_Corp.Name = "label_Corp";
            label_Corp.Size = new Size(69, 20);
            label_Corp.TabIndex = 24;
            label_Corp.Text = "发行方：";
            // 
            // textBox_Corp
            // 
            textBox_Corp.BorderStyle = BorderStyle.FixedSingle;
            textBox_Corp.Font = new Font("Microsoft YaHei UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_Corp.Location = new Point(21, 309);
            textBox_Corp.Name = "textBox_Corp";
            textBox_Corp.Size = new Size(450, 41);
            textBox_Corp.TabIndex = 23;
            textBox_Corp.TextAlign = HorizontalAlignment.Center;
            // 
            // numericUpDown_step
            // 
            numericUpDown_step.BorderStyle = BorderStyle.None;
            numericUpDown_step.Font = new Font("Microsoft YaHei UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDown_step.Location = new Point(21, 627);
            numericUpDown_step.Maximum = new decimal(new int[] { -1, -1, -1, 0 });
            numericUpDown_step.Name = "numericUpDown_step";
            numericUpDown_step.Size = new Size(150, 37);
            numericUpDown_step.TabIndex = 22;
            numericUpDown_step.TextAlign = HorizontalAlignment.Center;
            numericUpDown_step.Value = new decimal(new int[] { 120, 0, 0, 0 });
            // 
            // label_step
            // 
            label_step.AutoSize = true;
            label_step.Location = new Point(21, 583);
            label_step.Name = "label_step";
            label_step.Size = new Size(58, 20);
            label_step.TabIndex = 21;
            label_step.Text = "Step：";
            // 
            // label_secret_key
            // 
            label_secret_key.AutoSize = true;
            label_secret_key.Location = new Point(21, 463);
            label_secret_key.Name = "label_secret_key";
            label_secret_key.Size = new Size(102, 20);
            label_secret_key.TabIndex = 20;
            label_secret_key.Text = "Secret Key：";
            // 
            // textBox_secret_key
            // 
            textBox_secret_key.BorderStyle = BorderStyle.FixedSingle;
            textBox_secret_key.Font = new Font("Microsoft YaHei UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_secret_key.Location = new Point(21, 502);
            textBox_secret_key.Name = "textBox_secret_key";
            textBox_secret_key.PasswordChar = '*';
            textBox_secret_key.Size = new Size(450, 41);
            textBox_secret_key.TabIndex = 19;
            textBox_secret_key.TextAlign = HorizontalAlignment.Center;
            textBox_secret_key.Enter += textBox_secret_key_Enter;
            textBox_secret_key.Leave += textBox_secret_key_Leave;
            // 
            // button_copy
            // 
            button_copy.Location = new Point(301, 78);
            button_copy.Name = "button_copy";
            button_copy.Size = new Size(170, 58);
            button_copy.TabIndex = 17;
            button_copy.Text = "复制";
            button_copy.UseVisualStyleBackColor = true;
            button_copy.Click += button_copy_Click;
            button_copy.MouseLeave += button_copy_MouseLeave;
            // 
            // button_save
            // 
            button_save.Location = new Point(182, 609);
            button_save.Name = "button_save";
            button_save.Size = new Size(141, 55);
            button_save.TabIndex = 16;
            button_save.Text = "保存";
            button_save.UseVisualStyleBackColor = true;
            button_save.Click += button_save_Click;
            // 
            // label_time
            // 
            label_time.AutoSize = true;
            label_time.Location = new Point(21, 154);
            label_time.Name = "label_time";
            label_time.Size = new Size(69, 20);
            label_time.TabIndex = 15;
            label_time.Text = "倒计时：";
            // 
            // label_Captcha
            // 
            label_Captcha.AutoSize = true;
            label_Captcha.Location = new Point(21, 43);
            label_Captcha.Name = "label_Captcha";
            label_Captcha.Size = new Size(69, 20);
            label_Captcha.TabIndex = 13;
            label_Captcha.Text = "验证码：";
            // 
            // timer_Otp
            // 
            timer_Otp.Enabled = true;
            timer_Otp.Interval = 1000;
            timer_Otp.Tick += timer_Otp_Tick;
            // 
            // DetailControl
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Name = "DetailControl";
            Size = new Size(547, 700);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_step).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button button_delete;
        private Label label_TotpHashMode;
        private ComboBox comboBox_OtpHashMode;
        private Label label_Username;
        private TextBox textBox_Username;
        private Label label_Corp;
        private TextBox textBox_Corp;
        private NumericUpDown numericUpDown_step;
        private Label label_step;
        private Label label_secret_key;
        private TextBox textBox_secret_key;
        private Button button_copy;
        private Button button_save;
        private Label label_time;
        private Label label_Captcha;
        private System.Windows.Forms.Timer timer_Otp;
        private Label label_timeOutput;
        private Label label_CaptchaOutput;
    }
}
