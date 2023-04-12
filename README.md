# IntroToGraphQLTraining

C# version of GraphQL service created during a training.

Example queries:
```graphql
query GetAllTasks{
  taskCount
  tasks {
    id
    title
    complete
  }  
}
query getData {
  task(id: "rvjmygy9h") {
    id
    title
    complete
  }
}
mutation CreateTask {
  createTask(input: {title: "My New Task"}) {
    task {
      id
      title
      complete
    }
  }  
}
mutation UpdateTaskTitle {
  updateTask(input: {id: "rvjmygy9h", title: "Updated Task Name"}) {
    task {
      id
      title
      complete
    }
  }  
}
```
