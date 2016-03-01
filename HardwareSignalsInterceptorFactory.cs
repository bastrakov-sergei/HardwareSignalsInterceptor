using HardwareSignalsLibrary;
using HardwareSignalsLibrary.IO.Hardware;

namespace HardwareSignalsInterceptor
{
    public static class HardwareSignalsInterceptorFactory
    {
        public static IHardwareSignals Create()
        {
            return HardwareSignalsFactory.Create(new EmptyHardwareSignals(2, 2, 2, 2, 2),
                new HardwareSignalsFormInterceptor());
        }
    }
}