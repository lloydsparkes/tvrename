//
// Main website for TVRename is http://tvrename.com
//
// Source code available at http://code.google.com/p/tvrename/
//
// This code is released under GPLv3 http://www.gnu.org/licenses/gpl.html
//
//
// Main website for TVRename is http://tvrename.com
//
// Source code available at http://code.google.com/p/tvrename/
//
// This code is released under GPLv3 http://www.gnu.org/licenses/gpl.html
//

using System;
using System.ComponentModel;
using System.Collections;
using System.Windows.Forms;
using System.Data;
using System.Drawing;


namespace TVRename
{

	/// <summary>
	/// Summary for ShowException
	///
	/// WARNING: If you change the name of this class, you will need to change the
	///          'Resource File Name' property for the managed resource compiler tool
	///          associated with all .resx files this class depends on.  Otherwise,
	///          the designers will not be able to interact properly with localized
	///          resources associated with this form.
	/// </summary>
	public class ShowException : System.Windows.Forms.Form
	{
	  private Exception mException;
		public ShowException(Exception e)
		{
			InitializeComponent();

			mException = e;
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
	private System.Windows.Forms.TextBox txtText;

	private System.Windows.Forms.Button button1;
	private System.Windows.Forms.Label label1;

		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components;

#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
		  System.ComponentModel.ComponentResourceManager resources = (new System.ComponentModel.ComponentResourceManager(typeof(ShowException)));
		  this.txtText = (new System.Windows.Forms.TextBox());
		  this.button1 = (new System.Windows.Forms.Button());
		  this.label1 = (new System.Windows.Forms.Label());
		  this.SuspendLayout();
		  // 
		  // txtText
		  // 
		  this.txtText.Anchor = (System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
		  this.txtText.Location = new System.Drawing.Point(12, 58);
		  this.txtText.Multiline = true;
		  this.txtText.Name = "txtText";
		  this.txtText.ReadOnly = true;
		  this.txtText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
		  this.txtText.Size = new System.Drawing.Size(652, 300);
		  this.txtText.TabIndex = 0;
		  // 
		  // button1
		  // 
		  this.button1.Anchor = (System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right));
		  this.button1.Location = new System.Drawing.Point(589, 364);
		  this.button1.Name = "button1";
		  this.button1.Size = new System.Drawing.Size(75, 23);
		  this.button1.TabIndex = 1;
		  this.button1.Text = "Close";
		  this.button1.UseVisualStyleBackColor = true;
		  this.button1.Click += new System.EventHandler(button1_Click);
		  // 
		  // label1
		  // 
		  this.label1.Location = new System.Drawing.Point(12, 9);
		  this.label1.Name = "label1";
		  this.label1.Size = new System.Drawing.Size(652, 46);
		  this.label1.TabIndex = 2;
		  this.label1.Text = resources.GetString("label1.Text");
		  // 
		  // ShowException
		  // 
		  this.AutoScaleDimensions = new System.Drawing.SizeF(6, 13);
		  this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		  this.ClientSize = new System.Drawing.Size(676, 399);
		  this.Controls.Add(this.label1);
		  this.Controls.Add(this.button1);
		  this.Controls.Add(this.txtText);
		  this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
		  this.Name = "ShowException";
		  this.ShowInTaskbar = false;
		  this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		  this.Text = "Exception";
		  this.Load += new System.EventHandler(ShowException_Load);
		  this.ResumeLayout(false);
		  this.PerformLayout();

		}
#endregion
	private void ShowException_Load(object sender, System.EventArgs e)
			 {
			   string t;
			   t = mException.Message + "\r\n\r\n" + mException.StackTrace;
			   txtText.Text = t;
			 }
	private void button1_Click(object sender, System.EventArgs e)
			 {
			   this.Close();
			 }
	}
}


