using Abp.Application.Services;
using Abp.Events.Bus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Events.Bus.Entities;

namespace ruito.Event
{
    public class TaskAppService:ApplicationService
    {
        public IEventBus EventBus {  get; set; }

        public TaskAppService()
        {
            EventBus = NullEventBus.Instance;
        }

        public void CompleteTask(string input)
        {
            EventBus.Trigger(new EntityCreatedEventData<string>(input));
        }
    }
}
