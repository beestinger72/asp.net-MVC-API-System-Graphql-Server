using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class User
{
    public string Id { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string? Phone { get; set; }

    public string? JobTitle { get; set; }

    public string? Timezone { get; set; }

    public string Role { get; set; } = null!;

    public string? AvatarUrl { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public string? CreatedBy { get; set; }

    public string? UpdatedBy { get; set; }

    public virtual ICollection<Audit> Audits { get; set; } = new List<Audit>();

    public virtual ICollection<Company> CompanyCreatedByNavigations { get; set; } = new List<Company>();

    public virtual ICollection<CompanyNote> CompanyNoteCreatedByNavigations { get; set; } = new List<CompanyNote>();

    public virtual ICollection<CompanyNote> CompanyNoteUpdatedByNavigations { get; set; } = new List<CompanyNote>();

    public virtual ICollection<Company> CompanySalesOwnerNavigations { get; set; } = new List<Company>();

    public virtual ICollection<Company> CompanyUpdatedByNavigations { get; set; } = new List<Company>();

    public virtual ICollection<Contact> ContactCreatedByNavigations { get; set; } = new List<Contact>();

    public virtual ICollection<Contact> ContactSalesOwnerNavigations { get; set; } = new List<Contact>();

    public virtual ICollection<Contact> ContactUpdatedByNavigations { get; set; } = new List<Contact>();

    public virtual User? CreatedByNavigation { get; set; }

    public virtual ICollection<Deal> DealCreatedByNavigations { get; set; } = new List<Deal>();

    public virtual ICollection<Deal> DealDealOwners { get; set; } = new List<Deal>();

    public virtual ICollection<DealStage> DealStageCreatedByNavigations { get; set; } = new List<DealStage>();

    public virtual ICollection<DealStage> DealStageUpdatedByNavigations { get; set; } = new List<DealStage>();

    public virtual ICollection<Deal> DealUpdatedByNavigations { get; set; } = new List<Deal>();

    public virtual ICollection<EventCategory> EventCategoryCreatedByNavigations { get; set; } = new List<EventCategory>();

    public virtual ICollection<EventCategory> EventCategoryUpdatedByNavigations { get; set; } = new List<EventCategory>();

    public virtual ICollection<Event> EventCreatedByNavigations { get; set; } = new List<Event>();

    public virtual ICollection<Event> EventUpdatedByNavigations { get; set; } = new List<Event>();

    public virtual ICollection<User> InverseCreatedByNavigation { get; set; } = new List<User>();

    public virtual ICollection<User> InverseUpdatedByNavigation { get; set; } = new List<User>();

    public virtual ICollection<Quote> QuoteCreatedByNavigations { get; set; } = new List<Quote>();

    public virtual ICollection<Quote> QuoteSalesOwnerNavigations { get; set; } = new List<Quote>();

    public virtual ICollection<Quote> QuoteUpdatedByNavigations { get; set; } = new List<Quote>();

    public virtual ICollection<TaskComment> TaskCommentCreatedByNavigations { get; set; } = new List<TaskComment>();

    public virtual ICollection<TaskComment> TaskCommentUpdatedByNavigations { get; set; } = new List<TaskComment>();

    public virtual ICollection<Task> TaskCreatedByNavigations { get; set; } = new List<Task>();

    public virtual ICollection<TaskStage> TaskStageCreatedByNavigations { get; set; } = new List<TaskStage>();

    public virtual ICollection<TaskStage> TaskStageUpdatedByNavigations { get; set; } = new List<TaskStage>();

    public virtual ICollection<Task> TaskUpdatedByNavigations { get; set; } = new List<Task>();

    public virtual User? UpdatedByNavigation { get; set; }
}
