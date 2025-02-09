using System;
using System.Drawing;
using System.Windows.Forms;


namespace ConsoleForm
{
    public class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Form form = new InteractiveForm("Приветствие");
            Application.Run(form);

        }
        public class InteractiveForm : Form
        {
            private bool _mouseOnForm = false;
            public InteractiveForm(string title)
            {
                Text = title;
                Height = 600;
                Width = 800;
                StartPosition = FormStartPosition.CenterScreen;

                Button exitButton = CreateButton(new Size(60, 30), new Point(800, 500), "Выход");
                exitButton.Click += (sender, e) => Application.Exit();
                Label label = CreateLabel(new Size(200, 30), new Point(300, 200), "Вы дважды щёлкнули на кнопку");
                label.Visible = false;
                DoubleClick += (sender, e) => ShowLabel(label);
                MouseEnter += (sender, e) => _mouseOnForm = true;
                MouseLeave += (IChannelSender, e) => _mouseOnForm = false;
              
            }

            private void ShowLabel(Label label)
            {
                if (_mouseOnForm) label.Visible = true;
            }

            private void SetCommonParameters(Control element, Size size, Point position, string title)
            {
                element.Size = size;
                element.Location = position;
                element.Text = title;
                Controls.Add(element);

            }
            private Button CreateButton(Size size, Point position, string title)
            {
                Button button = new Button();
                SetCommonParameters(button, size, position, title);
                return button;
            }

            private Label CreateLabel(Size size, Point position, string title)
            {
                Label label = new Label();
                SetCommonParameters(label, size, position, title);
                return label;
            }
           
           
           
        }
    }
    
    public class TestClass
    {
        public int Id { get; private set; }
        public string Name { get; set; }

        public TestClass(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
