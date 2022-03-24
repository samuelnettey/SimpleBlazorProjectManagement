using Acme.ProjectManagement.Core.ProjectAggregate;
using Acme.ProjectManagement.SharedKernel;

namespace Acme.ProjectManagement.Core.ProjectAggregate.Events
{
    public class ToDoItemCompletedEvent : BaseDomainEvent
    {
        public ToDoItem CompletedItem { get; set; }

        public ToDoItemCompletedEvent(ToDoItem completedItem)
        {
            CompletedItem = completedItem;
        }
    }
}