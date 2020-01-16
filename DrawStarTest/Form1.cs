using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DrawStarTemplate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void drawButton_Click(object sender, EventArgs e)
        {
            Graphics formGraphics = this.CreateGraphics();
            formGraphics.Clear(Color.DarkKhaki);

            Pen starPen = new Pen(Color.Black);

            float xValue, yValue, size;

            xValue = Convert.ToSingle(xInput.Text);
            yValue = Convert.ToSingle(yInput.Text);
            size = Convert.ToSingle(sizeInput.Text);

            // create your call the the DrawStar method here using 
            // the parameters starPen, xValue, yValue, and size
        }    
        
        // create your DrawStar method here
    }
}
