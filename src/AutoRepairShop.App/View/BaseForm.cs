using System.Windows.Forms;

namespace AutoRepairShop.App.View
{
    public static class BaseForm
    {
        public static void Init(this Form form)
        {
            form.BackColor = System.Drawing.Color.White;
            form.ForeColor = System.Drawing.Color.Black;
            form.ControlBox = false;
            form.FormBorderStyle = FormBorderStyle.FixedSingle;
            form.StartPosition = FormStartPosition.CenterScreen;
        }
    }
}
