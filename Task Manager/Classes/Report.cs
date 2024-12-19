using System;

namespace Task_Manager.Classes
{
    internal class Report
    {
        public string ReportText { get; set; }
        public DateTime CompletionDate { get; set; }
        public Person Executor { get; set; }

        public Report(string reportText, DateTime completionDate, Person executor)
        {
            ReportText = reportText;
            CompletionDate = completionDate;
            Executor = executor;
        }

        public void ReportInfo()
        {
            Console.WriteLine($"Текст отчета: {ReportText}");
            Console.WriteLine($"Дата выполнения: {CompletionDate}");
            Console.WriteLine($"Исполнитель: {Executor}");
        }


    }
}
