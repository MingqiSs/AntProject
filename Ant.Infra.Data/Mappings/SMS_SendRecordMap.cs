using Ant.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ant.Infra.Data.Mappings
{
    public class SMS_SendRecordMap : IEntityTypeConfiguration<SMS_SendRecord>
    {
        public void Configure(EntityTypeBuilder<SMS_SendRecord> builder)
        {
            builder.Property(c => c.Id)
              .HasColumnName("Id");

            builder.Property(c => c.IP)
                .HasColumnType("varchar(30)")
                .HasMaxLength(30)
                .IsRequired();

            builder.Property(c => c.Receiver)
                .HasColumnType("varchar(30)")
                .HasMaxLength(30)
                .IsRequired();

            builder.Property(c => c.SMSType)
                .HasColumnType("tinyint(4)")
                .HasMaxLength(4)
                .IsRequired();

            builder.Property(c => c.Status)
                 .HasColumnType("tinyint(4)")
                 .HasMaxLength(4)
                 .IsRequired();

            builder.Property(c => c.Body)
                .HasColumnType("mediumtext")
                .HasMaxLength(4)
                .IsRequired();
        }
    }
}
