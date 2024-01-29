using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ETicaret.MvcWebUI.Entity
{
    public class Product
    {
        public int Id { get; set; }

        [DisplayName("Ürün Adı")]
        public string Name { get; set; }
        [DisplayName("Ürün Açıklama")]
        public string Description { get; set; }
        [DisplayName("Fiyat")]
        [Range(0, double.MaxValue, ErrorMessage = "Fiyat alanı pozitif bir değer olmalıdır.")]
        public double Price { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = "Stok alanı pozitif bir değer olmalıdır.")]
        [DisplayName("Stock")]
        public int Stock { get; set; }
        [DisplayName("Resim")]
        public string Image { get; set; }
        [DisplayName("Onaylandı mı?")]
        public bool IsApproved { get; set; }
        [DisplayName("Ev?")]
        public bool IsHome { get; set; }
        [DisplayName("Ürün Ayrıntılı Açıklama")]
        public string DescriptionLong { get; set; }
        [DisplayName("Ödeme Çeşitleri")]
        public string Payment { get; set; }
        [DisplayName("Kargo Bilgileri")]
        public string ShippingInf { get; set; }


        public int CategoryId { get; set; }
        public Category Categoty { get; set; }
    }
}