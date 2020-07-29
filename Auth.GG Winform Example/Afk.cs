using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsInput;
using WindowsInput.Native;
using Notifications.Wpf;

namespace Auth.GG_Winform_Example
{
    public partial class Afk : Form
    {
        public Afk()
        {
            InitializeComponent();
        }

        private async void siticoneGradientButton1_ClickAsync(object sender, EventArgs e)
        {
            var notificationManager = new NotificationManager();
            var simulator = new InputSimulator();

            notificationManager.Show(new NotificationContent
            {
                Title = "Start",
                Message = "AntiAFK Wurde Erfolgreich Gestartet!",
                Type = NotificationType.Success
            });
            while (true)
            {
                simulator.Mouse.MoveMouseToPositionOnVirtualDesktop(200, 0);
                await Task.Delay(100);
                simulator.Mouse.MoveMouseToPositionOnVirtualDesktop(210, 0);
                await Task.Delay(100);
                simulator.Mouse.MoveMouseToPositionOnVirtualDesktop(220, 0);
                await Task.Delay(100);
                simulator.Mouse.MoveMouseToPositionOnVirtualDesktop(230, 0);
                await Task.Delay(100);
                simulator.Mouse.MoveMouseToPositionOnVirtualDesktop(240, 0);
                await Task.Delay(100);
                simulator.Mouse.MoveMouseToPositionOnVirtualDesktop(250, 0);
                await Task.Delay(100);
                simulator.Mouse.MoveMouseToPositionOnVirtualDesktop(260, 0);
                await Task.Delay(100);
                simulator.Mouse.MoveMouseToPositionOnVirtualDesktop(270, 0);
                await Task.Delay(100);
                simulator.Mouse.MoveMouseToPositionOnVirtualDesktop(280, 0);
                await Task.Delay(100);
                simulator.Mouse.MoveMouseToPositionOnVirtualDesktop(290, 0);
                await Task.Delay(100);
                simulator.Mouse.MoveMouseToPositionOnVirtualDesktop(300, 0);
                await Task.Delay(100);
                simulator.Mouse.MoveMouseToPositionOnVirtualDesktop(310, 0);
                await Task.Delay(100);
                simulator.Mouse.MoveMouseToPositionOnVirtualDesktop(320, 0);
                await Task.Delay(100);
                simulator.Mouse.MoveMouseToPositionOnVirtualDesktop(330, 0);
                await Task.Delay(100);
                simulator.Mouse.MoveMouseToPositionOnVirtualDesktop(340, 0);
                await Task.Delay(100);
                simulator.Mouse.MoveMouseToPositionOnVirtualDesktop(350, 0);
                await Task.Delay(500);
                simulator.Keyboard.KeyDown(VirtualKeyCode.VK_W);
                await Task.Delay(6000);
                simulator.Keyboard.KeyUp(VirtualKeyCode.VK_W);
                await Task.Delay(60000);
            }
        }
    }
}
