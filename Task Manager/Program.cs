using Task_Manager.Classes;

namespace Task_Manager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Project project = new Project(18.12.2024, 19.12.2024);
            Person person1 = new Person("Вася", "88005553535");
            Person person2 = new Person("Вася", "88005553535");
            Person person3 = new Person();

            ProjectStatus status_proekta = ProjectStatus.New;
            Task task = new Task(person1, status_proekta);
            
            project.Tasks положить в список task
            project.Status = ProjectStatus.InProgress;
            task.Assignee = person2;
            task.дилигировать_задачу(person3);
            task.отклонить_задачу(person3);


        }
    }
}
