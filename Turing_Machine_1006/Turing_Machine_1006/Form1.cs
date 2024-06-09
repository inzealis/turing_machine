using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.Remoting.Channels;
using System.Runtime.CompilerServices;

namespace Turing_Machine_1006
{
    public partial class Form1 : Form
    {
        public int condition_count = 2;
        public DataTable dt = new DataTable();
        public int current_position = 0;
        TMState tMState = new TMState();
        TuringMachine turingMachine = new TuringMachine();
        public int last_i = 0, last_j = 0;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView_RuleSet.AllowUserToAddRows = false;
            dataGridView_tape.AllowUserToAddRows = false;
            dataGridView_tape.ColumnCount = 101;
            dataGridView_tape.RowCount = 2;

            for (int i = 0; i < 101; i++)
            {
                dataGridView_tape.Rows[0].Cells[i].Value = i - 50;
                dataGridView_tape.Rows[1].Cells[i].Value = null;
            }

            dataGridView_tape.HorizontalScrollingOffset = 4515;

            dataGridView_tape.Rows[0].Cells[current_position + 50].Style.BackColor = Color.LightBlue;
            dataGridView_tape.Rows[1].Cells[current_position + 50].Style.BackColor = Color.LightBlue;
            dataGridView_tape.Rows[1].Cells[current_position + 50].Selected = true;

            button1_Click(sender, e);
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_Create_Click(object sender, EventArgs e)
        {
            button_OK.Enabled = true;
            button_Start.Enabled = false;
            button_Step.Enabled = false;

            string ABS = textBox_ABS.Text;
            if (ABS.Length > 0)
            {
                dt = new DataTable();
                condition_count = 2;
                dt.Columns.Add(" ");
                dt.Columns.Add("Q1");
                dt.Columns.Add("Q2");
                for (int i = 0; i < ABS.Length; i++)
                    dt.Rows.Add(ABS[i]);
            }
            dataGridView_RuleSet.DataSource = dt;
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            condition_count++;
            dt.Columns.Add("Q" + condition_count.ToString());
        }

        private void button_del_Click(object sender, EventArgs e)
        {
            if (condition_count > 2)
            {
                dt.Columns.RemoveAt(condition_count);
                condition_count--;
            }
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dt.Rows.Count; i++)
                for (int j = 1; j < condition_count + 1; j++)
                    dt.Rows[i][j] = "";
        }

        private void button_R_Click(object sender, EventArgs e)
        {
            if (current_position < 45)
            {
                current_position++;
                dataGridView_tape.HorizontalScrollingOffset += 100;
                dataGridView_tape.Rows[0].Cells[current_position + 49].Style.BackColor = Color.White;
                dataGridView_tape.Rows[1].Cells[current_position + 49].Style.BackColor = Color.White;
                dataGridView_tape.Rows[0].Cells[current_position + 50].Style.BackColor = Color.LightBlue;
                dataGridView_tape.Rows[1].Cells[current_position + 50].Style.BackColor = Color.LightBlue;
            }
        }

        private void button_L_Click(object sender, EventArgs e)
        {
            if (current_position > -45)
            {
                current_position--;
                dataGridView_tape.HorizontalScrollingOffset -= 100;
                dataGridView_tape.Rows[0].Cells[current_position + 51].Style.BackColor = Color.White;
                dataGridView_tape.Rows[1].Cells[current_position + 51].Style.BackColor = Color.White;
                dataGridView_tape.Rows[0].Cells[current_position + 50].Style.BackColor = Color.LightBlue;
                dataGridView_tape.Rows[1].Cells[current_position + 50].Style.BackColor = Color.LightBlue;
            }
        }

        private void button_Step_Click(object sender, EventArgs e)
        {
            if (tMState.CurrentState != -1)
            {
                tMState = turingMachine.Run(tMState);
                dataGridView_tape.Rows[1].Cells[current_position + 50].Value = tMState.CurrentSymbol;

                if (tMState.CurrentPosition > current_position)
                {
                    if (current_position < 45)
                    {
                        dataGridView_tape.Rows[0].Cells[current_position + 50].Style.BackColor = Color.White;
                        dataGridView_tape.Rows[1].Cells[current_position + 50].Style.BackColor = Color.White;
                        dataGridView_tape.Rows[0].Cells[current_position + 51].Style.BackColor = Color.LightBlue;
                        dataGridView_tape.Rows[1].Cells[current_position + 51].Style.BackColor = Color.LightBlue;
                        current_position++;
                        dataGridView_tape.HorizontalScrollingOffset += 100;
                    }
                }
                else if (tMState.CurrentPosition < current_position)
                {
                    if (current_position > -45)
                    {
                        dataGridView_tape.Rows[0].Cells[current_position + 50].Style.BackColor = Color.White;
                        dataGridView_tape.Rows[1].Cells[current_position + 50].Style.BackColor = Color.White;
                        dataGridView_tape.Rows[0].Cells[current_position + 49].Style.BackColor = Color.LightBlue;
                        dataGridView_tape.Rows[1].Cells[current_position + 49].Style.BackColor = Color.LightBlue;
                        current_position--;
                        dataGridView_tape.HorizontalScrollingOffset -= 100;
                    }
                }
                //tMState.CurrentState = tMState.CurrentState;
                //Thread.Sleep(500);
                if (dataGridView_tape.Rows[1].Cells[current_position + 50].Value == null)
                    tMState.CurrentSymbol = ' ';
                else tMState.CurrentSymbol = dataGridView_tape.Rows[1].Cells[current_position + 50].Value.ToString()[0];
                //turingMachine.AddState(tMState);
                Animation(tMState);
            }
        }

