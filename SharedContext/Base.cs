using System;

namespace RandomBooks.SharedContext
{
    public class Base
    {
        public Base()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
    }
}