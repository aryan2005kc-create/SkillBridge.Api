public class JobRepository : IJobRepository
{
    public async Task<IEnumerable<JobDto>> GetJobListAsync()
    {
        var jobList = new List<JobDto>
          {
            new JobDto { Id = 1, Name = "Software Engineer",
             Description = "Develop and maintain software applications",
             MinSalary = 60000 ,MaxSalary = 12000 },

            new JobDto { Id = 2, Name = "Product Manager",
             Description = "Manage product development and strategy",
            MinSalary = 80000 ,MaxSalary = 160000 }
        };
        return jobList;
    }
}