using System;
using Windows.Security.ExchangeActiveSyncProvisioning;
using Xamarin.Forms;

namespace DisplayPlatformInfoSap2
{
    public class PlatformInfo
    {
        EasClientDeviceInformation devInfo = new EasClientDeviceInformation();

        public string GetModel()
        {
            return String.Format("{0} {1}", devInfo.SystemManufacturer, 
                                            devInfo.SystemProductName);
        }

        public string GetVersion()
        {
            return devInfo.OperatingSystem;
        }
    }
}
