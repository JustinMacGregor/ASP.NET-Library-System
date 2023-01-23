using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ABCBooksService_991471961
{
    [MetadataType(typeof(ColumnProperty))]
    public partial class BookInfo
    {

    }

    public class ColumnProperty
    {
        [Key]
        public int Id { get; set; }
    }
}