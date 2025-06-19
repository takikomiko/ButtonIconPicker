using System.Xml;

namespace ButtonIconPicker.Services
{
    public class IconListService
    {
        string bootstrapIconsText = Resources.Resource.BootstrapIcons;
        public List<string> BootstrapIcons
            => [.. bootstrapIconsText.Split(["\r\n", "\r", "\n"], StringSplitOptions.RemoveEmptyEntries)];
    }
}
