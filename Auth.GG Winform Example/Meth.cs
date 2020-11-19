using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsInput;
using WindowsInput.Native;
using Notifications.Wpf;

namespace Auth.GG_Winform_Example
{
    public partial class Meth : Form
    {
        public Meth()
        {

            InitializeComponent();


           

        }
        [DllImport("USER32.DLL", CharSet = CharSet.Unicode)]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("USER32.DLL")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);


       

        private async void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            string meth;
            int methint;
            meth = tbxfreiesgewicht.Text;
            methint = Convert.ToInt32(meth);
            int anzahl = methint / 5;

            var simulator = new InputSimulator();
            var notificationManager = new NotificationManager();

            IntPtr calculatorHandle = FindWindow("grcWindow", "FiveM - [GERMAN] 🎃👾 StoryV Roleplay | 🎤SaltyChat | 🔐Whitelist | 💵150.000 | 🔥Performance | ⚙️Crafting | 👮🏽LSPD | 👨🏽‍⚕️LSMC | 👨🏽‍🔧ACLS | 👮🏽Copnet | 👨🏽‍⚕️Medicnet");

            SetForegroundWindow(calculatorHandle);

           if(cbxsammeln.Checked == true && cbxgehen.Checked == true && cbxverarbeiten.Checked == true)
            {
                for (int i = anzahl; i > 0; i--)
                {
                    await Task.Delay(500);
                    simulator.Keyboard.KeyDown(VirtualKeyCode.VK_E);
                    await Task.Delay(3000);
                    simulator.Keyboard.KeyUp(VirtualKeyCode.VK_E);
                    await Task.Delay(13000);
                }

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
                await Task.Delay(800);

                simulator.Keyboard.KeyDown(VirtualKeyCode.VK_W);
                await Task.Delay(3700);
                simulator.Keyboard.KeyUp(VirtualKeyCode.VK_W);


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
                simulator.Mouse.MoveMouseToPositionOnVirtualDesktop(255, 0);
                await Task.Delay(800);

                simulator.Keyboard.KeyDown(VirtualKeyCode.VK_W);
                await Task.Delay(2600);
                simulator.Keyboard.KeyUp(VirtualKeyCode.VK_W);

                for (int i = anzahl; i > 0; i--)
                {
                    await Task.Delay(500);
                    simulator.Keyboard.KeyDown(VirtualKeyCode.VK_E);
                    await Task.Delay(3000);
                    simulator.Keyboard.KeyUp(VirtualKeyCode.VK_E);
                    await Task.Delay(23000);

                }

            }

           //if(cbxgehen.Checked == true)
            {
             //   simulator.Mouse.MoveMouseToPositionOnVirtualDesktop(200, 0);
             //   await Task.Delay(100);
            //    simulator.Mouse.MoveMouseToPositionOnVirtualDesktop(210, 0);
            //    await Task.Delay(100);
            //    simulator.Mouse.MoveMouseToPositionOnVirtualDesktop(220, 0);
            //    await Task.Delay(100);
            //    simulator.Mouse.MoveMouseToPositionOnVirtualDesktop(230, 0);
            //    await Task.Delay(100);
            //    simulator.Mouse.MoveMouseToPositionOnVirtualDesktop(240, 0);
            //    await Task.Delay(100);
            //   simulator.Mouse.MoveMouseToPositionOnVirtualDesktop(260, 0);
            //    await Task.Delay(100);
            //    simulator.Mouse.MoveMouseToPositionOnVirtualDesktop(270, 0);
            //    await Task.Delay(100);
            //    simulator.Mouse.MoveMouseToPositionOnVirtualDesktop(280, 0);
            //    await Task.Delay(100);
            //    simulator.Mouse.MoveMouseToPositionOnVirtualDesktop(290, 0);
            //    await Task.Delay(100);
            //    simulator.Mouse.MoveMouseToPositionOnVirtualDesktop(300, 0);
            //    await Task.Delay(100);
            //    simulator.Mouse.MoveMouseToPositionOnVirtualDesktop(310, 0);
            //   await Task.Delay(100);
            //    simulator.Mouse.MoveMouseToPositionOnVirtualDesktop(320, 0);
            //    await Task.Delay(100);
            //    simulator.Mouse.MoveMouseToPositionOnVirtualDesktop(330, 0);
            //    await Task.Delay(100);
            //    simulator.Mouse.MoveMouseToPositionOnVirtualDesktop(340, 0);
            //    await Task.Delay(100);
            ////    simulator.Mouse.MoveMouseToPositionOnVirtualDesktop(350, 0);
            //    await Task.Delay(800);

            //    simulator.Keyboard.KeyDown(VirtualKeyCode.VK_W);
            //    await Task.Delay(3700);
            //    simulator.Keyboard.KeyUp(VirtualKeyCode.VK_W);


            //    simulator.Mouse.MoveMouseToPositionOnVirtualDesktop(200, 0);
            //    await Task.Delay(100);
            //    simulator.Mouse.MoveMouseToPositionOnVirtualDesktop(210, 0);
            //    await Task.Delay(100);
            //    simulator.Mouse.MoveMouseToPositionOnVirtualDesktop(220, 0);
            //    await Task.Delay(100);
            //    simulator.Mouse.MoveMouseToPositionOnVirtualDesktop(230, 0);
            //    await Task.Delay(100);
            //    simulator.Mouse.MoveMouseToPositionOnVirtualDesktop(240, 0);
            //    await Task.Delay(100);
            //    simulator.Mouse.MoveMouseToPositionOnVirtualDesktop(250, 0);
            //    await Task.Delay(100);
            //    simulator.Mouse.MoveMouseToPositionOnVirtualDesktop(255, 0);
            //    await Task.Delay(800);

            //    simulator.Keyboard.KeyDown(VirtualKeyCode.VK_W);
            //    await Task.Delay(2600);
            //    simulator.Keyboard.KeyUp(VirtualKeyCode.VK_W);

            }

          // if(cbxverarbeiten.Checked == true)
            {
            //    for (int i = anzahl; i > 0; i--)
                {
            //        await Task.Delay(1000);
            //        simulator.Keyboard.KeyDown(VirtualKeyCode.VK_E);
             //       await Task.Delay(3000);
            //        simulator.Keyboard.KeyUp(VirtualKeyCode.VK_E);
             //       await Task.Delay(23000);

                }
            }
            
     
            ;
         //   MessageBox.Show(Convert.ToString(anzahl), "rest", MessageBoxButtons.OK);
        }
    }
}
