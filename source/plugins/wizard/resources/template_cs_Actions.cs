using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using JediMake;

namespace jpl.vscs2010.testplugin
{
    public partial class Actions : Form, IActionCallback
    {
        public Actions()
        {
            InitializeComponent();
        }
        
        public void Execute( String Action)
        {
            MessageBox.Show( "Action from VS C# 2010 Called");
        }
    }
}