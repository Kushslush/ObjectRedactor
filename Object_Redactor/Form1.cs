using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Object_Redactor
{
    public partial class Form1 : Form
    {
        List<Book> Book_Base;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Book_Base = new List<Book>();
            ViewList.Visible = false;
            B_del.Visible = false;
            AddMessage.Visible = false;
            Viewinfo.Visible = false;

        }

        private void B_info_Click(object sender, EventArgs e)
        {
            ViewList.Visible = false;
            B_del.Visible = false;
            B_add.Visible = false;
            Viewinfo.Visible = true;

            //delmessage
            B_Name.Visible = B_Author.Visible = B_Pages.Visible = true;
            label1.Visible = label2.Visible = label3.Visible = label4.Visible = true;
            B_Author.ReadOnly = B_Pages.ReadOnly = true;
            B_Binding.Visible = true;

            SetReadonlyControls(B_Binding.Controls);

            B_Author.Clear(); B_Pages.Clear(); 

        }


        private void AddBook_Click(object sender, EventArgs e)
        {

            ViewList.Visible = false;
            B_del.Visible = false;
            B_add.Visible = true;
            Viewinfo.Visible = false;
            //delmessage
            B_Name.Visible = B_Author.Visible = B_Pages.Visible = B_Binding.Visible = true;
            label1.Visible = label2.Visible = label3.Visible = label4.Visible = true;
            B_Author.ReadOnly = B_Pages.ReadOnly  = false;

            SetNoReadonlyControls(B_Binding.Controls);
        }


        private void B_add_Click(object sender, EventArgs e)
        {

            try
            {
                Book tmp = new Book(B_Name.Text, B_Author.Text, Int32.Parse(B_Pages.Text), Hard_Buttom.Checked);
                Book_Base.Add(tmp);
                AddMessage.Visible = true;
                AddMessage.ForeColor = System.Drawing.Color.Green;
                AddMessage.Text = "Book add";
            }
            catch (Exception)
            {
                AddMessage.Visible = true;
                AddMessage.ForeColor = System.Drawing.Color.Red;
                AddMessage.Text = "Неверный формат входных данных";
            }

        }

        private void List_of_book_Click(object sender, EventArgs e)
        {

            ViewList.Items.Clear();
            foreach (Book current in Book_Base)
                ViewList.Items.Add(current.ToString());


            B_Name.Visible = B_Author.Visible = B_Pages.Visible = B_Binding.Visible = false;
            label1.Visible = label2.Visible = label3.Visible = label4.Visible = false;
            B_del.Visible = false;
            B_add.Visible = false;

            ViewList.Visible = true;
            Viewinfo.Visible = false;
            AddMessage.Visible = false;
        }

        //DelBook Click
        private void button4_Click(object sender, EventArgs e)
        {
            ViewList.Visible = false;
            B_add.Visible = false;


            B_Author.Visible = B_Pages.Visible = B_Binding.Visible = false;
            label1.Visible = label2.Visible = label3.Visible = label4.Visible = false;
            Viewinfo.Visible = false;
            B_Name.Visible = true;
            label1.Visible = true;
            B_del.Visible = true;

        }

        private void B_del_Click(object sender, EventArgs e)
        {
            Book tmp = new Book();
            foreach (Book current in Book_Base)
                if (current.ToString() == B_Name.Text)
                    tmp = current;

            AddMessage.Visible = true;

            if(tmp.ToString() != "default")
            {
                Book_Base.Remove(tmp);
                AddMessage.ForeColor = System.Drawing.Color.Green;
                AddMessage.Text = "Book delete";
            }
            else
            {
                AddMessage.ForeColor = System.Drawing.Color.Red;
                AddMessage.Text = "Book NETU TAKOGO!!!";
            }
        }

        private void Viewinfo_Click(object sender, EventArgs e)
        {
            Book tmp = new Book();

            //Book_Base.FirstOrDefault(q => q.ToString == B_Name.Text);

            foreach (Book current in Book_Base)
                if (current.ToString() == B_Name.Text)
                    tmp = current;

            AddMessage.Visible = true;

            if(tmp.ToString() != "default")
            {
                B_Author.Text = tmp.getAuthor();
                B_Pages.Text = String.Concat(tmp.getNumberPages());

                SetNoReadonlyControls(B_Binding.Controls);
                if (tmp.getBinding())
                {
                    Hard_Buttom.PerformClick();

                }
                else
                {
                    Soft_button.PerformClick();

                }
                SetReadonlyControls(B_Binding.Controls);

                AddMessage.ForeColor = System.Drawing.Color.Green;
                AddMessage.Text = "Ноутбук найден";

            }
            else
            {

                AddMessage.Visible = true;
                AddMessage.ForeColor = System.Drawing.Color.Red;
                AddMessage.Text = "Такого ноутбука нет!";
                B_Author.Clear(); B_Pages.Clear(); 
            }







        }

        //===========================================================
        private void SetReadonlyControls(Control.ControlCollection controlCollection)
        {
            if (controlCollection == null)
            {
                return;
            }
            foreach (RadioButton r in controlCollection.OfType<RadioButton>())
            {
                r.Enabled = false; //RadioButtons do not have readonly property
            }
            foreach (ComboBox c in controlCollection.OfType<ComboBox>())
            {
                c.Enabled = false;//ComboBoxes do not have readonly property
            }
            foreach (TextBoxBase c in controlCollection.OfType<TextBoxBase>())
            {
                c.ReadOnly = true;
            }
        }

        private void SetNoReadonlyControls(Control.ControlCollection controlCollection)
        {
            if (controlCollection == null)
            {
                return;
            }
            foreach (RadioButton r in controlCollection.OfType<RadioButton>())
            {
                r.Enabled = true; //RadioButtons do not have readonly property
            }
            foreach (ComboBox c in controlCollection.OfType<ComboBox>())
            {
                c.Enabled = true;//ComboBoxes do not have readonly property
            }
            foreach (TextBoxBase c in controlCollection.OfType<TextBoxBase>())
            {
                c.ReadOnly = false;
            }
        }
        //===========================================================



    }
}
