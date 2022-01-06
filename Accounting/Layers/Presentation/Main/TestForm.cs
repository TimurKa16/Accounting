/* 
 * скачал шрифт swiss кириллица
 * Добавил событие по обработке comboBox
 * Добавил ссылку PresentationCore.dll
 * 
 * Чтобы спрятать ScrollBar, необходимо добавить событие MouseWheel
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Runtime.InteropServices;
//using System.Windows.Media;

namespace Accounting
{
    public partial class TestForm : Form
    {
        int selectedIndex = -1;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);




        public TestForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            dataGridView1.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }


        private void TestForm_Load(object sender, EventArgs e)
        {
            //comboBox1.DrawMode = DrawMode.OwnerDrawFixed;

            this.dataGridView1.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.DatagridView_MouseWheel);




        }

        private void comboBox1_DrawItem(object sender, System.Windows.Forms.DrawItemEventArgs e)
        {
            e.DrawBackground();
            //if (e.Index == 0)
            int a = 0;
            label1.Text = e.Index.ToString();
            if (e.Index == -1)
            {
                //label1.BackColor = Color.Red;
                //e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(39, 9, 44)), e.Bounds);

                //e.Graphics.DrawString(this.comboBox1.Items[e.Index].ToString(), this.comboBox1.Font,
                //    new SolidBrush(Color.FromArgb(248, 226, 255)),
                //    new Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height));
            }
            if (comboBox1.DroppedDown)
            {
                if (e.Index >= 0)
                {
                    //label1.BackColor = Color.Green;
                    if (comboBox1.Focused == false)
                    {
                        comboBox1.BackColor = Color.FromArgb(39, 9, 44);
                        comboBox1.ForeColor = Color.FromArgb(248, 226, 255);
                        label1.BackColor = Color.Red;

                    }
                    else
                    {
                        label1.BackColor = Color.Green;
                        //comboBox1.BackColor = Color.FromArgb(39, 9, 44);
                    }
                    //if (comboBox1.DroppedDown)
                    {
                        
                        //if (e.Index > 0)
                        {
                            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                            {

                                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(39, 9, 44)), e.Bounds);

                                e.Graphics.DrawString(this.comboBox1.Items[e.Index].ToString(), this.comboBox1.Font,
                                    new SolidBrush(Color.FromArgb(248, 226, 255)),
                                    new Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height));
                            }
                            else
                            {
                                // 248; 226; 255
                                // 39; 9; 44
                                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(248, 226, 255)), e.Bounds);

                                e.Graphics.DrawString(this.comboBox1.Items[e.Index].ToString(), this.comboBox1.Font,
                                    new SolidBrush(Color.FromArgb(39, 9, 44)),
                                    new Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height));

                            }
                        }
                    }
                    //else
                    //{
                    //    e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(39, 9, 44)), e.Bounds);

                    //    e.Graphics.DrawString(this.comboBox1.Items[e.Index].ToString(), this.comboBox1.Font,
                    //        new SolidBrush(Color.FromArgb(248, 226, 255)),
                    //        new Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height));
                    //}
                }
            }

        }

        private void comboBox1_FormatStringChanged(object sender, EventArgs e)
        {
            //comboBox1.BackColor = Color.FromArgb(39, 9, 44);
        }

        
        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            //comboBox1.Text = "1234";
            comboBox1.SelectionLength = 0;
            label1.Focus();
            //label1.BackColor = Color.Red;
            //comboBox1.BackColor = Color.FromArgb(39, 9, 44);
        }

        private void comboBox1_DropDownClosed(object sender, EventArgs e)
        {
            //comboBox1.BackColor = Color.Red;
            if (selectedIndex >= 0)
            {
                comboBox1.Text = comboBox1.Items[selectedIndex].ToString();
            }
            //comboBox1.BackColor = Color.Red;
            label1.Focus();
            //label1.BackColor = Color.Green;
            //comboBox1.BackColor = Color.FromArgb(39, 9, 44);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //selectedIndex = Convert.ToInt32(comboBox1.SelectedIndex);
            }
            catch (Exception) { }
        }

        private void comboBox1_MouseDown(object sender, MouseEventArgs e)
        {
            comboBox1.SelectionLength = 0;
        }

        private void comboBox1_MouseMove(object sender, MouseEventArgs e)
        {
            comboBox1.SelectionLength = 0;
        }

        private void TestForm_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void upButton_Click(object sender, EventArgs e)
        {
            try
            {
                
                dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.FirstDisplayedScrollingRowIndex - 5;
            }
            catch (Exception)
            {
                dataGridView1.FirstDisplayedScrollingRowIndex = 0;
            }
        }

        private void downButton_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.FirstDisplayedScrollingRowIndex + 5;
            }
            catch (Exception)
            {
                dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.RowCount - 1;
            }
        }

        private void dataGridView1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void DatagridView_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
            {

            }
            else if (e.Delta < 0)
            {
            }
        }

    }
}
