using Biriukov.Mathematics.Geometry;
using Biriukov.Orientation.Core;
using Biriukov.Orientation.Parameters.Domain;

namespace Biriukov.Orientation.Parameters.Application
{
    public class EulerAnglesConverter : IEulerAnglesConverter
    {
        public QuaternionDto ToQuaternion(EulerAnglesDto angles)
        {
            var eulerAngles = ToEulerAngles(angles);

            return ToQuaternionDto(eulerAngles.ToQuaternion());
        }

        private static EulerAngles ToEulerAngles(EulerAnglesDto angles)
        => angles.Units switch
        {
            AngleUnits.Degrees => EulerAngles.CreateKrylov(Angle.FromDeg(angles.Psi), Angle.FromDeg(angles.Theta), Angle.FromDeg(angles.Phi)),
            AngleUnits.Radians => EulerAngles.CreateKrylov(Angle.FromRad(angles.Psi), Angle.FromRad(angles.Theta), Angle.FromRad(angles.Phi)),
            _ => throw new NotImplementedException()
        };

        private static QuaternionDto ToQuaternionDto(Quaternion q)
            => new QuaternionDto(q.W, q.X, q.Y, q.Z);
    }
}
