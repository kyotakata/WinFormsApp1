using WinFormsApp1.Devices;
using WinFormsApp1.Measures;

namespace WinFormsApp1
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
      StartPosition = FormStartPosition.CenterScreen;
    }

    private void button1_Click(object sender, EventArgs e)
    {
      Device device = new AcDevice(new TempMeasure());
      Set(device);
    }

    private void button2_Click(object sender, EventArgs e)
    {
      Device device = new AcDevice(new WindMeasure());
      Set(device);
    }

    private void button4_Click(object sender, EventArgs e)
    {
      Device device = new BatteryDevice(new TempMeasure());
      Set(device);
    }

    private void button3_Click(object sender, EventArgs e)
    {
      Device device = new BatteryDevice(new WindMeasure());
      Set(device);
    }

    private void button6_Click(object sender, EventArgs e)
    {
      Device device = new AcDevice(new AutoTempMeasure());
      Set(device);
    }

    private void button5_Click(object sender, EventArgs e)
    {
      Device device = new BatteryDevice(
        new AutoTempMeasure());
      Set(device);
    }

    private void button9_Click(object sender, EventArgs e)
    {
      Device device = new SunDevice(new TempMeasure());
      Set(device);
    }

    private void button8_Click(object sender, EventArgs e)
    {
      Device device = new SunDevice(new WindMeasure());
      Set(device);
    }

    private void button7_Click(object sender, EventArgs e)
    {
      Device device = new SunDevice(new AutoTempMeasure());
      Set(device);
    }

    private void Set(Device device)
    {
      NameLabel.Text = device.GetName();
      MeasureLabel.Text = device.GetMeasure();
      KandoLabel.Text = device.GetKando();
      BatteryLevelLabel.Text = device.GetBatteryLevel();
      SunLevelLabel.Text = device.GetSunLevel();
    }
  }
}