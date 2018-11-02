using DiExmple.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace DiExmple.Persistance
{
	internal class MsSqlTodoConfiguration : IEntityTypeConfiguration<Todo>
	{
		public void Configure(EntityTypeBuilder<Todo> builder)
		{
			builder.HasKey(_ => new
			{
				_.Id,
				_.Value
			});

			builder.Property(_ => _.Id)
				   .HasColumnName("Id");

			builder.Property(_ => _.Value)
				   .HasColumnName("Value");

			builder.Property(_ => _.Created)
				   .HasColumnName("Created")
				   .HasConversion(v => v, v => DateTime.SpecifyKind(v, DateTimeKind.Local));

			builder.Property(_ => _.Updated)
				   .HasColumnName("Updated")
				   .HasConversion(v => v, v => DateTime.SpecifyKind(v, DateTimeKind.Local));

			builder.Property(_ => _.IsDone)
				   .HasColumnName("IsDone");
		}
	}
}
