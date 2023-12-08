namespace integral {
  partial class Form1 {
    /// <summary>
    /// Обязательная переменная конструктора.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Освободить все используемые ресурсы.
    /// </summary>
    /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Код, автоматически созданный конструктором форм Windows

    /// <summary>
    /// Требуемый метод для поддержки конструктора — не изменяйте 
    /// содержимое этого метода с помощью редактора кода.
    /// </summary>
    private void InitializeComponent() {
      System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
      System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
      this.label1 = new System.Windows.Forms.Label();
      this.textBoxB = new System.Windows.Forms.TextBox();
      this.textBoxA = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.textBoxFunc = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
      this.result = new System.Windows.Forms.Label();
      this.button1 = new System.Windows.Forms.Button();
      this.labelCondition = new System.Windows.Forms.Label();
      this.label8 = new System.Windows.Forms.Label();
      this.textBoxE = new System.Windows.Forms.TextBox();
      this.checkBox1 = new System.Windows.Forms.CheckBox();
      this.checkBox2 = new System.Windows.Forms.CheckBox();
      this.checkBox3 = new System.Windows.Forms.CheckBox();
      this.label7 = new System.Windows.Forms.Label();
      this.textBoxN = new System.Windows.Forms.TextBox();
      ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label1.Location = new System.Drawing.Point(128, 46);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(39, 58);
      this.label1.TabIndex = 0;
      this.label1.Text = "∫";
      // 
      // textBoxB
      // 
      this.textBoxB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.textBoxB.Location = new System.Drawing.Point(127, 12);
      this.textBoxB.Name = "textBoxB";
      this.textBoxB.Size = new System.Drawing.Size(50, 36);
      this.textBoxB.TabIndex = 1;
      // 
      // textBoxA
      // 
      this.textBoxA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.textBoxA.Location = new System.Drawing.Point(128, 116);
      this.textBoxA.Name = "textBoxA";
      this.textBoxA.Size = new System.Drawing.Size(50, 36);
      this.textBoxA.TabIndex = 2;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label2.Location = new System.Drawing.Point(48, 9);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(74, 39);
      this.label2.TabIndex = 3;
      this.label2.Text = "b = ";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label3.Location = new System.Drawing.Point(48, 112);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(74, 39);
      this.label3.TabIndex = 4;
      this.label3.Text = "a = ";
      // 
      // textBoxFunc
      // 
      this.textBoxFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.textBoxFunc.Location = new System.Drawing.Point(203, 66);
      this.textBoxFunc.Name = "textBoxFunc";
      this.textBoxFunc.Size = new System.Drawing.Size(548, 36);
      this.textBoxFunc.TabIndex = 5;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label4.Location = new System.Drawing.Point(155, 55);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(42, 58);
      this.label4.TabIndex = 6;
      this.label4.Text = "(";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label5.Location = new System.Drawing.Point(767, 55);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(42, 58);
      this.label5.TabIndex = 7;
      this.label5.Text = ")";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label6.Location = new System.Drawing.Point(801, 71);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(82, 39);
      this.label6.TabIndex = 8;
      this.label6.Text = "dx =";
      // 
      // chart
      // 
      chartArea1.Name = "ChartArea1";
      this.chart.ChartAreas.Add(chartArea1);
      this.chart.Location = new System.Drawing.Point(12, 173);
      this.chart.Name = "chart";
      series1.BorderColor = System.Drawing.Color.Red;
      series1.BorderWidth = 5;
      series1.ChartArea = "ChartArea1";
      series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
      series1.Name = "Series1";
      series1.YValuesPerPoint = 2;
      this.chart.Series.Add(series1);
      this.chart.Size = new System.Drawing.Size(902, 532);
      this.chart.TabIndex = 9;
      this.chart.Text = "chart1";
      // 
      // result
      // 
      this.result.AutoSize = true;
      this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.result.Location = new System.Drawing.Point(877, 71);
      this.result.Name = "result";
      this.result.Size = new System.Drawing.Size(109, 39);
      this.result.TabIndex = 10;
      this.result.Text = "label7";
      // 
      // button1
      // 
      this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.button1.Location = new System.Drawing.Point(1005, 641);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(326, 64);
      this.button1.TabIndex = 11;
      this.button1.Text = "Посчитать интеграл";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // labelCondition
      // 
      this.labelCondition.AutoSize = true;
      this.labelCondition.Location = new System.Drawing.Point(968, 327);
      this.labelCondition.Name = "labelCondition";
      this.labelCondition.Size = new System.Drawing.Size(93, 16);
      this.labelCondition.TabIndex = 12;
      this.labelCondition.Text = "labelCondition";
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label8.Location = new System.Drawing.Point(246, 9);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(74, 39);
      this.label8.TabIndex = 13;
      this.label8.Text = "e = ";
      // 
      // textBoxE
      // 
      this.textBoxE.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.textBoxE.Location = new System.Drawing.Point(326, 9);
      this.textBoxE.Name = "textBoxE";
      this.textBoxE.Size = new System.Drawing.Size(83, 36);
      this.textBoxE.TabIndex = 14;
      // 
      // checkBox1
      // 
      this.checkBox1.AutoSize = true;
      this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.checkBox1.Location = new System.Drawing.Point(971, 173);
      this.checkBox1.Name = "checkBox1";
      this.checkBox1.Size = new System.Drawing.Size(323, 33);
      this.checkBox1.TabIndex = 15;
      this.checkBox1.Text = "Метод прямоугольников";
      this.checkBox1.UseVisualStyleBackColor = true;
      // 
      // checkBox2
      // 
      this.checkBox2.AutoSize = true;
      this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.checkBox2.Location = new System.Drawing.Point(971, 212);
      this.checkBox2.Name = "checkBox2";
      this.checkBox2.Size = new System.Drawing.Size(226, 33);
      this.checkBox2.TabIndex = 16;
      this.checkBox2.Text = "Метод трапеций";
      this.checkBox2.UseVisualStyleBackColor = true;
      // 
      // checkBox3
      // 
      this.checkBox3.AutoSize = true;
      this.checkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.checkBox3.Location = new System.Drawing.Point(971, 251);
      this.checkBox3.Name = "checkBox3";
      this.checkBox3.Size = new System.Drawing.Size(236, 33);
      this.checkBox3.TabIndex = 17;
      this.checkBox3.Text = "Метод Симпсона";
      this.checkBox3.UseVisualStyleBackColor = true;
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label7.Location = new System.Drawing.Point(441, 8);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(80, 39);
      this.label7.TabIndex = 18;
      this.label7.Text = "N = ";
      // 
      // textBoxN
      // 
      this.textBoxN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.textBoxN.Location = new System.Drawing.Point(527, 9);
      this.textBoxN.Name = "textBoxN";
      this.textBoxN.Size = new System.Drawing.Size(83, 36);
      this.textBoxN.TabIndex = 19;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1415, 717);
      this.Controls.Add(this.textBoxN);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.checkBox3);
      this.Controls.Add(this.checkBox2);
      this.Controls.Add(this.checkBox1);
      this.Controls.Add(this.textBoxE);
      this.Controls.Add(this.label8);
      this.Controls.Add(this.labelCondition);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.result);
      this.Controls.Add(this.chart);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.textBoxFunc);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.textBoxA);
      this.Controls.Add(this.textBoxB);
      this.Controls.Add(this.label1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox textBoxB;
    private System.Windows.Forms.TextBox textBoxA;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox textBoxFunc;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.DataVisualization.Charting.Chart chart;
    private System.Windows.Forms.Label result;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Label labelCondition;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.TextBox textBoxE;
    private System.Windows.Forms.CheckBox checkBox1;
    private System.Windows.Forms.CheckBox checkBox2;
    private System.Windows.Forms.CheckBox checkBox3;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.TextBox textBoxN;
  }
}

