using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiceRollerSolution
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var _sides = int.Parse(this.textBox1.Text);
            var _rand = new DiceRollerLogic.DiceRoller().RollDice(_sides);
            this.Output.Text = _rand.ToString();    
        }

       
    }
}
