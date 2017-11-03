using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace dotnet_core.Model
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public List<tableJoin> ComponentTypes { get; set; }
    }

    public class ComponentType
    {
        public long ComponentTypeId { get; set; }
        public string ComponentName { get; set; }
        public string ComponentInfo { get; set; }
        public string Location { get; set; }
        public ComponentTypeStatus Status { get; set; }
        public string Datasheet { get; set; }
        public string ImageUrl { get; set; }
        public string Manufacturer { get; set; }
        public string WikiLink { get; set; }
        public string AdminComment { get; set; }
        public virtual ESImage Image { get; set; }
        public List<Component> Components { get; set; }
        public List<tableJoin> Categories { get; set; }
    }

    public class tableJoin
    {
        public long ComponentTypeId { get; set; }
        public ComponentType ComponentType { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }

    public class Component
    {
        public long ComponentId { get; set; }
        public long ComponentTypeId { get; set; }
        public int ComponentNumber { get; set; }
        public string SerialNo { get; set; }
        public ComponentStatus Status { get; set; }
        public string AdminComment { get; set; }
        public string UserComment { get; set; }
        public long? CurrentLoanInformationId { get; set; }
    }

    public class ESImage
    {
        public long ESImageId { get; set; }

        [MaxLength(128)]
        public string ImageMimeType { get; set; }

        public byte[] Thumbnail { get; set; }
        public byte[] ImageData { get; set; }
    }

    public enum ComponentTypeStatus
    {
        Available,
        ReservedAdmin
    }

    public enum ComponentStatus
    {
        Available,
        ReservedLoaner,
        ReservedAdmin,
        Loaned,
        Defect,
        Trashed,
        Lost,
        NeverReturned
    }

}


