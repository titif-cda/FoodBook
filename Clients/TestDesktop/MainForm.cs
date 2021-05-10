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
using TestDesktop;

namespace DesktopClient
{
    public partial class MainForm : Form
    {
        private readonly ILibrairiService _librairiService;
        private int currentPage = 1;
        private int defaultPageSize = 10;
        private int maxPage;
        private BindingSource bindingSource = new BindingSource();
        public MainForm()
        {
            _librairiService = new LibrairiService();
            InitializeComponent();
           this.LoadIngredients();
        }

        private async void LoadIngredients()
        {
            Task<PageResponse<Ingredient>> ingredientPageTask = _librairiService.GetAllIngredients(new PageRequest(currentPage, defaultPageSize));
            PageResponse<Ingredient> ingredientPage = await ingredientPageTask;
            maxPage = ingredientPage.TotalPages.GetValueOrDefault();
            bindingSource.DataSource = ingredientPage.Data;

            ingredientsDataGridView.DataSource = bindingSource;
            Grisage();

        }
        private void RefreshPage()
        {
            currentPageLabel.Text = currentPage.ToString();

            //currentPageLabel.Text = currentPageLabel.ToString();
            this.LoadIngredients();
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

        private void Grisage()
        {
            if (currentPage == 1)
            {
                previousBtn.Enabled = false;
            }
            else
            {
                previousBtn.Enabled = true;
            }

            if (currentPage == maxPage)
            {
                nextBtn.Enabled = false;
            }
            else
            {
                nextBtn.Enabled = true;
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            var crudIngredientForm = new CrudIngredients();
            crudIngredientForm.Initialize(null);
            crudIngredientForm.Show();

            crudIngredientForm.FormClosed += CrudIngredientForm_FormClosed;
        }

        private void ingredientsDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView gridView = (DataGridView)sender;
            if (ingredientsDataGridView.SelectedRows.Count > 0)
            {
                Ingredient selectedIngredient = (Ingredient)ingredientsDataGridView.SelectedRows[0].DataBoundItem;
                var crudIngredientForm = new CrudIngredients();
                crudIngredientForm.Initialize(selectedIngredient);
                crudIngredientForm.Show();

                crudIngredientForm.FormClosed += CrudIngredientForm_FormClosed;
            }
        }

        private void CrudIngredientForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.RefreshPage();
        }

       
    }


}
