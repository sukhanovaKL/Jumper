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
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Windows.Media.Imaging;

    public partial class Agents
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Agents()
        {
            this.HistiryChangesAgentCost = new HashSet<HistiryChangesAgentCost>();
            this.Products = new HashSet<Products>();
        }
    
        public int Id { get; set; }
        public Nullable<int> AgentTypeId { get; set; }
        public string AgentName { get; set; }
        public string AgentEmail { get; set; }
        public string AgentPhone { get; set; }
        public string AgentLogotip { get; set; }
        public string AgentAddress { get; set; }
        public string Priority { get; set; }
        public string DirectorFio { get; set; }
        public string INN { get; set; }
        public string KPP { get; set; }
        public Nullable<System.DateTime> DateRealization { get; set; }
        public Nullable<int> ProductCount { get; set; }

        [NotMapped]
        public string SaleCount => ProductCount + " продаж за год";

        [NotMapped]
        public string PriorityText => "Приоритетность " + Priority;

        [NotMapped]
        public string TypeAndNameAgent =>  "1 | " + AgentName;

        [NotMapped]
        public BitmapImage AgentPhotoFromResources => !string.IsNullOrEmpty(AgentLogotip) ? new BitmapImage(new Uri("C:/Users/79393/source/repos/Jumper/Photos/" + AgentLogotip)) : new BitmapImage(new Uri("C:/Users/79393/source/repos/Jumper/Photos/picture.png"));

        public virtual AgentTypes AgentTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HistiryChangesAgentCost> HistiryChangesAgentCost { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Products> Products { get; set; }
    }
}
