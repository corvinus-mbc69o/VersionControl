using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserMaintenance.Entities;

namespace UserMaintenance
{
    public partial class Form1 : Form
    {
        BindingList<User> users = new BindingList<User>();
        public Form1()
        {
            InitializeComponent();
            labelLastName.Text = Resource1.LastName;
            
            buttonAdd.Text = Resource1.Add;

            listBoxUsers.DataSource = users;
            listBoxUsers.ValueMember = "ID";
            listBoxUsers.DisplayMember = "FullName";

            var u = new User()
            {
                FullName = textBoxLastName.Text + " " + textBoxFirstName.Text,
                
            };
            users.Add(u);

        }

        private void buttonFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            if (sfd.ShowDialog() != DialogResult.OK) return;

            using (StreamWriter sw = new StreamWriter(sfd.FileName, false, Encoding.UTF8))
            {
                foreach (var u in users) 
                {
                    sw.Write(u.ID);
                    sw.Write(u.FullName);
                    
                }

            }
           
            

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var u = new User()
            {
                FullName = textBoxFirstName.Text

            };
            users.Add(u);
        }
    }
}

