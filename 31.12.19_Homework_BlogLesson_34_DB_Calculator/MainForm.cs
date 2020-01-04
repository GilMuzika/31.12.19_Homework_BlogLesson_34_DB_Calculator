using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _31._12._19_Homework_BlogLesson_34_DB_Calculator
{
    public partial class MainForm : Form
    {
        private DAO currentDAO = new DAO();
        private decimal X;
        private decimal Y;

        public MainForm()
        {
            InitializeComponent();
            Initialize();
        }
        private void Initialize()
        {
            cmbOperation.Items.AddRange(new object[] {"+","-","*","/"});
            cmbOperation.SelectedIndex = 0;
            cmbOperation.DropDownStyle = ComboBoxStyle.DropDownList;

            txtX.TextChanged += checkIfNumeric;
            txtY.TextChanged += checkIfNumeric;
        }
        private void checkIfNumeric(object sender, EventArgs e)
        {
            var text = (sender as TextBox).Text;
            if (!Int32.TryParse(text, out int textAsNum))
            {
                char[] digits = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
                string text2 = string.Empty;
                foreach (var s in text) if (digits.Contains(s)) text2 += s;

                (sender as TextBox).Text = text2;
                MessageBox.Show("Please enter only numbers");
            }
            else
            {
                switch((sender as TextBox).Name.Substring(3))
                {
                    case "X": X = textAsNum; break;
                    case "Y": Y = textAsNum; break;
                }

            }
            
            //lblResult.Text = $"{X.ToString()}, {Y.ToString()}"; 
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            currentDAO.addNumber(Convert.ToDecimal(X), "X");
            currentDAO.addNumber(Convert.ToDecimal(Y), "Y");
            lblResult.Text = currentDAO.Calculate(cmbOperation.SelectedItem as string).ToString();

        }
    }
}
