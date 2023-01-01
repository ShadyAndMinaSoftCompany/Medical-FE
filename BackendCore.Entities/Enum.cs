using System;
using BackendCore.Entities.Enum;

namespace BackendCore.Entities.Enum
{
    #region Lookup Enum

    public enum Gender
    {
        [Values("Male", "ذكر", "")]
        Male = 1,
        [Values("Female", "أنثى", "")]
        Female,
        [Values("Both", "الكل", "")]
        Both
    }

    public enum LoginStatus
    {
        [Values("Success", "ناجحة", "")]
        Success = 1,
        [Values("Failed", "فاشلة", "")]
        Failed
    }
   

    public enum UserType
    {
        [Values("Admin", "مدير", "")]
        Admin = 1,
        [Values("User", "مستخدم", "")]
        User = 2
    }
    public enum Action
    {
        [Values("Approve", "موافقة", "APPROVE")]
        Approve = 1,
        [Values("Reject", "رفض", "REJECT")]
        Reject,
        [Values("Close", "إغلاق", "CLOSE")]
        Close

    }
    public enum Status
    {
        [Values("Active", "فعال", "ACTIVE")]
        Active = 1,
        [Values("InActive", "غير فعال", "IN-ACTIVE")]
        InActive,
        [Values("Suspended", "موقوف", "SUSPENDED")]
        Suspended
    }

    #endregion


    #region Common Enum

    public enum StorageType
    {
        LocalStorage = 1,
        PasswordLess
    }

    public enum AuditType
    {
        None = 0,
        Create = 1,
        Update = 2,
        Delete = 3
    }
    public enum TransactionStatus
    {
        Paid = 1,
        UnPaid = 2,
    }

    public enum DateDuration
    {
        Day = 1,
        Month = 2,
        Year=3
    }

    public enum SortType
    {
        Asc = 1,
        Desc = 2
    }

    public enum ReportType
    {
        Demand = 1,
        Earning = 2
    }
    #endregion


    internal class Values : Attribute
    {
        public string NameEn;
        public string NameAr;
        public string Code;
        public Values(string nameEn, string nameAr, string code)
        {
            NameAr = nameAr;
            NameEn = nameEn;
            Code = code;
        }
    }
}
public static class Extensions
{
    public static EnumResult GetName(this Enum e)
    {
        var type = e.GetType();

        var memInfo = type.GetMember(e.ToString());

        if (memInfo.Length > 0)
        {
            var attrs = memInfo[0].GetCustomAttributes(typeof(Values), false);
            if (attrs.Length > 0)
            {
                var attributes = (Values)attrs[0];
                return new EnumResult
                {
                    Id = Convert.ToInt32(e),
                    NameEn = attributes.NameEn,
                    NameAr = attributes.NameAr,
                    Code = attributes.Code
                };
            }
        }

        throw new ArgumentException("Name " + e + " has no Name defined!");
    }
}

public class EnumResult
{
    public int Id { get; set; }
    public string NameEn { get; set; }
    public string NameAr { get; set; }
    public string Code { get; set; }
}

