﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FolderExplorer.Models;

public partial class Folder
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("path")]
    [StringLength(511)]
    [Unicode(false)]
    public string Path { get; set; }
}