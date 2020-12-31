using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ControlleCodeFirst
{
    public partial class Produits : System.Web.UI.Page
    {
        MyDb dba = new MyDb();
        static int index;
        static List<String> lbIndex = new List<string>();
        protected void Page_Load(object sender, EventArgs e)
        {
            refresh();
        }
        void refresh()
        {
            GridView1.DataSource = (from pro in dba.Produits orderby pro.name ascending select pro).ToList();
            GridView1.DataBind();


        }
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

            index = int.Parse(GridView1.SelectedValue.ToString());
            Produit newPro = (from pro in dba.Produits where pro.Idp == index select pro).Single();
            tbName.Text = newPro.name;
            
        }

        protected void btnAjouter_Click(object sender, EventArgs e)
        {
            Produit newPro = new Produit();
            try
            {
                newPro.name = tbName.Text;
                foreach (String toto in lbIndex)
                    newPro.matiere += " " + toto;
                
                dba.Produits.Add(newPro);
                dba.SaveChanges();
                refresh();
            }
            catch (Exception)
            {

            }
        }

        protected void btnModifier_Click(object sender, EventArgs e)
        {
            Produit newPro = (from pro in dba.Produits where pro.Idp == index select pro).Single();
            newPro.name = tbName.Text;
            try
            {
                foreach (String toto in lbIndex)
                    newPro.matiere = " " + toto;
               
                dba.SaveChanges();
                refresh();
            }
            catch (Exception)
            {

            }
        }

        protected void btnSupprimer_Click(object sender, EventArgs e)
        {
           Produit newPro = (from pro in dba.Produits where pro.Idp == index select pro).Single();
            dba.Produits.Remove(newPro);
            dba.SaveChanges();
            refresh();
        }

        protected void lbAtome_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbIndex.Clear();
            foreach (int index in lbMatieres.GetSelectedIndices())
                lbIndex.Add(lbMatieres.Items[index].ToString());
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            int good = 0;
            try
            {
                if (tbRechercher.Text.Length != 0)
                {
                    if (int.TryParse(tbRechercher.Text, out good))
                    {
                        GridView1.DataSource = (from pro in dba.Produits
                                                where pro.name.Contains(tbRechercher.Text)
                                                || pro.Idp == good
                                                orderby pro.name ascending
                                                select pro).ToList();
                    }
                    else
                    {
                        GridView1.DataSource = (from pro in dba.Produits
                                                where pro.name.Contains(tbRechercher.Text)
                                                orderby pro.name ascending
                                                select pro).ToList();
                    }
                    GridView1.DataBind();
                }
                else
                    refresh();

            }
            catch (Exception)
            {

            }
        }


        protected void lbmat_Init(object sender, EventArgs e)
        {
            lbMatieres.DataSource = (from mat in dba.Matieres orderby mat.name ascending select mat.name).ToList();
            lbMatieres.DataBind();
        }
    }
}