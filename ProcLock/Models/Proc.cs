using System;

namespace ProcLock.Models
{
    public class Proc
    {
        public string Name { get; set; }
        public string Title { get; set; }

        public int ID { get; set; }

        public override string ToString()
        {
            return $"{Name} ({Title})";
        }
    }
}
