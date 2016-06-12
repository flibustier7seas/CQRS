using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using EF;

namespace EF.Migrations
{
    [DbContext(typeof(EfContext))]
    [Migration("20160421161025_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Domain.Entities.Attribute", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<long>("ProductTypeId");

                    b.Property<string>("Type")
                        .IsRequired();

                    b.HasKey("Id");
                });

            modelBuilder.Entity("Domain.Entities.ProductType", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");
                });

            modelBuilder.Entity("Domain.Entities.Attribute", b =>
                {
                    b.HasOne("Domain.Entities.ProductType")
                        .WithMany()
                        .HasForeignKey("ProductTypeId");
                });
        }
    }
}
