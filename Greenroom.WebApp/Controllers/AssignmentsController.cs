using Greenroom.Application.Actions.Assignments.Interfaces;
using Greenroom.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Greenroom.WebApp.Controllers
{
    public class AssignmentsController : ApiControllerBase
    {
        private readonly IGetAssignmentById _getAssignmentById;
        
        public AssignmentsController(IGetAssignmentById getAssignmentById)
        {
            _getAssignmentById = getAssignmentById;
        }

        [HttpGet]
        public async Task<ActionResult<Assignment>> GetAssignmentById([FromQuery] int id)
        {
            return await _getAssignmentById.GetAsync(id);
        }
    }
}
