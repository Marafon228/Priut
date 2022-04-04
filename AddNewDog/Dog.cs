namespace AddNewDog
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Dog")]
    public partial class Dog
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Description { get; set; }

        [Required]
        [StringLength(50)]
        public string Phone { get; set; }

        [Column(TypeName = "image")]
        [Required]
        public byte[] Image { get; set; }
    }
}
