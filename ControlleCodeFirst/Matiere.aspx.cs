using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ControlleCodeFirst
{
    public partial class Matiere1 : System.Web.UI.Page
    {
        MyDb dba = new MyDb();
        static int index;
        static List<String> lbIndex=new List<string>();
        protected void Page_Load(object sender, EventArgs e)
        {
            refresh();
        }
        void refresh()
        {
            GridView1.DataSource = (from mat in dba.Matieres orderby mat.name ascending select mat).ToList();
            GridView1.DataBind();

           
        }
       

        protected void btnAjouter_Click(object sender, EventArgs e)
        {
            Matiere newMat = new Matiere();
            newMat.name = tbName.Text;
            try
            {
                foreach (String toto in lbIndex)
                newMat.atome+=" "+toto;
                newMat.etat = tbEtat.Text;
                newMat.MV = float.Parse(tbMV.Text);
                if (RadioButtonList1.SelectedValue == "Rare")
                    newMat.rare = true;
                else
                    newMat.rare = false;

                dba.Matieres.Add(newMat);
                dba.SaveChanges();
                refresh();
            }
            catch (Exception)
            {

            }
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
                        GridView1.DataSource = (from mat in dba.Matieres
                                                where mat.name.Contains(tbRechercher.Text)
                                                || mat.etat.Contains(tbRechercher.Text)
                                                || mat.MV == good
                                                || mat.Idm == good
                                                orderby mat.name ascending
                                                select mat).ToList();
                    }
                    else
                    {
                        GridView1.DataSource = (from mat in dba.Matieres
                                                where mat.name.Contains(tbRechercher.Text)
                                                || mat.etat.Contains(tbRechercher.Text)
                                                orderby mat.name ascending
                                                select mat).ToList();
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

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = int.Parse(GridView1.SelectedValue.ToString());
            Matiere newMat = (from mat in dba.Matieres where mat.Idm == index select mat).Single();
            tbName.Text = newMat.name;
            tbEtat.Text = newMat.etat;
            tbMV.Text = newMat.MV.ToString();
            if(newMat.rare.ToString()=="True")
            RadioButtonList1.SelectedValue = "Rare";
            else
                RadioButtonList1.SelectedValue = "Commun";


        }

        protected void btnModifier_Click(object sender, EventArgs e)
        {
            Matiere newMat = (from mat in dba.Matieres where mat.Idm == index select mat).Single();
            newMat.name = tbName.Text;
            try
            {
                foreach (String toto in lbIndex)
                    newMat.atome = " " + toto;
                newMat.etat = tbEtat.Text;
                newMat.MV = float.Parse(tbMV.Text);
                if (RadioButtonList1.SelectedValue == "Rare")
                    newMat.rare = true;
                else
                    newMat.rare = false;

                dba.SaveChanges();
                refresh();
            }
            catch (Exception)
            {

            }
        }

        protected void btnSupprimer_Click(object sender, EventArgs e)
        {
            Matiere newAtm = (from atm in dba.Matieres where atm.Idm == index select atm).Single();
            dba.Matieres.Remove(newAtm);
            dba.SaveChanges();
            refresh();
        }

        protected void lbAtome_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbIndex.Clear();
            foreach (int index in lbAtome.GetSelectedIndices())
                lbIndex.Add(lbAtome.Items[index].ToString());            
        }

        protected void lbAtome_Init(object sender, EventArgs e)
        {
            lbAtome.DataSource = (from atm in dba.Atomes orderby atm.symbole ascending select atm.symbole).ToList();
            lbAtome.DataBind();
        }
    }
}