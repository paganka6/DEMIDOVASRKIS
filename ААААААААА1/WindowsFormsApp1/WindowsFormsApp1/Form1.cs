using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Новое соединение
            SqlConnection con = new SqlConnection(Properties.Settings.Default.Database1ConnectionString);
            //Создание нового соединения для взаимоднйствия с базой данных после установки соединенич 
            SqlDataAdapter adap = new SqlDataAdapter("Select * from individ where login = '" + textBox1.Text + "'" + "and password= '" + textBox2.Text + "'", con);
            //Создаем новый элемент для хранения информации полученной из базы данных
            Database1DataSet ds = new Database1DataSet();
            //Заполнение массива данными Индливид
            adap.Fill(ds, "individ");
            //выполнение действий
            //ТЕкст на кнопке ВОЙТИ в ВЫЙТИ 
            //Если не нашли индвида пишем с таким логиным  паролем пишем ЛОГИН И ПАРОЛЬ НЕ ВЕРНЫ
            if (button1.Text == "ВОЙТИ")
            {


                if (ds.Tables["individ"].Rows.Count != 0)
                {
                    //Просмотр всех строк таблицы ИНДВИВИД и выполнение действий взависимости от роли
                    for (int i = 0; i < ds.Tables["individ"].Rows.Count; i++)
                    {
                        if (ds.Tables["individ"].Rows[i]["id_role"].ToString() != "")
                        {
                            
                            label1.Visible = false;
                            label2.Visible = false;
                            textBox1.Visible = false;
                            textBox2.Visible = false;
                            if (ds.Tables["individ"].Rows[i]["id_role"].ToString().Trim() == "1")
                            {
                                Form frm1 = new Form2();
                                frm1.Show();
                                frm1.Left = this.Left;//Задание открываемой форме позиции слева равнукю позиции текущей формы
                                frm1.Top = this.Top;//Задание открываемой форме позиции сверху равнукю позиции текущей формы
                                this.Hide();//Скрываем авториз

                            }
                            if (ds.Tables["individ"].Rows[i]["id_role"].ToString().Trim() == "2")
                            {
                                Form frm = new Form3();
                                frm.Show();
                                frm.Left = this.Left;//Задание открываемой форме позиции слева равнукю позиции текущей формы
                                frm.Top = this.Top;//Задание открываемой форме позиции сверху равнукю позиции текущей формы
                                this.Hide();//Скрываем авториз
                            }




                        }
                    }

                }
                else
                {
                    MessageBox.Show("Логин или пароль не верны");
                }
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
        }
