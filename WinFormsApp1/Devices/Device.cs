using WinFormsApp1.Measures;

namespace WinFormsApp1.Devices
{
  public abstract class Device
  {
    private Random _random = new Random();

  //切り出した実装単位のインタフェースを持つ
    private IMeasure _measure;
  
    //依存性注入で実装を切り替え可能とする
    public Device(IMeasure measure)
    {
      _measure = measure;
    }

    //実装を呼び出し，橋渡しをする
    public string GetName()
    {
      return _measure.GetName() + GetDeviceName();
    }

    //実装を呼び出し，橋渡しをする
    public string GetMeasure()
    {
      return _measure.GetMeasure();
    }

    public string GetKando()
    {
      return _random.Next(0, 100) + "db";
    }

    public abstract string GetBatteryLevel();
    protected abstract string GetDeviceName();
    public abstract string GetSunLevel();
  }
}
