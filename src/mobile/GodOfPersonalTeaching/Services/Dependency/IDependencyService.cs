using System;
namespace GodOfPersonalTeaching.Services.Dependency
{
    public interface IDependencyService
    {
        T Get<T>() where T : class;
    }
}
