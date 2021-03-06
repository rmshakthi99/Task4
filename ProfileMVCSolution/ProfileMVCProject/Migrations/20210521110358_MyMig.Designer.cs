// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProfileMVCProject.Models;

namespace ProfileMVCProject.Migrations
{
    [DbContext(typeof(ProfileContext))]
    [Migration("20210521110358_MyMig")]
    partial class MyMig
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ProfileMVCProject.Models.Profile", b =>
                {
                    b.Property<int>("PersonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("CurrentCTC")
                        .HasColumnType("real");

                    b.Property<string>("IsEmployed")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NoticePeriod")
                        .HasColumnType("int");

                    b.Property<int>("age")
                        .HasColumnType("int");

                    b.Property<string>("qualification")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PersonId");

                    b.ToTable("Profile");

                    b.HasData(
                        new
                        {
                            PersonId = 1,
                            CurrentCTC = 3f,
                            IsEmployed = "yes",
                            Name = "abi",
                            NoticePeriod = 3,
                            age = 21,
                            qualification = "B.E"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
