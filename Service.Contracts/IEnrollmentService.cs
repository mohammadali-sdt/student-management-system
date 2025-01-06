using System;
using Shared.DataTransferObjects;

namespace Service.Contracts;

public interface IEnrollmentService
{
    Task CreateEnrollment(Guid studentId, Guid courseId, EnrollmentForCreationDto? enrollmentForCreationDto);

    Task DeleteEnrollment(Guid studentId, Guid courseId, bool trackChanges);
}
