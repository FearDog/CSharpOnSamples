using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
  public partial class Form1 : Form
  {
    float a, b;
    int oper;
    bool znak = true;

    private void btn_Rev_Click(object sender, EventArgs e)
    {
      if (znak)
        textBox1.Text = "-" + textBox1.Text;
      else
        textBox1.Text = textBox1.Text.Replace("-", "");
      znak = !znak;
    }

    public Form1()
    {
      InitializeComponent();
    }
  }
}
