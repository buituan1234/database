using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace asm2database
{

    public partial class manager : Form
    {
        SqlConnection conn;

        private void ManagementForm_Load(object sender, EventArgs e)
        {
            displayData();
        }
        private void displayData()
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            String sql = "SELECT * FROM Books ORDER BY book_id DESC";
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvBooks.DataSource = dt;
            conn.Close();
        }
        public manager()

        {
            InitializeComponent();
            conn = new SqlConnection("server = DESKTOP-HPP1IIU\\MSSQLSERVER01; database = LibraryManagement1; integrated security = true");

        }
        public manager(string username)
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
            cbCID.DataSource = table;
            cbCID.DisplayMember = "category_name";
            cbCID.ValueMember = "category_id";
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
            cbCID.Text = "";
            cbBookPublisher.Text = "";
        }

        public void FillDataBorrowers()
        {
            string query = "select * from Borrowers";
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, conn);
            sqlDataAdapter.Fill(dataTable);
            dgvBorrowers.DataSource = dataTable;
        }
        public void ClearDataBorrowers()
        {
            txtBorrowerID.Text = "";
            txtBorrowerName.Text = "";
            txtBorrowerAddress.Text = "";
            txtBorrowerEmail.Text = "";
            txtBorrowerPhone.Text = "";
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
        private void ManagerBook_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Do you want to edit?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string update = "update Tickets set book_id = @book_id, borrower_id = @borrower_id, borrow_date = @borrow_date, return_date = @return_date where ticket_id = @ticket_id";
                conn.Open();
                SqlCommand cmd = new SqlCommand(update, conn);
                cmd.Parameters.Add("@ticket_id", SqlDbType.Int);
                cmd.Parameters["@ticket_id"].Value = txtTicketID.Text;

                cmd.Parameters.Add("@book_id", SqlDbType.Int);
                cmd.Parameters["@book_id"].Value = int.Parse(cbTicketBook.SelectedValue.ToString()); ;

                cmd.Parameters.Add("@borrower_id", SqlDbType.Int);
                cmd.Parameters["@borrower_id"].Value = int.Parse(cbTicketBorrower.SelectedValue.ToString()); ;

                cmd.Parameters.Add("@borrow_date", SqlDbType.Date);
                cmd.Parameters["@borrow_date"].Value = borrowerDatetTicket.Value;

                cmd.Parameters.Add("@return_date", SqlDbType.Date);
                cmd.Parameters["@return_date"].Value = returnDateTicket.Value;

                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    FillDataTickets();
                    ClearDataTickets();
                    MessageBox.Show(this, "Updated successfully", "Result", MessageBoxButtons.OK, MessageBoxIcon.None);
                    conn.Close();
                }
                conn.Close();
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void manager_Load(object sender, EventArgs e)
        {
            GetAuthors();
            GetCategories();
            GetPublishers();
            GetBooks();
            GetBorrowers();
            FillDataBooks();
            FillDataTickets();
            FillDataBorrowers();
        }

        private void btn_Clean_Click(object sender, EventArgs e)
        {
            ClearDataBooks();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            string name = txtBookName.Text;
            string authors = cbBookAuthor.SelectedValue.ToString();
            string categoryID = cbCID.SelectedValue.ToString();
            string Publishers = cbBookPublisher.SelectedValue.ToString();
            DateTime publishingDate = dateTimePicker1.Value;

            string insert = "INSERT INTO Books (book_name, authors , category_id, publishers, publishing_date) " +
                "VALUES (@book_name, @author_id, @category_id, @publishers, @publishing_date)";
            conn.Open();

            SqlCommand cmd = new SqlCommand(insert, conn);

            cmd.Parameters.Add("@book_name", SqlDbType.VarChar);
            cmd.Parameters["@book_name"].Value = name;

            cmd.Parameters.Add("@author_id", SqlDbType.Int);
            cmd.Parameters["@author_id"].Value = authors;

            cmd.Parameters.Add("@category_id", SqlDbType.Int);
            cmd.Parameters["@category_id"].Value = categoryID;

            cmd.Parameters.Add("@publishers", SqlDbType.Int);
            cmd.Parameters["@publishers"].Value = Publishers;

            cmd.Parameters.Add("@publishing_date", SqlDbType.Date);
            cmd.Parameters["@publishing_date"].Value = publishingDate;

            cmd.ExecuteNonQuery();
            FillDataBooks();
            ClearDataBooks();
            conn.Close();
            MessageBox.Show(this, "Inserted successfully", "Result", MessageBoxButtons.OK, MessageBoxIcon.None);
        }
        private void ManagerBorrwer_Click(object sender, EventArgs e)
        {

        }

        private void UpdateBook_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Do you want to edit?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string update = "update Books set book_name = @book_name, authors = @authors, category_id = @category_id, " +
                    "publishers = @publishers, publishing_date = @publishing_date where book_id = @book_id";
                conn.Open();
                SqlCommand cmd = new SqlCommand(update, conn);
                cmd.Parameters.Add("@book_id", SqlDbType.Int);
                cmd.Parameters["@book_id"].Value = txtBookID.Text;

                cmd.Parameters.Add("@book_name", SqlDbType.VarChar);
                cmd.Parameters["@book_name"].Value = txtBookName.Text;

                cmd.Parameters.Add("@authors", SqlDbType.Int);
                cmd.Parameters["@authors"].Value = cbBookAuthor.SelectedValue;

                cmd.Parameters.Add("@category_id", SqlDbType.Int);
                cmd.Parameters["@category_id"].Value = cbCID.SelectedValue;

                cmd.Parameters.Add("@publishers", SqlDbType.Int);
                cmd.Parameters["@publishers"].Value = cbBookPublisher.SelectedValue;

                cmd.Parameters.Add("@publishing_date", SqlDbType.Date);
                cmd.Parameters["@publishing_date"].Value = dateTimePicker1.Value;

                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    FillDataBooks();
                    ClearDataBooks();
                    MessageBox.Show("Book updated successfully!", "Result", MessageBoxButtons.OK, MessageBoxIcon.None);
                    conn.Close();
                }
                conn.Close();
            }

        }

        private void DeleteBook_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Do you want to delete?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                conn.Open();
                // Delete associated tickets first
                string deleteTickets = "DELETE FROM Tickets WHERE book_id = @book_id";
                SqlCommand cmdDeleteTickets = new SqlCommand(deleteTickets, conn);
                cmdDeleteTickets.Parameters.Add("@book_id", SqlDbType.Int);
                cmdDeleteTickets.Parameters["@book_id"].Value = txtBookID.Text;
                cmdDeleteTickets.ExecuteNonQuery();

                // Then delete the book
                string deleteBook = "DELETE FROM Books WHERE book_id = @book_id";
                SqlCommand cmdDeleteBook = new SqlCommand(deleteBook, conn);
                cmdDeleteBook.Parameters.Add("@book_id", SqlDbType.Int);
                cmdDeleteBook.Parameters["@book_id"].Value = txtBookID.Text;
                cmdDeleteBook.ExecuteNonQuery();

                FillDataBooks();
                ClearDataBooks();
                MessageBox.Show(this, "Deleted successfully", "Result", MessageBoxButtons.OK, MessageBoxIcon.None);
                conn.Close();
            }

        }

        private void AddBorrower_Click(object sender, EventArgs e)
        {

            string borrowerName = txtBorrowerName.Text;
            string borrowerAddress = txtBorrowerAddress.Text;
            string borrowerPhone = txtBorrowerPhone.Text;
            string borrowerEmail = txtBorrowerEmail.Text;
            DateTime DOB = dateTimePicker4.Value;

            string insert = "insert into Borrowers (borrower_name, borrower_address, borrower_phone, borrower_email, borrower_DOB)";
            insert += "values (@borrower_name, @borrower_address, @borrower_phone, @borrower_email, @borrower_DOB)";

            conn.Open();
            SqlCommand cmd = new SqlCommand(insert, conn);
            cmd.Parameters.Add("@borrower_name", SqlDbType.VarChar);
            cmd.Parameters["@borrower_name"].Value = borrowerName;

            cmd.Parameters.Add("@borrower_address", SqlDbType.VarChar);
            cmd.Parameters["@borrower_address"].Value = borrowerAddress;

            cmd.Parameters.Add("@borrower_phone", SqlDbType.VarChar);
            cmd.Parameters["@borrower_phone"].Value = borrowerPhone;

            cmd.Parameters.Add("@borrower_email", SqlDbType.VarChar);
            cmd.Parameters["@borrower_email"].Value = borrowerEmail;

            cmd.Parameters.Add("@borrower_DOB", SqlDbType.VarChar);
            cmd.Parameters["@borrower_DOB"].Value = DOB;

            cmd.ExecuteNonQuery();
            FillDataBorrowers();
            ClearDataBorrowers();
            MessageBox.Show(this, "Inserted successfully", "Result", MessageBoxButtons.OK, MessageBoxIcon.None);
            conn.Close();

        }

        private void UpdateBorrower_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Do you want to edit?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string update = "update Borrowers set borrower_name = @borrower_name, borrower_address = @borrower_address, borrower_phone = @borrower_phone, borrower_email = @borrower_email, borrower_DOB = @borrower_DOB where borrower_id = @borrower_id";
                conn.Open();
                SqlCommand cmd = new SqlCommand(update, conn);
                // Check if the borrower ID is not an empty string
                if (!string.IsNullOrEmpty(txtBorrowerID.Text))
                {
                    cmd.Parameters.Add("@borrower_id", SqlDbType.Int);
                    cmd.Parameters["@borrower_id"].Value = txtBorrowerID.Text;

                    cmd.Parameters.Add("@borrower_name", SqlDbType.VarChar);
                    cmd.Parameters["@borrower_name"].Value = txtBorrowerName.Text;

                    cmd.Parameters.Add("@borrower_address", SqlDbType.VarChar);
                    cmd.Parameters["@borrower_address"].Value = txtBorrowerAddress.Text;

                    cmd.Parameters.Add("@borrower_phone", SqlDbType.VarChar);
                    cmd.Parameters["@borrower_phone"].Value = txtBorrowerPhone.Text;

                    cmd.Parameters.Add("@borrower_email", SqlDbType.VarChar);
                    cmd.Parameters["@borrower_email"].Value = txtBorrowerEmail.Text;

                    cmd.Parameters.Add("@borrower_DOB", SqlDbType.Date);
                    cmd.Parameters["@borrower_DOB"].Value = dateTimePicker1.Value.Date;

                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        FillDataBorrowers();
                        ClearDataBorrowers();
                        MessageBox.Show(this, "Updated successfully", "Result", MessageBoxButtons.OK, MessageBoxIcon.None);
                        conn.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid Borrower ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                conn.Close();
            }
        }

        private void DeleteBorrower_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtBorrowerID.Text, out int borrowerId))
            {
                if (MessageBox.Show(this, "Do you want to delete?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    conn.Open();
                    string delete = "delete from Borrowers where borrower_id =@borrower_id";
                    SqlCommand cmd = new SqlCommand(delete, conn);
                    cmd.Parameters.Add("@borrower_id", SqlDbType.Int);
                    cmd.Parameters["@borrower_id"].Value = txtBorrowerID.Text;
                    cmd.ExecuteNonQuery();
                    FillDataBorrowers();
                    ClearDataBorrowers();
                    MessageBox.Show(this, "Deleted successfully", "Result", MessageBoxButtons.OK, MessageBoxIcon.None);
                    conn.Close();
                }
            }
            else
            {
                MessageBox.Show(this, "Please enter a valid Borrower ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void CleanBorrower_Click(object sender, EventArgs e)
        {
            ClearDataBorrowers();
        }

        private void AddTicket_Click(object sender, EventArgs e)
        {

            string txtBookID = cbTicketBook.SelectedValue.ToString();
            string txtBorrowerID = cbTicketBorrower.SelectedValue.ToString();
            DateTime borrowerDate = borrowerDatetTicket.Value.Date;
            DateTime returnDate = returnDateTicket.Value.Date;

            string insert = "insert into Tickets(book_id, borrower_id, borrow_date, return_date) values(@book_id, @borrower_id, @borrow_date, @return_date)";
            conn.Open();
            SqlCommand cmd = new SqlCommand(insert, conn);
            cmd.Parameters.Add("@book_id", SqlDbType.Int);
            cmd.Parameters["@book_id"].Value = txtBookID;

            cmd.Parameters.Add("@borrower_id", SqlDbType.Int);
            cmd.Parameters["@borrower_id"].Value = txtBorrowerID;

            cmd.Parameters.Add("@borrow_date", SqlDbType.VarChar);
            cmd.Parameters["@borrow_date"].Value = borrowerDate;

            cmd.Parameters.Add("@return_date", SqlDbType.VarChar);
            cmd.Parameters["@return_date"].Value = returnDate;

            cmd.ExecuteNonQuery();
            FillDataTickets();
            ClearDataTickets();
            MessageBox.Show(this, "Inserted successfully", "Result", MessageBoxButtons.OK, MessageBoxIcon.None);
            conn.Close();

        }

        private void DeleteTicket_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show(this, "Do you want to delete?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                conn.Open();
                string delete = "delete from Tickets where ticket_id =@ticket_id";
                SqlCommand cmd = new SqlCommand(delete, conn);
                cmd.Parameters.Add("@ticket_id", SqlDbType.Int);
                cmd.Parameters["@ticket_id"].Value = txtTicketID.Text;
                cmd.ExecuteNonQuery();
                FillDataTickets();
                ClearDataTickets();
                MessageBox.Show(this, "Deleted successfully", "Result", MessageBoxButtons.OK, MessageBoxIcon.None);
                conn.Close();
            }

        }

        private void CleanTicket_Click(object sender, EventArgs e)
        {
            ClearDataTickets();
        }

        private void txtTicketID_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbTicketBook_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbTicketBorrower_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private ComboBox GetCbBookAuthor()
        {
            return cbBookAuthor;
        }

        private void dgvBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvBooks.Rows[e.RowIndex];
                txtBookID.Text = row.Cells["book_id"].Value.ToString();
                txtBookName.Text = row.Cells["book_name"].Value.ToString();
                cbBookAuthor.SelectedValue = row.Cells["authors"].Value.ToString();
                cbCID.SelectedValue = row.Cells["category_id"].Value.ToString();
                cbBookPublisher.SelectedValue = row.Cells["publishers"].Value.ToString();
                dateTimePicker1.Value = (DateTime)row.Cells["publishing_date"].Value;
            }
        }

        private void dgvBorrowers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvBorrowers.Rows[e.RowIndex];
                txtBorrowerID.Text = row.Cells["borrower_id"].Value.ToString();
                txtBorrowerName.Text = row.Cells["borrower_name"].Value.ToString();
                txtBorrowerAddress.Text = row.Cells["borrower_address"].Value.ToString();
                txtBorrowerPhone.Text = row.Cells["borrower_phone"].Value.ToString();
                txtBorrowerEmail.Text = row.Cells["borrower_email"].Value.ToString();
                dateTimePicker1.Value = (DateTime)row.Cells["borrower_DOB"].Value;
            }

        }

        private void dgvTickets_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvTickets.Rows[e.RowIndex];
                txtTicketID.Text = row.Cells["ticket_id"].Value.ToString();
                cbTicketBook.SelectedValue = row.Cells["book_id"].Value.ToString();
                cbTicketBorrower.SelectedValue = row.Cells["borrower_name"].Value.ToString();
                borrowerDatetTicket.Value = (DateTime)row.Cells["borrow_date"].Value;
                returnDateTicket.Value = (DateTime)row.Cells["return_date"].Value;
            }
        }

        private void dgv_books(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvBooks.Rows[e.RowIndex];
                txtBookID.Text = row.Cells["book_id"].Value.ToString();
                txtBookName.Text = row.Cells["book_name"].Value.ToString();
                cbBookAuthor.SelectedValue = row.Cells["authors"].Value.ToString();
                cbCID.SelectedValue = row.Cells["category_id"].Value.ToString();
                cbBookPublisher.SelectedValue = row.Cells["publishers"].Value.ToString();
                dateTimePicker1.Value = (DateTime)row.Cells["publishing_date"].Value;
            }

        }


        private void getCID()
        {
            conn.Open();
            //TODO: get toan bo thong tin nguoi dung
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            String sqlQuery = "SELECT * FROM Books";
            cmd.CommandText = sqlQuery;
            SqlDataReader reader = cmd.ExecuteReader();
            // gan du lieu vao combo box
            while (reader.Read())
            {
                int productId = Int32.Parse(reader["category_id"].ToString());
                cbCID.Items.Add(productId);
            }
            conn.Close();
        }

        private void txtBorrowerID_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker4_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
