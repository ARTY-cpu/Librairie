using Librairie.Classes;
namespace Librairie
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            FillGridView();
            AdjustGridView();
        }
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        void FillGridView()
        {
            List<Book> bookList = new List<Book>();
            Book book = new Book();
            bookList = book.GetBooks();
            dataGridView1.DataSource = bookList;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            NewBookForm formNewBook = new NewBookForm();
            formNewBook.ShowDialog();
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            FillGridView();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditBook();
        }

        void EditBook()
        {
            int bookId;
            bookId = (int)dataGridView1.CurrentRow.Cells[0].Value;
            EditBookForm formEditBook = new EditBookForm(bookId);
            formEditBook.ShowDialog();
        }

        private void btnBookDelete_Click(object sender, EventArgs e)
        {
            DeleteBook();
        }

        void DeleteBook()
        {
            int bookId;
            bookId = (int)dataGridView1.CurrentRow.Cells[0].Value;
            string? bookTitle = dataGridView1.CurrentRow.Cells[1].Value.ToString();

            string message = "Êtes-vous sûr de supprimer ce livre '" + bookTitle + "'?";
            DialogResult dr = MessageBox.Show(message, "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Book book = new Book();
                book.DeleteBook(bookId);
                FillGridView();
            }

        }

        
        void AdjustGridView()
        {
            dataGridView1.Columns[0].HeaderText = "Identifiant livre";
            dataGridView1.Columns[1].HeaderText = "Titre";
            dataGridView1.Columns[2].HeaderText = "ISBN";
            dataGridView1.Columns[3].HeaderText = "Éditeur";
            dataGridView1.Columns[4].HeaderText = "Auteur";
            dataGridView1.Columns[5].HeaderText = "Catégorie";
            dataGridView1.Columns[0].Width = 150;
            dataGridView1.Columns[1].Width = 200;
            dataGridView1.Columns[2].Width = 90;
            dataGridView1.Columns[3].Width = 120;
            dataGridView1.Columns[4].Width = 120;
            dataGridView1.Columns[5].Width = 120;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}