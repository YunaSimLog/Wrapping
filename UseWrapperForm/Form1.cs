using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wrapper;

namespace UseWrapperForm
{
    public partial class Form1 : Form
    {
        MyArithmetic m_Arithmetic;

        public Form1()
        {
            InitializeComponent();

            m_Arithmetic = new MyArithmetic();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int nValueA = GetIntValueA();
            int nValueB = GetIntValueB();

            int nValue = m_Arithmetic.Add(nValueA, nValueB);
            tbResult.Text = nValue.ToString();
        }

        private void btnSubstract_Click(object sender, EventArgs e)
        {
            int nValueA = GetIntValueA();
            int nValueB = GetIntValueB();

            int nValue = m_Arithmetic.Subtract(nValueA, nValueB);
            tbResult.Text = nValue.ToString();
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            float fValueA = GetIntValueA();
            float fValueB = GetIntValueB();

            float fValue = m_Arithmetic.Multiply(fValueA, fValueB);
            tbResult.Text = fValue.ToString();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            float fValueA = GetIntValueA();
            float fValueB = GetIntValueB();

            float fValue = m_Arithmetic.Divide(fValueA, fValueB);
            tbResult.Text = fValue.ToString();
        }

        private int GetIntValueA()
        {
            return Convert.ToInt32(numValueA.Value);
        }

        private int GetIntValueB()
        {
            return Convert.ToInt32(numValueB.Value);
        }
    }
}
