
namespace asm2database
{
    partial class manager
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
            tabcontrol1 = new TabControl();
            ManagerBook = new TabPage();
            UpdateBook = new Button();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            txtBookName = new TextBox();
            txtBookID = new TextBox();
            cbBookPublisher = new ComboBox();
            cbCID = new ComboBox();
            cbBookAuthor = new ComboBox();
            CleanBook = new Button();
            DeleteBook = new Button();
            AddBook = new Button();
            dgvBooks = new DataGridView();
            ManagerBorrwer = new TabPage();
            UpdateBorrower = new Button();
            dateTimePicker4 = new DateTimePicker();
            txtBorrowerEmail = new TextBox();
            txtBorrowerPhone = new TextBox();
            txtBorrowerAddress = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            txtBorrowerName = new TextBox();
            txtBorrowerID = new TextBox();
            CleanBorrower = new Button();
            DeleteBorrower = new Button();
            AddBorrower = new Button();
            dgvBorrowers = new DataGridView();
            ManagerTicket = new TabPage();
            returnDateTicket = new DateTimePicker();
            borrowerDatetTicket = new DateTimePicker();
            cbTicketBook = new ComboBox();
            cbTicketBorrower = new ComboBox();
            label18 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label20 = new Label();
            label21 = new Label();
            txtTicketID = new TextBox();
            CleanTicket = new Button();
            DeleteTicket = new Button();
            UpdateTicket = new Button();
            AddTicket = new Button();
            dgvTickets = new DataGridView();
            tabcontrol1.SuspendLayout();
            ManagerBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).BeginInit();
            ManagerBorrwer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBorrowers).BeginInit();
            ManagerTicket.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTickets).BeginInit();
            SuspendLayout();
            // 
            // tabcontrol1
            // 
            tabcontrol1.Controls.Add(ManagerBook);
            tabcontrol1.Controls.Add(ManagerBorrwer);
            tabcontrol1.Controls.Add(ManagerTicket);
            tabcontrol1.Location = new Point(0, 0);
            tabcontrol1.Name = "tabcontrol1";
            tabcontrol1.SelectedIndex = 0;
            tabcontrol1.Size = new Size(1100, 477);
            tabcontrol1.TabIndex = 0;
            // 
            // ManagerBook
            // 
            ManagerBook.Controls.Add(UpdateBook);
            ManagerBook.Controls.Add(label7);
            ManagerBook.Controls.Add(label6);
            ManagerBook.Controls.Add(label5);
            ManagerBook.Controls.Add(label4);
            ManagerBook.Controls.Add(label3);
            ManagerBook.Controls.Add(label2);
            ManagerBook.Controls.Add(label1);
            ManagerBook.Controls.Add(dateTimePicker1);
            ManagerBook.Controls.Add(txtBookName);
            ManagerBook.Controls.Add(txtBookID);
            ManagerBook.Controls.Add(cbBookPublisher);
            ManagerBook.Controls.Add(cbCID);
            ManagerBook.Controls.Add(cbBookAuthor);
            ManagerBook.Controls.Add(CleanBook);
            ManagerBook.Controls.Add(DeleteBook);
            ManagerBook.Controls.Add(AddBook);
            ManagerBook.Controls.Add(dgvBooks);
            ManagerBook.Location = new Point(4, 29);
            ManagerBook.Name = "ManagerBook";
            ManagerBook.Padding = new Padding(3);
            ManagerBook.Size = new Size(1092, 444);
            ManagerBook.TabIndex = 0;
            ManagerBook.Text = "Manager Book";
            ManagerBook.UseVisualStyleBackColor = true;
            ManagerBook.Click += ManagerBook_Click;
            // 
            // UpdateBook
            // 
            UpdateBook.Location = new Point(164, 368);
            UpdateBook.Name = "UpdateBook";
            UpdateBook.Size = new Size(94, 29);
            UpdateBook.TabIndex = 18;
            UpdateBook.Text = "Update";
            UpdateBook.UseVisualStyleBackColor = true;
            UpdateBook.Click += UpdateBook_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(189, 43);
            label7.Name = "label7";
            label7.Size = new Size(152, 28);
            label7.TabIndex = 17;
            label7.Text = "Manager Book";
            label7.Click += label7_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(63, 275);
            label6.Name = "label6";
            label6.Size = new Size(111, 20);
            label6.TabIndex = 16;
            label6.Text = "Publishing date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(63, 244);
            label5.Name = "label5";
            label5.Size = new Size(69, 20);
            label5.TabIndex = 15;
            label5.Text = "Publisher";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(63, 210);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 14;
            label4.Text = "Category";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(63, 176);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 13;
            label3.Text = "Author";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(63, 142);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 12;
            label2.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 109);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 11;
            label1.Text = "ID";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(206, 270);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 10;
            // 
            // txtBookName
            // 
            txtBookName.Location = new Point(206, 135);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(250, 27);
            txtBookName.TabIndex = 9;
            // 
            // txtBookID
            // 
            txtBookID.Location = new Point(206, 102);
            txtBookID.Name = "txtBookID";
            txtBookID.Size = new Size(250, 27);
            txtBookID.TabIndex = 8;
            txtBookID.TextChanged += textBox1_TextChanged;
            // 
            // cbBookPublisher
            // 
            cbBookPublisher.FormattingEnabled = true;
            cbBookPublisher.Location = new Point(206, 236);
            cbBookPublisher.Name = "cbBookPublisher";
            cbBookPublisher.Size = new Size(250, 28);
            cbBookPublisher.TabIndex = 7;
            cbBookPublisher.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // cbCID
            // 
            cbCID.FormattingEnabled = true;
            cbCID.Location = new Point(206, 202);
            cbCID.Name = "cbCID";
            cbCID.Size = new Size(250, 28);
            cbCID.TabIndex = 6;
            cbCID.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // cbBookAuthor
            // 
            cbBookAuthor.FormattingEnabled = true;
            cbBookAuthor.Location = new Point(206, 168);
            cbBookAuthor.Name = "cbBookAuthor";
            cbBookAuthor.Size = new Size(250, 28);
            cbBookAuthor.TabIndex = 5;
            cbBookAuthor.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // CleanBook
            // 
            CleanBook.Location = new Point(405, 368);
            CleanBook.Name = "CleanBook";
            CleanBook.Size = new Size(94, 29);
            CleanBook.TabIndex = 4;
            CleanBook.Text = "Clean";
            CleanBook.UseVisualStyleBackColor = true;
            CleanBook.Click += btn_Clean_Click;
            // 
            // DeleteBook
            // 
            DeleteBook.Location = new Point(286, 368);
            DeleteBook.Name = "DeleteBook";
            DeleteBook.Size = new Size(94, 29);
            DeleteBook.TabIndex = 3;
            DeleteBook.Text = "Delete";
            DeleteBook.UseVisualStyleBackColor = true;
            DeleteBook.Click += DeleteBook_Click;
            // 
            // AddBook
            // 
            AddBook.Location = new Point(49, 368);
            AddBook.Name = "AddBook";
            AddBook.Size = new Size(94, 29);
            AddBook.TabIndex = 1;
            AddBook.Text = "Add";
            AddBook.UseVisualStyleBackColor = true;
            AddBook.Click += btn_Add_Click;
            // 
            // dgvBooks
            // 
            dgvBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBooks.Location = new Point(499, 76);
            dgvBooks.Name = "dgvBooks";
            dgvBooks.RowHeadersWidth = 51;
            dgvBooks.Size = new Size(587, 270);
            dgvBooks.TabIndex = 0;
            dgvBooks.CellClick += dgv_books;
            dgvBooks.CellContentClick += dgvBooks_CellContentClick;
            // 
            // ManagerBorrwer
            // 
            ManagerBorrwer.Controls.Add(UpdateBorrower);
            ManagerBorrwer.Controls.Add(dateTimePicker4);
            ManagerBorrwer.Controls.Add(txtBorrowerEmail);
            ManagerBorrwer.Controls.Add(txtBorrowerPhone);
            ManagerBorrwer.Controls.Add(txtBorrowerAddress);
            ManagerBorrwer.Controls.Add(label8);
            ManagerBorrwer.Controls.Add(label9);
            ManagerBorrwer.Controls.Add(label10);
            ManagerBorrwer.Controls.Add(label11);
            ManagerBorrwer.Controls.Add(label12);
            ManagerBorrwer.Controls.Add(label13);
            ManagerBorrwer.Controls.Add(label14);
            ManagerBorrwer.Controls.Add(txtBorrowerName);
            ManagerBorrwer.Controls.Add(txtBorrowerID);
            ManagerBorrwer.Controls.Add(CleanBorrower);
            ManagerBorrwer.Controls.Add(DeleteBorrower);
            ManagerBorrwer.Controls.Add(AddBorrower);
            ManagerBorrwer.Controls.Add(dgvBorrowers);
            ManagerBorrwer.Location = new Point(4, 29);
            ManagerBorrwer.Name = "ManagerBorrwer";
            ManagerBorrwer.Padding = new Padding(3);
            ManagerBorrwer.Size = new Size(1092, 444);
            ManagerBorrwer.TabIndex = 1;
            ManagerBorrwer.Text = "Manager Borrower";
            ManagerBorrwer.UseVisualStyleBackColor = true;
            ManagerBorrwer.Click += ManagerBorrwer_Click;
            // 
            // UpdateBorrower
            // 
            UpdateBorrower.Location = new Point(163, 370);
            UpdateBorrower.Name = "UpdateBorrower";
            UpdateBorrower.Size = new Size(94, 29);
            UpdateBorrower.TabIndex = 41;
            UpdateBorrower.Text = "Update";
            UpdateBorrower.UseVisualStyleBackColor = true;
            UpdateBorrower.Click += UpdateBorrower_Click;
            // 
            // dateTimePicker4
            // 
            dateTimePicker4.Location = new Point(150, 285);
            dateTimePicker4.Name = "dateTimePicker4";
            dateTimePicker4.Size = new Size(250, 27);
            dateTimePicker4.TabIndex = 39;
            dateTimePicker4.ValueChanged += dateTimePicker4_ValueChanged;
            // 
            // txtBorrowerEmail
            // 
            txtBorrowerEmail.Location = new Point(151, 245);
            txtBorrowerEmail.Name = "txtBorrowerEmail";
            txtBorrowerEmail.Size = new Size(251, 27);
            txtBorrowerEmail.TabIndex = 38;
            // 
            // txtBorrowerPhone
            // 
            txtBorrowerPhone.Location = new Point(151, 212);
            txtBorrowerPhone.Name = "txtBorrowerPhone";
            txtBorrowerPhone.Size = new Size(251, 27);
            txtBorrowerPhone.TabIndex = 37;
            // 
            // txtBorrowerAddress
            // 
            txtBorrowerAddress.Location = new Point(150, 179);
            txtBorrowerAddress.Name = "txtBorrowerAddress";
            txtBorrowerAddress.Size = new Size(251, 27);
            txtBorrowerAddress.TabIndex = 36;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(188, 45);
            label8.Name = "label8";
            label8.Size = new Size(191, 28);
            label8.TabIndex = 35;
            label8.Text = "Manager Borrower";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(62, 285);
            label9.Name = "label9";
            label9.Size = new Size(38, 20);
            label9.TabIndex = 34;
            label9.Text = "Dob";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(62, 252);
            label10.Name = "label10";
            label10.Size = new Size(46, 20);
            label10.TabIndex = 33;
            label10.Text = "Email";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(62, 219);
            label11.Name = "label11";
            label11.Size = new Size(50, 20);
            label11.TabIndex = 32;
            label11.Text = "Phone";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(62, 186);
            label12.Name = "label12";
            label12.Size = new Size(62, 20);
            label12.TabIndex = 31;
            label12.Text = "Address";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(62, 151);
            label13.Name = "label13";
            label13.Size = new Size(49, 20);
            label13.TabIndex = 30;
            label13.Text = "Name";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(62, 115);
            label14.Name = "label14";
            label14.Size = new Size(24, 20);
            label14.TabIndex = 29;
            label14.Text = "ID";
            // 
            // txtBorrowerName
            // 
            txtBorrowerName.Location = new Point(151, 144);
            txtBorrowerName.Name = "txtBorrowerName";
            txtBorrowerName.Size = new Size(250, 27);
            txtBorrowerName.TabIndex = 27;
            // 
            // txtBorrowerID
            // 
            txtBorrowerID.Location = new Point(151, 108);
            txtBorrowerID.Name = "txtBorrowerID";
            txtBorrowerID.Size = new Size(250, 27);
            txtBorrowerID.TabIndex = 26;
            txtBorrowerID.TextChanged += txtBorrowerID_TextChanged;
            // 
            // CleanBorrower
            // 
            CleanBorrower.Location = new Point(404, 370);
            CleanBorrower.Name = "CleanBorrower";
            CleanBorrower.Size = new Size(94, 29);
            CleanBorrower.TabIndex = 22;
            CleanBorrower.Text = "Clean";
            CleanBorrower.UseVisualStyleBackColor = true;
            CleanBorrower.Click += CleanBorrower_Click;
            // 
            // DeleteBorrower
            // 
            DeleteBorrower.Location = new Point(285, 370);
            DeleteBorrower.Name = "DeleteBorrower";
            DeleteBorrower.Size = new Size(94, 29);
            DeleteBorrower.TabIndex = 21;
            DeleteBorrower.Text = "Delete";
            DeleteBorrower.UseVisualStyleBackColor = true;
            DeleteBorrower.Click += DeleteBorrower_Click;
            // 
            // AddBorrower
            // 
            AddBorrower.Location = new Point(48, 370);
            AddBorrower.Name = "AddBorrower";
            AddBorrower.Size = new Size(94, 29);
            AddBorrower.TabIndex = 19;
            AddBorrower.Text = "Add";
            AddBorrower.UseVisualStyleBackColor = true;
            AddBorrower.Click += AddBorrower_Click;
            // 
            // dgvBorrowers
            // 
            dgvBorrowers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBorrowers.Location = new Point(498, 78);
            dgvBorrowers.Name = "dgvBorrowers";
            dgvBorrowers.RowHeadersWidth = 51;
            dgvBorrowers.Size = new Size(546, 270);
            dgvBorrowers.TabIndex = 18;
            dgvBorrowers.CellContentClick += dgvBorrowers_CellContentClick;
            // 
            // ManagerTicket
            // 
            ManagerTicket.Controls.Add(returnDateTicket);
            ManagerTicket.Controls.Add(borrowerDatetTicket);
            ManagerTicket.Controls.Add(cbTicketBook);
            ManagerTicket.Controls.Add(cbTicketBorrower);
            ManagerTicket.Controls.Add(label18);
            ManagerTicket.Controls.Add(label15);
            ManagerTicket.Controls.Add(label16);
            ManagerTicket.Controls.Add(label17);
            ManagerTicket.Controls.Add(label20);
            ManagerTicket.Controls.Add(label21);
            ManagerTicket.Controls.Add(txtTicketID);
            ManagerTicket.Controls.Add(CleanTicket);
            ManagerTicket.Controls.Add(DeleteTicket);
            ManagerTicket.Controls.Add(UpdateTicket);
            ManagerTicket.Controls.Add(AddTicket);
            ManagerTicket.Controls.Add(dgvTickets);
            ManagerTicket.Location = new Point(4, 29);
            ManagerTicket.Name = "ManagerTicket";
            ManagerTicket.Padding = new Padding(3);
            ManagerTicket.Size = new Size(1092, 444);
            ManagerTicket.TabIndex = 2;
            ManagerTicket.Text = "Manager Ticket";
            ManagerTicket.UseVisualStyleBackColor = true;
            // 
            // returnDateTicket
            // 
            returnDateTicket.Location = new Point(150, 254);
            returnDateTicket.Name = "returnDateTicket";
            returnDateTicket.Size = new Size(250, 27);
            returnDateTicket.TabIndex = 58;
            // 
            // borrowerDatetTicket
            // 
            borrowerDatetTicket.Location = new Point(150, 221);
            borrowerDatetTicket.Name = "borrowerDatetTicket";
            borrowerDatetTicket.Size = new Size(251, 27);
            borrowerDatetTicket.TabIndex = 57;
            // 
            // cbTicketBook
            // 
            cbTicketBook.FormattingEnabled = true;
            cbTicketBook.Location = new Point(150, 151);
            cbTicketBook.Name = "cbTicketBook";
            cbTicketBook.Size = new Size(251, 28);
            cbTicketBook.TabIndex = 56;
            cbTicketBook.SelectedIndexChanged += cbTicketBook_SelectedIndexChanged;
            // 
            // cbTicketBorrower
            // 
            cbTicketBorrower.FormattingEnabled = true;
            cbTicketBorrower.Location = new Point(150, 187);
            cbTicketBorrower.Name = "cbTicketBorrower";
            cbTicketBorrower.Size = new Size(251, 28);
            cbTicketBorrower.TabIndex = 55;
            cbTicketBorrower.SelectedIndexChanged += cbTicketBorrower_SelectedIndexChanged;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(48, 228);
            label18.Name = "label18";
            label18.Size = new Size(91, 20);
            label18.TabIndex = 54;
            label18.Text = "Borrow date";
            label18.Click += label18_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(188, 45);
            label15.Name = "label15";
            label15.Size = new Size(160, 28);
            label15.TabIndex = 53;
            label15.Text = "Manager Ticket";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(48, 261);
            label16.Name = "label16";
            label16.Size = new Size(86, 20);
            label16.TabIndex = 52;
            label16.Text = "Return date";
            label16.Click += label16_Click;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(48, 195);
            label17.Name = "label17";
            label17.Size = new Size(70, 20);
            label17.TabIndex = 51;
            label17.Text = "Borrower";
            label17.Click += label17_Click;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(48, 159);
            label20.Name = "label20";
            label20.Size = new Size(43, 20);
            label20.TabIndex = 48;
            label20.Text = "Book";
            label20.Click += label20_Click;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(48, 121);
            label21.Name = "label21";
            label21.Size = new Size(24, 20);
            label21.TabIndex = 47;
            label21.Text = "ID";
            label21.Click += label21_Click;
            // 
            // txtTicketID
            // 
            txtTicketID.Location = new Point(150, 118);
            txtTicketID.Name = "txtTicketID";
            txtTicketID.Size = new Size(250, 27);
            txtTicketID.TabIndex = 45;
            txtTicketID.TextChanged += txtTicketID_TextChanged;
            // 
            // CleanTicket
            // 
            CleanTicket.Location = new Point(404, 370);
            CleanTicket.Name = "CleanTicket";
            CleanTicket.Size = new Size(94, 29);
            CleanTicket.TabIndex = 44;
            CleanTicket.Text = "Clean";
            CleanTicket.UseVisualStyleBackColor = true;
            CleanTicket.Click += CleanTicket_Click;
            // 
            // DeleteTicket
            // 
            DeleteTicket.Location = new Point(285, 370);
            DeleteTicket.Name = "DeleteTicket";
            DeleteTicket.Size = new Size(94, 29);
            DeleteTicket.TabIndex = 43;
            DeleteTicket.Text = "Delete";
            DeleteTicket.UseVisualStyleBackColor = true;
            DeleteTicket.Click += DeleteTicket_Click;
            // 
            // UpdateTicket
            // 
            UpdateTicket.Location = new Point(168, 370);
            UpdateTicket.Name = "UpdateTicket";
            UpdateTicket.Size = new Size(94, 29);
            UpdateTicket.TabIndex = 42;
            UpdateTicket.Text = "Update";
            UpdateTicket.UseVisualStyleBackColor = true;
            UpdateTicket.Click += button2_Click;
            // 
            // AddTicket
            // 
            AddTicket.Location = new Point(48, 370);
            AddTicket.Name = "AddTicket";
            AddTicket.Size = new Size(94, 29);
            AddTicket.TabIndex = 41;
            AddTicket.Text = "Add";
            AddTicket.UseVisualStyleBackColor = true;
            AddTicket.Click += AddTicket_Click;
            // 
            // dgvTickets
            // 
            dgvTickets.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTickets.Location = new Point(498, 78);
            dgvTickets.Name = "dgvTickets";
            dgvTickets.RowHeadersWidth = 51;
            dgvTickets.Size = new Size(546, 270);
            dgvTickets.TabIndex = 40;
            dgvTickets.CellContentClick += dgvTickets_CellContentClick;
            // 
            // manager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1098, 478);
            Controls.Add(tabcontrol1);
            Name = "manager";
            Text = "Manager";
            Load += manager_Load;
            tabcontrol1.ResumeLayout(false);
            ManagerBook.ResumeLayout(false);
            ManagerBook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).EndInit();
            ManagerBorrwer.ResumeLayout(false);
            ManagerBorrwer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBorrowers).EndInit();
            ManagerTicket.ResumeLayout(false);
            ManagerTicket.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTickets).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabcontrol1;
        private TabPage ManagerBook;
        private TabPage ManagerBorrwer;
        private Button CleanBook;
        private Button DeleteBook;
        private Button UpdateTicket;
        private Button AddBook;
        private DataGridView dgvBooks;
        private ComboBox cbCID;
        private ComboBox cbBookAuthor;
        private TextBox txtBookName;
        private TextBox txtBookID;
        private ComboBox cbBookPublisher;
        private Label label2;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label7;
        private TextBox txtBorrowerEmail;
        private TextBox txtBorrowerPhone;
        private TextBox txtBorrowerAddress;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private TextBox txtBorrowerName;
        private TextBox txtBorrowerID;
        private Button CleanTicket;
        private Button DeleteTicket;
        private Button Updater1;
        private Button AddTicket;
        private DataGridView dgvBorrowers;
        private TabPage ManagerTicket;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label20;
        private Label label21;
        private TextBox txtTicketID;
        private Button CleanBorrower;
        private Button DeleteBorrower;
        private Button Update2;
        private Button AddBorrower;
        private DataGridView dgvTickets;
        private Label label18;
        private ComboBox cbTicketBook;
        private ComboBox cbTicketBorrower;
        private DateTimePicker returnDateTicket;
        private DateTimePicker borrowerDatetTicket;
        private DateTimePicker dateTimePicker4;
        private Button UpdateBook;
        private Button UpdateBorrower;

        public EventHandler Delete1_Click { get; private set; }
        public EventHandler Add2_Click { get; private set; }
    }
}