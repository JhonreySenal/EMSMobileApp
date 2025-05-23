﻿using EmployeeManagementSystem.Database;
using EmployeeManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeManagementSystem.Services
{
    public class TaskService
    {
        private readonly DbContext _dbContext;


        public TaskService(DbContext dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));  // Ensure dbContext is not null
        }

        public void AddTask(Tasks task)
        {
            _dbContext.AddTask(task);
        }

        public List<Tasks> GetTasks() 
        {
            return _dbContext.GetTasks(); 
        }

        public List<Tasks> GetCompletedTasksByEmployeeId(int employeeId)
        {
            var tasks = _dbContext.GetTasks();
            return tasks
                .Where(t => t.Status.Equals("Pending", StringComparison.OrdinalIgnoreCase) && t.EmployeeId == employeeId)
                .ToList();
        }

        public void MarkTaskComplete(int taskId)
        {
            _dbContext.MarkTaskComplete(taskId);
        }
        public void DeleteTask(int taskId)
        {
            _dbContext.DeleteTask(taskId); 
        }
    }
}
