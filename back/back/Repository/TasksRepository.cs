using back.DAL;
using back.Models;
using back.Repository.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebGrease.Activities;

namespace back.Repository
{
    public class TasksRepository : ITasksRepository
    {
        TCDbContext db = new TCDbContext();
        public List<Task> GetAllTasks()
        {
            var query = db.Tasks.ToList();
            return query;
        }

        public Task GetTask(int id)
        {
            var query = db.Tasks.Find(id);
            return query;
        }

        public void DeleteTask(int id)
        {
            db.Tasks.Remove(db.Tasks.Find(id));
            db.SaveChanges();
        }

        public void CreateTask(Task task)
        {
            db.Tasks.Add(task);
            db.SaveChanges();
        }

        public void ModifyTask(Task task)
        {
            var query = db.Tasks.Find(task.Id);
        }


    }
}