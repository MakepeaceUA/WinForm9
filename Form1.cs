using System;
using System.Windows.Forms;
using WinFormsApp19.Controller;
using WinFormsApp19.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp19
{
    public partial class Form1 : Form
    {
        private TodoController _controller;
        public Form1()
        {
            InitializeComponent();
            _controller = new TodoController();
        }
        private void Form1_Load(object sender, EventArgs e)
        { }

        private void buttonAddTask_Click(object sender, EventArgs e)
        {
            string task = textBox1.Text;
            _controller.AddTask(task);
            textBox1.Clear();
            UpdateTaskList();
        }
        private void buttonCompleteTask_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                _controller.MarkTaskAsCompleted(listBox1.SelectedIndex);
                UpdateTaskList();
            }
            else
            {
                MessageBox.Show("Выберите задание", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void buttonDeleteTask_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                _controller.DeleteTask(listBox1.SelectedIndex);
                UpdateTaskList();
            }
            else
            {
                MessageBox.Show("Выберите задание", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void UpdateTaskList()
        {
            listBox1.Items.Clear();
            foreach (var task in _controller.GetTasks())
            {
                listBox1.Items.Add(task.ToString());
            }
        }

        
    }
}