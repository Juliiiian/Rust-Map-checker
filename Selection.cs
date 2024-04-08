namespace Rust_Map_checker
{
    public partial class Selection : Form
    {

        public WorldSerialization world = new WorldSerialization();
        public string path = string.Empty;

        public Selection()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void file_select_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Filter = "Map files (*.map)|*.map";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                path = openFileDialog1.FileName;
                file_name.Text = path;
            }
            else
            {
                path = string.Empty;
            }
        }

        private void Selection_Load(object sender, EventArgs e)
        {

        }

        private void file_name_Click(object sender, EventArgs e)
        {

        }

        private void result_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (path != null)
            {
                result.Text = "Started with loading";
                world.Load(path);
                result.Text = $"Loading has worked! Map size: {world.world.size}";
                string maps_str = "Maps: \n";

                for (int i = 0; i < world.world.maps.Count; i++)
                {
                    maps_str += $" - {world.world.maps[i].name}\n";
                }
                maps.Text = maps_str;
            }
        }

        private void maps_Click(object sender, EventArgs e)
        {

        }
    }
}