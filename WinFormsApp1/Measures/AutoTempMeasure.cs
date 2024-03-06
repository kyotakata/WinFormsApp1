namespace WinFormsApp1.Measures
{
  public sealed class AutoTempMeasure : IMeasure
  {
    public string GetName() => "予測温度";
    public string GetMeasure()
    {
      return File.ReadAllText("auto.txt") + "℃";
    }
  }
}
