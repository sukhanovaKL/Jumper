//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Jumper
{
    using System;
    using System.Collections.Generic;
    
    public partial class Application
    {
        public int Id { get; set; }
        public Nullable<int> AgentId { get; set; }
        public Nullable<int> EmployeeId { get; set; }
        public Nullable<bool> IsNew { get; set; }
        public Nullable<int> StatusId { get; set; }
        public Nullable<System.DateTime> DateCreate { get; set; }
        public Nullable<bool> IsPrepayment { get; set; }
        public Nullable<int> DeliveryId { get; set; }
    
        public virtual Deliverys Deliverys { get; set; }
        public virtual Employees Employees { get; set; }
        public virtual ApplicationStatuses ApplicationStatuses { get; set; }
    }
}