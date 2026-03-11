using Biriukov.Orientation.Parameters.Application;
using Biriukov.Orientation.Parameters.Domain;
using Microsoft.AspNetCore.Mvc;

namespace Biriukov.Orientation.Parameters.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EulerAnglesConverterController : ControllerBase
    {
        private readonly IEulerAnglesService converter;

        public EulerAnglesConverterController(IEulerAnglesService converter)
        {
            this.converter = converter;
        }

        [HttpPost(Name = "Quaternion")]
        public QuaternionDto Get(EulerAnglesDto angles)
        {            
            return converter.ToQuaternion(angles);
        }        
    }
}
