using System;
using WinFormsApp1.Measures;

namespace WinFormsApp1.Devices
{
  public sealed class BatteryDevice : Device
  {
    private Random _random = new Random();
    public BatteryDevice(IMeasure measure) : base(measure)
    {
    }

    public override string GetBatteryLevel()
    {
      return _random.Next(0, 100) + "%";
    }

    public override string GetSunLevel()
    {
      return "--";
    }

    protected override string GetDeviceName()
    {
      return "バッテリー";
    }
  }
}
