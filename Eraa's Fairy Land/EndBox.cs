using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eraa_s_Fairy_Land
{
    public partial class EndBox : Form
    {
        public EndBox()
        {
            InitializeComponent();
        }

        private void EndBox_Load(object sender, EventArgs e)
        {

        }
        
      
        public void Era(int c)
        {
            
           // String y = c.ToString();
            if(c == 0)
            {
                Impression.Text = "Oops Game is Ended";
                Impression.ForeColor = Color.Maroon;
                String y = c.ToString();
                TotalCollection.Text = y;
                ReactionImage.BackgroundImage = moodImage.Images[0];

            }
           else if(c >=1 && c<8)
            {
                Impression.Text = "Quiet Good! TRY Harder";
                Impression.ForeColor = Color.Maroon;
                String y = c.ToString();
                TotalCollection.Text = y;
                ReactionImage.BackgroundImage = moodImage.Images[3];
            }
            else if (c >=8 && c<100)
            {
                Impression.Text = "Bravo!!!! Good TRY";
                Impression.ForeColor = Color.Maroon;
                String y = c.ToString();
                TotalCollection.Text = y;
                ReactionImage.BackgroundImage = moodImage.Images[4];
            }
        }
        private void StartPage_Click(object sender, EventArgs e)
        {
            Fairy_Land fl= new Fairy_Land();
            fl.Show();
        }
    }
}
