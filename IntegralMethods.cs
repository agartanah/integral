using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace integral {
  public class IntegralMethods {
    private static string textFunction;
    public static string TextFunction {
      get {
        return textFunction;
      }
      set {
        if (FunctionParser.Expression.IsExpression(value, idsNames)) {
          textFunction = value;
        } else {
          throw new Exception("Функция написана неверно !!!");
        }
      }
    }

    public static string[] idsNames;
    public static double[] idsValues;

    public static double[] countN = new double[3];
    public static double[] result = new double[3];

    public static double Derivative(double x) {
      idsValues[0] = x;

      double e = 0.01;

      double result1 = Fun(idsValues[0] + e);
      idsValues[0] -= e;

      double result2 = Fun(idsValues[0] - e);
      idsValues[0] += e;

      return (result1 - result2) / (2 * e);
    }

    public static double Derivative2(double x) {
      idsValues[0] = x;

      double e = 0.01;

      double result1 = Fun(idsValues[0] + e);
      idsValues[0] -= e;

      double result2 = Fun(idsValues[0] - e);
      idsValues[0] += e;

      double result3 = Fun(idsValues[0]);

      return (result1 - 2 * result3 + result2) / (e * e);
    }

    public static double Fun(double x) {
      if (FunctionParser.Expression.IsExpression(TextFunction, idsNames)) {
        FunctionParser.Expression expression = new FunctionParser.Expression(TextFunction, idsNames, null);

        idsValues[0] = x;

        double res = expression.CalculateValue(idsValues);

        return res;
      } else {
        throw new Exception("Функция написана неверно !!!");
      }
    }

    public static double RectangleMethodConcreteN(double a, double b, double e, int N) {
      double lengthSigment = b - a;
      double step;
      double valintegral2 = 0;

      step = lengthSigment / N;

      for (double x = a; x < b; x += step) {
        valintegral2 += step * Fun(x);
      }

      countN[0] = N;
      result[0] = valintegral2;

      return valintegral2;
    }

    public static double RectangleMethod(double a, double b, double e) {
      double countPartitions = 1;
      double lengthSigment = b - a;
      double step;
      double valIntegral1;
      double valIntegral2 = 0;

      do {
        countPartitions *= 2;
        valIntegral1 = valIntegral2;
        valIntegral2 = 0;

        step = lengthSigment / countPartitions;

        for (double x = a; x < b; x += step) {
          valIntegral2 += step * Fun(x);
        }
      } while (Math.Abs(valIntegral2 - valIntegral1) > e);

      countN[0] = countPartitions;
      result[0] = valIntegral2;

      return valIntegral2;
    }

    public static double TrapezoidMethodConcreteN(double a, double b, double e, int N) {
      double lengthSigment = b - a;
      double step;
      double valIntegral2 = 0;

      step = lengthSigment / N;

      for (double x = a; x < b; x += step) {
        valIntegral2 += ((Fun(x) + Fun(x + step)) / 2) * step;
      }

      countN[1] = N;
      result[1] = valIntegral2;

      return valIntegral2;
    }

    public static double TrapezoidMethod(double a, double b, double e) {
      double countPartitions = 1;
      double lengthSigment = b - a;
      double step;
      double valIntegral1;
      double valIntegral2 = 0;

      do {
        countPartitions *= 2;
        valIntegral1 = valIntegral2;
        valIntegral2 = 0;

        step = lengthSigment / countPartitions;

        for (double x = a; x < b; x += step) {
          valIntegral2 += ((Fun(x) + Fun(x + step)) / 2) * step;
        }
      } while (Math.Abs(valIntegral2 - valIntegral1) > e);

      countN[1] = countPartitions;
      result[1] = valIntegral2;

      return valIntegral2;
    }

    public static double SimpsonMethodConcreteN(double a, double b, double e, int N) {
      double valIntegral2;

      double step = (b - a) / N;
      double sum1 = 0d;
      double sum2 = 0d;

      for (var indexN = 1; indexN <= N; indexN++) {
        var xk = a + indexN * step;

        if (indexN <= N - 1) {
          sum1 += Fun(xk);
        }

        var xk_1 = a + (indexN - 1) * step;
        sum2 += Fun((xk + xk_1) / 2);
      }

      valIntegral2 = step / 3d * (1d / 2d * Fun(a) + sum1 + 2 * sum2 + 1d / 2d * Fun(b));

      countN[2] = N;
      result[2] = valIntegral2;


      return valIntegral2;
    }

    public static double SimpsonMethod(double a, double b, double e) {
      int countPartitions = 1;
      double valIntegral1;
      double valIntegral2 = 0;

      do {
        countPartitions *= 2;
        valIntegral1 = valIntegral2;
        valIntegral2 = 0;

        double step = (b - a) / countPartitions;
        double sum1 = 0d;
        double sum2 = 0d;

        for (var indexN = 1; indexN <= countPartitions; indexN++) {
          var xk = a + indexN * step;
          if (indexN <= countPartitions - 1) {
            sum1 += Fun(xk);
          }

          var xk_1 = a + (indexN - 1) * step;
          sum2 += Fun((xk + xk_1) / 2);
        }

        valIntegral2 = step / 3d * (1d / 2d * Fun(a) + sum1 + 2 * sum2 + 1d / 2d * Fun(b));
      } while ((1d / 3d) * Math.Abs(valIntegral2 - valIntegral1) > e);
      
      countN[2] = countPartitions;
      result[2] = valIntegral2;

      return valIntegral2;
    }
  }
}
