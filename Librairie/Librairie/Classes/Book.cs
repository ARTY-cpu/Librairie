﻿using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;

namespace Librairie.Classes
{
    public class Book
    {
        public int BookId { get; set; }
        public string? Title { get; set; }
        public string? Isbn { get; set; }
        public string? PublisherName { get; set; }
        public string? AuthorName { get; set; }
        public string? CategoryName { get; set; }
        string connectionString = "Data Source=tcp:localhost,1433;Initial Catalog = Library; User ID = sa; Password=Magixtime!To75;TrustServerCertificate=true;";

        public List<Book> GetBooks()
        {
            List<Book> bookList = new List<Book>();
            SqlConnection con = new SqlConnection(connectionString);
            string selectSQL = "select BookId, Title, Isbn, PublisherName, AuthorName, CategoryName from GetBookData";
            con.Open();
            SqlCommand cmd = new SqlCommand(selectSQL, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr != null)
            {
                while (dr.Read())
                {
                    Book book = new Book();
                    book.BookId = Convert.ToInt32(dr["BookId"]);
                    book.Title = dr["Title"].ToString();
                    book.Isbn = dr["ISBN"].ToString();
                    book.PublisherName = dr["PublisherName"].ToString();
                    book.AuthorName = dr["AuthorName"].ToString();
                    book.CategoryName = dr["CategoryName"].ToString();
                    bookList.Add(book);
                }
            }
            return bookList;
        }

        public void CreateBook(Book book)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("CreateBook", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@Title", book.Title));
            cmd.Parameters.Add(new SqlParameter("@Isbn", book.Isbn));
            cmd.Parameters.Add(new SqlParameter("@PublisherName", book.PublisherName));
            cmd.Parameters.Add(new SqlParameter("@AuthorName", book.AuthorName));
            cmd.Parameters.Add(new SqlParameter("@CategoryName", book.CategoryName));

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public Book GetBookData(int bookId)
        {
            SqlConnection con = new SqlConnection(connectionString);
            string selectSQL = "select BookId, Title, Isbn, PublisherName, AuthorName, CategoryName from GetBookData where BookId = " + bookId;
            con.Open();
            SqlCommand cmd = new SqlCommand(selectSQL, con);
            SqlDataReader dr = cmd.ExecuteReader();
            Book book = new Book();
            if (dr != null)
            {
                while (dr.Read())
                {
                    book.BookId = Convert.ToInt32(dr["BookId"]);
                    book.Title = dr["Title"].ToString();
                    book.Isbn = dr["ISBN"].ToString();
                    book.PublisherName = dr["PublisherName"].ToString();
                    book.AuthorName = dr["AuthorName"].ToString();
                    book.CategoryName = dr["CategoryName"].ToString();
                }
            }
            return book;
        }

        public void EditBook(Book book)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("UpdateBook", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@BookId", book.BookId));
            cmd.Parameters.Add(new SqlParameter("@Title", book.Title));
            cmd.Parameters.Add(new SqlParameter("@Isbn", book.Isbn));
            cmd.Parameters.Add(new SqlParameter("@PublisherName", book.PublisherName));
            cmd.Parameters.Add(new SqlParameter("@AuthorName", book.AuthorName));
            cmd.Parameters.Add(new SqlParameter("@CategoryName", book.CategoryName));
            con.Open();
            cmd.ExecuteNonQuery();
        }

        public void DeleteBook(int bookId)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("DeleteBook", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@BookId", bookId));

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

    }
}
