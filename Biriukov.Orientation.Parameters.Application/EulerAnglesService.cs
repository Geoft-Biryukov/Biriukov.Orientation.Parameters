using Biriukov.Mathematics.Geometry;
using Biriukov.Orientation.Core;
using Biriukov.Orientation.Parameters.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biriukov.Orientation.Parameters.Application
{
    public class EulerAnglesService : IEulerAnglesService
    {
        private readonly IEulerAnglesConverter converter;

        public EulerAnglesService(IEulerAnglesConverter converter)
        {
            this.converter = converter;
        }

        public QuaternionDto ToQuaternion(EulerAnglesDto angles)
        {            
            return converter.ToQuaternion(angles);
        }

        //private static EulerAngles ToEulerAngles(EulerAnglesDto angles)
        //=> angles.Units switch
        //{
        //    AngleUnits.Degrees => EulerAngles.CreateKrylov(Angle.FromDeg(angles.Psi), Angle.FromDeg(angles.Theta), Angle.FromDeg(angles.Phi)),
        //    AngleUnits.Radians => EulerAngles.CreateKrylov(Angle.FromRad(angles.Psi), Angle.FromRad(angles.Theta), Angle.FromRad(angles.Phi)),
        //    _ => throw new NotImplementedException()
        //};

        //private static QuaternionDto ToQuaternionDto(Quaternion q)
        //    => new QuaternionDto(q.W, q.X, q.Y, q.Z);
    }
}
