﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FolderExplorer.Models;

public partial class FolderRelations
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("father_id")]
    public int FatherId { get; set; }

    [Column("child_id")]
    public int ChildId { get; set; }

    [ForeignKey("ChildId")]
    [InverseProperty("FolderRelationsChild")]
    public virtual Folder Child { get; set; }

    [ForeignKey("FatherId")]
    [InverseProperty("FolderRelationsFather")]
    public virtual Folder Father { get; set; }
}