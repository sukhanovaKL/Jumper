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
    
    public partial class Postavshiks
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Postavshiks()
        {
            this.Materials = new HashSet<Materials>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string INN { get; set; }
        public Nullable<int> AgentTypeId { get; set; }
    
        public virtual AgentTypes AgentTypes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Materials> Materials { get; set; }
    }
}
