namespace Ex1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnX2 = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblNumber = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Play = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.menuBG = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.randomLabel = new System.Windows.Forms.Label();
            this.btnUndo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(498, 42);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(166, 56);
            this.btnPlus.TabIndex = 0;
            this.btnPlus.Text = "+1";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnX2
            // 
            this.btnX2.Location = new System.Drawing.Point(498, 147);
            this.btnX2.Name = "btnX2";
            this.btnX2.Size = new System.Drawing.Size(166, 56);
            this.btnX2.TabIndex = 1;
            this.btnX2.Text = "x2";
            this.btnX2.UseVisualStyleBackColor = true;
            this.btnX2.Click += new System.EventHandler(this.btnX2_Click_1);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(498, 364);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(166, 56);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Сброс";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click_1);
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNumber.Location = new System.Drawing.Point(265, 224);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(70, 76);
            this.lblNumber.TabIndex = 3;
            this.lblNumber.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 395);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Кол-во отданных команд";
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCount.Location = new System.Drawing.Point(121, 439);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(23, 25);
            this.labelCount.TabIndex = 5;
            this.labelCount.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(200, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 46);
            this.label2.TabIndex = 6;
            this.label2.Text = "Значение";
            // 
            // Play
            // 
            this.Play.BackColor = System.Drawing.Color.Turquoise;
            this.Play.Font = new System.Drawing.Font("Marlett", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Play.Location = new System.Drawing.Point(256, 147);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(236, 82);
            this.Play.TabIndex = 8;
            this.Play.Text = "START";
            this.Play.UseVisualStyleBackColor = false;
            this.Play.Click += new System.EventHandler(this.Play_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.LightCoral;
            this.exit.Location = new System.Drawing.Point(308, 247);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(138, 56);
            this.exit.TabIndex = 9;
            this.exit.Text = "EXIT";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // menuBG
            // 
            this.menuBG.BackColor = System.Drawing.Color.FloralWhite;
            this.menuBG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuBG.Location = new System.Drawing.Point(0, 0);
            this.menuBG.Name = "menuBG";
            this.menuBG.Size = new System.Drawing.Size(744, 483);
            this.menuBG.TabIndex = 7;
            this.menuBG.Click += new System.EventHandler(this.menuBG_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(24, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 46);
            this.label3.TabIndex = 10;
            this.label3.Text = "Цель:";
            // 
            // randomLabel
            // 
            this.randomLabel.AutoSize = true;
            this.randomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.randomLabel.Location = new System.Drawing.Point(179, 19);
            this.randomLabel.Name = "randomLabel";
            this.randomLabel.Size = new System.Drawing.Size(42, 46);
            this.randomLabel.TabIndex = 11;
            this.randomLabel.Text = "0";
            // 
            // btnUndo
            // 
            this.btnUndo.Location = new System.Drawing.Point(498, 253);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(166, 56);
            this.btnUndo.TabIndex = 12;
            this.btnUndo.Text = "Отмена";
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(744, 483);
            this.Controls.Add(this.btnUndo);
            this.Controls.Add(this.randomLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnX2);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.Play);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.menuBG);
            this.Name = "Form1";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Удвоитель";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnX2;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Play;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label menuBG;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label randomLabel;
        private System.Windows.Forms.Button btnUndo;
    }
}

