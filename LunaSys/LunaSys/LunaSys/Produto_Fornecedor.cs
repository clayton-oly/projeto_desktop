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
    
    public partial class Produto_Fornecedor
    {
        public int Idproduto_fornecedor { get; set; }
        public Nullable<int> ID_Fornecedor { get; set; }
        public Nullable<int> ID_Produtos { get; set; }
    
        public virtual Fornecedore Fornecedore { get; set; }
        public virtual Produto Produto { get; set; }
    }
}