//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ComputerClub.Db
{
    using System;
    using System.Collections.Generic;
    
    public partial class Booking
    {
        public int ID_Booking { get; set; }
        public int ID_Employees { get; set; }
        public Nullable<int> ID_PlayPlaces { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public int ID_Client { get; set; }
        public int TariffID { get; set; }
        public Nullable<bool> booked { get; set; }
    
        public virtual Client Client { get; set; }
        public virtual Employees Employees { get; set; }
        public virtual Employees Employees1 { get; set; }
        public virtual PlayPlaces PlayPlaces { get; set; }
        public virtual Tariff Tariff { get; set; }
    }
}