        private async void button_Start_Click(object sender, EventArgs e)
        {
            while (tMState.CurrentState != -1)
            {
                button_Step_Click(sender, e);
                await Task.Delay(300);
            }
            dataGridView_RuleSet.HorizontalScrollingOffset = 500;
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            tMState.CurrentState = 1;
            tMState.CurrentPosition = current_position;
            if (dataGridView_tape.Rows[1].Cells[current_position + 50].Value == null)
                tMState.CurrentSymbol = ' ';
            else tMState.CurrentSymbol = dataGridView_tape.Rows[1].Cells[current_position + 50].Value.ToString()[0];
            turingMachine.AddState(tMState);

            button_Start.Enabled = true;
            button_Step.Enabled = true;
            char read_symbol;
            int current_state;
            int new_state;
            char write_sywbol;
            int move;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                read_symbol = dataGridView_RuleSet.Rows[i].Cells[0].Value.ToString()[0];
                for (int j = 1; j <= condition_count; j++)
                {
                    if (dataGridView_RuleSet.Rows[i].Cells[j].Value.ToString().Length == 3) //замена символа, движение, новое состояние
                    {
                        current_state = j;
                        new_state = Convert.ToInt32(dataGridView_RuleSet.Rows[i].Cells[j].Value.ToString().Remove(0, 2));
                        write_sywbol = dataGridView_RuleSet.Rows[i].Cells[j].Value.ToString()[0];
                        move = dataGridView_RuleSet.Rows[i].Cells[j].Value.ToString()[1] == '>' ? 1 : dataGridView_RuleSet.Rows[i].Cells[j].Value.ToString()[1] == '<' ? -1 : 0;
                    }
                    else if (dataGridView_RuleSet.Rows[i].Cells[j].Value.ToString().Length == 2) //замена символа и !
                    {
                        current_state = j;
                        new_state = current_state;
                        write_sywbol = dataGridView_RuleSet.Rows[i].Cells[j].Value.ToString()[0];
                        move = 0;
                    }
                    else //просто !
                    {
                        current_state = j;
                        new_state = -1;
                        write_sywbol = read_symbol;
                        move = 0;
                    }
                    turingMachine.AddRule(new TMRule { CurrentState = current_state, ReadSymbol = read_symbol, NewState = new_state, WriteSymbol = write_sywbol, Move = move });
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox_ABS.Text = "0123456789- ";
            button_Create_Click(sender, e);

            for (int i = 3; i < 9; i++)
                button_add_Click(sender, e);

            string[,] arr = { {"0>1","9<2", "0<3", "9<4", "0>7", " >6",  "0>7", "" },
                              { "1>1", "0<3", "1<3", "0<5", "1>7", "1>7", "1>7", "" },
                              { "2>1", "1<3", "2<3", "1<5", "2>7", "2>7", "2>7", "" },
                              { "3>1", "2<3", "3<3", "2<5", "3>7", "3>7", "3>7", "" },
                              { "4>1", "3<3", "4<3", "3<5", "4>7", "4>7", "4>7", "" },
                              { "5>1", "4<3", "5<3", "4<5", "5>7", "5>7", "5>7", "" },
                              { "6>1", "5<3", "6<3", "5<5", "6>7", "6>7", "6>7", "" },
                              { "7>1", "6<3", "7<3", "6<5", "7>7", "7>7", "7>7", "" },
                              { "8>1", "7<3", "8<3", "7<5", "8>7", "8>7", "8>7", "" },
                              { "9>1", "8<3", "9<3", "8<5", "9>7", "9>7", "9>7", " >8" },
                              { "->1", " >8", "-<4", "", "", "->7", "->7", "" },
                              {" <2", "", "", " >7", " >6", "", " <2", "!"} };

            for (int i = 0; i < arr.GetLength(0); i++)
                for (int j = 0; j < arr.GetLength(1); j++)
                    dataGridView_RuleSet.Rows[i].Cells[j + 1].Value = arr[i, j];
        }

        private void Animation(TMState tMState)
        {
            dataGridView_RuleSet.Rows[last_i].Cells[last_j].Style.BackColor = Color.White;
            int index_row = 0;
            for (int i = 0; i < dataGridView_RuleSet.Rows.Count; i++)
                if (dataGridView_RuleSet.Rows[i].Cells[0].Value.ToString()[0] == tMState.CurrentSymbol) index_row = i;

            int index_col = tMState.CurrentState > 0 ? tMState.CurrentState : 8;
            last_i = index_row;
            last_j= index_col;
            dataGridView_RuleSet.Rows[index_row].Cells[index_col].Style.BackColor = Color.LightBlue;

            if (tMState.CurrentState > 6) dataGridView_RuleSet.HorizontalScrollingOffset = 500;
            else dataGridView_RuleSet.HorizontalScrollingOffset = 0;
        }
    }
}
