using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music_Player_App
{
    public partial class Form1 : Form
    {
        String[] paths, files;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelectSongs_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Multiselect = true;
            ofd.Filter = "All Supported Audio | *.mp3; *.wma | MP3s | *.mp3 | WMAs | *.wma";

            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = ofd.SafeFileNames;
                paths = ofd.FileNames;

                //Mostra a musica no List Box
                for(int i = 0; i < files.Length; i++)
                {
                    listSongs.Items.Add(files[i]);
                }
            }
        }

        private void listSongs_SelectedIndexChanged(object sender, EventArgs e)
        {
            WMP_Music.URL = paths[listSongs.SelectedIndex];          
        }

        private void WMP_Music_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listSongs.Items.Clear();
            WMP_Music.URL = "";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
