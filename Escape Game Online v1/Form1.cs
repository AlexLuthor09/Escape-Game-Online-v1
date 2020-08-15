using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Forms;


namespace Escape_Game_Online_v1
{
    public partial class OcarinaBox : Form
    {
        public OcarinaBox()
        {
            InitializeComponent();
        }
        //--------------fonction------------------------------------
        void LancerVideo(string PathVideo)
        {
            if (System.IO.File.Exists(PathVideo))
            {
                System.Diagnostics.Process.Start(PathVideo);   
            }
            else
            {
                MessageBox.Show("Fichier introuvable : " + PathVideo);
                this.Show();
            }
        }
        void GoToSite(string url)
        {
            System.Diagnostics.Process.Start(url);
            
        }
        void clear()
        {
            textBoxMP.Text = "";
            textBoxName.Text = "";
        }
        //----------------- Constantes -----------------------------

        string NomUtilisateur = "";
       

        string site1 = "https://www.youtube.com";
        string site2 = "https://www.youtube.com";
        string site3 = "https://www.youtube.com";
        string site4 = "https://www.youtube.com";
        

        string PathVraiVideo = "VraiVideo.mp4";

        //----------------------------------------------------------
        private void ValidationButton_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text == NomUtilisateur)
            {
                switch(textBoxMP.Text)
                {
                    case "1":                   //mot de passe pour site 1 
                       
                        GoToSite(site1);
                        MessageBox.Show("b");                       
                        break;

                    case "2":                   //mot de passe pour site 2
                        MessageBox.Show("Trouvez la solution a cette enigme : ... ?");
                        GoToSite(site2);
                        GoToSite(site3);
                        GoToSite(site4);
                        GoToSite(site1);
                        break;

                    case "3":                   //mot de passe pour site 3
                        MessageBox.Show("b");
                        GoToSite(site3);
                        break;

                    case "4":                   //mot de passe pour site 4
                        MessageBox.Show("b");
                        GoToSite(site4);
                        break;

                    case "vrai":                   //Vrai mot de passe
                        LancerVideo(PathVraiVideo);
                        clear();
                        break;

                    default:
                        MessageBox.Show("ERROR : Mauvais mot de passe");
                        break;
                }   
            }
            else
            {
                MessageBox.Show("ERROR : Nom utilisateur");
            }
        }
       
    }
}
