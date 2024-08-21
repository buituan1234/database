namespace asm2database
{
    partial class user
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Book = new TabControl();
            tabPage1 = new TabPage();
            cbBookAuthor = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            cbBookPublisher = new ComboBox();
            cbBookCategory = new ComboBox();
            txtBookName = new TextBox();
            txtBookID = new TextBox();
            dgvBooks = new DataGridView();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabPage2 = new TabPage();
            dpgReturnDate = new DateTimePicker();
            dpgBorrowDate = new DateTimePicker();
            cbTicketBorrower = new ComboBox();
            cbTicketBook = new ComboBox();
            txtTicketID = new TextBox();
            dgvTickets = new DataGridView();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            Book.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTickets).BeginInit();
            SuspendLayout();
            // 
            // Book
            // 
            Book.Controls.Add(tabPage1);
            Book.Controls.Add(tabPage2);
            Book.Location = new Point(2, 1);
            Book.Name = "Book";
            Book.SelectedIndex = 0;
            Book.ShowToolTips = true;
            Book.Size = new Size(1031, 471);
            Book.SizeMode = TabSizeMode.FillToRight;
            Book.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(cbBookAuthor);
            tabPage1.Controls.Add(dateTimePicker1);
            tabPage1.Controls.Add(cbBookPublisher);
            tabPage1.Controls.Add(cbBookCategory);
            tabPage1.Controls.Add(txtBookName);
            tabPage1.Controls.Add(txtBookID);
            tabPage1.Controls.Add(dgvBooks);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1023, 438);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Book";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // cbBookAuthor
            // 
            cbBookAuthor.FormattingEnabled = true;
            cbBookAuthor.Location = new Point(214, 89);
            cbBookAuthor.Name = "cbBookAuthor";
            cbBookAuthor.Size = new Size(221, 28);
            cbBookAuthor.TabIndex = 16;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(655, 89);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 15;
            // 
            // cbBookPublisher
            // 
            cbBookPublisher.FormattingEnabled = true;
            cbBookPublisher.Location = new Point(655, 39);
            cbBookPublisher.Name = "cbBookPublisher";
            cbBookPublisher.Size = new Size(250, 28);
            cbBookPublisher.TabIndex = 14;
            // 
            // cbBookCategory
            // 
            cbBookCategory.FormattingEnabled = true;
            cbBookCategory.Location = new Point(214, 198);
            cbBookCategory.Name = "cbBookCategory";
            cbBookCategory.Size = new Size(221, 28);
            cbBookCategory.TabIndex = 13;
            cbBookCategory.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // txtBookName
            // 
            txtBookName.Location = new Point(214, 145);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(221, 27);
            txtBookName.TabIndex = 11;
            // 
            // txtBookID
            // 
            txtBookID.Location = new Point(214, 40);
            txtBookID.Name = "txtBookID";
            txtBookID.Size = new Size(221, 27);
            txtBookID.TabIndex = 9;
            txtBookID.TextChanged += textBox1_TextChanged;
            // 
            // dgvBooks
            // 
            dgvBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBooks.Location = new Point(6, 265);
            dgvBooks.Name = "dgvBooks";
            dgvBooks.RowHeadersWidth = 51;
            dgvBooks.Size = new Size(996, 164);
            dgvBooks.TabIndex = 8;
            dgvBooks.CellContentClick += dgvBooks_CellContentClick;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(534, 257);
            label8.Name = "label8";
            label8.Size = new Size(0, 20);
            label8.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(484, 237);
            label7.Name = "label7";
            label7.Size = new Size(145, 26);
            label7.TabIndex = 6;
            label7.Text = "List of Book";
            label7.Click += label7_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(569, 89);
            label6.Name = "label6";
            label6.Size = new Size(41, 20);
            label6.TabIndex = 5;
            label6.Text = "Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(569, 40);
            label5.Name = "label5";
            label5.Size = new Size(69, 20);
            label5.TabIndex = 4;
            label5.Text = "Publisher";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(131, 198);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 3;
            label4.Text = "Category";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(131, 145);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 2;
            label3.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(131, 89);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 1;
            label2.Text = "Author";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(131, 40);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dpgReturnDate);
            tabPage2.Controls.Add(dpgBorrowDate);
            tabPage2.Controls.Add(cbTicketBorrower);
            tabPage2.Controls.Add(cbTicketBook);
            tabPage2.Controls.Add(txtTicketID);
            tabPage2.Controls.Add(dgvTickets);
            tabPage2.Controls.Add(label14);
            tabPage2.Controls.Add(label13);
            tabPage2.Controls.Add(label12);
            tabPage2.Controls.Add(label11);
            tabPage2.Controls.Add(label10);
            tabPage2.Controls.Add(label9);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1023, 438);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Ticket";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dpgReturnDate
            // 
            dpgReturnDate.Location = new Point(678, 113);
            dpgReturnDate.Name = "dpgReturnDate";
            dpgReturnDate.Size = new Size(250, 27);
            dpgReturnDate.TabIndex = 11;
            // 
            // dpgBorrowDate
            // 
            dpgBorrowDate.Location = new Point(678, 55);
            dpgBorrowDate.Name = "dpgBorrowDate";
            dpgBorrowDate.Size = new Size(250, 27);
            dpgBorrowDate.TabIndex = 10;
            // 
            // cbTicketBorrower
            // 
            cbTicketBorrower.FormattingEnabled = true;
            cbTicketBorrower.Location = new Point(164, 165);
            cbTicketBorrower.Name = "cbTicketBorrower";
            cbTicketBorrower.Size = new Size(250, 28);
            cbTicketBorrower.TabIndex = 9;
            cbTicketBorrower.SelectedIndexChanged += comboBox4_SelectedIndexChanged;
            // 
            // cbTicketBook
            // 
            cbTicketBook.FormattingEnabled = true;
            cbTicketBook.Location = new Point(164, 113);
            cbTicketBook.Name = "cbTicketBook";
            cbTicketBook.Size = new Size(250, 28);
            cbTicketBook.TabIndex = 8;
            cbTicketBook.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // txtTicketID
            // 
            txtTicketID.Location = new Point(164, 55);
            txtTicketID.Name = "txtTicketID";
            txtTicketID.Size = new Size(250, 27);
            txtTicketID.TabIndex = 7;
            txtTicketID.TextChanged += textBox2_TextChanged;
            // 
            // dgvTickets
            // 
            dgvTickets.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTickets.Location = new Point(3, 230);
            dgvTickets.Name = "dgvTickets";
            dgvTickets.RowHeadersWidth = 51;
            dgvTickets.Size = new Size(1000, 188);
            dgvTickets.TabIndex = 6;
            dgvTickets.CellContentClick += dataGridView2_CellContentClick;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.Location = new Point(468, 198);
            label14.Name = "label14";
            label14.Size = new Size(158, 26);
            label14.TabIndex = 5;
            label14.Text = "List of Ticket";
            label14.Click += label14_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(554, 113);
            label13.Name = "label13";
            label13.Size = new Size(88, 20);
            label13.TabIndex = 4;
            label13.Text = "Return Date";
            label13.Click += label13_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(549, 55);
            label12.Name = "label12";
            label12.Size = new Size(93, 20);
            label12.TabIndex = 3;
            label12.Text = "Borrow Date";
            label12.Click += label12_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(75, 165);
            label11.Name = "label11";
            label11.Size = new Size(70, 20);
            label11.TabIndex = 2;
            label11.Text = "Borrower";
            label11.Click += label11_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(75, 113);
            label10.Name = "label10";
            label10.Size = new Size(43, 20);
            label10.TabIndex = 1;
            label10.Text = "Book";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(75, 55);
            label9.Name = "label9";
            label9.Size = new Size(24, 20);
            label9.TabIndex = 0;
            label9.Text = "ID";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // user
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1011, 460);
            Controls.Add(Book);
            Name = "user";
            Text = "user";
            Load += user_Load;
            Book.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTickets).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl Book;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DateTimePicker dateTimePicker1;
        private ComboBox cbBookPublisher;
        private ComboBox cbBookCategory;
        private TextBox txtBookName;
        private TextBox txtBookID;
        private DataGridView dgvBooks;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ContextMenuStrip contextMenuStrip1;
        private DataGridView dgvTickets;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private DateTimePicker dpgReturnDate;
        private DateTimePicker dpgBorrowDate;
        private ComboBox cbTicketBorrower;
        private ComboBox cbTicketBook;
        private TextBox txtTicketID;
        private ComboBox cbBookAuthor;
    }
}