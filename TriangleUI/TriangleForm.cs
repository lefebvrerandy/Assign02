/* 
 * Programmer:      Randy Lefebvre
 * Course Code:     INFO2180
 * Solution:        Assign02
 * Project:         TriangleUI
 * Description:     This is the code behind the forms UI. It controls the text boxes
 *                  and button clicks. All the math is done in the project called "Triangle".
 * 
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


namespace TriangleUI
{

    public partial class TriangleForm : Form
    {
        public TriangleForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Hyp_Btn_Click()
        /// </summary>
        /// <param>
        /// object sender, EventArgs e
        /// </param>
        /// <desc>
        /// This event takes the values of the top two textboxes and produces 
        /// the result in the third textbox. It calls upon FindHypotenuseOfRight in The
        /// Triangle class.
        /// </desc>
        private void Hyp_Btn_Click(object sender, EventArgs e)
        {
            Double.TryParse(One_Txt.Text, out double value1);
            Double.TryParse(Two_Txt.Text, out double value2);
            double value3;

            Triangle triangle = new Triangle();
            value3 = triangle.FindHypotenuseOfRight(value1, value2);
            if (value3 == -1)
                Three_Txt.Text = "Invalid values.. Cannot find answer.. beep boop..";
            else
                Three_Txt.Text = value3.ToString();

        }

        /// <summary>
        /// Area_Btn_Click()
        /// </summary>
        /// <param>
        /// object sender, EventArgs e
        /// </param>
        /// <desc>
        /// This event takes the values of the top two textboxes and produces 
        /// the result in the third textbox. It calls upon FindAreaOfRight in The
        /// Triangle class.
        /// </desc>
        private void Area_Btn_Click(object sender, EventArgs e)
        {
            Double.TryParse(One_Txt.Text, out double value1);
            Double.TryParse(Two_Txt.Text, out double value2);
            double value3;

            Triangle triangle = new Triangle();
            value3 = triangle.FindAreaOfRight(value1, value2);
            if (value3 == -1)
                Three_Txt.Text = "Invalid values.. Cannot find answer.. beep boop..";
            else
                Three_Txt.Text = value3.ToString();
        }

        /// <summary>
        /// Angle_Btn_Click()
        /// </summary>
        /// <param>
        /// object sender, EventArgs e
        /// </param>
        /// <desc>
        /// This event takes the values of the top two textboxes and produces 
        /// the result in the third textbox. It calls upon FindMissingAngle in The
        /// Triangle class.
        /// </desc>
        private void Angle_Btn_Click(object sender, EventArgs e)
        {
            Double.TryParse(One_Txt.Text, out double value1);
            Double.TryParse(Two_Txt.Text, out double value2);
            double value3;

            Triangle triangle = new Triangle();
            value3 = triangle.FindMissingAngle(value1, value2);
            if (value3 == -1)
                Three_Txt.Text = "Invalid values.. Cannot find answer.. beep boop..";
            else
                Three_Txt.Text = value3.ToString();
        }

        /// <summary>
        /// label1_Click()
        /// </summary>
        /// <desc>
        /// This label event was a mistake when i clicked it in the form, and I cant
        /// find out how to delete it without breaking the form all together.. 
        /// This is just an example of my relationship with visual studios. Love-Hate. 
        /// </desc>
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
