//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Diplom
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        public int IdUser { get; set; }
        public string Name { get; set; }
        public Nullable<int> Type { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Passport { get; set; }
        public string Residence { get; set; }
        public string Birthday { get; set; }
    
        public virtual TypeUser TypeUser { get; set; }
    }
}