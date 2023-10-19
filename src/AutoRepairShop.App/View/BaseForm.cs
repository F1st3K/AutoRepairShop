using System;
using System.Windows.Forms;

namespace AutoRepairShop.App.View
{
    public static class BaseForm
    {
        public static void Init(this Form obj)
        {
            obj.BackColor = System.Drawing.Color.White;
            obj.ForeColor = System.Drawing.Color.Black;
            obj.ControlBox = false;
            obj.FormBorderStyle = FormBorderStyle.FixedSingle;
            obj.StartPosition = FormStartPosition.CenterScreen;
        }

        public static void SwitchFormTo(this Form obj, Form form)
        {
            form.FormClosed += (e, a) => obj.Show();
            obj.Hide();
            form.Show();
        }

        public static void SwitchFormTo(this Form obj, Form form, Action action)
        {
            form.FormClosed += (e, a) => action();
            obj.Hide();
            form.Show();
        }

        public static void SwitchToBackForm(this Form obj)
        {
            obj.Close();
        }
    }
}
