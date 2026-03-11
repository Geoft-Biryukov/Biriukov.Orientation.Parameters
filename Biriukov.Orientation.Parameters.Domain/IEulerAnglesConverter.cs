using Biriukov.Orientation.Parameters.Domain;

namespace Biriukov.Orientation.Parameters.Application
{
    public interface IEulerAnglesConverter
    {
        QuaternionDto ToQuaternion(EulerAnglesDto angles);
    }
}
