﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace encryption
{
    public partial class Key : Form
    {
        public Key()
        {
            InitializeComponent();
            Properties.Settings.Default.Save();  // Сохраняем переменные.
        }
        private void Key_Load(object sender, EventArgs e)
        {

        }
        private void Key_KeyDown(object sender, KeyEventArgs e)
        {
            ///Попытка в в закрытие формы через кнопку Enter
            //if (e.KeyCode == Keys.Enter)
            //{
            //    Searcher searcher = new Searcher(KeyStringBox.Text);
            //    searcher.Set();
            //}
        }
        private void StringBox_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(KeyStringBox.Text)) //== (OutResult.Text.Length < 4))
            {
                InOutPutDataError.SetError(KeyStringBox, "Нe может быть пустым!");
            }
            //else if (OutResult.Text.Length < 4)
            //{
            //    InOutPutDataError.SetError(OutResult, "Слишком короткое имя!");
            //}
            else
            {
                InOutPutDataError.Clear();
            }

        }

        //private void СolumnBox_TextChanged(object sender, EventArgs e)
        //{
        //    if (String.IsNullOrEmpty(СolumnBox.Text)) //== (OutResult.Text.Length < 4))
        //    {
        //        InOutPutDataError.SetError(СolumnBox, "Нe может быть пустым!");
        //    }
        //    //else if (OutResult.Text.Length < 4)
        //    //{
        //    //    InOutPutDataError.SetError(OutResult, "Слишком короткое имя!");
        //    //}
        //    else
        //    {
        //        InOutPutDataError.Clear();
        //    }
        //}

        private void Key_FormClosing(object sender, FormClosingEventArgs e)
        {
            DataReform.KeyStringText = KeyStringBox.Text;
            //DataReform.СolumnText = СolumnBox.Text;
            //Properties.Settings.Default.StringText();
            //Properties.Settings.Default.СolumnText();
            //Properties.Settings.Default.Save();           
        }

        private void CloseThisForm_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(KeyStringBox.Text))//(String.IsNullOrEmpty(СolumnBox.Text))
            {
                MessageBox.Show("Заполни пробелы бро!","Брооооо.....", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Properties.Settings.Default.SaveTextColumn = СolumnBox.Text; // Записываем содержимое СolumnBox в SaveTextColumn
                Properties.Settings.Default.SaveTextSrting = KeyStringBox.Text; // Записываем содержимое StringBox в SaveTextSrting
                Properties.Settings.Default.Save(); // Сохраняем переменные.
                this.Close();
            }
        }

        private void StringBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        //private void СolumnBox_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    char number = e.KeyChar;
        //    if (!Char.IsDigit(number) && e.KeyChar != Convert.ToChar(8))
        //    {
        //        e.Handled = true;
        //    }
        //}
    }
}
