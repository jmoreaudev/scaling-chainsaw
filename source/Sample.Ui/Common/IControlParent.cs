using System.Windows.Forms;

namespace Sample.Ui.Common
{
    public interface IControlParent
    {
        void SetVisibleControl(UserControl control);
    }
}