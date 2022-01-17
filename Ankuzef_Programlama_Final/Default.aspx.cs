using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ankuzef_Programlama_Final
{
    public partial class Default : System.Web.UI.Page
    {
        CuzdanEntities baglanti = new CuzdanEntities();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_Ekle_Click(object sender, EventArgs e)
        {
            Hesap hesap = new Hesap();

            hesap.Hesap_Adi = txt_hspAd.Text.ToString();
            hesap.Hesap_No = int.Parse(txt_hspNo.Text);
            if (string.IsNullOrEmpty(txt_alacak.Text) == false)
            {
                hesap.Alacak = decimal.Parse(txt_alacak.Text);
            }
            if (string.IsNullOrEmpty(txt_borc.Text) == false)
            {
                hesap.Borc = decimal.Parse(txt_borc.Text);
            }
            if (string.IsNullOrEmpty(txt_aciklama.Text) == false)
            {
                hesap.Aciklama = txt_aciklama.Text.ToString();
            }

            try
            {
                baglanti.Hesap.Add(hesap);
                baglanti.SaveChanges();
                lbl_snc.Text = "Kayıt başarılı bir şekilde gerçekleştirildi.";
            }
            catch (Exception)
            {
                lbl_snc.Text = "Bir Hata ile karşılaşıldı.";
            }
        }

        protected void btn_lst_Click(object sender, EventArgs e)
        {
            baglanti.Hesap.Load();
            GridView1.DataSource = baglanti.Hesap.Local;
            GridView1.DataBind();
        }

        protected void btn_Sil_Click(object sender, EventArgs e)
        {
            int hesapNo = int.Parse(txt_hspNo.Text);
            var kayit = (from hesap in baglanti.Hesap
                         where hesap.Hesap_No == hesapNo
                         select hesap).FirstOrDefault();
            if (kayit != null)
            {
                baglanti.Hesap.Remove(kayit);
                baglanti.SaveChanges();
                lbl_snc.Text = "Kayıt başarı ile silindi.";
            }
            else
            {
                lbl_snc.Text = "Bir hata ile karşılaşıldı";
            }
        }

        protected void btn_Guncelle_Click(object sender, EventArgs e)
        {
            int hesapNo = Convert.ToInt32(txt_hspNo.Text);
            var kayit = (from hesap in baglanti.Hesap
                         where hesap.Hesap_No == hesapNo
                         select hesap).FirstOrDefault();

            if (kayit != null)
            {
                kayit.Hesap_Adi = txt_hspAd.Text.ToString();
                kayit.Hesap_No = int.Parse(txt_hspNo.Text);
                if (string.IsNullOrEmpty(txt_alacak.Text) == false)
                {
                    kayit.Alacak = decimal.Parse(txt_alacak.Text);
                }
                if (string.IsNullOrEmpty(txt_borc.Text) == false)
                {
                    kayit.Borc = decimal.Parse(txt_borc.Text);
                }
                if (string.IsNullOrEmpty(txt_aciklama.Text) == false)
                {
                    kayit.Aciklama = txt_aciklama.Text.ToString();
                }

                baglanti.SaveChanges();
                lbl_snc.Text = "Kayıt başarı ile güncellendi";
            }
            else
            {
                lbl_snc.Text = "Güncelleme sırasında bir hata ile karşılaşıldı.";
            }
        }
    }
}