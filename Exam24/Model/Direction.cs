//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Exam24.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Direction
    {
        public Direction()
        {
            this.Event = new HashSet<Event>();
        }
    
        public int DirectionID { get; set; }
        public string Name { get; set; }
    
        public virtual ICollection<Event> Event { get; set; }
    }
}
