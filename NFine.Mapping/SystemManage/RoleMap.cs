﻿
using HH.Domain.Entity.SystemManage;
using System.Data.Entity.ModelConfiguration;

namespace HH.Mapping.SystemManage
{
    public class RoleMap : EntityTypeConfiguration<RoleEntity>
    {
        public RoleMap()
        {
            this.ToTable("Sys_Role");
            this.HasKey(t => t.F_Id);
        }
    }
}
