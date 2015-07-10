using System.Drawing;
using SeleniumTestTemplate.Enums;

namespace SeleniumTestTemplate.Models
{
    public class DeviceModel
    {
        public Size ScreenSize { get; set; }
        public string UserAgent { get; set; }
        public DeviceType Type { get; set; }
    }
}
