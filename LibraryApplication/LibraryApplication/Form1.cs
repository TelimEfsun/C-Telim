using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace LibraryApplication
{
    public partial class Form1: Form
    {
        List<Library> LibraryList = new List<Library>();

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TextName.Text) &&     //Bos olub olmadigini yoxlayir
                 !string.IsNullOrWhiteSpace(TextGenre.Text) &&
                !string.IsNullOrWhiteSpace(TextPrice.Text))
            {
                
                Library newBook = new Library()
                {
                    BookName = TextName.Text,
                    BookGenre = TextGenre.Text,
                    BookPrice = Convert.ToDouble(TextPrice.Text)
                };

                LibraryList.Add(newBook); 

                MessageBox.Show("Kitab əlavə olundu!");

                
                TextName.Text = "";
                TextGenre.Text = "";
                TextPrice.Text = "";

                UpdateDataGridView(); 
            }
            else
            {
                MessageBox.Show("Yalnis operasiya");
            }
        }
        private void UpdateDataGridView()
        {
            DataGridView.Rows.Clear(); 

            foreach (var book in LibraryList)
            {
                DataGridView.Rows.Add(book.BookName, book.BookGenre, book.BookPrice);
            }
        }

        private void BtnGoster_Click(object sender, EventArgs e)
        {
            UpdateDataGridView();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            if (DataGridView.SelectedRows.Count > 0)
            {
                
                int index = DataGridView.SelectedRows[0].Index;
                LibraryList.RemoveAt(index); 
                UpdateDataGridView(); 

                MessageBox.Show("Seçilmiş kitab silindi!");
            }
            else
            {
                MessageBox.Show("Zəhmət olmasa, silmək üçün bir kitab seçin!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataGridView.ColumnCount = 3;
            DataGridView.Columns[0].Name = "Kitab Adı";
            DataGridView.Columns[1].Name = "Janr";
            DataGridView.Columns[2].Name = "Qiymət";
        }

    }
}
