using Librairie.Classes;

namespace Librairie
{
    public partial class NewBookForm : Form
    {
        public NewBookForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e) //OK CLICK
        {
            SaveBookData();
            GotoMainForm();
        }
        void SaveBookData()
        {
            Book book = new Book();
            book.Title = txtTitle.Text;
            book.Isbn = txtIsbn.Text;
            book.PublisherName = txtPublisher.Text;
            book.AuthorName = txtAuthor.Text;
            book.CategoryName = txtCategory.Text;
            book.CreateBook(book);
        }

        void GotoMainForm()
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e) // KO CLICK
        {
            GotoMainForm();
        }

        private void NewBookForm_Load(object sender, EventArgs e)
        {

        }
    }
}
