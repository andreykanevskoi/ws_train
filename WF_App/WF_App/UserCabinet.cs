using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_App
{
    public partial class UserCabinet : Form
    {
        public static string default_path_to_photos = @"D:\Andrey\ws_train\ws_train\UserImages\";
        public static string path_UserImage;
        public UserCabinet()
        {
            InitializeComponent();
        }

        private void UserCabinet_Load(object sender, EventArgs e)
        {
            lblLogin.Text = User.user_login;
            lblRole.Text = Features.GetRoleFromInt(User.user_role);
            path_UserImage = default_path_to_photos + User.user_login + @".jpg";
            pictureUser.ImageLocation = path_UserImage;
        }

        private void lblRole_Click(object sender, EventArgs e)
        {

        }

        private void lblLogin_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Изображения |*.jpg";
            save.DefaultExt = "Изображения |*.jpg";
            //save.FileName = path_UserImage;
            var res = save.ShowDialog();

            if (res == DialogResult.Cancel)
                return;

            if (System.IO.File.Exists(save.FileName))
                System.IO.File.Delete(save.FileName);

            System.IO.File.Copy(path_UserImage, save.FileName);
            MessageBox.Show("Файл сохранен.");
            return;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Изображения |*.jpg";
            open.DefaultExt = "Изображения |*.jpg";

            var res = open.ShowDialog();

            if (res == DialogResult.Cancel)
                return;

            if (System.IO.File.Exists(path_UserImage))
                System.IO.File.Delete(path_UserImage);

            System.IO.File.Copy(open.FileName, path_UserImage);
            MessageBox.Show("Файл сохранен.");

            pictureUser.ImageLocation = path_UserImage;

            return;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
