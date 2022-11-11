using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SuperMarket.Data.Employees.Common
{
  public class CommonProps
  {

    [Key]
    [Column("id", TypeName = EntityDataType.EntityDataType.IntType)]
    public int Id { get; set; }


    [Column("created_at", TypeName = EntityDataType.EntityDataType.DateTimeType)]
    public DateTime Created_at { get; set; }


    [Column("created_by", TypeName = EntityDataType.EntityDataType.IntType)]
    public int Created_by { get; set; }


    [Column("updated_at", TypeName = EntityDataType.EntityDataType.DateTimeType)]
    public DateTime Updated_at { get; set; }


    [Column("updated_by", TypeName = EntityDataType.EntityDataType.IntType)]
    public int Updated_by { get; set; }

  }
}