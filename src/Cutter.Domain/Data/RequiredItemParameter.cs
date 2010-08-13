using System;

namespace Cutter.Domain.Data
{
    public struct RequiredItemParameter
    {
        public Guid ShapeId { get; set; }
        public int Quantity { get; set; }
        public int Length { get; set; }
    }
}