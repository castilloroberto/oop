using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace oop
{
    public partial class Form1 : Form
    {
        List<Task> todoList = new List<Task>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
             Task taskN = new Task(todoList.Count,txt_title.Text, txt_desc.Text);
            todoList.Add(taskN);
            UpdateGrid();
        }

        private void UpdateGrid()
        {
            dgv_todolist.Rows.Clear();
            foreach (Task task in todoList)
            {
                if (task.getEnabled())
                    dgv_todolist.Rows.Add(task.getId(),task.getTitle(),task.getDescription());

            }
        }
    }
}
