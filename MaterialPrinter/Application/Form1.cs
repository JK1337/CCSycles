using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace MaterialPrinter
{
	public partial class Form1 : Form, IUI
	{

		delegate void SetTextCallback(string text);
        delegate void SetProgress(int value);

        public void IUIConsole(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.txtConsole.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(IUIConsole);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                string sent = this.txtConsole.Text;
                this.txtConsole.Text = text + "\r\n" + sent;
            }
        }

        public void IUIProgress(int val)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.progressBar1.InvokeRequired)
            {
                SetProgress d = new SetProgress(IUIProgress);
                this.Invoke(d, new object[] { val });
            }
            else
            {
                string sent = this.txtConsole.Text;
                this.progressBar1.Value = val;
            }
        }

		public bool ControlInvokeRequired(Control c, Action a)
		{
			if (c.InvokeRequired) c.Invoke(new MethodInvoker(delegate { a(); }));
			else return false;

			return true;
		}

		public void UpdatelblProgress(String text)
		{
			//Check if invoke requied if so return - as i will be recalled in correct thread
			if (ControlInvokeRequired(this.txtConsole, () => UpdatelblProgress(text))) return;
		}

		public Form1()
		{
			InitializeComponent();

            #region tabpages
            //this.tabPage1.SuspendLayout();
            //this.tabPage1.Controls.Add(tableLayoutPanel1);
            //this.tableLayoutPanel1.Dock = DockStyle.Fill;
            //this.tabPage1.ResumeLayout();

            //this.tabPage3.Controls.Add(tableLayoutPanel2);
            //this.tableLayoutPanel2.Dock = DockStyle.Fill;
            //this.tabPage3.Controls.Add(panel1);
            //this.panel1.Dock = DockStyle.Bottom;
            //this.tabPage3.ResumeLayout();
            #endregion

            Engine.Iui = this;
		}

        #region Scene Select Button Handler
        //private void btnSelectScene_Click(object sender, EventArgs e)
        //{
        //    DialogResult result = openFileDialog1.ShowDialog();
        //    if (result == DialogResult.OK) // Test result.
        //    {
        //        string file = openFileDialog1.FileName;
        //        try
        //        {
        //            //txtSelectedScene.Text = File.ReadAllText(file);
        //            txtSelectedScene.Text = file;
        //        }
        //        catch (IOException)
        //        {
        //        }
        //    }
        //    Console.WriteLine(result); // <-- For debugging use.
        //}
        #endregion

        private void btnSelectMaterial_Click(object sender, EventArgs e)
		{
			DialogResult result = openFileDialog2.ShowDialog();
			if (result == DialogResult.OK) // Test result.
			{
				string file = openFileDialog2.FileName;
				try
				{
                    btnSelectMaterial.Text = file;
				}
				catch (IOException)
				{
				}
			}
			Console.WriteLine(result); // <-- For debugging use.
		}

		private void btnSelectOutputFolder_Click(object sender, EventArgs e)
		{
			DialogResult result = folderBrowserDialog1.ShowDialog();
			if (result == DialogResult.OK) // Test result.
			{
				string file = folderBrowserDialog1.SelectedPath;
				try
				{
                    btnSelectOutputFolder.Text = file;
				}
				catch (IOException)
				{
				}
			}
			Console.WriteLine(result); // <-- For debugging use.
		}

		private void onFormClosed(object sender, FormClosingEventArgs e)
		{
			backgroundWorker1.CancelAsync();
		}

		private void btnRender_Click(object sender, EventArgs e)
		{
            //if (!Engine.Initialised)
            //{
            //    IUIConsole("Initialising Cycles engine (First run)");

            //    Engine.Initiate();

            //}
            //Engine.RenderLoop();
            backgroundWorker1.RunWorkerAsync();
			btnRender.Enabled = false;
			btnCancel.Visible = true;    
		}
		
		private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
		{
			BackgroundWorker worker = sender as BackgroundWorker;

			if (!Engine.Initialised)
			{
                IUIConsole("Initialising Cycles engine (First run)");
				Engine.Initiate();

                //if engine is initialising but isn't finished yet.
			}

			if (worker.CancellationPending == true)
			{
				e.Cancel = true;
				//break;
			}
			else
			{
				// Perform a time consuming operation and report progress.
				//System.Threading.Thread.Sleep(500);
				//Engine.Render(0);
                Engine.RenderLoop();
				worker.ReportProgress(0);
			}
		}

		// This event handler updates the progress. 
		private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
		{
			//Console.WriteLine((e.ProgressPercentage.ToString() + "%"));
			//UpdatelblProgress((e.ProgressPercentage.ToString() + "%"));
            IUIConsole(e.ProgressPercentage.ToString() + "%");
			this.progressBar1.Value = e.ProgressPercentage;
		}

		// This event handler deals with the results of the background operation. 
		private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			if (e.Cancelled == true)
			{
				//Console.WriteLine("Canceled!");
				//UpdatelblProgress("Canceled!");
				IUIConsole("Canceled!");
			}
			else if (e.Error != null)
			{
				//Console.WriteLine("Error: " + e.Error.Message);
				//UpdatelblProgress("Error: " + e.Error.Message);
                IUIConsole("Error: " + e.Error.Message);
			}
			else
			{
				//Console.WriteLine("Done!");
				//UpdatelblProgress("Done!");
				IUIConsole("Done!");
			}

			this.btnCancel.Visible = false;
			this.btnRender.Enabled = true;
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			backgroundWorker1.CancelAsync();
		}

        #region get Scene Filename
        //public string getSceneFileName()
        //{
        //    return txtSelectedScene.Text;
        //}
        #endregion

        public string getMaterialFileName()
		{
            string result;
            if (btnSelectMaterial.Text == "- Select your Material file -")
                result = "";
            else
                result = btnSelectMaterial.Text;
            return result;
		}

		public string getOutputFolderName()
		{
            string result;
            if (btnSelectOutputFolder.Text == "- Select your Output folder -")
                result = "";
            else
                result = btnSelectOutputFolder.Text;
			return result;
		}

		private void btnCompile_Click(object sender, EventArgs e)
		{
			//Engine.CompileMaterial();
			if (!Engine.Initialised)
			{
				IUIConsole("Initialising Cycles engine (First run)");
				
				Engine.Initiate();
				
			}

			Engine.CompileMaterial(btnSelectMaterial.Text);
		}

        private void txtConsole_TextChanged(object sender, EventArgs e)
        {
            this.Refresh();
        }

	}
}
