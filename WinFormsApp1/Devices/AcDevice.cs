using WinFormsApp1.Measures;

namespace WinFormsApp1.Devices
{
  public sealed class AcDevice : Device
  {
    public AcDevice(IMeasure measure) : base(measure)
    {
    }

    public override string GetBatteryLevel()
    {
      return "--";
    }

    public override string GetSunLevel()
    {
      return "--";
    }

    protected override string GetDeviceName()
    {
      return "AC";
    }
  }
}
