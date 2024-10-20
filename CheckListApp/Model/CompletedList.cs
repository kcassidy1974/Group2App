﻿using System;
using System.Collections.Generic;
using System.Linq;

public class Task
{
    public string Name { get; set; }
    public bool IsComplete { get; set; }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Example list of tasks
        List<Task> tasks = new List<Task>
        {
            new Task { Name = "Task 1", IsComplete = false },
            new Task { Name = "Task 2", IsComplete = true },
            new Task { Name = "Task 3", IsComplete = false },
            new Task { Name = "Task 4", IsComplete = true }
        };

        // Move completed tasks to the bottom
        tasks = MoveCompletedTasksToBottom(tasks);

        // Print the reordered task list
        foreach (var task in tasks)
        {
            Console.WriteLine($"{task.Name} (Complete: {task.IsComplete})");
        }
    }

    public static List<Task> MoveCompletedTasksToBottom(List<Task> tasks)
    {
        // Sort the list: non-completed tasks first, completed tasks last
        return tasks.OrderBy(t => t.IsComplete).ToList();
    }
}

public class Class1
{
    public Class1()
    {
    }
}
