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
    
    public partial class NFCEmployee
    {
        public int Id { get; set; }
        public Nullable<int> EmployeeId { get; set; }
        public string NFC { get; set; }
    
        public virtual Employees Employees { get; set; }
    }
}