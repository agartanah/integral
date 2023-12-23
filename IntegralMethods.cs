using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
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

    public static double RectangleMethodConcreteN(double a, double b, double e, double N) {
      double lengthSigment = b - a;
      double step;
      double valintegral2 = 0;

      step = lengthSigment / N;

      for (double x = a; x <= b - step; x += step) {
        valintegral2 += step * Fun(x);
      }

      countN[0] = N;
      result[0] = valintegral2;

      return valintegral2;
    }

    public static double RectangleMethod(double a, double b, double e) {
      double N = 1d / 2d;
      double lengthSigment = b - a;
      double step;
      double valIntegral1 = RectangleMethodConcreteN(a, b, e, N *= 2);
      double valIntegral2 = valIntegral1;

      do {
        N *= 2;
        valIntegral1 = valIntegral2;
        valIntegral2 = 0;

        step = lengthSigment / N;

        for (double x = a; x <= b - step; x += step) {
          valIntegral2 += step * Fun(x);
        }
      } while (Math.Round((decimal)valIntegral2, Math.Abs((int)Math.Log10(e))) != Math.Round((decimal)valIntegral1, Math.Abs((int)Math.Log10(e))));

      if (N == 1) {
        countN[0] = N;
      } else {
        if (N != 2) {
          countN[1] = SearchN(RectangleMethodConcreteN, a, b, e, N / 4, N / 2, valIntegral2);

          if (countN[1] == -1) {
            countN[1] = SearchN(RectangleMethodConcreteN, a, b, e, N / 2, N, valIntegral2);
          }
        } else {
          countN[1] = SearchN(RectangleMethodConcreteN, a, b, e, N / 2, N, valIntegral2);
        }
      }

      result[0] = RectangleMethodConcreteN(a, b, e, countN[0]);

      return result[0];
    }

    private static double SearchN(Func<double, double, double, double, double> integralMethod,
      double a, double b, double e, double left, double right, double valintegral, bool flag = true) {
      double N = (left + right) / 2;

      if (Math.Abs(right - left) <= 2) {
        if (!flag) {
          return -1;
        }

        decimal bruh1 = Math.Round((decimal)valintegral, Math.Abs((int)Math.Log10(e)));
        decimal bruhleft = (decimal)integralMethod(a, b, e, left);
        decimal bruhLeft = Math.Round((decimal)integralMethod(a, b, e, left), Math.Abs((int)Math.Log10(e)));
        decimal bruhn = (decimal)integralMethod(a, b, e, N);
        decimal bruhN = Math.Round((decimal)integralMethod(a, b, e, N), Math.Abs((int)Math.Log10(e)));
        decimal bruhright = (decimal)integralMethod(a, b, e, right);
        decimal bruhRight = Math.Round((decimal)integralMethod(a, b, e, right), Math.Abs((int)Math.Log10(e)));

        if (Math.Round((decimal)valintegral, Math.Abs((int)Math.Log10(e))) == Math.Round((decimal)integralMethod(a, b, e, left), Math.Abs((int)Math.Log10(e)))) {
          return left;
        } else if (Math.Round((decimal)valintegral, Math.Abs((int)Math.Log10(e))) == Math.Round((decimal)integralMethod(a, b, e, N), Math.Abs((int)Math.Log10(e)))) {
          return N;
        } else if (Math.Round((decimal)valintegral, Math.Abs((int)Math.Log10(e))) == Math.Round((decimal)integralMethod(a, b, e, right), Math.Abs((int)Math.Log10(e)))) {
          return right;
        }
      }

      if (Math.Round((decimal)valintegral, Math.Abs((int)Math.Log10(e))) == Math.Round((decimal)integralMethod(a, b, e, N), Math.Abs((int)Math.Log10(e)))) {
        N = SearchN(integralMethod, a, b, e, left, N, valintegral, true);
      } else {
        double N1 = SearchN(integralMethod, a, b, e, left, N, valintegral, false);
        double N2;

        if (N1 != -1) {
          N = N1;
        } else {
          N2 = SearchN(integralMethod, a, b, e, N, right, valintegral, false);
          
          if (N2 != -1) {
            N = N2;
          } else {
            return -1;
          }
        }
      }

      return N;
    }

    public static double TrapezoidMethodConcreteN(double a, double b, double e, double N) {
      double lengthSigment = b - a;
      double step;
      double valIntegral2 = 0;

      step = lengthSigment / N;

      int k = 0;

      for (double x = a; x <= b - step; x += step) {
        valIntegral2 += ((Fun(x) + Fun(x + step)) / 2) * step;

        ++k;
      }

      countN[1] = N;
      result[1] = valIntegral2;

      return valIntegral2;
    }

    public static double TrapezoidMethod(double a, double b, double e) {
      double N = 1d / 2d;
      double lengthSigment = b - a;
      double step;
      double valIntegral1 = TrapezoidMethodConcreteN(a, b, e, N *= 2);
      double valIntegral2 = valIntegral1;

      do {
        N *= 2;
        valIntegral1 = valIntegral2;
        valIntegral2 = 0;

        step = lengthSigment / N;

        for (double x = a; x <= b - step; x += step) {
          valIntegral2 += ((Fun(x) + Fun(x + step)) / 2) * step;
        }

        decimal bruh = Math.Abs(Math.Round((decimal)valIntegral2, Math.Abs((int)Math.Log10(e)) + 1) - Math.Round((decimal)valIntegral1, Math.Abs((int)Math.Log10(e)) + 1));
      } while (Math.Round((decimal)valIntegral2, Math.Abs((int)Math.Log10(e))) != Math.Round((decimal)valIntegral1, Math.Abs((int)Math.Log10(e))));
      
      //  while (Math.Abs(Math.Round((decimal)valIntegral2, Math.Abs((int)Math.Log10(e)) + 1)
      //- Math.Round((decimal)valIntegral1, Math.Abs((int)Math.Log10(e)) + 1)) >= (decimal)e);

      if (N == 1) {
        countN[1] = N;
      } else {
        if (N != 2) {
          countN[1] = SearchN(TrapezoidMethodConcreteN, a, b, e, N / 4, N / 2, valIntegral2);

          if (countN[1] == -1) {
            countN[1] = SearchN(TrapezoidMethodConcreteN, a, b, e, N / 2, N, valIntegral2);
          }
        } else {
          countN[1] = SearchN(TrapezoidMethodConcreteN, a, b, e, N / 2, N, valIntegral2);
        }
      }

      result[1] = TrapezoidMethodConcreteN(a, b, e, countN[1]);

      return result[1];
    }

    public static double SimpsonMethodConcreteN(double a, double b, double e, double N) {
      double valIntegral2;

      double step = (b - a) / (N);
      double summOdd = 0d;
      double summEven = 0d;

      double indexN = 1;

      while (indexN < N) {
        var odd = a + step * indexN;

        if (indexN <= N - 1) {
          summOdd += Fun(odd);

          indexN++;
        }

        var even = a + step * indexN;

        if (indexN <= N - 2) {
          summEven += Fun(even);

          indexN++;
        }
      }

      valIntegral2 = (step / 3d) * (Fun(a) + 4 * summOdd + 2 * summEven + Fun(b));

      countN[2] = N;
      result[2] = valIntegral2;


      return valIntegral2;
    }

    public static double SimpsonMethod(double a, double b, double e) {
      double N = 1;
      double step;
      double valIntegral1 = SimpsonMethodConcreteN(a, b, e, N *= 2);
      double valIntegral2 = valIntegral1;

      do {
        N = 2 * N;
        step = (b - a) / (N);
        double summOdd = 0d;
        double summEven = 0d;
        valIntegral1 = valIntegral2;
        valIntegral2 = 0;
        double indexN = 1;

        while (indexN < N) {
          var odd = a + step * indexN;

          if (indexN <= N - 1) {
            summOdd += Fun(odd);

            indexN++;
          }

          var even = a + step * indexN;

          if (indexN <= N - 2) {
            summEven += Fun(even);

            indexN++;
          }
        }

        valIntegral2 = (step / 3d) * (Fun(a) + 4 * summOdd + 2 * summEven + Fun(b));
      } while ((1m / 3m) * Math.Abs(Math.Round((decimal)valIntegral2, Math.Abs((int)Math.Log10(e)))
      - Math.Round((decimal)valIntegral1, Math.Abs((int)Math.Log10(e)))) > 0);
      
      if (N == 1 && SimpsonMethodConcreteN(a, b, e, countN[2]) == 0) {
        ++N;
        countN[2] = N;
      } else if (N == 2) {
        countN[2] = N;
      } else {
        if (N >= 8) {
          countN[2] = SearchN(SimpsonMethodConcreteN, a, b, e, N / 4, N / 2, valIntegral2);

          if (countN[2] == -1) {
            countN[2] = SearchN(SimpsonMethodConcreteN, a, b, e, N / 2, N, valIntegral2);
          }
        } else {
          countN[2] = SearchN(SimpsonMethodConcreteN, a, b, e, N / 2, N, valIntegral2);
        }
      }

      
      if (countN[2] % 2 != 0) {
        if (Math.Abs(Math.Round((decimal)valIntegral2, Math.Abs((int)Math.Log10(e)))
          - Math.Round((decimal)SimpsonMethodConcreteN(a, b, e, countN[2] - 1), Math.Abs((int)Math.Log10(e)))) < (decimal)e) {
          ++countN[2];
          countN[2] = countN[2] - 1;
        } else if (Math.Abs(Math.Round((decimal)valIntegral2, Math.Abs((int)Math.Log10(e)))
          - Math.Round((decimal)SimpsonMethodConcreteN(a, b, e, countN[2] + 1), Math.Abs((int)Math.Log10(e)))) < (decimal)e) {
          countN[2] = countN[2] + 1;
        }
      }

      result[2] = SimpsonMethodConcreteN(a, b, e, countN[2]);

      return result[2];
    }
  }
}
