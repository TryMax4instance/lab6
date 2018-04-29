namespace lab6
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
            this.KasButCacl = new System.Windows.Forms.Button();
            this.KasBoxX0 = new System.Windows.Forms.TextBox();
            this.KasBoxTo = new System.Windows.Forms.TextBox();
            this.KasDGV = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.MdpDGV = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Root = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MpdBoxTo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.KasBoxItr = new System.Windows.Forms.TextBox();
            this.KasButGr = new System.Windows.Forms.Button();
            this.MpdBatGr = new System.Windows.Forms.Button();
            this.MpdBatCalc = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.MpdBoxA = new System.Windows.Forms.TextBox();
            this.MpdBoxB = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Inr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Val = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.KasDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MdpDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // KasButCacl
            // 
            this.KasButCacl.Location = new System.Drawing.Point(12, 314);
            this.KasButCacl.Name = "KasButCacl";
            this.KasButCacl.Size = new System.Drawing.Size(130, 23);
            this.KasButCacl.TabIndex = 1;
            this.KasButCacl.Text = "Посчитать";
            this.KasButCacl.UseVisualStyleBackColor = true;
            this.KasButCacl.Click += new System.EventHandler(this.KasButCacl_Click);
            // 
            // KasBoxX0
            // 
            this.KasBoxX0.Location = new System.Drawing.Point(273, 201);
            this.KasBoxX0.Name = "KasBoxX0";
            this.KasBoxX0.Size = new System.Drawing.Size(62, 20);
            this.KasBoxX0.TabIndex = 2;
            // 
            // KasBoxTo
            // 
            this.KasBoxTo.Location = new System.Drawing.Point(273, 230);
            this.KasBoxTo.Name = "KasBoxTo";
            this.KasBoxTo.Size = new System.Drawing.Size(62, 20);
            this.KasBoxTo.TabIndex = 3;
            this.KasBoxTo.Text = "0,0001";
            // 
            // KasDGV
            // 
            this.KasDGV.AllowUserToDeleteRows = false;
            this.KasDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.KasDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Inr,
            this.Val});
            this.KasDGV.Location = new System.Drawing.Point(12, 25);
            this.KasDGV.Name = "KasDGV";
            this.KasDGV.ReadOnly = true;
            this.KasDGV.Size = new System.Drawing.Size(323, 170);
            this.KasDGV.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Метод касательных";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Начальное приближение";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Точность";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(403, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Точность";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(530, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Метод половинного деления";
            // 
            // MdpDGV
            // 
            this.MdpDGV.AllowUserToDeleteRows = false;
            this.MdpDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MdpDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.Root});
            this.MdpDGV.Location = new System.Drawing.Point(406, 25);
            this.MdpDGV.Name = "MdpDGV";
            this.MdpDGV.ReadOnly = true;
            this.MdpDGV.Size = new System.Drawing.Size(340, 170);
            this.MdpDGV.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn1.HeaderText = "Точность";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 105;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "Номер итерация";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // Root
            // 
            this.Root.HeaderText = "Корень уравнения";
            this.Root.Name = "Root";
            this.Root.ReadOnly = true;
            // 
            // MpdBoxTo
            // 
            this.MpdBoxTo.Location = new System.Drawing.Point(684, 201);
            this.MpdBoxTo.Name = "MpdBoxTo";
            this.MpdBoxTo.Size = new System.Drawing.Size(62, 20);
            this.MpdBoxTo.TabIndex = 10;
            this.MpdBoxTo.Text = "0,0001";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 261);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Допустимое число итераций";
            // 
            // KasBoxItr
            // 
            this.KasBoxItr.Location = new System.Drawing.Point(273, 258);
            this.KasBoxItr.Name = "KasBoxItr";
            this.KasBoxItr.Size = new System.Drawing.Size(62, 20);
            this.KasBoxItr.TabIndex = 16;
            // 
            // KasButGr
            // 
            this.KasButGr.Location = new System.Drawing.Point(205, 314);
            this.KasButGr.Name = "KasButGr";
            this.KasButGr.Size = new System.Drawing.Size(130, 23);
            this.KasButGr.TabIndex = 17;
            this.KasButGr.Text = "График";
            this.KasButGr.UseVisualStyleBackColor = true;
            // 
            // MpdBatGr
            // 
            this.MpdBatGr.Location = new System.Drawing.Point(622, 314);
            this.MpdBatGr.Name = "MpdBatGr";
            this.MpdBatGr.Size = new System.Drawing.Size(130, 23);
            this.MpdBatGr.TabIndex = 20;
            this.MpdBatGr.Text = "График";
            this.MpdBatGr.UseVisualStyleBackColor = true;
            // 
            // MpdBatCalc
            // 
            this.MpdBatCalc.Location = new System.Drawing.Point(406, 314);
            this.MpdBatCalc.Name = "MpdBatCalc";
            this.MpdBatCalc.Size = new System.Drawing.Size(130, 23);
            this.MpdBatCalc.TabIndex = 19;
            this.MpdBatCalc.Text = "Посчитать";
            this.MpdBatCalc.UseVisualStyleBackColor = true;
            this.MpdBatCalc.Click += new System.EventHandler(this.MpdBatCalc_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(403, 240);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Левая граница (а)";
            // 
            // MpdBoxA
            // 
            this.MpdBoxA.Location = new System.Drawing.Point(507, 237);
            this.MpdBoxA.Name = "MpdBoxA";
            this.MpdBoxA.Size = new System.Drawing.Size(62, 20);
            this.MpdBoxA.TabIndex = 22;
            // 
            // MpdBoxB
            // 
            this.MpdBoxB.Location = new System.Drawing.Point(684, 237);
            this.MpdBoxB.Name = "MpdBoxB";
            this.MpdBoxB.Size = new System.Drawing.Size(62, 20);
            this.MpdBoxB.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(578, 240);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Правая граница (b)";
            // 
            // Inr
            // 
            this.Inr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Inr.HeaderText = "Номер итерации";
            this.Inr.Name = "Inr";
            this.Inr.ReadOnly = true;
            this.Inr.Width = 106;
            // 
            // Val
            // 
            this.Val.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Val.HeaderText = "Значение";
            this.Val.Name = "Val";
            this.Val.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 354);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.MpdBoxB);
            this.Controls.Add(this.MpdBoxA);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.MpdBatGr);
            this.Controls.Add(this.MpdBatCalc);
            this.Controls.Add(this.KasButGr);
            this.Controls.Add(this.KasBoxItr);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.MdpDGV);
            this.Controls.Add(this.MpdBoxTo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.KasDGV);
            this.Controls.Add(this.KasBoxTo);
            this.Controls.Add(this.KasBoxX0);
            this.Controls.Add(this.KasButCacl);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.KasDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MdpDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button KasButCacl;
        private System.Windows.Forms.TextBox KasBoxX0;
        private System.Windows.Forms.TextBox KasBoxTo;
        private System.Windows.Forms.DataGridView KasDGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView MdpDGV;
        private System.Windows.Forms.TextBox MpdBoxTo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox KasBoxItr;
        private System.Windows.Forms.Button KasButGr;
        private System.Windows.Forms.Button MpdBatGr;
        private System.Windows.Forms.Button MpdBatCalc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox MpdBoxA;
        private System.Windows.Forms.TextBox MpdBoxB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Root;
        private System.Windows.Forms.DataGridViewTextBoxColumn Inr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Val;
    }
}

