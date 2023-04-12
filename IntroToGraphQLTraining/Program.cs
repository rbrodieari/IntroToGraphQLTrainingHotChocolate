using IntroToGraphQLTraining;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddGraphQLServer()
    .AddQueryType<Query>()
    .AddMutationType<Mutation>()
    .AddMutationConventions(applyToAllMutations: true);

var app = builder.Build();

app.UseHttpsRedirection();

app.MapGraphQL();

app.Run();

public class Query
{
    public int GetTaskCount() => Data.Tasks.Count;
    public List<Task> GetTasks() => Data.Tasks;
    public Task? GetTask(string id) => Data.Tasks.Find(task => task.Id == id);
    public List<User> GetUsers() => Data.Users;
    public User? GetUser(int id) => Data.Users.Find(user => user.Id == id);
}

public class Mutation
{
    public Task CreateTask(string title)
    {
        var newTask = new Task
        {
            Id = Convert.ToBase64String(Encoding.UTF8.GetBytes(DateTime.Now.Ticks.ToString())),
            Title = title,
            Complete = false
        };

        Data.Tasks.Add(newTask);

        return newTask;
    }

    public Task UpdateTask(string id, string title)
    {       
        var tempTask = Data.Tasks.Find(task => task.Id == id);

        if (tempTask == null)
            throw new GraphQLException("Task not found!");

        tempTask.Title = title;
        return tempTask;
    }


}

public class Task
{
    public string Id { get; set; }
    public string Title { get; set; }
    public bool Complete { get; set; }
    public int UserId { get; set; }

    public User GetUser() {
        return Data.Users.Find(user => user.Id == UserId);
    }
}

public class User
{
    public int Id { get; set; }
    public string Name { get; set; }

    public List<Task> GetTasks()
    {
        return Data.Tasks.Where(task => task.UserId == Id).ToList();
    }
}
