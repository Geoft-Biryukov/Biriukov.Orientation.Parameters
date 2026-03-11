

using Biriukov.Orientation.Parameters.Domain;

namespace Biriukov.Orientation.Parameters.Application
{
    public interface IEulerAnglesService
    {
        QuaternionDto ToQuaternion(EulerAnglesDto angles);
    }
}
