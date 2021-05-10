using BLLC.Services;
using BO.DTO.Requests;
using BO.DTO.Responses;
using BO.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopClient
{
    public partial class MainForm : Form
    {
        private readonly ILibrairiService _librairiService;


        private int currentPage = 1;
        private int defaultPageSize = 50;
        private int maxPage;
        private BindingSource bindingSource = new BindingSource();
        public MainForm()
        {
            _librairiService = new LibrairiService();
            InitializeComponent();
            LoadBooks();
        }

        private async void LoadBooks()
        {
            Task<PageResponse<Book>> booksPageTask = _librairiService.GetAllBooks(new PageRequest(currentPage, defaultPageSize));
            PageResponse<Book> BooksPage = await booksPageTask;
            maxPage = BooksPage.TotalPages.GetValueOrDefault();
            bindingSource.DataSource = BooksPage.Data;

            booksDataGridView.DataSource = bindingSource;
        }

        private void NextPage()
        {
            if (currentPage < maxPage)
            {
                currentPage++;
                RefreshPage();

            }

        }

        private void PreviousPage()
        {
            if (currentPage > 1)
            {
                currentPage--;
                RefreshPage();

            }
        }
        private void RefreshPage()
        {
            currentPageLabel.Text = currentPageLabel.ToString();
            LoadBooks();
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            NextPage();
        }

        private void previousBtn_Click(object sender, EventArgs e)
        {
            PreviousPage();
        }

        private void reloadBtn_Click(object sender, EventArgs e)
        {
            RefreshPage();
        }
    }

      
}
