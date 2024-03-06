namespace WinFormsApp1.Measures
{
  public sealed class WindMeasure : IMeasure
  {
    public string GetName() => "風力";
    public string GetMeasure()
    {
      return File.ReadAllText("wind.txt") + "m/s";
    }
  }
}
