namespace IntroToGraphQLTraining
{
    public static class Data
    {
        public static List<Task> Tasks = new List<Task>
        {
            new Task
            {
                Id = "rvjmygy9h",
                Title =  "Learn JavaScript",
                Complete = false,
            },
            new Task
            {
                Id = "oszz1w0z9",
                Title = "Make coffee",
                Complete = true,
            },
            new Task
            {
                Id = "e2iliqkfg",
                Title = "Build a deck",
                Complete = true,
            },
            new Task
            {
                Id = "iy93nd667",
                Title = "Go viral on TikTok",
                Complete = true,
            },
            new Task
            {
                Id = "d2d9ymim6",
                Title = "Solve world hunger",
                Complete = false,
            },
        };

        public static List<User> Users = new List<User>
        {
            new User
            {
                Id = 123,
                Name =  "Alice",                
            },
            new User
            {
                Id = 345,
                Name = "Bob",                
            },            
        };
    }
}
