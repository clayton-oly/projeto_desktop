//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Usuario
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Usuario()
        {
            this.Pedidos = new HashSet<Pedido>();
        }
    
        public int ID_Usuario { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public string Login { get; set; }
        public Nullable<bool> Nivel { get; set; }
        public string CPF { get; set; }
        public string Funcao { get; set; }
        public string Telefone { get; set; }
        public byte[] photo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pedido> Pedidos { get; set; }
    }
}
