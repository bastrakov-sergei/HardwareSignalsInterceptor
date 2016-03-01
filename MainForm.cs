using System.Windows.Forms;
using HardwareSignalsLibrary;
using HardwareSignalsLibrary.Interceptor.HardwareSignals;

namespace HardwareSignalsInterceptor
{
    public partial class MainForm : Form, IHardwareSignalsInterceptor
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public void Start()
        {
            Show();
        }

        public void Stop()
        {
            Close();
        }

        public float ReadAnalogInputHandle(int index, float value)
        {
            throw new System.NotImplementedException();
        }

        public int[] AnalogInputsHandle(int[] values)
        {
            throw new System.NotImplementedException();
        }

        public bool ReadDigitalInputHandle(int index, bool value)
        {
            throw new System.NotImplementedException();
        }

        public bool[] DigitalInputsHandle(bool[] values)
        {
            throw new System.NotImplementedException();
        }

        public bool WriteDigitalOuputHandle(int index, bool value)
        {
            throw new System.NotImplementedException();
        }

        public float WriteAnalogOuputHandle(int index, float value)
        {
            throw new System.NotImplementedException();
        }

        public byte WriteDigitalIndicatorHandle(int index, byte value)
        {
            throw new System.NotImplementedException();
        }
    }
}
