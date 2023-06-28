using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tinder_interplanetario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void alterarNome()
        {
            for (int i = 0; i < ltv_list.Items.Count; i++)
            {
                string[] nome = ltv_list.Items[i].Text.Split('(');
                ltv_list.Items[i].Text = nome[0];

                ltv_list.Items[i].Text =
                    ltv_list.Items[i].Text +
                    "(" +
                    ltv_list.Items[i].SubItems[2].Text +
                    " --> " +
                    ltv_list.Items[i].SubItems[3].Text +
                    ")";
            }
        }
        private void nomePadrao()
        {
            for (int i = 0; i < ltv_list.Items.Count; i++)
            {
                string[] nome = ltv_list.Items[i].Text.Split('(');
                ltv_list.Items[i].Text = nome[0];
            }
        }

        private void labelCount() // Change the label above the listview
        {
            int countM = 0;
            int countF = 0;
            for (int i = 0; i < ltv_list.Items.Count; i++)
            {
                if (ltv_list.Items[i].SubItems[2].Text == "M")
                {
                    countM++;
                } else
                {
                    countF++;
                }
            }

            if (countM > countF)
            {
                lbl_masculinos.ForeColor = Color.Blue;
                lbl_femininos.ForeColor = Color.Red;
            } else if (countM < countF)
            {
                lbl_femininos.ForeColor = Color.DeepPink;
                lbl_masculinos.ForeColor = Color.Red;
            } else
            {
                lbl_masculinos.ForeColor = Color.Blue;
                lbl_femininos.ForeColor = Color.DeepPink;
            }

            lbl_femininos.Text = countF + " Feminios";
            lbl_masculinos.Text = countM + " Masculinos";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbl_masculinos.ForeColor = Color.Blue;
            lbl_masculinos.Text = 1 + " Masculinos";
            lbl_femininos.ForeColor = Color.DeepPink;
            lbl_femininos.Text = 1 + " Femininos";
        }

        private void txb_nome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 32)
            {
                e.Handled = true;
            }
        }

        private void txb_nome_TextChanged(object sender, EventArgs e)
        {
            btn_inserir.Enabled = txb_nome.TextLength == 0 ? false : true;
        }

        private void btn_inserir_Click(object sender, EventArgs e)
        {
            if (cmb_planeta.SelectedIndex != -1 &&
                (rdb_feminino.Checked == true || rdb_masculino.Checked == true) &&
                (ckb_feminino.Checked == true || ckb_masculino.Checked == true)
                )
            {
                // Adding the new item
                ListViewItem newItem = new ListViewItem(txb_nome.Text);
                newItem.SubItems.Add(cmb_planeta.SelectedItem.ToString());
                newItem.SubItems.Add(rdb_feminino.Checked == true ? "F" : "M");
                newItem.SubItems.Add(ckb_masculino.Checked == true ? ckb_feminino.Checked == true ? "M, F" : "M" : "F");
                newItem.ImageIndex = rdb_masculino.Checked == true ? 0 : 1;

                if (ltv_list.View == View.LargeIcon)
                {
                    newItem.Text = newItem.Text + "(" + newItem.SubItems[2].Text + " --> " + newItem.SubItems[3].Text + ")";
                }

                // Reseting all the options
                rdb_feminino.Checked = false;
                rdb_masculino.Checked = false;
                ckb_feminino.Checked = false;
                ckb_masculino.Checked = false;
                txb_nome.Text = "";
                cmb_planeta.SelectedIndex = -1;

                // Background
                if (ltv_list.Items.Count % 2 == 0)
                {
                    newItem.BackColor = Color.Silver;
                }

                // Adding the new Item
                ltv_list.Items.Add(newItem);

                // Update the female and male label counter
                labelCount();
            } else
            {
                MessageBox.Show("You have to fill all boxes to continue", "Agência de encontros", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            // Code to remove the selected list view items
            if (ltv_list.SelectedItems.Count > 0)
            {
                for (int i = ltv_list.SelectedIndices.Count - 1; i >= 0; i--)
                {
                    ltv_list.Items.RemoveAt(ltv_list.SelectedIndices[i]);
                }

            } else
            {
                MessageBox.Show("Precisa selecionar pelo menos um item", "Agência de encontros", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            string possiveisMatch = "";
            if (ltv_list.Items.Count < 2)
            {
                possiveisMatch += "     Não existem possiveis casais";
            } else
            {
                for (int i = 0; i < ltv_list.Items.Count - 1; i++)
                {
                    for (int j = i + 1; j < ltv_list.Items.Count; j++)
                    {
                        string iprocura = ltv_list.Items[i].SubItems[3].Text;
                        string igenero = ltv_list.Items[i].SubItems[2].Text;
                        string jprocura = ltv_list.Items[j].SubItems[3].Text;
                        string jgenero = ltv_list.Items[j].SubItems[2].Text;

                        if (iprocura[0].ToString() == jgenero || iprocura[iprocura.Length - 1].ToString() == jgenero)
                        {
                            if (jprocura[0].ToString() == igenero || jprocura[jprocura.Length - 1].ToString() == igenero)
                            {
                                string[] nomei = ltv_list.Items[i].Text.Split('(');
                                ltv_list.Items[i].Text = nomei[0];
                                string[] nomej = ltv_list.Items[j].Text.Split('(');
                                ltv_list.Items[i].Text = nomej[0];

                                possiveisMatch +=
                                    "     " +
                                    ltv_list.Items[i].Text +
                                    "[" +
                                    ltv_list.Items[i].SubItems[1].Text +
                                    "] --> " +
                                    ltv_list.Items[j].Text +
                                    "[" +
                                    ltv_list.Items[j].SubItems[1].Text +
                                    "]\n";
                            }
                        }
                    }
                }

                if (possiveisMatch.Length == 0)
                {
                    possiveisMatch += "     Não existem possiveis casais";
                }
            }

            DialogResult result = MessageBox.Show(
                "Encontros a realizar: \n" + 
                possiveisMatch + 
                "\nQuer mesmo terminar a aplicação?", 
                "Agência de encontros", 
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Information
                );
            if (result == DialogResult.Yes)
            {
                System.Windows.Forms.Application.Exit();
            } else
            {
                // Message box close.
            }
        }

        private void tsmi_large_Click(object sender, EventArgs e)
        {
            tsmi_large.Checked = true;

            if (tsmi_large.Checked == true)
            {
                ltv_list.View = View.LargeIcon;
                tsmi_list.Checked = false;
                tsmi_details.Checked = false;

                // Atualizando o nome
                alterarNome();
            }
        }

        private void tsmi_list_Click(object sender, EventArgs e)
        {
            tsmi_list.Checked = true;

            if (tsmi_list.Checked == true)
            {
                ltv_list.View = View.List;
                tsmi_large.Checked = false;
                tsmi_details.Checked = false;

                // Voltar ao nome padrão
                nomePadrao();
            }
        }

        private void tsmi_details_Click(object sender, EventArgs e)
        {
            tsmi_details.Checked = true;

            if (tsmi_details.Checked == true)
            {
                ltv_list.View = View.Details;
                tsmi_large.Checked = false;
                tsmi_list.Checked = false;

                // Voltar ao nome padrão
                nomePadrao();
            }
        }
    }
}
