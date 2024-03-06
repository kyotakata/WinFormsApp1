using WinFormsApp1.Measures;

namespace WinFormsApp1.Devices
{
  public sealed class SunDevice : Device
  {
    private Random _random = new Random();  
    public SunDevice(IMeasure measure) : base(measure)
    {
    }

    public override string GetBatteryLevel()
    {
      return "--";
    }

    public override string GetSunLevel()
    {
      return _random.Next(1, 100) + "kWh";
    }

    protected override string GetDeviceName()
    {
      return "太陽光";
    }
  }
}
