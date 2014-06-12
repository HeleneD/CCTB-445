using DesktopApp.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Set the application's start date/time in the status bar.  object is an instance of a class.
            StartTimeStatus.Text = "App Started on " + DateTime.Now.ToString();
        }
        #region Support Methods

        // vehicle loaner = new car() refer to a more specific thing by its general type of classification
        // int minutes = loaner.Move(10);
        // polymorphism  :  call generic specific implementation
        //                                  where T is a Form , new ensures a constrain that this is a class, newable - can be instantiated    
        //   parameter list constructor required.  constraining type is a class, is a newable thing
        //  could be done as a value rather than as reference which we are doing now.
        // Linq Language integrated query .no
        // Unit testing no, makes use of extension methods
        // extension and generics > functionality
        // before entity framework, ado.net, command, connection object and data readers - whole mismatch. db nulls on primitives and 
        private void LaunchOrActivate<T>() where T : Form, new()
        {
            T theForm = GetChildForm<T>();
            if (theForm == null)
            {
                theForm = new T();
                theForm.MdiParent = this;
                theForm.WindowState = FormWindowState.Maximized;
                theForm.Show();
            }
            else
            {
                theForm.WindowState = FormWindowState.Maximized;
                theForm.Focus();
            }
        }
        //  is like typeof java
        // ordinary object inheritance
        private T GetChildForm<T>() where T : Form
        {
            foreach ( var childForm in MdiChildren)
            
            {
                if (childForm is T)
                {
                return (T)childForm;
                }
            }  
            return null;     
         }
        #endregion
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO:  1) open the about app form as a dialog.. create instance of the form
            LaunchOrActivate<ProductSalesForm>();
            //AboutApp theForm = new AboutApp();
            //theForm.Text = "Glad you asked";
            //theForm.ShowDialog(); // we pause in this method until the AboutApp form is closed.
            //MessageBox.Show("Thanks for asking.");
        }

        private void shippersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewShippers theForm = new ViewShippers();
            theForm.MdiParent = this;  // Tell the form that I (main form ) am the parent
            theForm.WindowState = FormWindowState.Maximized;
            theForm.Show(); // we do NOT pause here as we show the form...
            MessageBox.Show("Here's the ViewShipper's Form!");
        }

        private void productSalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductSalesForm myForm = new ProductSalesForm();
            myForm.MdiParent = this;
            myForm.WindowState = FormWindowState.Maximized;
            myForm.Show();

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO: Close the program/form
            this.Close();
        }

        private void regionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO: Open a form as a dialog box
            ViewRegions frm = new ViewRegions();

            frm.ShowDialog(); // Execution of this method will PAUSE here until the dialog box (ViewRegions) is closed
            // resume after the dialog box is closed

        }
    }
}
