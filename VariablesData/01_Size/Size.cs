using System;

public class Size
{
  private double width;
  private double heigth;

  public Size(double figureWidth, double figureHeigth)
  {
    this.width = figureWidth;
    this.heigth = figureHeigth;
  }

  public static Size GetRotatedSize(
                        Size currentSize,
                        double angleOfTheFigureThatWillBeRotaed)
  {
      var angleCosinus = Math.Abs(Math.Cos(angleOfTheFigureThatWillBeRotaed));
      var angleSinus = Math.Abs(Math.Sin(angleOfTheFigureThatWillBeRotaed));

      var sideA = (angleCosinus * currentSize.width) +
                  (angleSinus * currentSize.heigth);
      var sideB = (angleSinus * currentSize.width) +
                  (angleCosinus * currentSize.heigth);

      return new Size(sideA, sideB);
  }
}