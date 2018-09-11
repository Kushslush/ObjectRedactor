namespace Object_Redactor
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.B_info = new System.Windows.Forms.Button();
            this.AddBook = new System.Windows.Forms.Button();
            this.List_of_book = new System.Windows.Forms.Button();
            this.DelBook = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.B_Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.B_Author = new System.Windows.Forms.TextBox();
            this.B_Pages = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.B_Binding = new System.Windows.Forms.GroupBox();
            this.Soft_button = new System.Windows.Forms.RadioButton();
            this.Hard_Buttom = new System.Windows.Forms.RadioButton();
            this.ViewList = new System.Windows.Forms.ListBox();
            this.B_add = new System.Windows.Forms.Button();
            this.Viewinfo = new System.Windows.Forms.Button();
            this.B_del = new System.Windows.Forms.Button();
            this.AddMessage = new System.Windows.Forms.Label();
            this.B_Binding.SuspendLayout();
            this.SuspendLayout();
            // 
            // B_info
            // 
            this.B_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.B_info.Location = new System.Drawing.Point(261, 12);
            this.B_info.Name = "B_info";
            this.B_info.Size = new System.Drawing.Size(131, 29);
            this.B_info.TabIndex = 0;
            this.B_info.Text = "Book info";
            this.B_info.UseVisualStyleBackColor = true;
            this.B_info.Click += new System.EventHandler(this.B_info_Click);
            // 
            // AddBook
            // 
            this.AddBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddBook.Location = new System.Drawing.Point(261, 47);
            this.AddBook.Name = "AddBook";
            this.AddBook.Size = new System.Drawing.Size(131, 29);
            this.AddBook.TabIndex = 1;
            this.AddBook.Text = "Add book";
            this.AddBook.UseVisualStyleBackColor = true;
            this.AddBook.Click += new System.EventHandler(this.AddBook_Click);
            // 
            // List_of_book
            // 
            this.List_of_book.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.List_of_book.Location = new System.Drawing.Point(261, 82);
            this.List_of_book.Name = "List_of_book";
            this.List_of_book.Size = new System.Drawing.Size(131, 29);
            this.List_of_book.TabIndex = 2;
            this.List_of_book.Text = "Books list";
            this.List_of_book.UseVisualStyleBackColor = true;
            this.List_of_book.Click += new System.EventHandler(this.List_of_book_Click);
            // 
            // DelBook
            // 
            this.DelBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DelBook.Location = new System.Drawing.Point(261, 117);
            this.DelBook.Name = "DelBook";
            this.DelBook.Size = new System.Drawing.Size(131, 29);
            this.DelBook.TabIndex = 3;
            this.DelBook.Text = "Delete book";
            this.DelBook.UseVisualStyleBackColor = true;
            this.DelBook.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name:";
            //============this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // B_Name
            // 
            this.B_Name.Location = new System.Drawing.Point(103, 34);
            this.B_Name.Name = "B_Name";
            this.B_Name.Size = new System.Drawing.Size(135, 20);
            this.B_Name.TabIndex = 5;
            //============this.B_Name.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Author:";
            //============this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // B_Author
            // 
            this.B_Author.Location = new System.Drawing.Point(103, 60);
            this.B_Author.Name = "B_Author";
            this.B_Author.Size = new System.Drawing.Size(135, 20);
            this.B_Author.TabIndex = 7;
            // 
            // B_Pages
            // 
            this.B_Pages.Location = new System.Drawing.Point(103, 86);
            this.B_Pages.Name = "B_Pages";
            this.B_Pages.Size = new System.Drawing.Size(135, 20);
            this.B_Pages.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Number of pages:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Binding:";
            // 
            // B_Binding
            // 
            this.B_Binding.Controls.Add(this.Soft_button);
            this.B_Binding.Controls.Add(this.Hard_Buttom);
            this.B_Binding.Location = new System.Drawing.Point(103, 107);
            this.B_Binding.Name = "B_Binding";
            this.B_Binding.Size = new System.Drawing.Size(135, 31);
            this.B_Binding.TabIndex = 12;
            this.B_Binding.TabStop = false;
            //============this.B_Binding.Enter += new System.EventHandler(this.B_Binding_Enter);
            // 
            // Soft_button
            // 
            this.Soft_button.AutoSize = true;
            this.Soft_button.Location = new System.Drawing.Point(61, 7);
            this.Soft_button.Name = "Soft_button";
            this.Soft_button.Size = new System.Drawing.Size(44, 17);
            this.Soft_button.TabIndex = 1;
            this.Soft_button.TabStop = true;
            this.Soft_button.Text = "Soft";
            this.Soft_button.UseVisualStyleBackColor = true;
            //============this.Soft_button.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged_1);
            // 
            // Hard_Buttom
            // 
            this.Hard_Buttom.AutoSize = true;
            this.Hard_Buttom.Location = new System.Drawing.Point(7, 7);
            this.Hard_Buttom.Name = "Hard_Buttom";
            this.Hard_Buttom.Size = new System.Drawing.Size(48, 17);
            this.Hard_Buttom.TabIndex = 0;
            this.Hard_Buttom.TabStop = true;
            this.Hard_Buttom.Text = "Hard";
            this.Hard_Buttom.UseVisualStyleBackColor = true;
            //============this.Hard_Buttom.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged_1);
            // 
            // ViewList
            // 
            this.ViewList.FormattingEnabled = true;
            this.ViewList.Location = new System.Drawing.Point(12, 11);
            this.ViewList.Name = "ViewList";
            this.ViewList.Size = new System.Drawing.Size(226, 134);
            this.ViewList.TabIndex = 13;
            // 
            // B_add
            // 
            this.B_add.Location = new System.Drawing.Point(163, 156);
            this.B_add.Name = "B_add";
            this.B_add.Size = new System.Drawing.Size(75, 23);
            this.B_add.TabIndex = 14;
            this.B_add.Text = "Add";
            this.B_add.UseVisualStyleBackColor = true;
            this.B_add.Click += new System.EventHandler(this.B_add_Click);
            // 
            // Viewinfo
            // 
            this.Viewinfo.Location = new System.Drawing.Point(163, 156);
            this.Viewinfo.Name = "Viewinfo";
            this.Viewinfo.Size = new System.Drawing.Size(75, 23);
            this.Viewinfo.TabIndex = 15;
            this.Viewinfo.Text = "Show";
            this.Viewinfo.UseVisualStyleBackColor = true;
            this.Viewinfo.Click += new System.EventHandler(this.Viewinfo_Click);
            // 
            // B_del
            // 
            this.B_del.Location = new System.Drawing.Point(164, 156);
            this.B_del.Name = "B_del";
            this.B_del.Size = new System.Drawing.Size(75, 23);
            this.B_del.TabIndex = 16;
            this.B_del.Text = "Delete";
            this.B_del.UseVisualStyleBackColor = true;
            this.B_del.Click += new System.EventHandler(this.B_del_Click);
            // 
            // AddMessage
            // 
            this.AddMessage.AutoSize = true;
            this.AddMessage.Location = new System.Drawing.Point(75, 161);
            this.AddMessage.Name = "AddMessage";
            this.AddMessage.Size = new System.Drawing.Size(69, 13);
            this.AddMessage.TabIndex = 18;
            this.AddMessage.Text = "AddMessage";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 201);
            this.Controls.Add(this.AddMessage);
            this.Controls.Add(this.B_del);
            this.Controls.Add(this.Viewinfo);
            this.Controls.Add(this.B_add);
            this.Controls.Add(this.ViewList);
            this.Controls.Add(this.B_Binding);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.B_Pages);
            this.Controls.Add(this.B_Author);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.B_Name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DelBook);
            this.Controls.Add(this.List_of_book);
            this.Controls.Add(this.AddBook);
            this.Controls.Add(this.B_info);
            this.MaximumSize = new System.Drawing.Size(420, 240);
            this.MinimumSize = new System.Drawing.Size(420, 240);
            this.Name = "Form1";
            this.Text = "Books";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.B_Binding.ResumeLayout(false);
            this.B_Binding.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button B_info;
        private System.Windows.Forms.Button AddBook;
        private System.Windows.Forms.Button List_of_book;
        private System.Windows.Forms.Button DelBook;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox B_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox B_Author;
        private System.Windows.Forms.TextBox B_Pages;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox B_Binding;
        private System.Windows.Forms.RadioButton Soft_button;
        private System.Windows.Forms.RadioButton Hard_Buttom;
        private System.Windows.Forms.ListBox ViewList;
        private System.Windows.Forms.Button B_add;
        private System.Windows.Forms.Button Viewinfo;
        private System.Windows.Forms.Button B_del;
        private System.Windows.Forms.Label AddMessage;
    }
}

