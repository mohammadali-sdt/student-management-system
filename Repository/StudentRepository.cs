using System;
using Contracts;
using Entities.Models;

namespace Repository;

public sealed class StudentRepository : RepositoryBase<Student>, IStudentRepository
{

    public StudentRepository(RepositoryContext repositoryContext) : base(repositoryContext)
    {
    }

    public IEnumerable<Student> GetAllStudents(bool trackChanges)
    {
        return FindAll(trackChanges);
    }
}
