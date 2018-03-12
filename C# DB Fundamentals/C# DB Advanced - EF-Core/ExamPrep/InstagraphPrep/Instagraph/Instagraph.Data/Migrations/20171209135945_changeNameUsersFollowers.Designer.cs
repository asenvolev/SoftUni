﻿// <auto-generated />
using Instagraph.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace Instagraph.Data.Migrations
{
    [DbContext(typeof(InstagraphContext))]
    [Migration("20171209135945_changeNameUsersFollowers")]
    partial class changeNameUsersFollowers
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Instagraph.Models.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.Property<int>("PostId");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("PostId");

                    b.HasIndex("UserId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("Instagraph.Models.Picture", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Path")
                        .IsRequired();

                    b.Property<decimal>("Size");

                    b.HasKey("Id");

                    b.ToTable("Pictures");
                });

            modelBuilder.Entity("Instagraph.Models.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Caption")
                        .IsRequired();

                    b.Property<int>("PictureId");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("PictureId");

                    b.HasIndex("UserId");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("Instagraph.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<int>("ProfilePictureId");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.HasKey("Id");

                    b.HasAlternateKey("Username");

                    b.HasIndex("ProfilePictureId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Instagraph.Models.UserFollower", b =>
                {
                    b.Property<int>("UserId");

                    b.Property<int>("FollowerId");

                    b.HasKey("UserId", "FollowerId");

                    b.HasIndex("FollowerId");

                    b.ToTable("UsersFollowers");
                });

            modelBuilder.Entity("Instagraph.Models.Comment", b =>
                {
                    b.HasOne("Instagraph.Models.Post", "Post")
                        .WithMany("Comments")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Instagraph.Models.User", "User")
                        .WithMany("Comments")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Instagraph.Models.Post", b =>
                {
                    b.HasOne("Instagraph.Models.Picture", "Picture")
                        .WithMany("Posts")
                        .HasForeignKey("PictureId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Instagraph.Models.User", "User")
                        .WithMany("Posts")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Instagraph.Models.User", b =>
                {
                    b.HasOne("Instagraph.Models.Picture", "ProfilePicture")
                        .WithMany("Users")
                        .HasForeignKey("ProfilePictureId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Instagraph.Models.UserFollower", b =>
                {
                    b.HasOne("Instagraph.Models.User", "Follower")
                        .WithMany("UsersFollowing")
                        .HasForeignKey("FollowerId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Instagraph.Models.User", "User")
                        .WithMany("Followers")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}
