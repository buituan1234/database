using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace asm2database
{
    public partial class user : Form
    {
        SqlConnection conn;
        public user()
        {
            InitializeComponent();
            conn = new SqlConnection("server = DESKTOP-HPP1IIU\\MSSQLSERVER01; database = LibraryManagement1; integrated security = true");
        }

        public user(string username)
        {
            InitializeComponent();
            conn = new SqlConnection("server = DESKTOP-HPP1IIU\\MSSQLSERVER01; database = LibraryManagement1; integrated security = true");
            MessageBox.Show("Welcome " + username);
        }

        public void GetAuthors()
        {
            string query = "select author_id, author_name from Authors";
            DataTable table = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);
            dataAdapter.Fill(table);
            cbBookAuthor.DataSource = table;
            cbBookAuthor.DisplayMember = "author_name";
            cbBookAuthor.ValueMember = "author_id";
        }

        public void GetCategories()
        {
            string query = "select category_id, category_name from Categories";
            DataTable table = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);
            dataAdapter.Fill(table);
            cbBookCategory.DataSource = table;
            cbBookCategory.DisplayMember = "category_name";
            cbBookCategory.ValueMember = "category_id";

        }
        public void GetBorrowers()
        {
            string query = "select borrower_id, borrower_name from Borrowers";
            DataTable table = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);
            dataAdapter.Fill(table);
            cbTicketBorrower.DataSource = table;
            cbTicketBorrower.DisplayMember = "borrower_name";
            cbTicketBorrower.ValueMember = "borrower_id";
        }

        public void FillDataBooks()
        {
            string query = "select * from Books";
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, conn);
            sqlDataAdapter.Fill(dataTable);
            dgvBooks.DataSource = dataTable;
        }

        public void ClearDataBooks()
        {
            txtBookID.Text = "";
            txtBookName.Text = "";
            cbBookAuthor.Text = "";
            cbBookCategory.Text = "";
            cbBookPublisher.Text = "";
        }

        public void FillDataTickets()
        {
            string query = "select * from Tickets";
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, conn);
            sqlDataAdapter.Fill(dataTable);
            dgvTickets.DataSource = dataTable;
        }

        public void ClearDataTickets()
        {
            txtTicketID.Text = "";
            cbTicketBook.Text = "";
            cbTicketBorrower.Text = "";
        }
        public void GetPublishers()
        {
            string query = "select publisher_id, publisher_name from Publishers";
            DataTable table = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);
            dataAdapter.Fill(table);
            cbBookPublisher.DataSource = table;
            cbBookPublisher.DisplayMember = "publisher_name";
            cbBookPublisher.ValueMember = "publisher_id";
        }

        public void GetBooks()
        {
            string query = "select book_id, book_name from Books";
            DataTable table = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);
            dataAdapter.Fill(table);
            cbTicketBook.DataSource = table;
            cbTicketBook.DisplayMember = "book_name";
            cbTicketBook.ValueMember = "book_id";
        }


        private void user_Load(object sender, EventArgs e)
        {
            GetAuthors();
            GetCategories();
            GetPublishers();
            GetBooks();
            GetBorrowers();
            FillDataTickets();
            FillDataBooks();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvBooks.Rows[e.RowIndex];
                txtBookID.Text = row.Cells["book_id"].Value.ToString();
                txtBookName.Text = row.Cells["book_name"].Value.ToString();
                cbBookAuthor.SelectedValue = row.Cells["authors"].Value.ToString();
                cbBookCategory.SelectedValue = row.Cells["category_id"].Value.ToString();
                cbBookPublisher.SelectedValue = row.Cells["publishers"].Value.ToString();
            }
        }

        private void dgvTickets_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvTickets.Rows[e.RowIndex];
                txtTicketID.Text = row.Cells["ticket_id"].Value.ToString();
                cbTicketBook.SelectedValue = row.Cells["book_id"].Value.ToString();
                cbTicketBorrower.SelectedValue = row.Cells["borrower_id"].Value.ToString();
                dpgReturnDate.Value = (DateTime)row.Cells["return_date"].Value;
                dpgBorrowDate.Value = (DateTime)row.Cells["borrow_date"].Value;
            }

        }
    }
}
