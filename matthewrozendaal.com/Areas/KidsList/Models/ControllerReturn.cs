using System;

namespace matthewrozendaal.com.Areas.KidsList.Models
{
    public sealed class ControllerReturn<T>
    {
        public T ObjectType { get; set; }
        public Boolean ReturnValid { get; set; }
        public String InvalidReturnString { get; set; }
        
    }
}