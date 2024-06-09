namespace Turing_Machine_1006
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_tape = new System.Windows.Forms.DataGridView();
            this.button_R = new System.Windows.Forms.Button();
            this.button_L = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button_OK = new System.Windows.Forms.Button();
            this.button_Start = new System.Windows.Forms.Button();
            this.button_Step = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.button_del = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.dataGridView_RuleSet = new System.Windows.Forms.DataGridView();
            this.button_Create = new System.Windows.Forms.Button();
            this.textBox_ABS = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.richTextBox_com = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_tape)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_RuleSet)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.menuStrip1.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(10, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1284, 32);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(136, 26);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(75, 26);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Location = new System.Drawing.Point(13, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1259, 103);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Условие задачи:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.Location = new System.Drawing.Point(7, 26);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(1246, 73);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dataGridView_tape);
            this.groupBox2.Controls.Add(this.button_R);
            this.groupBox2.Controls.Add(this.button_L);
            this.groupBox2.Location = new System.Drawing.Point(13, 142);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1259, 168);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Лента:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(610, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 42);
            this.label1.TabIndex = 3;
            this.label1.Text = "▼";
            // 
            // dataGridView_tape
            // 
            this.dataGridView_tape.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridView_tape.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_tape.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_tape.Location = new System.Drawing.Point(57, 60);
            this.dataGridView_tape.Name = "dataGridView_tape";
            this.dataGridView_tape.Size = new System.Drawing.Size(1146, 183);
            this.dataGridView_tape.TabIndex = 2;
            // 
            // button_R
            // 
            this.button_R.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_R.ForeColor = System.Drawing.Color.Black;
            this.button_R.Location = new System.Drawing.Point(1203, 60);
            this.button_R.Name = "button_R";
            this.button_R.Size = new System.Drawing.Size(50, 64);
            this.button_R.TabIndex = 1;
            this.button_R.Text = "▶";
            this.button_R.UseVisualStyleBackColor = true;
            this.button_R.Click += new System.EventHandler(this.button_R_Click);
            // 
            // button_L
            // 
            this.button_L.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_L.ForeColor = System.Drawing.Color.Black;
            this.button_L.Location = new System.Drawing.Point(7, 60);
            this.button_L.Name = "button_L";
            this.button_L.Size = new System.Drawing.Size(50, 64);
            this.button_L.TabIndex = 0;
            this.button_L.Text = "◀";
            this.button_L.UseVisualStyleBackColor = true;
            this.button_L.Click += new System.EventHandler(this.button_L_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.button_Start);
            this.groupBox3.Controls.Add(this.button_Step);
            this.groupBox3.Controls.Add(this.button_clear);
            this.groupBox3.Controls.Add(this.button_del);
            this.groupBox3.Controls.Add(this.button_add);
            this.groupBox3.Controls.Add(this.dataGridView_RuleSet);
            this.groupBox3.Controls.Add(this.button_Create);
            this.groupBox3.Controls.Add(this.textBox_ABS);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(13, 317);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(860, 502);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Управление:";
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(10, 242);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 50);
            this.button1.TabIndex = 9;
            this.button1.Text = "Solve";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_OK
            // 
            this.button_OK.Enabled = false;
            this.button_OK.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_OK.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_OK.Location = new System.Drawing.Point(1144, 332);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(122, 39);
            this.button_OK.TabIndex = 8;
            this.button_OK.Text = "OK";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // button_Start
            // 
            this.button_Start.BackColor = System.Drawing.SystemColors.HighlightText;
            this.button_Start.Enabled = false;
            this.button_Start.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Start.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_Start.Location = new System.Drawing.Point(603, 447);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(122, 39);
            this.button_Start.TabIndex = 7;
            this.button_Start.Text = "Пуск";
            this.button_Start.UseVisualStyleBackColor = false;
            this.button_Start.Click += new System.EventHandler(this.button_Start_Click);
            // 
            // button_Step
            // 
            this.button_Step.Enabled = false;
            this.button_Step.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Step.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_Step.Location = new System.Drawing.Point(731, 447);
            this.button_Step.Name = "button_Step";
            this.button_Step.Size = new System.Drawing.Size(122, 39);
            this.button_Step.TabIndex = 6;
            this.button_Step.Text = "Пошагово";
            this.button_Step.UseVisualStyleBackColor = true;
            this.button_Step.Click += new System.EventHandler(this.button_Step_Click);
            // 
            // button_clear
            // 
            this.button_clear.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_clear.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_clear.Location = new System.Drawing.Point(10, 186);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(50, 50);
            this.button_clear.TabIndex = 6;
            this.button_clear.Text = "Clear";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // button_del
            // 
            this.button_del.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_del.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_del.Location = new System.Drawing.Point(10, 130);
            this.button_del.Name = "button_del";
            this.button_del.Size = new System.Drawing.Size(50, 50);
            this.button_del.TabIndex = 5;
            this.button_del.Text = "-";
            this.button_del.UseVisualStyleBackColor = true;
            this.button_del.Click += new System.EventHandler(this.button_del_Click);
            // 
            // button_add
            // 
            this.button_add.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_add.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_add.Location = new System.Drawing.Point(10, 74);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(50, 50);
            this.button_add.TabIndex = 4;
            this.button_add.Text = "+";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // dataGridView_RuleSet
            // 
            this.dataGridView_RuleSet.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridView_RuleSet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_RuleSet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_RuleSet.Location = new System.Drawing.Point(65, 74);
            this.dataGridView_RuleSet.Name = "dataGridView_RuleSet";
            this.dataGridView_RuleSet.Size = new System.Drawing.Size(788, 343);
            this.dataGridView_RuleSet.TabIndex = 3;
            // 
            // button_Create
            // 
            this.button_Create.Location = new System.Drawing.Point(763, 29);
            this.button_Create.Name = "button_Create";
            this.button_Create.Size = new System.Drawing.Size(90, 30);
            this.button_Create.TabIndex = 2;
            this.button_Create.Text = "Создать";
            this.button_Create.UseVisualStyleBackColor = true;
            this.button_Create.Click += new System.EventHandler(this.button_Create_Click);
            // 
            // textBox_ABS
            // 
            this.textBox_ABS.Location = new System.Drawing.Point(99, 30);
            this.textBox_ABS.Name = "textBox_ABS";
            this.textBox_ABS.Size = new System.Drawing.Size(658, 27);
            this.textBox_ABS.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Алфавит:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.richTextBox_com);
            this.groupBox4.Location = new System.Drawing.Point(904, 377);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(367, 442);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Комментарии:";
            // 
            // richTextBox_com
            // 
            this.richTextBox_com.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox_com.Location = new System.Drawing.Point(6, 38);
            this.richTextBox_com.Name = "richTextBox_com";
            this.richTextBox_com.Size = new System.Drawing.Size(361, 398);
            this.richTextBox_com.TabIndex = 0;
            this.richTextBox_com.Text = resources.GetString("richTextBox_com.Text");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1284, 827);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximumSize = new System.Drawing.Size(1300, 866);
            this.MinimumSize = new System.Drawing.Size(1300, 866);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Машина Тьюринга";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_tape)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_RuleSet)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView_tape;
        private System.Windows.Forms.Button button_R;
        private System.Windows.Forms.Button button_L;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView_RuleSet;
        private System.Windows.Forms.Button button_Create;
        private System.Windows.Forms.TextBox textBox_ABS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button_Start;
        private System.Windows.Forms.Button button_Step;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button button_del;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.RichTextBox richTextBox_com;
        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.Button button1;
    }
}

