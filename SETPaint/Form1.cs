
/*
 * 
 * FILE             : Form1.cs
 * PROJECT          : prog2120-SETPaint
 * PROGRAMMER       : SAMEER SAPRA(6845382)
 * FIRST VERSION    : 10/5/2014
 * DESCRIPTION      : This application draws 3 simple shapes (line, rectangle and sphere) by selecting different radio buttons. Their properties can be changed
 *                    by selecting different checkboxes,but it has to selected before drawing the respective shape. It can also clear the current drawing drawn
 *                    by selecting edit menu.
 *                  
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

namespace SETPaint
{
    public partial class SETPaint : Form
    {

        //Global variables.
        bool mouseDown = false;
       
        int height = 0;
        int width = 0;

        //different points are used to store the postions of mouse.
        Point mouseDownPoint = new Point();
        Point mouseUpPoint = new Point();
        Point mouseInitialPoint = new Point();
        Point rect_initial_point = new Point();

        //bitmap used to store the dashed shapes.
        Bitmap dashed_bmp;

        //bitmap used to store original shapes after mouse up event. 
        Bitmap original_bmp;

        //Brush fillcolor;
        Graphics mm1;
       
        public SETPaint()
        {
            InitializeComponent();
            original_bmp = new Bitmap(paint_area.Width, paint_area.Height);
            mm1 = paint_area.CreateGraphics();

            //save the file in png format.
            saveFileDialog1.Filter = "Image Files (*.png)|*.png" ;
            colorDialog2.Color = Color.White;
            
        }




        /* FUNCTION NAME : void paint_area_MouseDown
         * 
         * PARAMETERS    : object sender    : action called by the control. 
         *               : MouseEventArgs e : current event's i.e paint_area_MouseDown properties.
         *               
         * DESCRIPTION   : This event is raised and gets the position of mouse when left button is clicked on the paint_area control.
         * 
         * RETURN        : void
         * 
         */

        private void paint_area_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseDownPoint.X = e.X;
                mouseDownPoint.Y = e.Y;
                mouseInitialPoint.X = mouseDownPoint.X;
                mouseInitialPoint.Y = mouseDownPoint.Y;
                mouseDown = true;
            }
        }



        /* FUNCTION NAME : void paint_area_MouseMove
         * 
         * PARAMETERS    : object sender    : action called by the control. 
         *               : MouseEventArgs e : current event's i.e paint_area_MouseMove.
         *               
         * DESCRIPTION   : This event is stores the position of mouse whenever it moves while on paint_area control while pressed down.
         *                 If any of the radio button is selected then it will create the selected shape else it will create a fr
         * 
         * RETURN        : void
         * 
         */

        private void paint_area_MouseMove(object sender, MouseEventArgs e)
        {
            //creates a copy of the original_bmp bitmap.
            dashed_bmp = (Bitmap)original_bmp.Clone();

            //creates a graphic object to get the graphics from the bitmap.
            Graphics mm = Graphics.FromImage(dashed_bmp);

            //show whatever is in bitmap on the paint_area control's background image property.
            paint_area.BackgroundImage = dashed_bmp;

            //color of pen.
            Pen pen = new Pen(Color.Black);
            pen.DashCap = System.Drawing.Drawing2D.DashCap.Round;

            // Create a custom dash pattern.
            pen.DashPattern = new float[] { 1.0F, 2.0F, 1.0F, 2.0F };

            //point of mouse while moving.
            mouseUpPoint.X = e.X;
            mouseUpPoint.Y = e.Y;

           

            //if mouse's left button is pressed.
            if (mouseDown)
            {
                //prints the postion of the mouse while moving on the paint_area control.
                mouse_position.Text = "Position is : " + e.X.ToString() + "  " + e.Y.ToString();

                //if user has selected to draw a line.
                if (line_r_button.Checked)
                {
                    //draw line.
                    mm.DrawLine(pen, mouseInitialPoint, mouseUpPoint);
                }
                else
                {
                    //if user has selected to draw a rectangle.
                    if (rectangle_r_button.Checked)
                    {
                        //check whether rectangle is left/right top/bottom quarter.
                        check_rectangle_position();

                        //draw rectangle.
                        mm.DrawRectangle(pen, rect_initial_point.X, rect_initial_point.Y, width, height);
                    }
                    else
                    {
                        //if user has selected to draw a ellipse.
                        if (ellipse_r_button.Checked)
                        {
                            //check whether rectangle is left/right top/bottom quarter.
                            check_rectangle_position();

                            //draw ellipse.
                            mm.DrawEllipse(pen, rect_initial_point.X, rect_initial_point.Y, width, height);
                        }
                        else
                        {
                            //free path drawn.
                            mm.DrawLine(pen, mouseDownPoint, mouseUpPoint);
                            mouseDownPoint.X = e.X;
                            mouseDownPoint.Y = e.Y;
                        }
                    }
                }
            }
            else
            {
                mouse_position.Text = "";
            }
        }



        /* FUNCTION NAME : void paint_area_MouseUp
         * 
         * PARAMETERS    : object sender    : action called by the control. 
         *               : MouseEventArgs e : current event's i.e paint_area_MouseMove.
         *               
         * DESCRIPTION   : This event creates a selected shape with the starting point as mouse_down event's mosue position and end point be paint_area_MouseUp 
         *                 event mouse postion.
         * 
         * RETURN        : void
         * 
         */
        private void paint_area_MouseUp(object sender, MouseEventArgs e)
        {
            //local variables.
            int border_width = 0;
            int index = 0;
           
            //gets the width for the line or border.
            index = line_width.SelectedIndex;
            switch (index)
            {
                case 0:
                    border_width = 1;
                    break;
                case 1:
                    border_width = 3;
                    break;
                case 2:
                    border_width = 5;
                    break;
                case 3:
                    border_width = 8;
                    break;

            }

            if (mouseDown)
            {
                //copy the bitmap.
                original_bmp = (Bitmap)dashed_bmp.Clone();
                Graphics m = Graphics.FromImage(original_bmp);
                Pen pen = new Pen(colorDialog1.Color, border_width);

                //if user wants to draw a line.
                if (line_r_button.Checked)
                {
                    m.DrawLine(pen, mouseInitialPoint, mouseUpPoint);
                }

                //if user wants to draw a rectangle.
                if ((rectangle_r_button.Checked)) 
                {

                    m.DrawRectangle(pen, rect_initial_point.X, rect_initial_point.Y, width, height);
                    m.FillRectangle(new SolidBrush( colorDialog2.Color), rect_initial_point.X, rect_initial_point.Y, width, height);
                 
                   
                }

                //if user wants to draw an ellipse.
                if((ellipse_r_button.Checked))
                {

                    m.DrawEllipse(pen, rect_initial_point.X, rect_initial_point.Y, width, height);
                    m.FillEllipse(new SolidBrush(colorDialog2.Color), rect_initial_point.X, rect_initial_point.Y, width, height);
                }
                mouseDown = false;
          
                //graw the original bitmap on the paint_area contol.
                mm1.DrawImage(original_bmp,paint_area.Width,paint_area.Height);

            }
        }



        /* FUNCTION NAME : check_rectangle_position
        * 
        * PARAMETERS    : 
        *               
        * DESCRIPTION   : This function sets the initial point of the mouse according to the cursor moved. 
        * 
        * RETURN        : void
        * 
        */
        public void check_rectangle_position()
        {
            // top/bottom left corner.
            if (mouseDownPoint.X > mouseUpPoint.X)
            {
                if (mouseDownPoint.Y > mouseUpPoint.Y)
                {
                    //top left quarter.
                    width = mouseInitialPoint.X - mouseUpPoint.X;
                    height = mouseInitialPoint.Y - mouseUpPoint.Y;


                    //set the initial point.
                    rect_initial_point.X = mouseUpPoint.X;
                    rect_initial_point.Y = mouseUpPoint.Y;
                }
                if (mouseDownPoint.Y < mouseUpPoint.Y)
                {
                    //bottom left quarter.
                    width = mouseInitialPoint.X - mouseUpPoint.X;
                    height = mouseUpPoint.Y - mouseInitialPoint.Y;


                    //set the initial point.
                    rect_initial_point.X = mouseUpPoint.X;
                    rect_initial_point.Y = mouseDownPoint.Y;
                }

            }

            else
            {
                if (mouseDownPoint.Y > mouseUpPoint.Y)
                {
                    //top right quarter.
                    width = mouseUpPoint.X - mouseInitialPoint.X;
                    height = mouseInitialPoint.Y - mouseUpPoint.Y;


                    //set the initial point.
                    rect_initial_point.X = mouseInitialPoint.X;
                    rect_initial_point.Y = mouseUpPoint.Y;
                }
                else
                {
                    //bottom right quarter.
                    width = mouseUpPoint.X - mouseInitialPoint.X;
                    height = mouseUpPoint.Y - mouseInitialPoint.Y;


                    //set the initial point.
                    rect_initial_point.X = mouseInitialPoint.X;
                    rect_initial_point.Y = mouseInitialPoint.Y;
                }
            }
        }



        /* FUNCTION NAME : line_color_cb_CheckedChanged
        * 
        * PARAMETERS     : object sender    : action called by the control. 
         *               : EventArgs e : current event.
        *               
        * DESCRIPTION   : This event is raise when line color checkbox is clicked and selects the color of the line or border of the rectangle/ellipse.
        * 
        * RETURN        : void
        * 
        */
        private void line_color_cb_CheckedChanged(object sender, EventArgs e)
        {
           //if checkbox in clicked
            if (line_color_cb.Checked)
            {
                //show the color dialog box.
                colorDialog1.ShowDialog();
            }
                
            else
            {
                //set the default color 
                colorDialog1.Color = Color.Black;
            }
        }



        /* FUNCTION NAME : fill_color_cb_CheckedChanged
        * 
        * PARAMETERS     : object sender    : action called by the control. 
         *               : EventArgs e      : current event.
        *               
        * DESCRIPTION   : This event is raised when line color checkbox is clicked.
        * 
        * RETURN        : void
        * 
        */
        private void fill_color_cb_CheckedChanged(object sender, EventArgs e)
        {
            if(fill_color_cb.Checked)
            {
                //show the color dialog.
                colorDialog2.ShowDialog();
            }
            else
            {
                //set the default color.
                colorDialog2.Color = Color.White;
            }
        }




        /* FUNCTION NAME : exit_file_option_Click
       * 
       * PARAMETERS     : object sender    : action called by the control. 
        *               : EventArgs e      : current event.
       *               
       * DESCRIPTION   : This event is called when exit option under edit is pressed. It closes the form.
       * 
       * RETURN        : void
       * 
       */

        private void exit_file_option_Click(object sender, EventArgs e)
        {
            //close the form.
            this.Close();
        }



        /* FUNCTION NAME : about_menu_Click
        * 
        * PARAMETERS     : object sender    : action called by the control. 
        *               : EventArgs e      : current event.
        *               
        * DESCRIPTION   : This event is called when about option is pressed under help option. It shows a message box.
        * 
        * RETURN        : void
        * 
        */

        private void about_menu_Click(object sender, EventArgs e)
        {
            //show a message box.
            MessageBox.Show("Hello, this small paint application is developed by Sameer Sapra on .Net framework.");
        }





       /* FUNCTION NAME : erase_drawing_Click
       * 
       * PARAMETERS     : object sender    : action called by the control. 
       *                : EventArgs e      : current event.
       *               
       * DESCRIPTION   : This event is called when erase option under edit is pressed and it clears the paint_area control's area.
       * 
       * RETURN        : void
       * 
       */

        private void erase_drawing_Click(object sender, EventArgs e)
        {
            const string message = "Are you sure that you would like to close the form?";
            const string caption = "Erase image";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            // If the yes button was pressed ... 
            if (result == DialogResult.Yes)
            {
                //clear the paint_area control by setting the original_bmp bitmap to empty bitmap which will show nothing on the paint_area control's.
                Bitmap g = new Bitmap(paint_area.Width, paint_area.Height);
                original_bmp = (Bitmap)g.Clone();

            }
        }




        /* FUNCTION NAME : open_file_option_Click
      * 
      * PARAMETERS     : object sender    : action called by the control. 
      *                : EventArgs e      : current event.
      *               
      * DESCRIPTION   : This event is called to open a file and load its graphics into origianl_bmp bitmap.
      * 
      * RETURN        : void
      * 
      */
        private void open_file_option_Click(object sender, EventArgs e)
        {
            string filename;

            //show dialog box.
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filename = openFileDialog1.FileName;

                //get the graphics from the file and sets into bitmap.
                Bitmap b = (Bitmap)Bitmap.FromFile(filename);

                //copies the bitmap.
                original_bmp = (Bitmap)b.Clone();

                //set the background image.
                paint_area.BackgroundImage = original_bmp;
                mm1.DrawImage(b, paint_area.Width, paint_area.Height);

                b.Dispose();
            }
        }




        /* FUNCTION NAME : save_file_option_Click
       * 
       * PARAMETERS     : object sender    : action called by the control. 
       *                : EventArgs e      : current event.
       *               
       * DESCRIPTION   : This event is called to save the drawing created into a file.
       * 
       * RETURN        : void
       * 
       */
        private void save_file_option_Click(object sender, EventArgs e)
        {
            //save the bitmap created in a file.
            string filename;

            //show the dialog.
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {

                filename = saveFileDialog1.FileName;

                saveFileDialog1.CheckFileExists = true;
                saveFileDialog1.CheckPathExists = true;

                //save the file in png format.
                original_bmp.Save(filename);
            }
        }
    }
}
