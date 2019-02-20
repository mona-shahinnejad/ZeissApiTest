using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Description;
using ZeissApiTest.Business.Dto;
using ZeissApiTest.Business.IService;

namespace ZeissApiTest.WebApi.Controllers
{
    [RoutePrefix("api/machine")]
    public class MachineController : ApiController
    {
        private readonly IMachineService _machineService;

        public MachineController(IMachineService machineService)
        {
            _machineService = machineService;
        }

        /// <summary>
        /// rerturn all register machines data
        /// </summary>
        /// <returns>{MachineDto}</returns>
        [HttpGet]
        [Route("getallmachines")]
        [ResponseType(typeof(List<MachineDto>))]
        public IHttpActionResult GetAllMachines()
        {
            try
            {
                var result = _machineService.GetAllMachines();

                if (result != null && result.Any())
                {
                    return Ok(result);
                }
                else
                {
                    return NotFound();
                }
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        /// <summary>
        /// Return specfic machine data
        /// </summary>
        /// <param name="machineId"></param>
        /// <returns>{MachineDto}</returns>
        [HttpGet]
        [Route("getmachinebyid")]
        [ResponseType(typeof(MachineDto))]
        public IHttpActionResult GetMachineById(string machineId)
        {
            try
            {
                var result = _machineService.GetMachineById(machineId);

                if (result != null)
                {
                    return Ok(result);
                }
                else
                {
                    return NotFound();
                }
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        /// <summary>
        /// Return latest machin status
        /// </summary>
        /// <param name="machineId"></param>
        /// <returns>{string}</returns>
        [HttpGet]
        [Route("getmachinestatus")]
        [ResponseType(typeof(string))]
        public IHttpActionResult GetMachineStatus(string machineId)
        {
            try
            {
                var result = _machineService.GetMachineStatus(machineId);

                if (result != null)
                {
                    return Ok(result);
                }
                else
                {
                    return NotFound();
                }
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }
}
