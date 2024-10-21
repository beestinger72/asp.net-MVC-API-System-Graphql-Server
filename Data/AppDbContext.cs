using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Data;

public partial class AppDbContext : DbContext
{

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }
    public async System.Threading.Tasks.Task MyMethodAsync()
    {
        // Example of using System.Threading.Tasks.Task
        await System.Threading.Tasks.Task.Delay(1000);
    }
    public virtual DbSet<Audit> Audits { get; set; }

    public virtual DbSet<Company> Companies { get; set; }

    public virtual DbSet<CompanyContactsAggregateGroupBy> CompanyContactsAggregateGroupBies { get; set; }

    public virtual DbSet<CompanyContactsCountAggregate> CompanyContactsCountAggregates { get; set; }

    public virtual DbSet<CompanyContactsMaxAggregate> CompanyContactsMaxAggregates { get; set; }

    public virtual DbSet<CompanyContactsMinAggregate> CompanyContactsMinAggregates { get; set; }

    public virtual DbSet<CompanyContactsSumAggregate> CompanyContactsSumAggregates { get; set; }

    public virtual DbSet<CompanyDealsAggregateGroupBy> CompanyDealsAggregateGroupBies { get; set; }

    public virtual DbSet<CompanyDealsAggregateResponse> CompanyDealsAggregateResponses { get; set; }

    public virtual DbSet<CompanyDealsAvgAggregate> CompanyDealsAvgAggregates { get; set; }

    public virtual DbSet<CompanyDealsCountAggregate> CompanyDealsCountAggregates { get; set; }

    public virtual DbSet<CompanyDealsMaxAggregate> CompanyDealsMaxAggregates { get; set; }

    public virtual DbSet<CompanyDealsMinAggregate> CompanyDealsMinAggregates { get; set; }

    public virtual DbSet<CompanyDealsSumAggregate> CompanyDealsSumAggregates { get; set; }

    public virtual DbSet<CompanyDeleteResponse> CompanyDeleteResponses { get; set; }

    public virtual DbSet<CompanyMaxAggregate> CompanyMaxAggregates { get; set; }

    public virtual DbSet<CompanyMinAggregate> CompanyMinAggregates { get; set; }

    public virtual DbSet<CompanyNote> CompanyNotes { get; set; }

    public virtual DbSet<CompanyNoteConnection> CompanyNoteConnections { get; set; }

    public virtual DbSet<CompanyNoteDeleteResponse> CompanyNoteDeleteResponses { get; set; }

    public virtual DbSet<CompanyNotesAggregateGroupBy> CompanyNotesAggregateGroupBies { get; set; }

    public virtual DbSet<CompanyNotesAggregateResponse> CompanyNotesAggregateResponses { get; set; }

    public virtual DbSet<CompanyNotesAvgAggregate> CompanyNotesAvgAggregates { get; set; }

    public virtual DbSet<CompanyNotesCountAggregate> CompanyNotesCountAggregates { get; set; }

    public virtual DbSet<CompanyNotesMaxAggregate> CompanyNotesMaxAggregates { get; set; }

    public virtual DbSet<CompanyNotesMinAggregate> CompanyNotesMinAggregates { get; set; }

    public virtual DbSet<CompanyNotesSumAggregate> CompanyNotesSumAggregates { get; set; }

    public virtual DbSet<CompanySumAggregate> CompanySumAggregates { get; set; }

    public virtual DbSet<Contact> Contacts { get; set; }

    public virtual DbSet<ContactDeleteResponse> ContactDeleteResponses { get; set; }

    public virtual DbSet<ContactNote> ContactNotes { get; set; }

    public virtual DbSet<Deal> Deals { get; set; }

    public virtual DbSet<DealAggregateGroupBy> DealAggregateGroupBies { get; set; }

    public virtual DbSet<DealDeleteResponse> DealDeleteResponses { get; set; }

    public virtual DbSet<DealMaxAggregate> DealMaxAggregates { get; set; }

    public virtual DbSet<DealMinAggregate> DealMinAggregates { get; set; }

    public virtual DbSet<DealStage> DealStages { get; set; }

    public virtual DbSet<DealStageDealsAggregateGroupBy> DealStageDealsAggregateGroupBies { get; set; }

    public virtual DbSet<DealStageDealsAvgAggregate> DealStageDealsAvgAggregates { get; set; }

    public virtual DbSet<DealStageDealsCountAggregate> DealStageDealsCountAggregates { get; set; }

    public virtual DbSet<DealStageDealsMaxAggregate> DealStageDealsMaxAggregates { get; set; }

    public virtual DbSet<DealStageDealsMinAggregate> DealStageDealsMinAggregates { get; set; }

    public virtual DbSet<DealStageDealsSumAggregate> DealStageDealsSumAggregates { get; set; }

    public virtual DbSet<DealStageDeleteResponse> DealStageDeleteResponses { get; set; }

    public virtual DbSet<DealSumAggregate> DealSumAggregates { get; set; }

    public virtual DbSet<DeletedTaskComment> DeletedTaskComments { get; set; }

    public virtual DbSet<Event> Events { get; set; }

    public virtual DbSet<EventCategory> EventCategories { get; set; }

    public virtual DbSet<EventCategoryDeleteResponse> EventCategoryDeleteResponses { get; set; }

    public virtual DbSet<EventDeleteResponse> EventDeleteResponses { get; set; }

    public virtual DbSet<PrismaMigration> PrismaMigrations { get; set; }

    public virtual DbSet<Quote> Quotes { get; set; }

    public virtual DbSet<QuoteDeleteResponse> QuoteDeleteResponses { get; set; }

    public virtual DbSet<QuoteItem> QuoteItems { get; set; }

    public virtual DbSet<WebApplication1.Models.Task> Tasks { get; set; }

    public virtual DbSet<TaskAvgAggregate> TaskAvgAggregates { get; set; }

    public virtual DbSet<TaskComment> TaskComments { get; set; }

    public virtual DbSet<TaskCommentsCountAggregate> TaskCommentsCountAggregates { get; set; }

    public virtual DbSet<TaskCommentsMaxAggregate> TaskCommentsMaxAggregates { get; set; }

    public virtual DbSet<TaskCommentsMinAggregate> TaskCommentsMinAggregates { get; set; }

    public virtual DbSet<TaskStage> TaskStages { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=localhost,1433;Database=PROJECTS;User Id=sa;Password=123;Encrypt=true;TrustServerCertificate=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Audit>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Audit__3213E83F688D6CD3");

            entity.ToTable("Audit");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("action");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("createdAt");
            entity.Property(e => e.TargetEntity)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("targetEntity");
            entity.Property(e => e.TargetId).HasColumnName("targetId");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updatedAt");
            entity.Property(e => e.UserId)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("userId");

            entity.HasOne(d => d.User).WithMany(p => p.Audits)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__Audit__userId__0E6E26BF");
        });

        modelBuilder.Entity<Company>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Company__3213E83FFB5EFEFE");

            entity.ToTable("Company");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.AvatarUrl)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("avatarUrl");
            entity.Property(e => e.BusinessType)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("businessType");
            entity.Property(e => e.CompanySize)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("companySize");
            entity.Property(e => e.Country)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("country");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("createdAt");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("createdBy");
            entity.Property(e => e.Industry)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("industry");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.SalesOwner)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("salesOwner");
            entity.Property(e => e.TotalRevenue).HasColumnName("totalRevenue");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updatedAt");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("updatedBy");
            entity.Property(e => e.Website)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("website");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.CompanyCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .HasConstraintName("FK__Company__created__09A971A2");

            entity.HasOne(d => d.SalesOwnerNavigation).WithMany(p => p.CompanySalesOwnerNavigations)
                .HasForeignKey(d => d.SalesOwner)
                .HasConstraintName("FK__Company__salesOw__0B91BA14");

            entity.HasOne(d => d.UpdatedByNavigation).WithMany(p => p.CompanyUpdatedByNavigations)
                .HasForeignKey(d => d.UpdatedBy)
                .HasConstraintName("FK__Company__updated__0A9D95DB");
        });

        modelBuilder.Entity<CompanyContactsAggregateGroupBy>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CompanyC__3213E83F53DDC4AD");

            entity.ToTable("CompanyContactsAggregateGroupBy");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("createdAt");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.JobTitle)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("jobTitle");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Phone)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("phone");
            entity.Property(e => e.Score).HasColumnName("score");
            entity.Property(e => e.Stage)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("stage");
            entity.Property(e => e.Status)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("status");
            entity.Property(e => e.Timezone)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("timezone");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updatedAt");
        });

        modelBuilder.Entity<CompanyContactsCountAggregate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CompanyC__3213E83FFFC1DF6D");

            entity.ToTable("CompanyContactsCountAggregate");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt).HasColumnName("createdAt");
            entity.Property(e => e.Email).HasColumnName("email");
            entity.Property(e => e.JobTitle).HasColumnName("jobTitle");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.Phone).HasColumnName("phone");
            entity.Property(e => e.Score).HasColumnName("score");
            entity.Property(e => e.Stage).HasColumnName("stage");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.Timezone).HasColumnName("timezone");
            entity.Property(e => e.UpdatedAt).HasColumnName("updatedAt");
        });

        modelBuilder.Entity<CompanyContactsMaxAggregate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CompanyC__3213E83F8BDD7643");

            entity.ToTable("CompanyContactsMaxAggregate");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("createdAt");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.JobTitle)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("jobTitle");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Phone)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("phone");
            entity.Property(e => e.Score).HasColumnName("score");
            entity.Property(e => e.Stage)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("stage");
            entity.Property(e => e.Status)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("status");
            entity.Property(e => e.Timezone)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("timezone");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updatedAt");
        });

        modelBuilder.Entity<CompanyContactsMinAggregate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CompanyC__3213E83FD4FCDBEA");

            entity.ToTable("CompanyContactsMinAggregate");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("createdAt");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.JobTitle)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("jobTitle");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Phone)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("phone");
            entity.Property(e => e.Score).HasColumnName("score");
            entity.Property(e => e.Stage)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("stage");
            entity.Property(e => e.Status)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("status");
            entity.Property(e => e.Timezone)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("timezone");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updatedAt");
        });

        modelBuilder.Entity<CompanyContactsSumAggregate>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CompanyContactsSumAggregate");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Score).HasColumnName("score");
        });

        modelBuilder.Entity<CompanyDealsAggregateGroupBy>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CompanyDealsAggregateGroupBy");

            entity.Property(e => e.CloseDateDay).HasColumnName("closeDateDay");
            entity.Property(e => e.CloseDateMonth).HasColumnName("closeDateMonth");
            entity.Property(e => e.CloseDateYear).HasColumnName("closeDateYear");
            entity.Property(e => e.CompanyId).HasColumnName("companyId");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("createdAt");
            entity.Property(e => e.DealOwnerId).HasColumnName("dealOwnerId");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.StageId).HasColumnName("stageId");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("title");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updatedAt");
            entity.Property(e => e.Value).HasColumnName("value");
        });

        modelBuilder.Entity<CompanyDealsAggregateResponse>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CompanyDealsAggregateResponse");

            entity.Property(e => e.AvgId).HasColumnName("avgId");
            entity.Property(e => e.AvgValue).HasColumnName("avgValue");
            entity.Property(e => e.CountCloseDateDay).HasColumnName("countCloseDateDay");
            entity.Property(e => e.CountCloseDateMonth).HasColumnName("countCloseDateMonth");
            entity.Property(e => e.CountCloseDateYear).HasColumnName("countCloseDateYear");
            entity.Property(e => e.CountCompanyId).HasColumnName("countCompanyId");
            entity.Property(e => e.CountCreatedAt).HasColumnName("countCreatedAt");
            entity.Property(e => e.CountDealOwnerId).HasColumnName("countDealOwnerId");
            entity.Property(e => e.CountId).HasColumnName("countId");
            entity.Property(e => e.CountStageId).HasColumnName("countStageId");
            entity.Property(e => e.CountTitle).HasColumnName("countTitle");
            entity.Property(e => e.CountUpdatedAt).HasColumnName("countUpdatedAt");
            entity.Property(e => e.CountValue).HasColumnName("countValue");
            entity.Property(e => e.GroupByCloseDateDay).HasColumnName("groupByCloseDateDay");
            entity.Property(e => e.GroupByCloseDateMonth).HasColumnName("groupByCloseDateMonth");
            entity.Property(e => e.GroupByCloseDateYear).HasColumnName("groupByCloseDateYear");
            entity.Property(e => e.GroupByCompanyId).HasColumnName("groupByCompanyId");
            entity.Property(e => e.GroupByCreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("groupByCreatedAt");
            entity.Property(e => e.GroupByDealOwnerId).HasColumnName("groupByDealOwnerId");
            entity.Property(e => e.GroupById).HasColumnName("groupById");
            entity.Property(e => e.GroupByStageId).HasColumnName("groupByStageId");
            entity.Property(e => e.GroupByTitle)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("groupByTitle");
            entity.Property(e => e.GroupByUpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("groupByUpdatedAt");
            entity.Property(e => e.GroupByValue).HasColumnName("groupByValue");
            entity.Property(e => e.MaxId).HasColumnName("maxId");
            entity.Property(e => e.MaxTitle).HasColumnName("maxTitle");
            entity.Property(e => e.MinId).HasColumnName("minId");
            entity.Property(e => e.MinTitle).HasColumnName("minTitle");
            entity.Property(e => e.SumId).HasColumnName("sumId");
            entity.Property(e => e.SumValue).HasColumnName("sumValue");
        });

        modelBuilder.Entity<CompanyDealsAvgAggregate>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CompanyDealsAvgAggregate");

            entity.Property(e => e.CloseDateDay).HasColumnName("closeDateDay");
            entity.Property(e => e.CloseDateMonth).HasColumnName("closeDateMonth");
            entity.Property(e => e.CloseDateYear).HasColumnName("closeDateYear");
            entity.Property(e => e.CompanyId).HasColumnName("companyId");
            entity.Property(e => e.DealOwnerId).HasColumnName("dealOwnerId");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.StageId).HasColumnName("stageId");
            entity.Property(e => e.Value).HasColumnName("value");
        });

        modelBuilder.Entity<CompanyDealsCountAggregate>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CompanyDealsCountAggregate");

            entity.Property(e => e.CloseDateDay).HasColumnName("closeDateDay");
            entity.Property(e => e.CloseDateMonth).HasColumnName("closeDateMonth");
            entity.Property(e => e.CloseDateYear).HasColumnName("closeDateYear");
            entity.Property(e => e.CompanyId).HasColumnName("companyId");
            entity.Property(e => e.CreatedAt).HasColumnName("createdAt");
            entity.Property(e => e.DealOwnerId).HasColumnName("dealOwnerId");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.StageId).HasColumnName("stageId");
            entity.Property(e => e.Title).HasColumnName("title");
            entity.Property(e => e.UpdatedAt).HasColumnName("updatedAt");
            entity.Property(e => e.Value).HasColumnName("value");
        });

        modelBuilder.Entity<CompanyDealsMaxAggregate>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CompanyDealsMaxAggregate");

            entity.Property(e => e.CloseDateDay).HasColumnName("closeDateDay");
            entity.Property(e => e.CloseDateMonth).HasColumnName("closeDateMonth");
            entity.Property(e => e.CloseDateYear).HasColumnName("closeDateYear");
            entity.Property(e => e.CompanyId).HasColumnName("companyId");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("createdAt");
            entity.Property(e => e.DealOwnerId).HasColumnName("dealOwnerId");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.StageId).HasColumnName("stageId");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("title");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updatedAt");
            entity.Property(e => e.Value).HasColumnName("value");
        });

        modelBuilder.Entity<CompanyDealsMinAggregate>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CompanyDealsMinAggregate");

            entity.Property(e => e.CloseDateDay).HasColumnName("closeDateDay");
            entity.Property(e => e.CloseDateMonth).HasColumnName("closeDateMonth");
            entity.Property(e => e.CloseDateYear).HasColumnName("closeDateYear");
            entity.Property(e => e.CompanyId).HasColumnName("companyId");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("createdAt");
            entity.Property(e => e.DealOwnerId).HasColumnName("dealOwnerId");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.StageId).HasColumnName("stageId");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("title");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updatedAt");
            entity.Property(e => e.Value).HasColumnName("value");
        });

        modelBuilder.Entity<CompanyDealsSumAggregate>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CompanyDealsSumAggregate");

            entity.Property(e => e.CloseDateDay).HasColumnName("closeDateDay");
            entity.Property(e => e.CloseDateMonth).HasColumnName("closeDateMonth");
            entity.Property(e => e.CloseDateYear).HasColumnName("closeDateYear");
            entity.Property(e => e.CompanyId).HasColumnName("companyId");
            entity.Property(e => e.DealOwnerId).HasColumnName("dealOwnerId");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.StageId).HasColumnName("stageId");
            entity.Property(e => e.Value).HasColumnName("value");
        });

        modelBuilder.Entity<CompanyDeleteResponse>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CompanyD__3213E83FFB2E839E");

            entity.ToTable("CompanyDeleteResponse");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.AvatarUrl)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("avatarUrl");
            entity.Property(e => e.BusinessType)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("businessType");
            entity.Property(e => e.CompanySize)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("companySize");
            entity.Property(e => e.Country)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("country");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("createdAt");
            entity.Property(e => e.Industry)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("industry");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.TotalRevenue).HasColumnName("totalRevenue");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updatedAt");
            entity.Property(e => e.Website)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("website");
        });

        modelBuilder.Entity<CompanyMaxAggregate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CompanyM__3213E83F2DA9454F");

            entity.ToTable("CompanyMaxAggregate");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.BusinessType)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("businessType");
            entity.Property(e => e.CompanySize)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("companySize");
            entity.Property(e => e.Country)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("country");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("createdAt");
            entity.Property(e => e.Industry)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("industry");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.TotalRevenue).HasColumnName("totalRevenue");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updatedAt");
            entity.Property(e => e.Website)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("website");
        });

        modelBuilder.Entity<CompanyMinAggregate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CompanyM__3213E83F18298F4D");

            entity.ToTable("CompanyMinAggregate");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.BusinessType)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("businessType");
            entity.Property(e => e.CompanySize)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("companySize");
            entity.Property(e => e.Country)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("country");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("createdAt");
            entity.Property(e => e.Industry)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("industry");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.TotalRevenue).HasColumnName("totalRevenue");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updatedAt");
            entity.Property(e => e.Website)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("website");
        });

        modelBuilder.Entity<CompanyNote>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CompanyN__3213E83FAAED26D8");

            entity.ToTable("CompanyNote");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.CompanyId).HasColumnName("companyID");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("createdAt");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("createdBy");
            entity.Property(e => e.Note)
                .HasColumnType("text")
                .HasColumnName("note");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updatedAt");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("updatedBy");

            entity.HasOne(d => d.Company).WithMany(p => p.CompanyNotes)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CompanyNo__compa__1F63A897");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.CompanyNoteCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CompanyNo__creat__1D7B6025");

            entity.HasOne(d => d.UpdatedByNavigation).WithMany(p => p.CompanyNoteUpdatedByNavigations)
                .HasForeignKey(d => d.UpdatedBy)
                .HasConstraintName("FK__CompanyNo__updat__1E6F845E");
        });

        modelBuilder.Entity<CompanyNoteConnection>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CompanyN__3213E83FC893A2E1");

            entity.ToTable("CompanyNoteConnection");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Nodes).HasColumnName("nodes");
            entity.Property(e => e.PageInfoHasNextPage).HasColumnName("pageInfoHasNextPage");
            entity.Property(e => e.PageInfoLimit).HasColumnName("pageInfoLimit");
            entity.Property(e => e.PageInfoOffset).HasColumnName("pageInfoOffset");
            entity.Property(e => e.TotalCount).HasColumnName("totalCount");
        });

        modelBuilder.Entity<CompanyNoteDeleteResponse>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CompanyN__3213E83FE5E9B3FE");

            entity.ToTable("CompanyNoteDeleteResponse");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("createdAt");
            entity.Property(e => e.Note).HasColumnName("note");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updatedAt");
        });

        modelBuilder.Entity<CompanyNotesAggregateGroupBy>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CompanyN__3213E83FCF8D0654");

            entity.ToTable("CompanyNotesAggregateGroupBy");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("createdAt");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.JobTitle)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("jobTitle");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Phone)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("phone");
            entity.Property(e => e.Score).HasColumnName("score");
            entity.Property(e => e.Stage)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("stage");
            entity.Property(e => e.Status)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("status");
            entity.Property(e => e.Timezone)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("timezone");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updatedAt");
        });

        modelBuilder.Entity<CompanyNotesAggregateResponse>(entity =>
        {
            entity.HasKey(e => e.GroupById).HasName("PK__CompanyN__D30D023206B9EFE1");

            entity.ToTable("CompanyNotesAggregateResponse");

            entity.Property(e => e.GroupById)
                .ValueGeneratedNever()
                .HasColumnName("groupById");
            entity.Property(e => e.Avg).HasColumnName("avg");
            entity.Property(e => e.Count).HasColumnName("count");
            entity.Property(e => e.GroupByCreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("groupByCreatedAt");
            entity.Property(e => e.GroupByUpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("groupByUpdatedAt");
            entity.Property(e => e.Max).HasColumnName("max");
            entity.Property(e => e.Min).HasColumnName("min");
            entity.Property(e => e.Sum).HasColumnName("sum");

            entity.HasOne(d => d.GroupBy).WithOne(p => p.CompanyNotesAggregateResponse)
                .HasForeignKey<CompanyNotesAggregateResponse>(d => d.GroupById)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CompanyNo__group__6C190EBB");
        });

        modelBuilder.Entity<CompanyNotesAvgAggregate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CompanyN__3213E83F457A2A66");

            entity.ToTable("CompanyNotesAvgAggregate");

            entity.Property(e => e.Id).HasColumnName("id");
        });

        modelBuilder.Entity<CompanyNotesCountAggregate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CompanyN__3213E83FC171E3DF");

            entity.ToTable("CompanyNotesCountAggregate");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.CreatedAtCount).HasColumnName("createdAtCount");
            entity.Property(e => e.UpdatedAtCount).HasColumnName("updatedAtCount");
        });

        modelBuilder.Entity<CompanyNotesMaxAggregate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CompanyN__3213E83F815B4690");

            entity.ToTable("CompanyNotesMaxAggregate");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.MaxCreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("maxCreatedAt");
            entity.Property(e => e.MaxUpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("maxUpdatedAt");
        });

        modelBuilder.Entity<CompanyNotesMinAggregate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CompanyN__3213E83F683629AE");

            entity.ToTable("CompanyNotesMinAggregate");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.MinCreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("minCreatedAt");
            entity.Property(e => e.MinUpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("minUpdatedAt");
        });

        modelBuilder.Entity<CompanyNotesSumAggregate>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CompanyNotesSumAggregate");

            entity.Property(e => e.Id).HasColumnName("id");
        });

        modelBuilder.Entity<CompanySumAggregate>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CompanySumAggregate");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.TotalRevenue).HasColumnName("totalRevenue");
        });

        modelBuilder.Entity<Contact>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Contact__3213E83FFB4243DD");

            entity.ToTable("Contact");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.AvatarUrl)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("avatarUrl");
            entity.Property(e => e.Company).HasColumnName("company");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("createdAt");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("createdBy");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.JobTitle)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("jobTitle");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Phone)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("phone");
            entity.Property(e => e.SalesOwner)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("salesOwner");
            entity.Property(e => e.Score).HasColumnName("score");
            entity.Property(e => e.Stage)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("stage");
            entity.Property(e => e.Status)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("status");
            entity.Property(e => e.Timezone)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("timezone");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updatedAt");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("updatedBy");

            entity.HasOne(d => d.CompanyNavigation).WithMany(p => p.Contacts)
                .HasForeignKey(d => d.Company)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Contact__company__151B244E");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.ContactCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Contact__created__123EB7A3");

            entity.HasOne(d => d.SalesOwnerNavigation).WithMany(p => p.ContactSalesOwnerNavigations)
                .HasForeignKey(d => d.SalesOwner)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Contact__salesOw__14270015");

            entity.HasOne(d => d.UpdatedByNavigation).WithMany(p => p.ContactUpdatedByNavigations)
                .HasForeignKey(d => d.UpdatedBy)
                .HasConstraintName("FK__Contact__updated__1332DBDC");
        });

        modelBuilder.Entity<ContactDeleteResponse>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ContactD__3213E83F058D75DF");

            entity.ToTable("ContactDeleteResponse");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.AvatarUrl)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("avatarUrl");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("createdAt");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.JobTitle)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("jobTitle");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Phone)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("phone");
            entity.Property(e => e.Score).HasColumnName("score");
            entity.Property(e => e.Stage)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("stage");
            entity.Property(e => e.Status)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("status");
            entity.Property(e => e.Timezone)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("timezone");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updatedAt");
        });

        modelBuilder.Entity<ContactNote>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ContactNote_pkey");

            entity.ToTable("ContactNote");

            entity.Property(e => e.Id)
                .HasMaxLength(1000)
                .HasColumnName("id");
            entity.Property(e => e.ContactId)
                .HasMaxLength(1000)
                .HasColumnName("contactId");
            entity.Property(e => e.CreatedAt).HasColumnName("createdAt");
            entity.Property(e => e.CreatedById)
                .HasMaxLength(1000)
                .HasColumnName("createdById");
            entity.Property(e => e.Note)
                .HasMaxLength(1000)
                .HasColumnName("note");
            entity.Property(e => e.UpdatedAt).HasColumnName("updatedAt");
            entity.Property(e => e.UpdatedById)
                .HasMaxLength(1000)
                .HasColumnName("updatedById");
        });

        modelBuilder.Entity<Deal>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Deal__3213E83F08F620A2");

            entity.ToTable("Deal");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.CloseDateDay).HasColumnName("closeDateDay");
            entity.Property(e => e.CloseDateMonth).HasColumnName("closeDateMonth");
            entity.Property(e => e.CloseDateYear).HasColumnName("closeDateYear");
            entity.Property(e => e.CompanyId).HasColumnName("companyId");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("createdAt");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("createdBy");
            entity.Property(e => e.DealOwnerId)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("dealOwnerId");
            entity.Property(e => e.Notes)
                .HasColumnType("text")
                .HasColumnName("notes");
            entity.Property(e => e.StageId).HasColumnName("stageId");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("title");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updatedAt");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("updatedBy");
            entity.Property(e => e.Value).HasColumnName("value");

            entity.HasOne(d => d.Company).WithMany(p => p.Deals)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Deal__companyId__345EC57D");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.DealCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Deal__createdBy__3552E9B6");

            entity.HasOne(d => d.DealOwner).WithMany(p => p.DealDealOwners)
                .HasForeignKey(d => d.DealOwnerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Deal__dealOwnerI__336AA144");

            entity.HasOne(d => d.Stage).WithMany(p => p.Deals)
                .HasForeignKey(d => d.StageId)
                .HasConstraintName("FK__Deal__stageId__32767D0B");

            entity.HasOne(d => d.UpdatedByNavigation).WithMany(p => p.DealUpdatedByNavigations)
                .HasForeignKey(d => d.UpdatedBy)
                .HasConstraintName("FK__Deal__updatedBy__36470DEF");
        });

        modelBuilder.Entity<DealAggregateGroupBy>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DealAggregateGroupBy");

            entity.Property(e => e.CloseDateDay).HasColumnName("closeDateDay");
            entity.Property(e => e.CloseDateMonth).HasColumnName("closeDateMonth");
            entity.Property(e => e.CloseDateYear).HasColumnName("closeDateYear");
            entity.Property(e => e.CompanyId).HasColumnName("companyId");
            entity.Property(e => e.CreatedAt).HasColumnName("createdAt");
            entity.Property(e => e.DealOwnerId).HasColumnName("dealOwnerId");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.StageId).HasColumnName("stageId");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("title");
            entity.Property(e => e.UpdatedAt).HasColumnName("updatedAt");
            entity.Property(e => e.Value).HasColumnName("value");
        });

        modelBuilder.Entity<DealDeleteResponse>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__DealDele__3213E83FCE8E5E19");

            entity.ToTable("DealDeleteResponse");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.CloseDateDay).HasColumnName("closeDateDay");
            entity.Property(e => e.CloseDateMonth).HasColumnName("closeDateMonth");
            entity.Property(e => e.CloseDateYear).HasColumnName("closeDateYear");
            entity.Property(e => e.CompanyId).HasColumnName("companyId");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("createdAt");
            entity.Property(e => e.DealOwnerId).HasColumnName("dealOwnerId");
            entity.Property(e => e.Notes)
                .HasColumnType("text")
                .HasColumnName("notes");
            entity.Property(e => e.StageId).HasColumnName("stageId");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("title");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updatedAt");
            entity.Property(e => e.Value).HasColumnName("value");
        });

        modelBuilder.Entity<DealMaxAggregate>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DealMaxAggregate");

            entity.Property(e => e.CloseDateDay).HasColumnName("closeDateDay");
            entity.Property(e => e.CloseDateMonth).HasColumnName("closeDateMonth");
            entity.Property(e => e.CloseDateYear).HasColumnName("closeDateYear");
            entity.Property(e => e.CompanyId).HasColumnName("companyId");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("createdAt");
            entity.Property(e => e.DealOwnerId).HasColumnName("dealOwnerId");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.StageId).HasColumnName("stageId");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("title");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updatedAt");
            entity.Property(e => e.Value).HasColumnName("value");
        });

        modelBuilder.Entity<DealMinAggregate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__DealMinA__3213E83FC478DCCB");

            entity.ToTable("DealMinAggregate");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.CloseDateDay).HasColumnName("closeDateDay");
            entity.Property(e => e.CloseDateMonth).HasColumnName("closeDateMonth");
            entity.Property(e => e.CloseDateYear).HasColumnName("closeDateYear");
            entity.Property(e => e.CompanyId).HasColumnName("companyId");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("createdAt");
            entity.Property(e => e.DealOwnerId).HasColumnName("dealOwnerId");
            entity.Property(e => e.StageId).HasColumnName("stageId");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("title");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updatedAt");
            entity.Property(e => e.Value).HasColumnName("value");
        });

        modelBuilder.Entity<DealStage>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__DealStag__3213E83F8029D5E7");

            entity.ToTable("DealStage");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("createdAt");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("createdBy");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("title");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updatedAt");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("updatedBy");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.DealStageCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__DealStage__creat__32AB8735");

            entity.HasOne(d => d.UpdatedByNavigation).WithMany(p => p.DealStageUpdatedByNavigations)
                .HasForeignKey(d => d.UpdatedBy)
                .HasConstraintName("FK__DealStage__updat__339FAB6E");
        });

        modelBuilder.Entity<DealStageDealsAggregateGroupBy>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DealStageDealsAggregateGroupBy");

            entity.Property(e => e.CloseDateDay).HasColumnName("closeDateDay");
            entity.Property(e => e.CloseDateMonth).HasColumnName("closeDateMonth");
            entity.Property(e => e.CloseDateYear).HasColumnName("closeDateYear");
            entity.Property(e => e.CompanyId).HasColumnName("companyId");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("createdAt");
            entity.Property(e => e.DealOwnerId).HasColumnName("dealOwnerId");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.StageId).HasColumnName("stageId");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("title");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updatedAt");
            entity.Property(e => e.Value).HasColumnName("value");
        });

        modelBuilder.Entity<DealStageDealsAvgAggregate>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DealStageDealsAvgAggregate");

            entity.Property(e => e.CloseDateDay).HasColumnName("closeDateDay");
            entity.Property(e => e.CloseDateMonth).HasColumnName("closeDateMonth");
            entity.Property(e => e.CloseDateYear).HasColumnName("closeDateYear");
            entity.Property(e => e.CompanyId).HasColumnName("companyId");
            entity.Property(e => e.DealOwnerId).HasColumnName("dealOwnerId");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.StageId).HasColumnName("stageId");
            entity.Property(e => e.Value).HasColumnName("value");
        });

        modelBuilder.Entity<DealStageDealsCountAggregate>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DealStageDealsCountAggregate");

            entity.Property(e => e.CloseDateDay).HasColumnName("closeDateDay");
            entity.Property(e => e.CloseDateMonth).HasColumnName("closeDateMonth");
            entity.Property(e => e.CloseDateYear).HasColumnName("closeDateYear");
            entity.Property(e => e.CompanyId).HasColumnName("companyId");
            entity.Property(e => e.CreatedAt).HasColumnName("createdAt");
            entity.Property(e => e.DealOwnerId).HasColumnName("dealOwnerId");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.StageId).HasColumnName("stageId");
            entity.Property(e => e.Title).HasColumnName("title");
            entity.Property(e => e.UpdatedAt).HasColumnName("updatedAt");
            entity.Property(e => e.Value).HasColumnName("value");
        });

        modelBuilder.Entity<DealStageDealsMaxAggregate>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DealStageDealsMaxAggregate");

            entity.Property(e => e.CloseDateDay).HasColumnName("closeDateDay");
            entity.Property(e => e.CloseDateMonth).HasColumnName("closeDateMonth");
            entity.Property(e => e.CloseDateYear).HasColumnName("closeDateYear");
            entity.Property(e => e.CompanyId).HasColumnName("companyId");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("createdAt");
            entity.Property(e => e.DealOwnerId).HasColumnName("dealOwnerId");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.StageId).HasColumnName("stageId");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("title");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updatedAt");
            entity.Property(e => e.Value).HasColumnName("value");
        });

        modelBuilder.Entity<DealStageDealsMinAggregate>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DealStageDealsMinAggregate");

            entity.Property(e => e.CloseDateDay).HasColumnName("closeDateDay");
            entity.Property(e => e.CloseDateMonth).HasColumnName("closeDateMonth");
            entity.Property(e => e.CloseDateYear).HasColumnName("closeDateYear");
            entity.Property(e => e.CompanyId).HasColumnName("companyId");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("createdAt");
            entity.Property(e => e.DealOwnerId).HasColumnName("dealOwnerId");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.StageId).HasColumnName("stageId");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("title");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updatedAt");
            entity.Property(e => e.Value).HasColumnName("value");
        });

        modelBuilder.Entity<DealStageDealsSumAggregate>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DealStageDealsSumAggregate");

            entity.Property(e => e.CloseDateDay).HasColumnName("closeDateDay");
            entity.Property(e => e.CloseDateMonth).HasColumnName("closeDateMonth");
            entity.Property(e => e.CloseDateYear).HasColumnName("closeDateYear");
            entity.Property(e => e.CompanyId).HasColumnName("companyId");
            entity.Property(e => e.DealOwnerId).HasColumnName("dealOwnerId");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.StageId).HasColumnName("stageId");
            entity.Property(e => e.Value).HasColumnName("value");
        });

        modelBuilder.Entity<DealStageDeleteResponse>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__DealStag__3213E83F7F7A6536");

            entity.ToTable("DealStageDeleteResponse");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("createdAt");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("title");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updatedAt");
        });

        modelBuilder.Entity<DealSumAggregate>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DealSumAggregate");

            entity.Property(e => e.CloseDateDay).HasColumnName("closeDateDay");
            entity.Property(e => e.CloseDateMonth).HasColumnName("closeDateMonth");
            entity.Property(e => e.CloseDateYear).HasColumnName("closeDateYear");
            entity.Property(e => e.CompanyId).HasColumnName("companyId");
            entity.Property(e => e.DealOwnerId).HasColumnName("dealOwnerId");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.StageId).HasColumnName("stageId");
            entity.Property(e => e.Value).HasColumnName("value");
        });

        modelBuilder.Entity<DeletedTaskComment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__DeletedT__3213E83F8D66A0FD");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Comment)
                .HasColumnType("text")
                .HasColumnName("comment");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("createdAt");
            entity.Property(e => e.DeletedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("deletedAt");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updatedAt");
        });

        modelBuilder.Entity<Event>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Event__3213E83F26F50709");

            entity.ToTable("Event");

            entity.Property(e => e.Id)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("id");
            entity.Property(e => e.CategoryId)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("categoryId");
            entity.Property(e => e.Color)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("color");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("createdAt");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("createdBy");
            entity.Property(e => e.Description)
                .HasColumnType("text")
                .HasColumnName("description");
            entity.Property(e => e.EndDate)
                .HasColumnType("datetime")
                .HasColumnName("endDate");
            entity.Property(e => e.StartDate)
                .HasColumnType("datetime")
                .HasColumnName("startDate");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("title");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updatedAt");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("updatedBy");

            entity.HasOne(d => d.Category).WithMany(p => p.Events)
                .HasForeignKey(d => d.CategoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Event__categoryI__5AEE82B9");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.EventCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Event__createdBy__59063A47");

            entity.HasOne(d => d.UpdatedByNavigation).WithMany(p => p.EventUpdatedByNavigations)
                .HasForeignKey(d => d.UpdatedBy)
                .HasConstraintName("FK__Event__updatedBy__59FA5E80");
        });

        modelBuilder.Entity<EventCategory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__EventCat__3213E83FDF60BAE4");

            entity.ToTable("EventCategory");

            entity.Property(e => e.Id)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("createdAt");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("createdBy");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("title");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updatedAt");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("updatedBy");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.EventCategoryCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__EventCate__creat__5535A963");

            entity.HasOne(d => d.UpdatedByNavigation).WithMany(p => p.EventCategoryUpdatedByNavigations)
                .HasForeignKey(d => d.UpdatedBy)
                .HasConstraintName("FK__EventCate__updat__5629CD9C");
        });

        modelBuilder.Entity<EventCategoryDeleteResponse>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__EventCat__3213E83F0D9DB61D");

            entity.ToTable("EventCategoryDeleteResponse");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("createdAt");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("title");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updatedAt");
        });

        modelBuilder.Entity<EventDeleteResponse>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__EventDel__3213E83F1A8963EE");

            entity.ToTable("EventDeleteResponse");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Color)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("color");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("createdAt");
            entity.Property(e => e.Description)
                .HasColumnType("text")
                .HasColumnName("description");
            entity.Property(e => e.EndDate)
                .HasColumnType("datetime")
                .HasColumnName("endDate");
            entity.Property(e => e.StartDate)
                .HasColumnType("datetime")
                .HasColumnName("startDate");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("title");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updatedAt");
        });

        modelBuilder.Entity<PrismaMigration>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK___prisma___3213E83F85A303E9");

            entity.ToTable("_prisma_migrations");

            entity.Property(e => e.Id)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("id");
            entity.Property(e => e.AppliedStepsCount).HasColumnName("applied_steps_count");
            entity.Property(e => e.Checksum)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("checksum");
            entity.Property(e => e.FinishedAt).HasColumnName("finished_at");
            entity.Property(e => e.Logs).HasColumnName("logs");
            entity.Property(e => e.MigrationName)
                .HasMaxLength(250)
                .HasColumnName("migration_name");
            entity.Property(e => e.RolledBackAt).HasColumnName("rolled_back_at");
            entity.Property(e => e.StartedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("started_at");
        });

        modelBuilder.Entity<Quote>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Quote__3213E83F8CD50805");

            entity.ToTable("Quote");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.CompanyId).HasColumnName("companyId");
            entity.Property(e => e.ContactId).HasColumnName("contactId");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("createdAt");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("createdBy");
            entity.Property(e => e.Description)
                .HasColumnType("text")
                .HasColumnName("description");
            entity.Property(e => e.SalesOwner)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("salesOwner");
            entity.Property(e => e.Status)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("status");
            entity.Property(e => e.SubTotal).HasColumnName("subTotal");
            entity.Property(e => e.Tax).HasColumnName("tax");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("title");
            entity.Property(e => e.Total).HasColumnName("total");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updatedAt");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("updatedBy");

            entity.HasOne(d => d.Company).WithMany(p => p.Quotes)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Quote__companyId__498EEC8D");

            entity.HasOne(d => d.Contact).WithMany(p => p.Quotes)
                .HasForeignKey(d => d.ContactId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Quote__contactId__489AC854");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.QuoteCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Quote__createdBy__45BE5BA9");

            entity.HasOne(d => d.SalesOwnerNavigation).WithMany(p => p.QuoteSalesOwnerNavigations)
                .HasForeignKey(d => d.SalesOwner)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Quote__salesOwne__47A6A41B");

            entity.HasOne(d => d.UpdatedByNavigation).WithMany(p => p.QuoteUpdatedByNavigations)
                .HasForeignKey(d => d.UpdatedBy)
                .HasConstraintName("FK__Quote__updatedBy__46B27FE2");
        });

        modelBuilder.Entity<QuoteDeleteResponse>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__QuoteDel__3213E83F84D8F7E7");

            entity.ToTable("QuoteDeleteResponse");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("createdAt");
            entity.Property(e => e.Description)
                .HasColumnType("text")
                .HasColumnName("description");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("status");
            entity.Property(e => e.SubTotal).HasColumnName("subTotal");
            entity.Property(e => e.Tax).HasColumnName("tax");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("title");
            entity.Property(e => e.Total).HasColumnName("total");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updatedAt");
        });

        modelBuilder.Entity<QuoteItem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__QuoteIte__3213E83F9DC6C3EA");

            entity.ToTable("QuoteItem");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Discount).HasColumnName("discount");
            entity.Property(e => e.Quantity).HasColumnName("quantity");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("title");
            entity.Property(e => e.TotalPrice).HasColumnName("totalPrice");
            entity.Property(e => e.UnitPrice).HasColumnName("unitPrice");
        });

        modelBuilder.Entity<WebApplication1.Models.Task>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Task__3213E83F20CF8954");

            entity.ToTable("Task");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Completed).HasColumnName("completed");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("createdAt");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("createdBy");
            entity.Property(e => e.Description)
                .HasColumnType("text")
                .HasColumnName("description");
            entity.Property(e => e.DueDate)
                .HasColumnType("datetime")
                .HasColumnName("dueDate");
            entity.Property(e => e.StageId).HasColumnName("stageId");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("title");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updatedAt");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("updatedBy");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.TaskCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Task__createdBy__51300E55");

            entity.HasOne(d => d.Stage).WithMany(p => p.Tasks)
                .HasForeignKey(d => d.StageId)
                .HasConstraintName("FK__Task__stageId__503BEA1C");

            entity.HasOne(d => d.UpdatedByNavigation).WithMany(p => p.TaskUpdatedByNavigations)
                .HasForeignKey(d => d.UpdatedBy)
                .HasConstraintName("FK__Task__updatedBy__5224328E");
        });

        modelBuilder.Entity<TaskAvgAggregate>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TaskAvgAggregate");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.StageId).HasColumnName("stageId");
        });

        modelBuilder.Entity<TaskComment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TaskComm__3213E83FB76C56B7");

            entity.ToTable("TaskComment");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Comment)
                .HasColumnType("text")
                .HasColumnName("comment");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("createdAt");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("createdBy");
            entity.Property(e => e.TaskId).HasColumnName("taskID");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updatedAt");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("updatedBy");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.TaskCommentCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__TaskComme__creat__0B5CAFEA");

            entity.HasOne(d => d.Task).WithMany(p => p.TaskComments)
                .HasForeignKey(d => d.TaskId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__TaskComme__taskI__0D44F85C");

            entity.HasOne(d => d.UpdatedByNavigation).WithMany(p => p.TaskCommentUpdatedByNavigations)
                .HasForeignKey(d => d.UpdatedBy)
                .HasConstraintName("FK__TaskComme__updat__0C50D423");
        });

        modelBuilder.Entity<TaskCommentsCountAggregate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TaskComm__3213E83F1AC3F71C");

            entity.ToTable("TaskCommentsCountAggregate");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt).HasColumnName("createdAt");
            entity.Property(e => e.UpdatedAt).HasColumnName("updatedAt");
        });

        modelBuilder.Entity<TaskCommentsMaxAggregate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TaskComm__3213E83FAF523A50");

            entity.ToTable("TaskCommentsMaxAggregate");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("createdAt");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updatedAt");
        });

        modelBuilder.Entity<TaskCommentsMinAggregate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TaskComm__3213E83F7BA65C68");

            entity.ToTable("TaskCommentsMinAggregate");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("createdAt");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updatedAt");
        });

        modelBuilder.Entity<TaskStage>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TaskStag__3213E83F0DF511D9");

            entity.ToTable("TaskStage");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("createdAt");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("createdBy");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("title");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updatedAt");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("updatedBy");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.TaskStageCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__TaskStage__creat__4C6B5938");

            entity.HasOne(d => d.UpdatedByNavigation).WithMany(p => p.TaskStageUpdatedByNavigations)
                .HasForeignKey(d => d.UpdatedBy)
                .HasConstraintName("FK__TaskStage__updat__4D5F7D71");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__User__3213E83F5D940461");

            entity.ToTable("User");

            entity.Property(e => e.Id)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("id");
            entity.Property(e => e.AvatarUrl)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("avatarUrl");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("createdAt");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("createdBy");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.JobTitle)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("jobTitle");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Phone)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("phone");
            entity.Property(e => e.Role)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("role");
            entity.Property(e => e.Timezone)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("timezone");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updatedAt");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("updatedBy");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.InverseCreatedByNavigation)
                .HasForeignKey(d => d.CreatedBy)
                .HasConstraintName("FK__User__createdBy__4CA06362");

            entity.HasOne(d => d.UpdatedByNavigation).WithMany(p => p.InverseUpdatedByNavigation)
                .HasForeignKey(d => d.UpdatedBy)
                .HasConstraintName("FK__User__updatedBy__4D94879B");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
