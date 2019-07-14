﻿// <auto-generated />
using System;
using HouseParty.Client.DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HouseParty.Client.Migrations
{
    [DbContext(typeof(HousePartyDataContext))]
    [Migration("20190713164537_AddedQuestionUpdatedColumnInQuestion")]
    partial class AddedQuestionUpdatedColumnInQuestion
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("HouseParty")
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HouseParty.Client.Contracts.Questions.Question", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AdityaSolution");

                    b.Property<string>("Notes");

                    b.Property<int>("QuestionType");

                    b.Property<DateTime>("QuestionUploaded");

                    b.Property<string>("QuestionUrl");

                    b.Property<string>("ShubhiSolution");

                    b.Property<DateTime>("SolutionSubmittedOn");

                    b.Property<DateTime>("SolutionUpdatedOn");

                    b.Property<string>("Title");

                    b.Property<DateTime>("WhenSeen");

                    b.Property<bool>("WhetherAdityaSubmitted");

                    b.Property<bool>("WhetherSeen");

                    b.Property<bool>("WhetherShubhiSubmitted");

                    b.Property<bool>("WontDo");

                    b.Property<string>("WontDoReason");

                    b.HasKey("Id");

                    b.ToTable("Questions");
                });
#pragma warning restore 612, 618
        }
    }
}