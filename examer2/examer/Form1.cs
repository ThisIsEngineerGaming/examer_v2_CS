namespace examer
{
    public partial class Form1 : Form
    {
        CheckBox thing2 = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tiles_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox current = sender as CheckBox;
            if (!current.Checked) return;

            if (thing2 == null)
            {
                thing2 = current;
                return;
            }

            if (thing2 != current && thing2.Text == current.Text)
            {
                this.Controls.Remove(thing2);
                this.Controls.Remove(current);
                thing2.Dispose();
                current.Dispose();
            }
            else
            {
                thing2.Checked = false;
                current.Checked = false;
            }

            thing2 = null;
        }
    }
}
