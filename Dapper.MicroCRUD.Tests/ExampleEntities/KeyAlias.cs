﻿// <copyright file="KeyAlias.cs" company="Berkeleybross">
// Copyright (c) Berkeleybross. All rights reserved.
// </copyright>

namespace Dapper.MicroCRUD.Tests.ExampleEntities
{
    using System.ComponentModel.DataAnnotations.Schema;

    [Table(nameof(KeyAlias))]
    public class KeyAlias
    {
        [Column("Key")]
        public int Id { get; set; }

        public string Name { get; set; }
    }
}