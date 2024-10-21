using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebApplication1.Models;
using WebApplication1.Data; // Ensure to import the correct namespace for IRepository

[ApiController]
[Route("api/[controller]")]
public class AuditController : GenericController<Audit>
{
    public AuditController(IRepository<Audit> repository) : base(repository)
    {
    }
}

[ApiController]
[Route("api/[controller]")]
public class CompanyController : GenericController<Company>
{
    public CompanyController(IRepository<Company> repository) : base(repository)
    {
    }
}
[ApiController]
[Route("api/[controller]")]
public class CompanyNoteController : GenericController<CompanyNote>
{
    public CompanyNoteController(IRepository<CompanyNote> repository) : base(repository)
    {
    }
}

[ApiController]
[Route("api/[controller]")]
public class ContactsController : GenericController<Contact>
{
    public ContactsController(IRepository<Contact> repository) : base(repository)
    {
    }
}
[ApiController]
[Route("api/[controller]")]
public class DealController : GenericController<Deal>
{
    public DealController(IRepository<Deal> repository) : base(repository)
    {
    }
}
[ApiController]
[Route("api/[controller]")]
public class DealStageController : GenericController<DealStage>
{
    public DealStageController(IRepository<DealStage> repository) : base(repository)
    {
    }
}
[ApiController]
[Route("api/[controller]")]
public class EventController : GenericController<Event>
{
    public EventController(IRepository<Event> repository) : base(repository)
    {
    }
}

[ApiController]
[Route("api/[controller]")]
public class EventCategoryController : GenericController<EventCategory>
{
    public EventCategoryController(IRepository<EventCategory> repository) : base(repository)
    {
    }
}
[ApiController]
[Route("api/[controller]")]
public class QuotesController : GenericController<Quote>
{
    public QuotesController(IRepository<Quote> repository) : base(repository)
    {
    }
}
[ApiController]
[Route("api/[controller]")]
public class QuoteItemController : GenericController<QuoteItem>
{
    public QuoteItemController(IRepository<QuoteItem> repository) : base(repository)
    {
    }
}
[ApiController]
[Route("api/[controller]")]
public class TaskItemController : GenericController<WebApplication1.Models.Task>
{
    public TaskItemController(IRepository<WebApplication1.Models.Task> repository) : base(repository)
    {
    }
}
[ApiController]
[Route("api/[controller]")]
public class TaskCommentController : GenericController<TaskComment>
{
    public TaskCommentController(IRepository<TaskComment> repository) : base(repository)
    {
    }
}
[ApiController]
[Route("api/[controller]")]
public class TaskStageController : GenericController<TaskStage>
{
    public TaskStageController(IRepository<TaskStage> repository) : base(repository)
    {
    }
}
[ApiController]
[Route("api/[controller]")]
public class UserController : GenericController<User>
{
    public UserController(IRepository<User> repository) : base(repository)
    {
    }
}