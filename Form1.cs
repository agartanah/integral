using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

//(27-18*x+2*(x^2))*(e^(-(x/3)))

namespace integral {
  public partial class Form1 : Form {
    private double a, b, e, x, y;
    private int N;
    private const double step = 0.01;

    public Form1() {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e) {
      result.Text = string.Empty;
      labelCondition.Text = string.Empty;

      IntegralMethods.idsNames = new string[] { "x", "e" };
      IntegralMethods.idsValues = new double[] { default, Math.E };
    }

    private void button1_Click(object sender, EventArgs e) {
      labelCondition.Text = string.Empty;

      if (!double.TryParse(textBoxA.Text, out a)) {
        labelCondition.Text = "Неправильный формат данных для значения a !!!\n\n";

        return;
      }

      if (!double.TryParse(textBoxB.Text, out b)) {
        labelCondition.Text = "Неправильный формат данных для значения b !!!\n\n";

        return;
      }

      if (a > b) {
        labelCondition.Text = "a и b должны быть такие, что: \n a <= b\n\n";
        return;
      }

      //textBoxE.Text[textBoxE.Text.Length - 1] != '1'
      if (!double.TryParse(textBoxE.Text, out this.e) || !Regex.IsMatch(textBoxE.Text, @"(1|10+)|(0,(1|0+1))")
        || textBoxE.Text[0] == '-') {
        labelCondition.Text = "Неправильный формат данных для значения e !!!\n\n";

        return;
      }

      bool hasN = true;

      if (textBoxN.Text == string.Empty) {
        hasN = false;
      } else if (!int.TryParse(textBoxN.Text, out N)) {
        labelCondition.Text = "Неверный формат для количества разбиений N !!!";

        return;
      }

      try {
        IntegralMethods.TextFunction = textBoxFunc.Text;
      } catch (Exception ex) {
        labelCondition.Text = ex.Message;
        return;
      }

      if (hasN == true) {
        if (checkBox1.Checked) {
          double integralValue = Math.Round((double)IntegralMethods.RectangleMethodConcreteN(a, b, this.e, N), Math.Abs((int)Math.Log10(this.e)) + 1);

          result.Text = integralValue.ToString() + "\n";

          labelCondition.Text += $"Количество разбиений Методом Прямоугольника: {IntegralMethods.countN[0].ToString()}\n";
        }

        if (checkBox2.Checked) {
          double integralValue = Math.Round((double)IntegralMethods.TrapezoidMethodConcreteN(a, b, this.e, N), Math.Abs((int)Math.Log10(this.e)) + 1);

          result.Text = integralValue.ToString();

          labelCondition.Text += $"Количество разбиений Методом Трапеций: {IntegralMethods.countN[1].ToString()}\n";
        }

        if (checkBox3.Checked) {
          double integralValue = Math.Round((double)IntegralMethods.SimpsonMethodConcreteN(a, b, this.e, N), Math.Abs((int)Math.Log10(this.e)) + 1);

          result.Text = integralValue.ToString();

          labelCondition.Text += $"Количество разбиений Методом Симпсона: {IntegralMethods.countN[2].ToString()}\n";
        }
      } else {
        if (checkBox1.Checked) {
          double integralValue = Math.Round((double)IntegralMethods.RectangleMethod(a, b, this.e), Math.Abs((int)Math.Log10(this.e)) + 1);

          result.Text = integralValue.ToString() + "\n";

          labelCondition.Text += $"Количество разбиений Методом Прямоугольника:" +
            $" {IntegralMethods.countN[0].ToString()}\nРезультат: {IntegralMethods.result[0]}\n";
        }

        if (checkBox2.Checked) {
          double integralValue = Math.Round((double)IntegralMethods.TrapezoidMethod(a, b, this.e), Math.Abs((int)Math.Log10(this.e)) + 1);

          result.Text = integralValue.ToString();

          labelCondition.Text += $"Количество разбиений Методом Трапеций:" +
            $" {IntegralMethods.countN[1].ToString()}\nРезультат: {IntegralMethods.result[1]}\n";
        }

        if (checkBox3.Checked) {
          double integralValue = Math.Round((double)IntegralMethods.SimpsonMethod(a, b, this.e), Math.Abs((int)Math.Log10(this.e)) + 1);

          result.Text = integralValue.ToString();

          labelCondition.Text += $"Количество разбиений Методом Симпсона:" +
            $" {IntegralMethods.countN[2].ToString()}\nРезультат: {IntegralMethods.result[2]}\n";
        }
      }

      PaintFun();
    }

    private void PaintFun() {
      chart.Series[0].Points.Clear();

      chart.ChartAreas[0].AxisX.Crossing = 0;

      if (a - b == 0) {
        a = -10;
        b = 10;
      }

      double bruh = Math.Floor(Math.Log10(b - a) + 1);

      x = a;

      while (x <= b) {
        y = IntegralMethods.Fun(x);

        chart.Series[0].Points.AddXY(x, y);
        x += step;
      }
    }
  }
}
