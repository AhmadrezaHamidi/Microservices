using LearningLantern.Common.Response;

namespace LearningLantern.ApiGateway.Utility;

public static class ErrorsList
{
    public static Error UserEmailNotFound(string email) =>
        new()
        {
            StatusCode = StatusCodes.Status404NotFound,
            ErrorCode = nameof(UserEmailNotFound),
            Description = $"There is no user in this University with this email {email}."
        };

    public static Error UserIdNotFound(string userId) =>
        new()
        {
            StatusCode = StatusCodes.Status404NotFound,
            ErrorCode = nameof(UserIdNotFound),
            Description = $"There is no user in this University with this Id {userId}."
        };

    public static Error SignInNotAllowed() =>
        new()
        {
            StatusCode = StatusCodes.Status400BadRequest,
            ErrorCode = nameof(SignInNotAllowed),
            Description = "SignIn not allowed"
        };

    public static Error SignInFailed() =>
        new()
        {
            StatusCode = StatusCodes.Status400BadRequest,
            ErrorCode = nameof(SignInFailed),
            Description = "SignIn not Failed"
        };

    public static Error UniversityNotFound() =>
        new()
        {
            StatusCode = StatusCodes.Status404NotFound,
            ErrorCode = nameof(UniversityNotFound),
            Description = "There is no University in our database with this name."
        };

    public static Error NameNotValid() => new()
    {
        StatusCode = StatusCodes.Status400BadRequest,
        ErrorCode = nameof(NameNotValid),
        Description =
            "this name is not valid, the length of the alphabetic characters must be greater than or equal to 2."
    };

    public static Error ClassroomIdNotFound(int classroomId) => new()
    {
        StatusCode = StatusCodes.Status404NotFound,
        ErrorCode = nameof(ClassroomIdNotFound),
        Description = $"classroom {classroomId} is not Found"
    };
}