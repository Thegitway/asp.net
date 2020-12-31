using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ControlleCodeFirst
{
    public partial class Atomes : System.Web.UI.Page
    {
        MyDb dba = new MyDb();
        static String index;
        protected void Page_Load(object sender, EventArgs e)
        {
            refresh();
        }
        void refresh()
        {
            GridView1.DataSource = (from atm in dba.Atomes orderby atm.symbole ascending select atm).ToList();
            GridView1.DataBind();
        }

        protected void btnAjouter_Click(object sender, EventArgs e)
        {
            Atome newAtm = new Atome();
            newAtm.symbole = tbSymbole.Text;
            try { 
            newAtm.neutron = int.Parse(tbNeutron.Text);
            newAtm.electron = int.Parse(tbElectron.Text);
            newAtm.proton = int.Parse(tbProton.Text);
            dba.Atomes.Add(newAtm);
            dba.SaveChanges();
            refresh();
            }
            catch(Exception)
            {

            }
        }

        protected void btnModifier_Click(object sender, EventArgs e)
        {

            Atome newAtm = (from atm in dba.Atomes where atm.symbole == index select atm).Single();
            newAtm.symbole = tbSymbole.Text;
            try
            {

                newAtm.neutron = int.Parse(tbNeutron.Text);
                newAtm.electron = int.Parse(tbElectron.Text);
                newAtm.proton = int.Parse(tbProton.Text);
                
                dba.SaveChanges();
                refresh();
            }
            catch (Exception)
            {

            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = GridView1.SelectedValue.ToString();
            Atome newAtm = (from atm in dba.Atomes where atm.symbole == index select atm).Single();
            tbSymbole.Text= newAtm.symbole;
           tbNeutron.Text=newAtm.neutron.ToString() ;
            tbElectron.Text=newAtm.electron.ToString() ;
            tbProton.Text=newAtm.proton.ToString();

            }

        protected void btnSupprimer_Click(object sender, EventArgs e)
        {
            Atome newAtm = (from atm in dba.Atomes where atm.symbole == index select atm).Single();
            dba.Atomes.Remove(newAtm);
            dba.SaveChanges();
            refresh();
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
                        GridView1.DataSource = (from atm in dba.Atomes
                                                where atm.symbole.Contains(tbRechercher.Text)
                                                || atm.electron==good
                                                || atm.neutron == good
                                                || atm.proton == good
                                                orderby atm.symbole ascending
                                                select atm).ToList();
                    }
                    else
                    {
                        GridView1.DataSource = (from atm in dba.Atomes
                                                where atm.symbole.Contains(tbRechercher.Text)

                                                orderby atm.symbole ascending
                                                select atm).ToList();
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
    }
}