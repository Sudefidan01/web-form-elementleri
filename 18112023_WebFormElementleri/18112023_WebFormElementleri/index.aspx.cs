using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _18112023_WebFormElementleri
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string metin = TextBox1.Text;
            if (string.IsNullOrEmpty(metin))
            {
                Label1.Text = "Metin alanı boş bırakılamaz";
                Label1.ForeColor = Color.Red;
            }
            else
            {
                Label1.Text = metin;
                TextBox1.Text = string.Empty;
                Label1.ForeColor = Color.Green;
            }
        }

        protected void btnCheckbox_Click(object sender, EventArgs e)
        {
            List<string> list = new List<string>();
            if (CheckBox1.Checked)
            {
                list.Add(CheckBox1.Text);
            }
            if (CheckBox2.Checked)
            {
                list.Add(CheckBox2.Text);
            }
            if (CheckBox3.Checked)
            {
                list.Add (CheckBox3.Text);
            }
            if (CheckBox4.Checked)
            {
                list.Add(CheckBox4.Text);
            }
            if (CheckBox5.Checked) 
            {
                list.Add(CheckBox5.Text);
            }
            string secilenler = string.Empty;
            if (list.Any())
            {
                for (int i = 0; i < list.Count; i++)
                {
                    secilenler += (i==0 ?"":",")+list[i];
                }
                lblCheckbox.Text = "Seçilen Değeler = " + secilenler;
                lblCheckbox.ForeColor = Color.Green;
            }
            else
            {
                lblCheckbox.Text = "En az bir seçim yapmalısınız";
                lblCheckbox.ForeColor = Color.Red;  
            }
        }

        protected void btnRadioButton_Click(object sender, EventArgs e)
        {
            if (RadioButton1.Checked)
            {
                lblRadioButton.Text = RadioButton1.Text;
            }
            else if (RadioButton2.Checked) 
            {
                lblRadioButton.Text = RadioButton2.Text;
            }
            else if(RadioButton3.Checked)
            {
                lblRadioButton.Text = RadioButton3.Text;
            }
            else
            {
                lblRadioButton.Text = "Seçim Yapmalısınız ";
            }
        }

        protected void btnSehirOku_Click(object sender, EventArgs e)
        {
            lblSehir.Text = string.Format("Text: {0} , Value: {1}",ddlSehirler.SelectedItem.Text,ddlSehirler.SelectedItem.Value);
        }

        protected void btnYeniDeger_Click(object sender, EventArgs e)
        {
            ddlSehirler.Items.Clear();
            ddlSehirler.Items.Add(new ListItem("Kastamonu","37"));
            ddlSehirler.Items.Add(new ListItem("Rize","53"));
            ddlSehirler.Items.Add(new ListItem("Sivas","58"));
            ddlSehirler.Items.Add(new ListItem("Çanakkale","17"));
            ddlSehirler.Items.Add(new ListItem("Bursa","16"));
        }

        protected void btnImage_Click(object sender, EventArgs e)
        {
            if (Image1.ImageUrl== "~/images/armut.jpg")
            {
                Image1.ImageUrl = "~/images/cilek.jpg";
            }
            else if (Image1.ImageUrl == "~/images/cilek.jpg")
            {
                Image1.ImageUrl = "~/images/elma.jpg";
            }

            else if (Image1.ImageUrl== "~/images/elma.jpg")
            {
                Image1.ImageUrl = "~/images/karpuz.jpg";
            }
            else if (Image1.ImageUrl== "~/images/karpuz.jpg")
            {
                Image1.ImageUrl = "~/images/kivi.jpg";
            }
            else
            {
                Image1.ImageUrl = "~/images/armut.jpg";
            }

        }

        protected void btnUpload_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile) //File upload ile bir dosya seçildi mi
            {
                if (FileUpload1.PostedFile.ContentLength>0)
                {
                    if (FileUpload1.FileName.Contains(".jpg") || FileUpload1.FileName.Contains(".jpeg") ||
                        FileUpload1.FileName.Contains(".png"))
                    {
                        string fileName = Guid.NewGuid().ToString() + "_" + FileUpload1.ToString();
                        FileUpload1.SaveAs(Server.MapPath("~/images/"+fileName));
                        lblUpload.Text = "Dosya yükleme işlemi başarılı";
                    }
                    else
                    {
                        lblUpload.Text = "Lütfen .png .jpg .jpeg uzantısına sahip resimleri ekleyenizi";
                    }

                }
                else
                {

                    lblUpload.Text = "Lütfen geçerli bir dosya seçiniz";
                }
            }
            else
            {
                lblUpload.Text = "Lütfen dosya seçimi yapınız";
            }
        }
    }
}