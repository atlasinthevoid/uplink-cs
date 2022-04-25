namespace Uplink.Capability.Menu
{
    public class Task : Capability
    {
        public string Description;
        public string DueDate;
        public string ScheduledDate;
        public string WaitDate;
        public string UntilDate;
        public string EndDate;
        public List<string> Status; //Done, InProgress, scheduled, started...
        public string Project;
        public string Priority; // m, h, l
        public List<string> Tags;
        public bool Next;
        public List<Type.Id> DependsOn;
        public int Urgency;


        public Task()
        {
            StringType = "Task";
            Description = "";
            DueDate = "";
            ScheduledDate = "";
            WaitDate = "";
            UntilDate = "";
            EndDate = "";
            Status = new();
            Project = "";
            Priority = "";
            Tags = new();
            Next = false;
            DependsOn = new();
            Urgency = 0;
            Program.Systems.Register(this);
        }

        public override void Update()
        {
            
        }
    }
}