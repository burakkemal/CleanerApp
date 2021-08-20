using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string HospitalAdded = "Hastane eklendi";
        public static string HospitalUpdated = "Hastane güncellendi";
        public static string CleanerAdded = "Personel eklendi";
        public static string CleanerUpdated = "Personel güncellendi";
        public static string LocationAdded = "Lokasyon eklendi";
        public static string LocationUpdated = "Lokasyon güncellendi";
        public static string AuthorizationDenied = "Yetkiniz yok";
        public static string UserRegistered="Kayıt olundu.";
        public static string UserNotFound="Kullanıcı bulunamadı ";
        public static string PasswordError="Şifre Hatalı";
        public static string SuccessfulLogin="Başarılı Giriş";
        public static string UserAlreadyExists="Kullanıcı zaten mevcut";
        public static string AccessTokenCreated="Token oluşturuldu";
    }
}
