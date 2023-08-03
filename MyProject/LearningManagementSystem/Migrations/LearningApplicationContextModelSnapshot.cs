﻿// <auto-generated />
using System;
using LearningManagementSystem.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LearningManagementSystem.Migrations
{
    [DbContext(typeof(LearningApplicationContext))]
    partial class LearningApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.8");

            modelBuilder.Entity("LearningManagementSystem.Entities.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CourseCode")
                        .HasColumnType("varchar(767)");

                    b.Property<string>("CourseName")
                        .HasColumnType("text");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CourseCode")
                        .IsUnique();

                    b.HasIndex("DepartmentId");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("LearningManagementSystem.Entities.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("DepartmentName")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("LearningManagementSystem.Entities.Instructor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasColumnType("text");

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("varchar(767)");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<string>("Gender")
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.Property<string>("PassWord")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("varchar(767)");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("PhoneNumber")
                        .IsUnique();

                    b.ToTable("Instructors");
                });

            modelBuilder.Entity("LearningManagementSystem.Entities.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasColumnType("text");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("varchar(767)");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<string>("Gender")
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.Property<string>("PassWord")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("varchar(767)");

                    b.Property<string>("StudentPhoto")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("PhoneNumber")
                        .IsUnique();

                    b.ToTable("Students");
                });

            modelBuilder.Entity("LearningManagementSystem.Entities.StudentCourse", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("StudentId");

                    b.ToTable("StudentCourse");
                });

            modelBuilder.Entity("LearningManagementSystem.Entities.Course", b =>
                {
                    b.HasOne("LearningManagementSystem.Entities.Department", "Department")
                        .WithMany("Courses")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("LearningManagementSystem.Entities.Instructor", b =>
                {
                    b.HasOne("LearningManagementSystem.Entities.Course", "Course")
                        .WithMany()
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LearningManagementSystem.Entities.Department", "Department")
                        .WithMany("Instructors")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Department");
                });

            modelBuilder.Entity("LearningManagementSystem.Entities.Student", b =>
                {
                    b.HasOne("LearningManagementSystem.Entities.Department", "Department")
                        .WithMany("Students")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("LearningManagementSystem.Entities.StudentCourse", b =>
                {
                    b.HasOne("LearningManagementSystem.Entities.Course", "Course")
                        .WithMany("StudentCourses")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LearningManagementSystem.Entities.Student", "Student")
                        .WithMany("StudentCourses")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("LearningManagementSystem.Entities.Course", b =>
                {
                    b.Navigation("StudentCourses");
                });

            modelBuilder.Entity("LearningManagementSystem.Entities.Department", b =>
                {
                    b.Navigation("Courses");

                    b.Navigation("Instructors");

                    b.Navigation("Students");
                });

            modelBuilder.Entity("LearningManagementSystem.Entities.Student", b =>
                {
                    b.Navigation("StudentCourses");
                });
#pragma warning restore 612, 618
        }
    }
}
