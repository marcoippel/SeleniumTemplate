using System.Drawing;
using SeleniumTestTemplate.Enums;
using SeleniumTestTemplate.Models;

namespace SeleniumTestTemplate.Helpers
{
    public static class Device
    {
        public static DeviceModel Get(Devices device)
        {
            switch (device)
            {
                case Devices.Iphone4:
                    return new DeviceModel
                    {
                        ScreenSize = new Size(320, 568),
                        UserAgent = "Mozilla/5.0 (iPhone; U; CPU iPhone OS 4_0 like Mac OS X; en-us) AppleWebKit/532.9 (KHTML, like Gecko) Version/4.0.5 Mobile/8A293 Safari/6531.22.7"
                    };
                    break;
                case Devices.Iphone5:
                    return new DeviceModel
                    {
                        ScreenSize = new Size(320, 568),
                        UserAgent = "Mozilla/5.0 (iPhone; CPU iPhone OS 5_0 like Mac OS X) AppleWebKit/534.46 (KHTML, like Gecko) Version/5.1 Mobile/9A334 Safari/7534.48.3"
                    };
                    break;
                case Devices.Iphone6:
                    return new DeviceModel
                    {
                        ScreenSize = new Size(320, 480),
                        UserAgent =
                            "Mozilla/5.0 (iPhone; CPU iPhone OS 8_0_2 like Mac OS X) AppleWebKit/600.1.4 (KHTML, like Gecko) Version/8.0 Mobile/12A366 Safari/600.1.4"
                    };
                    break;

                case Devices.Ipad:
                    return new DeviceModel
                    {
                        ScreenSize = new Size(1024, 768),
                        UserAgent =
                            "Mozilla/5.0 (iPad; CPU OS 5_0 like Mac OS X) AppleWebKit/534.46 (KHTML, like Gecko) Version/5.1 Mobile/9A334 Safari/7534.48.3"
                    };
                    break;
                //case Devices.GalaxyS4:
                //    return new Size(360, 640);
                //    break;
                //case Devices.GalaxyTab:
                //    return new Size(1024, 600);
                //    break;
                //case Devices.Nexus5:
                //    return new Size(360, 640);
                //    break;
                    default:
                    return new DeviceModel
                    {
                        ScreenSize = new Size(1024, 768),
                        UserAgent =
                            "Mozilla/5.0 (iPad; CPU OS 5_0 like Mac OS X) AppleWebKit/534.46 (KHTML, like Gecko) Version/5.1 Mobile/9A334 Safari/7534.48.3"
                    };
            }
        }
    }
}
