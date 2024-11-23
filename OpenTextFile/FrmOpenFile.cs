using System.IO;

namespace OpenTextFile
{
    public partial class FrmOpenFile : Form
    {
        public FrmOpenFile()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            DisplayToList();
        }
        private void DisplayToList()
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.InitialDirectory = @"C:\Documents";
                openFileDialog1.Title = "Browse Text Files";
                openFileDialog1.DefaultExt = "txt";
                openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string path = openFileDialog1.FileName;

                    lvShowText.Items.Clear();

                    using (StreamReader streamReader = File.OpenText(path))
                    {
                        string _getText;
                        while ((_getText = streamReader.ReadLine()) != null)
                        {
                            Console.WriteLine(_getText); 
                            lvShowText.Items.Add(_getText);
                        }
                    }
                }
            }
        }
    }
