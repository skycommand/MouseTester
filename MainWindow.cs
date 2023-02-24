using System.Reflection;

namespace MouseTester
{
  public partial class MainWindow : Form
  {
    private const string StrWheelDown = "↡";
    private const string StrWheelUp = "↟";
    private const string StrWheelDeltaZero = "⛔"; //User must never see this
    private const string StrMouseWheel = "Mouse wheel";

    private bool MouseWheelIsInUse = false;

    public MainWindow()
    {
      InitializeComponent();

      /* Visual Studio 2022 form designer neither supports the OnMouseWheel event nor assigning multiple handlers to one
       * event. Hence, we assign our handlers here. */
      MouseWheel += new MouseEventHandler(MainWindow_AllMouseEventsInitial);
      MouseWheel += new MouseEventHandler(MainWindow_MouseWheel);
      MouseDown += new MouseEventHandler(MainWindow_AllMouseEventsInitial);
      MouseDown += new MouseEventHandler(MainWindow_MouseDown);
      logLabel.MouseDown += new MouseEventHandler(MainWindow_AllMouseEventsInitial);
      logLabel.MouseDown += new MouseEventHandler(MainWindow_MouseDown);
    }

    private void MainWindow_AllMouseEventsInitial (object? sender, MouseEventArgs e)
    {
      logLabel.Text = "";
      MouseWheel -= MainWindow_AllMouseEventsInitial;
      MouseDown -= MainWindow_AllMouseEventsInitial;
      logLabel.MouseDown -= MainWindow_AllMouseEventsInitial;
    }

    private void MainWindow_MouseDown(object? sender, MouseEventArgs e)
    {
      MouseWheelIsInUse = false;
      logLabel.Text += " " + e.Button.ToString();
    }

    private void MainWindow_MouseWheel(object? sender, MouseEventArgs e)
    {
      if (!MouseWheelIsInUse) { 
        MouseWheelIsInUse = true;
        logLabel.Text += " " + StrMouseWheel + " ";
      }
      logLabel.Text += e.Delta switch
      {
        < 0 => StrWheelDown,
        > 0 => StrWheelUp,
        0 => StrWheelDeltaZero // This never runs
      };
    }
  }
}