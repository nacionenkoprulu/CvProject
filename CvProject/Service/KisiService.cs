using CvProject.Contexts;
using CvProject.DTO;
using CvProject.Entities;
using CvProject.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvProject.Service
{
    public class KisiService
    {

        CvliteDbContext _db = new CvliteDbContext();

        public IQueryable<KisiDTO> Sorgula()
        {

            IQueryable<KisiDTO> query = _db.Kisiler.Include(k => k.Sehir).Include(k => k.Ulke).Include(kisi => kisi.KisiIsler).ThenInclude(kisiIs => kisiIs.Is).Select(kisi => new KisiDTO()
            {
                Id = kisi.Id,
                AdSoyadGosterim = kisi.Adi + " " + kisi.Soyadi,
                KimlikNo = kisi.KimlikNo,
                DogumTarihiGosterim = kisi.DogumTarihi.ToString("dd.MM.yyyy", new CultureInfo("tr-TR")),

                UlkeSehirGosterim = kisi.Ulke != null && kisi.Sehir != null ? (kisi.Ulke.Adi + "/" + kisi.Sehir.Adi) : kisi.Ulke != null ? kisi.Ulke.Adi : kisi.Sehir != null ? kisi.Sehir.Adi : "Bilinmiyor",

                CinsiyetGosterim = kisi.Cinsiyeti == 1 ? Cinsiyet.Erkek : Cinsiyet.Kadın,

                UlkeId = kisi.UlkeId,
                Biyografi = kisi.Biyografi,
                Cinsiyeti = kisi.Cinsiyeti,
                DogumTarihi = kisi.DogumTarihi,
                SehirId = kisi.SehirId,
                Adi = kisi.Adi,
                Soyadi = kisi.Soyadi,

                KisiIsler = kisi.KisiIsler.Select(kis => new KisiIsDTO()
                {
                    KisiId = kis.KisiId,
                    IsId = kis.IsId,
                    BaslangicTarihi = kis.BaslangicTarihi,
                    BitisTarihi = kis.BitisTarihi,
                    Is = kis.Is,
                    Kisi = kis.Kisi
                }).ToList(),

                

                

                //MaasListesi = personel.Maas.Select(maas => new MaasModel()
                //{
                //    Yil = maas.Yil,
                //    Ucret = maas.Ucret,

                //    UcretiGosterim = maas.Ucret.ToString("C2", new CultureInfo("tr-TR"))
                //}).ToList()




            });

            query = query.OrderBy(k => k.AdSoyadGosterim);

            return query;

        }

        public void Guncelle(KisiDTO kisi)
        {

            Kisi mevcutKisi = _db.Kisiler.Find(kisi.Id);

            mevcutKisi.Adi = kisi.Adi;
            mevcutKisi.Soyadi = kisi.Soyadi;
            mevcutKisi.Cinsiyeti = kisi.Cinsiyeti;
            mevcutKisi.DogumTarihi = kisi.DogumTarihi;
            mevcutKisi.Biyografi = kisi.Biyografi;
            mevcutKisi.SehirId = kisi.SehirId;
            mevcutKisi.UlkeId = kisi.UlkeId;


            _db.Kisiler.Update(mevcutKisi);
            _db.SaveChanges();
        }

        public void Ekle(KisiDTO kisi)
        {

            Kisi kisiEntity = new Kisi()
            {
                Adi = kisi.Adi,
                Soyadi = kisi.Soyadi,
                KimlikNo = kisi.KimlikNo,
                Cinsiyeti = kisi.Cinsiyeti,
                DogumTarihi = kisi.DogumTarihi,
                UlkeId = kisi.UlkeId,
                SehirId = kisi.SehirId,
                Biyografi = kisi.Biyografi
            };

            _db.Kisiler.Add(kisiEntity);
            _db.SaveChanges();
            
        }



        public void Sil(int id)
        {

            Kisi kisiEntity = _db.Kisiler.Include(k => k.KisiIsler).SingleOrDefault(k => k.Id == id);

            if(kisiEntity.KisiIsler != null && kisiEntity.KisiIsler.Count() > 0)
                _db.KisiIsler.RemoveRange(kisiEntity.KisiIsler);
    
            _db.Kisiler.Remove(kisiEntity);
            _db.SaveChanges();


        }

    }
}
