using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constant
{
    public static class Messages
    {
        public static string AboutMeAdded = "Hakkımda eklendi";
        public static string AboutMeDeleted = "Hakkımda Silindi";
        public static string AboutMeUpdated = "Hakkımda Güncellendi";

        public static string MessageSent = "Mesaj Gönderildi";
        public static string MessageDeleted = "Mesaj Silindi";

        public static string EducationAdded = "Eğitim eklendi";
        public static string EducationDeleted = "Eğitim silindi";
        public static string EducationUpdated = "Eğitim güncellendi";

        public static string ExperienceAdded = "Deneyim eklendi";
        public static string ExperienceDeleted = "Deneyim silindi";
        public static string ExperienceUpdated = "Deneyim güncellendi";

        public static string ProjectAdded = "Proje eklendi";
        public static string ProjectDeleted = "Proje silindi";
        public static string ProjectUpdated = "Proje güncellendi";

        public static string SkillAdded = "Yetenek eklendi";
        public static string SkillDeleted = "Yetenek silindi";
        public static string SkillUpdated = "Yetenek güncellendi";

        public static string UserOperationClaimAdded = "Kullanıcı yetkisi eklendi";

        public static string UserAdded = "Kullanıcı eklendi";
        public static string UserDeleted = "Kullanıcı silindi";
        public static string UserUpdated = "Kullanıcı güncellendi";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string UserAlreadyExists = "Kullanıcı zaten mevcut";
        public static string PasswordError = "Parola hatalı";

        public static string AuthorizationDenied = "Geçersiz yetki";
    }
}
