﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KAM_Remake_Launcher
{
    public partial class frmVerGame : Form
    {
        public DialogResult ShowDialog_VerGame(string aCaption, string aText, string aYesBtn, string aNoBtn)
        {
            lblCaption.Text = aCaption;
            lblText.Text = aText;
            btnYes.Text = aYesBtn;
            btnNo.Text = aNoBtn;
            return ShowDialog();
        }

        public frmVerGame()
        {
            InitializeComponent();
        }
    }
}