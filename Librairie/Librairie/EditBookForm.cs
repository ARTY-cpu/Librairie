using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Librairie.Classes;

namespace Librairie
{
    public partial class EditBookForm : Form
    {
        int selectedBookId;
        public EditBookForm(int bookId)
        {
            InitializeComponent();
            selectedBookId = bookId;
            GetBookData();
        }

        void GetBookData()
        {
            Book book = new Book();
            book = book.GetBookData(selectedBookId);

            txtTitle.Text = book.Title;
            txtIsbn.Text = book.Isbn;
            txtPublisher.Text = book.PublisherName;
            txtAuthor.Text = book.AuthorName;
            txtCategory.Text = book.CategoryName;
        }

        void EditBookData()
        {
            Book book = new Book();
            book.BookId = selectedBookId;
            book.Title = txtTitle.Text;
            book.Isbn = txtIsbn.Text;
            book.PublisherName = txtPublisher.Text;
            book.AuthorName = txtAuthor.Text;
            book.CategoryName = txtCategory.Text;
            book.EditBook(book);
        }

        private void EditBookForm_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e) //modif
        {
            EditBookData();
            GotoMainForm();
        }

        void GotoMainForm()
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GotoMainForm();
        }
    }
}
