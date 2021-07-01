using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace PapEval
{
    public partial class frmMain : MetroFramework.Forms.MetroForm
    {
        private List<Grupo> gruposList;
        
        public frmMain()
        {
            InitializeComponent();

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.DimGray;
            gruposList = new List<Grupo>();
            LoadList();
            //lstGroups.DataSource = gruposList;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("[-] - Exit the Application??", "QUESTION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                SaveList();
                this.Close();
            }else
            {
                lstGroups.Focus();
            }
        }

        private void SaveList()
        {
            string path = Directory.GetCurrentDirectory();
            //string dir = @"e:\PROGRAMING\CSHARP_APPS\PapEval\PapEval\PapEval\bin\Debug\net5.0-windows";
            string serializationFile = Path.Combine(path, "grupos.bin");

            //serialize
            using (Stream stream = File.Open(serializationFile, FileMode.Create))
            {
                var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                bformatter.Serialize(stream, gruposList);
            }
        }

        private void LoadList()
        {
            string path = Directory.GetCurrentDirectory();
            //string dir = @"e:\PROGRAMING\CSHARP_APPS\PapEval\PapEval\PapEval\bin\Debug\net5.0-windows";
            string serializationFile = Path.Combine(path, "grupos.bin");
            //deserialize
            using (Stream stream = File.Open(serializationFile, FileMode.Open))
            {
                var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                 gruposList = (List<Grupo>)bformatter.Deserialize(stream);
            }

            foreach (var grupo in gruposList)
            {
                populateListBox(grupo);
            }
        }

        private void populateListBox(Grupo grupo)
        {
            lstGroups.Items.Add("GRUPO: " + grupo.id + " --> Nome: " + grupo.name + " --> Alunos:  " + grupo.aluno1 + " - " + grupo.aluno2 + " --> " + grupo.aluno3 + " --> " + "NOTA FINAL: " + grupo.finalGrade);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmGroup newGroup = new frmGroup(this);
            newGroup.ShowDialog(this);
        }

        public int totAlunos()
        {
            return gruposList.Count();
        }
        public void AddGroups(Grupo grupo)
        {  
            gruposList.Add(grupo);
            populateListBox(grupo);
        }

        public void updateGroup(int index, Grupo grupo)
        {
            gruposList[index].name = grupo.name;
            gruposList[index].aluno1 = grupo.aluno1;
            gruposList[index].aluno2 = grupo.aluno2;
            gruposList[index].aluno3 = grupo.aluno3;
            gruposList[index].presentationGrade = grupo.presentationGrade;
            gruposList[index].reportGrade = grupo.reportGrade;
            gruposList[index].projectGrade = grupo.projectGrade;
            gruposList[index].finalGrade = grupo.finalGrade;
            gruposList[index].obs = grupo.obs;


            lstGroups.Items.Clear();
            foreach (var group in gruposList)
            {
                populateListBox(group);
            }
        }

        public List<Grupo> getGroups()
        {
            return gruposList;
        }

        private void frmMain_Activated(object sender, EventArgs e)
        {
            lstGroups.Refresh();
            foreach (var grupo in gruposList)
            {
                Console.WriteLine(grupo.name);
            }
            
        }

        private void pnlData_Enter(object sender, EventArgs e)
        {
            lstGroups.Refresh();
            foreach (var grupo in gruposList)
            {
                Console.WriteLine(grupo.name);
            }

        }

        private void lstGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            string itemSelected = lstGroups.GetItemText(lstGroups.SelectedItem);
            
        }

        private void lstGroups_DoubleClick(object sender, EventArgs e)
        {
            int index = lstGroups.SelectedIndex;
            editGrades form3 = new editGrades(index, this);
            form3.ShowDialog();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DialogResult response = MessageBox.Show("[-] - Warning... All Data Will Be Deleted!!", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (response == DialogResult.Yes)
            {
                lstGroups.Items.Clear();
                gruposList.Clear();
            }else
            {
                lstGroups.Focus();
            }
        }
    }
}
