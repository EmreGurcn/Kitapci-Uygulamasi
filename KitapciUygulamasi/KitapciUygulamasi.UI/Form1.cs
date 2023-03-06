using KitaciUygulamasi.Entities.Concrete;
using KitapciUygulamasi.BLL.EntitiesRepo;

namespace KitapciUygulamasi.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        MusteriAdresRepository musteriAdresRepository = new MusteriAdresRepository();
        MusteriAdres musteriAdres = new MusteriAdres();
        private void btnEkle_Click(object sender, EventArgs e)
        {
            MusteriAdres _eklenecek = new()
            {
                Sehir = txtSehir.Text,
                Ilçe = txtIlce.Text,
                Mahalle = txtMahalle.Text,
                AdresDetay = txtAdresDetay.Text,
                PostaKodu = txtPostaKodu.Text,
                CreatedBy = "Emre",
                CreatedDate = DateTime.Now,
                ModifiedBy = "Emre",
                ModifiedDate = DateTime.Now,
                Musteri = new Musteri()
                {
                    Adi = "ali",
                    Soyadi = "Ali",
                    CreatedBy = "Emre",
                    CreatedDate = DateTime.Now,
                    ModifiedBy = "Emre",
                    ModifiedDate = DateTime.Now
                }
            };

            musteriAdresRepository.Ekle(_eklenecek);
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = musteriAdresRepository.GetByAll();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
    }
}