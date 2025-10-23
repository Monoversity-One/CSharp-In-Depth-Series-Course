#region

using System.Linq;
using System.Windows.Forms;

#endregion

namespace BasicInventoryManager.MyClass
{
    public class Global
    {
        public static void ClearValue(GroupBox groupBox)
        {
            foreach (var item in groupBox.Controls.OfType<TextBox>())
            {
                item.Text = string.Empty;
            }
        }
    }
}