﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OSharp.Entity;

#nullable disable

namespace OSharp.CodeGenerator.Migrations
{
    [DbContext(typeof(DefaultDbContext))]
    partial class DefaultDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.1");

            modelBuilder.Entity("OSharp.Authorization.EntityInfos.EntityInfo", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<bool>("AuditEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<string>("PropertyJson")
                        .IsRequired()
                        .HasMaxLength(5000)
                        .HasColumnType("TEXT");

                    b.Property<string>("TypeName")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("TypeName")
                        .IsUnique()
                        .HasDatabaseName("ClassFullNameIndex");

                    b.ToTable("Auth_EntityInfo", (string)null);
                });

            modelBuilder.Entity("OSharp.Authorization.Functions.Function", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<int>("AccessType")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Action")
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<string>("Area")
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<bool>("AuditEntityEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("AuditOperationEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CacheExpirationSeconds")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Controller")
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsAccessTypeChanged")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsAjax")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsCacheSliding")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsController")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsLocked")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsSlaveDatabase")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("Area", "Controller", "Action")
                        .IsUnique()
                        .HasDatabaseName("AreaControllerActionIndex");

                    b.ToTable("Auth_Function", (string)null);
                });

            modelBuilder.Entity("OSharp.CodeGeneration.Services.Entities.CodeEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Addable")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Deletable")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Display")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<bool>("HasCreatedTime")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("HasCreationAudited")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("HasLocked")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("HasSoftDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("HasUpdateAudited")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Icon")
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsDataAuth")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsLocked")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Listable")
                        .HasColumnType("INTEGER");

                    b.Property<Guid>("ModuleId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<int>("Order")
                        .HasColumnType("INTEGER");

                    b.Property<string>("PrimaryKeyTypeFullName")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("TEXT");

                    b.Property<bool>("Updatable")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ModuleId");

                    b.ToTable("CodeGen_CodeEntity", (string)null);
                });

            modelBuilder.Entity("OSharp.CodeGeneration.Services.Entities.CodeForeign", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<int?>("DeleteBehavior")
                        .HasColumnType("INTEGER");

                    b.Property<Guid>("EntityId")
                        .HasColumnType("TEXT");

                    b.Property<int>("ForeignRelation")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsRequired")
                        .HasColumnType("INTEGER");

                    b.Property<string>("OtherEntity")
                        .HasColumnType("TEXT");

                    b.Property<string>("OtherNavigation")
                        .HasColumnType("TEXT");

                    b.Property<string>("SelfForeignKey")
                        .HasColumnType("TEXT");

                    b.Property<string>("SelfNavigation")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("EntityId");

                    b.ToTable("CodeGen_CodeForeign", (string)null);
                });

            modelBuilder.Entity("OSharp.CodeGeneration.Services.Entities.CodeModule", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("Display")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<string>("Icon")
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsLocked")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<int>("Order")
                        .HasColumnType("INTEGER");

                    b.Property<Guid>("ProjectId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ProjectId");

                    b.ToTable("CodeGen_CodeModule", (string)null);
                });

            modelBuilder.Entity("OSharp.CodeGeneration.Services.Entities.CodeProject", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Company")
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<string>("Copyright")
                        .HasMaxLength(500)
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("Creator")
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<string>("NamespacePrefix")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<string>("RootPath")
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<string>("SiteUrl")
                        .HasMaxLength(500)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("CodeGen_CodeProject", (string)null);
                });

            modelBuilder.Entity("OSharp.CodeGeneration.Services.Entities.CodeProjectTemplate", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsLocked")
                        .HasColumnType("INTEGER");

                    b.Property<Guid>("ProjectId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("TemplateId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ProjectId");

                    b.HasIndex("TemplateId");

                    b.ToTable("CodeGen_CodeProjectTemplate", (string)null);
                });

            modelBuilder.Entity("OSharp.CodeGeneration.Services.Entities.CodeProperty", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("DataAuthFlag")
                        .HasColumnType("TEXT");

                    b.Property<string>("DefaultValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("Display")
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<Guid>("EntityId")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Filterable")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsEnum")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsForeignKey")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsInputDto")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsLocked")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsNavigation")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsNullable")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsOutputDto")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsReadonly")
                        .HasColumnType("INTEGER");

                    b.Property<bool?>("IsRequired")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsVirtual")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Listable")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("MaxLength")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("MinLength")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<int>("Order")
                        .HasColumnType("INTEGER");

                    b.Property<string>("RelateEntity")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Sortable")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TypeName")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("TEXT");

                    b.Property<bool>("Updatable")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("EntityId");

                    b.ToTable("CodeGen_CodeProperty", (string)null);
                });

            modelBuilder.Entity("OSharp.CodeGeneration.Services.Entities.CodeTemplate", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsLocked")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsOnce")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsSystem")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MetadataType")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<int>("Order")
                        .HasColumnType("INTEGER");

                    b.Property<string>("OutputFileFormat")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("TEXT");

                    b.Property<string>("TemplateFile")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("CodeGen_CodeTemplate", (string)null);
                });

            modelBuilder.Entity("OSharp.Core.Systems.KeyValue", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Display")
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsLocked")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Key")
                        .IsRequired()
                        .HasMaxLength(512)
                        .HasColumnType("TEXT");

                    b.Property<int>("Order")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Remark")
                        .HasMaxLength(1000)
                        .HasColumnType("TEXT");

                    b.Property<string>("ValueJson")
                        .HasColumnType("text");

                    b.Property<string>("ValueType")
                        .HasMaxLength(1000)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("Key")
                        .IsUnique()
                        .HasDatabaseName("KeyIndex");

                    b.ToTable("Systems_KeyValue", (string)null);
                });

            modelBuilder.Entity("OSharp.CodeGeneration.Services.Entities.CodeEntity", b =>
                {
                    b.HasOne("OSharp.CodeGeneration.Services.Entities.CodeModule", "Module")
                        .WithMany("Entities")
                        .HasForeignKey("ModuleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Module");
                });

            modelBuilder.Entity("OSharp.CodeGeneration.Services.Entities.CodeForeign", b =>
                {
                    b.HasOne("OSharp.CodeGeneration.Services.Entities.CodeEntity", "Entity")
                        .WithMany("Foreigns")
                        .HasForeignKey("EntityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Entity");
                });

            modelBuilder.Entity("OSharp.CodeGeneration.Services.Entities.CodeModule", b =>
                {
                    b.HasOne("OSharp.CodeGeneration.Services.Entities.CodeProject", "Project")
                        .WithMany("Modules")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Project");
                });

            modelBuilder.Entity("OSharp.CodeGeneration.Services.Entities.CodeProjectTemplate", b =>
                {
                    b.HasOne("OSharp.CodeGeneration.Services.Entities.CodeProject", "Project")
                        .WithMany("ProjectTemplates")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OSharp.CodeGeneration.Services.Entities.CodeTemplate", "Template")
                        .WithMany("ProjectTemplates")
                        .HasForeignKey("TemplateId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Project");

                    b.Navigation("Template");
                });

            modelBuilder.Entity("OSharp.CodeGeneration.Services.Entities.CodeProperty", b =>
                {
                    b.HasOne("OSharp.CodeGeneration.Services.Entities.CodeEntity", "Entity")
                        .WithMany("Properties")
                        .HasForeignKey("EntityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Entity");
                });

            modelBuilder.Entity("OSharp.CodeGeneration.Services.Entities.CodeEntity", b =>
                {
                    b.Navigation("Foreigns");

                    b.Navigation("Properties");
                });

            modelBuilder.Entity("OSharp.CodeGeneration.Services.Entities.CodeModule", b =>
                {
                    b.Navigation("Entities");
                });

            modelBuilder.Entity("OSharp.CodeGeneration.Services.Entities.CodeProject", b =>
                {
                    b.Navigation("Modules");

                    b.Navigation("ProjectTemplates");
                });

            modelBuilder.Entity("OSharp.CodeGeneration.Services.Entities.CodeTemplate", b =>
                {
                    b.Navigation("ProjectTemplates");
                });
#pragma warning restore 612, 618
        }
    }
}
