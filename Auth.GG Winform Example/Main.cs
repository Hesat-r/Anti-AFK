using System;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using WindowsInput;
using WindowsInput.Native;
using Notifications.Wpf;


namespace Auth.GG_Winform_Example
{
    public partial class Main : Form
    {
       
        public Main()
        {
            InitializeComponent();
            
           
        }
        
        [DllImport("USER32.DLL", CharSet = CharSet.Unicode)]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("USER32.DLL")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);

        private Form activeForm = null;

        private void openchildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel2.Controls.Add(childForm);
            panel2.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        

        private async void guna2GradientButton1_ClickAsync(object sender, EventArgs e)
        {

            var notificationManager = new NotificationManager();

            //FiveM - [GERMAN] 🔥SKYLINE RP 2.0🔥
            IntPtr calculatorHandle = FindWindow("grcWindow", "FiveM - [GERMAN] 🔥SKYLINE RP 2.0🔥");

            // Verify that Calculator is a running process.
            if (calculatorHandle == IntPtr.Zero)
            {
                notificationManager.Show(new NotificationContent
                {
                    Title = "Fivem-M Start",
                    Message = "Five-M ist nicht gestartet oder du bist nicht auf SKYLINE",
                    Type = NotificationType.Error
                });
                
               // return;

            }

            SetForegroundWindow(calculatorHandle);


            int geld;
            int Sortieren;
            int schneiden;
            int rest;
            int waschen;
            string reststring;
            int grüngeld1;
            double grüngeld;
            string grüngeldstring;
            int zeit;
            string zeitstring;
            geld = Convert.ToInt32(bunifuMetroTextbox1.Text);
            Sortieren = geld / 50000;
            schneiden = geld / 50000;
            waschen = geld / 50000;
            rest = geld % 50000;
            reststring = Convert.ToString(rest);
            grüngeld1 = Sortieren * 50000;
            grüngeld = grüngeld1 * 0.86;
            grüngeldstring = Convert.ToString(grüngeld);
            zeit = Sortieren * 2;
            zeitstring = Convert.ToString(zeit);
            label6.Text = zeitstring + "Min";
            label5.Text = grüngeldstring;
            label4.Text = reststring;
            var simulator = new InputSimulator();
            richTextBox1.Text = "";
            notificationManager.Show(new NotificationContent
            {
                Title = "Start",
                Message = "Programm Wurde Erfolgreich Gestartet!",
                Type = NotificationType.Success
            });
            await Task.Delay(2000);


            if (siticoneCheckBox1.Checked == false && siticoneCheckBox2.Checked == false &&
                siticoneCheckBox3.Checked == false && siticoneCheckBox4.Checked == false &&
                siticoneCheckBox5.Checked == false)
            {
                notificationManager.Show(new NotificationContent
                {
                    Title = "Keine Optionen Ausgewählt",
                    Message = "Du Hast keine Operatoren Ausgewählt, du musst Mindestens 1 Operator Auswählen",
                    Type = NotificationType.Error
                });
                return;
            }

            if (siticoneCheckBox1.Checked == true)
            {
                for (int i = Sortieren; i > 0; i--)
                {
                    richTextBox1.Text += "[" + DateTime.Now.ToShortTimeString() + "] " + i + " Geld wird Sortiert\r\n";
                    notificationManager.Show(new NotificationContent
                    {
                        Title = "Sortieren",
                        Message = "Du musst noch " + i + " Schwarzgeld Sortieren",
                        Type = NotificationType.Success
                    });
                    await Task.Delay(1200);
                    simulator.Keyboard.KeyDown(VirtualKeyCode.VK_E);
                    await Task.Delay(5000);
                    simulator.Keyboard.KeyUp(VirtualKeyCode.VK_E);
                    await Task.Delay(20500);

                   
                }
                
            }else if(siticoneCheckBox1.Checked == false){
                notificationManager.Show(new NotificationContent
                {
                    Title = "Sortieren",
                    Message = "Sortieren wurde nicht ausgewählt",
                    Type = NotificationType.Warning
                });
            }

            if (siticoneCheckBox2.Checked == true)
            {
                notificationManager.Show(new NotificationContent
                {
                    Title = "Schneiden",
                    Message = "Du Gehst zum Schneiden",
                    Type = NotificationType.Success
                });

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
                await Task.Delay(800);

                simulator.Keyboard.KeyDown(VirtualKeyCode.VK_W);
                await Task.Delay(850);
                simulator.Keyboard.KeyDown(VirtualKeyCode.SPACE);
                await Task.Delay(500);
                simulator.Keyboard.KeyUp(VirtualKeyCode.VK_W);
                simulator.Keyboard.KeyUp(VirtualKeyCode.SPACE);
                await Task.Delay(500);
                simulator.Keyboard.KeyDown(VirtualKeyCode.VK_S);
                await Task.Delay(700);
                simulator.Keyboard.KeyUp(VirtualKeyCode.VK_S);

             
            }
            else if (siticoneCheckBox2.Checked == false)
            {
                notificationManager.Show(new NotificationContent
                {
                    Title = "Gehen",
                    Message = "Du Gehst nicht Automatisch zum Sortieren",
                    Type = NotificationType.Warning
                });
            }

            if (siticoneCheckBox3.Checked == true)
            {
                for (int i = schneiden; i > 0; i--)
                {

                    notificationManager.Show(new NotificationContent
                    {
                        Title = "Schneiden",
                        Message = "Du musst noch " + i + " Schwarzgeld Geschnitten",
                        Type = NotificationType.Warning
                    });
                    richTextBox1.Text += "[" + DateTime.Now.ToShortTimeString() + "] " + i + " Geld wird Sortiert\r\n";
                    await Task.Delay(1000);
                    simulator.Keyboard.KeyDown(VirtualKeyCode.VK_E);
                    await Task.Delay(1000);
                    simulator.Keyboard.KeyUp(VirtualKeyCode.VK_E);
                    await Task.Delay(45500);

                    

                }
            }else if (siticoneCheckBox3.Checked == false)
            {
                notificationManager.Show(new NotificationContent
                {
                    Title = "Sortieren",
                    Message = "Du Sortierst nicht Automatisch",
                    Type = NotificationType.Warning
                });
            }

            if (siticoneCheckBox4.Checked == true)
            {
                notificationManager.Show(new NotificationContent
                {
                    Title = "Gehen",
                    Message = "Du Gehst zum Waschen",
                    Type = NotificationType.Success
                });

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
                await Task.Delay(800);
                simulator.Keyboard.KeyDown(VirtualKeyCode.VK_W);
                await Task.Delay(1200);
                simulator.Keyboard.KeyUp(VirtualKeyCode.VK_W);

               

            }
            else if (siticoneCheckBox4.Checked == false)
            {
                notificationManager.Show(new NotificationContent
                {
                    Title = "Gehen",
                    Message = "Du Gehst nicht Automatisch zum Waschen",
                    Type = NotificationType.Warning
                });
            }

            if (siticoneCheckBox5.Checked == true)
            {
                for (int i = waschen; i > 0; i--)
                {

                    notificationManager.Show(new NotificationContent
                    {
                        Title = "Waschen",
                        Message = "Du musst noch " + i + " Schwarzgeld Waschen",
                        Type = NotificationType.Warning
                    });

                    richTextBox1.Text += "[" + DateTime.Now.ToShortTimeString() + "] " + i + " Geld wird Gewaschen\r\n";

                    await Task.Delay(1000);
                    simulator.Keyboard.KeyDown(VirtualKeyCode.VK_E);
                    await Task.Delay(1000);
                    simulator.Keyboard.KeyUp(VirtualKeyCode.VK_E);
                    await Task.Delay(45500);


                   

                }
            }else if (siticoneCheckBox5.Checked == false)
            {
                notificationManager.Show(new NotificationContent
                {
                    Title = "Waschen",
                    Message = "Du Wäscht nicht Automatisch",
                    Type = NotificationType.Warning
                });
            }

           
           
            

            richTextBox1.Text += "[" + DateTime.Now.ToShortTimeString() + "]" + " Erledigt\r\n";
            notificationManager.Show(new NotificationContent
            {
                Title = "Erfolgreich Gewaschen",
                Message = "Geld Erfolgreich Gewaschne Zahle Das Geld in einer Bank Ein",
                Type = NotificationType.Success
            });

        }

        private void button4_Click(object sender, EventArgs e)
        {

            Environment.Exit(0);
            
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            
            Task.WaitAll();
            var notificationManager = new NotificationManager();
            notificationManager.Show(new NotificationContent
            {
                Title = "IN ARBEIT",
                Message = "STOPP BUTTON IST IN ARBEIT",
                Type = NotificationType.Information
            });
            

            

        }
        

 

        private void button2_Click(object sender, EventArgs e)
        {
            openchildForm(new Koks());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openchildForm(new mdma());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            openchildForm(new Afk());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Close();

        }
    }
}
