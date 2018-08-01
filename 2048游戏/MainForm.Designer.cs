namespace _2048游戏
{
    partial class MainForm
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Start = new System.Windows.Forms.Button();
            this.Tips = new System.Windows.Forms.Label();
            this.Label2048 = new System.Windows.Forms.Label();
            this.Dont = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.Color.Transparent;
            this.Start.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.Start.FlatAppearance.BorderSize = 2;
            this.Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Start.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start.ForeColor = System.Drawing.Color.LightCoral;
            this.Start.Location = new System.Drawing.Point(260, 340);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(148, 55);
            this.Start.TabIndex = 0;
            this.Start.Tag = "20";
            this.Start.Text = "开始";
            this.Start.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.StartClick);
            // 
            // Tips
            // 
            this.Tips.AutoSize = true;
            this.Tips.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tips.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Tips.Location = new System.Drawing.Point(260, 422);
            this.Tips.Name = "Tips";
            this.Tips.Size = new System.Drawing.Size(148, 27);
            this.Tips.TabIndex = 1;
            this.Tips.Text = "Click it to start";
            // 
            // Label2048
            // 
            this.Label2048.AutoSize = true;
            this.Label2048.BackColor = System.Drawing.Color.Transparent;
            this.Label2048.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label2048.ForeColor = System.Drawing.Color.LightCoral;
            this.Label2048.Location = new System.Drawing.Point(125, 114);
            this.Label2048.Name = "Label2048";
            this.Label2048.Size = new System.Drawing.Size(421, 135);
            this.Label2048.TabIndex = 2;
            this.Label2048.Text = "2 0 4 8";
            // 
            // Dont
            // 
            this.Dont.AutoSize = true;
            this.Dont.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Dont.ForeColor = System.Drawing.Color.Black;
            this.Dont.Location = new System.Drawing.Point(0, 640);
            this.Dont.Name = "Dont";
            this.Dont.Size = new System.Drawing.Size(36, 18);
            this.Dont.TabIndex = 4;
            this.Dont.Text = "Tips";
            this.Dont.Click += new System.EventHandler(this.HelpsClick);
            // 
            // Exit
            // 
            this.Exit.AutoSize = true;
            this.Exit.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Exit.ForeColor = System.Drawing.Color.Black;
            this.Exit.Location = new System.Drawing.Point(643, 636);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(35, 20);
            this.Exit.TabIndex = 5;
            this.Exit.Text = "Exit";
            this.Exit.Click += new System.EventHandler(this.ExitClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(688, 665);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Dont);
            this.Controls.Add(this.Label2048);
            this.Controls.Add(this.Tips);
            this.Controls.Add(this.Start);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainForm";
            this.Text = "2048";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainFormKeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Label Tips;
        private System.Windows.Forms.Label Label2048;
        private System.Windows.Forms.Label Dont;
        private System.Windows.Forms.Label Exit;
    }
}

