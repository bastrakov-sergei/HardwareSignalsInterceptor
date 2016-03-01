using System;
using System.Windows.Forms;
using HardwareSignalsLibrary;
using HardwareSignalsLibrary.Interceptor.HardwareSignals;

namespace HardwareSignalsInterceptor
{
    internal class HardwareSignalsFormInterceptor : IHardwareSignalsInterceptor
    {                              
        private MainForm form;

        public void Start()
        {
            form = new MainForm();
            form.Start();
        }

        public void Stop()
        {
            form.Stop();
        }

        public float ReadAnalogInputHandle(int index, float value)
        {
            return InvokeInto(form, () => form.ReadAnalogInputHandle(index, value));
        }

        public int[] AnalogInputsHandle(int[] values)
        {
            return InvokeInto(form, () => form.AnalogInputsHandle(values));
        }

        public bool ReadDigitalInputHandle(int index, bool value)
        {
            return InvokeInto(form, () => form.ReadDigitalInputHandle(index, value));
        }

        public bool[] DigitalInputsHandle(bool[] values)
        {
            return InvokeInto(form, () => form.DigitalInputsHandle(values));
        }

        public bool WriteDigitalOuputHandle(int index, bool value)
        {
            return InvokeInto(form, () => form.WriteDigitalOuputHandle(index, value));
        }

        public float WriteAnalogOuputHandle(int index, float value)
        {
            return InvokeInto(form, () => form.WriteAnalogOuputHandle(index, value));
        }

        public byte WriteDigitalIndicatorHandle(int index, byte value)
        {
            return InvokeInto(form, () => form.WriteDigitalIndicatorHandle(index, value));
        }

        private static TValue InvokeInto<TValue>(Control control, Func<TValue> action)
        {
            if (control.IsHandleCreated)
            {
                return (TValue)control.Invoke(action);
            }
            return action();
        }
    }
}
