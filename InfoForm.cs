/*
 * Created by SharpDevelop.
 * User: ZHANITEST
 * Date: 2019-07-14
 * Time: 오전 2:43
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuickSpecs
{
	/// <summary>
	/// Description of InfoForm.
	/// </summary>
	public partial class InfoForm : Form
	{
		public InfoForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			this.Close();
		}
		
	}
}
