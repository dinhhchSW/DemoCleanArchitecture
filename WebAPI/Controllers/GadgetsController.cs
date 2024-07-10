//using Microsoft.AspNetCore.Mvc;
//using MediatR;
//using System.Threading.Tasks;
//using Application.Gadgets.Commands;
//using Application.Gadgets.Queries;
//using Application.DTOs;
//using Application.Services;

//namespace API.Controllers
//{
//    [ApiController]
//    [Route("api/[controller]")]
//    public class GadgetsController : ControllerBase
//    {
//        private readonly IGadgetService _gadgetService;

//        public GadgetsController(IGadgetService gadgetService)
//        {
//            _gadgetService = gadgetService;
//        }

//        [HttpGet("{id}")]
//        public async Task<IActionResult> GetGadgetById(int id)
//        {
//            var gadget = await _gadgetService.GetByIdAsync(id);
//            if (gadget == null) return NotFound();
//            return Ok(gadget);
//        }

//        [HttpGet]
//        public async Task<IActionResult> GetAllGadgets()
//        {
//            var gadgets = await _gadgetService.GetAllAsync();
//            return Ok(gadgets);
//        }


//        [HttpGet("brand/{brand}")]
//        public async Task<IActionResult> GetByBrand(string brand)
//        {
//            if (string.IsNullOrWhiteSpace(brand))
//            {
//                return BadRequest("Brand cannot be null or empty.");
//            }

//            var gadgets = await _gadgetService.GetGadgetsByBrandAsync(brand);
//            return Ok(gadgets);
//        }


//        //[HttpPost]
//        //public async Task<IActionResult> AddGadget([FromBody] GadgetDto gadgetDto)
//        //{
//        //    await _gadgetService.AddGadgetAsync(gadgetDto);
//        //    return CreatedAtAction(nameof(GetGadgetById), new { id = gadgetDto.Id }, gadgetDto);
//        //}


//        [HttpPost]
//        public async Task<IActionResult> CreateGadget([FromBody] GadgetDto gadgetDto)
//        {
//            if (!ModelState.IsValid)
//                return BadRequest(ModelState);

//            var gadget = await _gadgetService.AddAsync(gadgetDto);
//            return CreatedAtAction(nameof(GetGadgetById), new { id = gadget.Id }, gadget);
//        }



//        [HttpPut("{id}")]
//        public async Task<IActionResult> UpdateGadget(int id, [FromBody] GadgetDto gadgetDto)
//        {
//            if (id != gadgetDto.Id) return BadRequest();
//            await _gadgetService.UpdateAsync(gadgetDto);
//            return NoContent();
//        }

//        [HttpDelete("{id}")]
//        public async Task<IActionResult> DeleteGadget(int id)
//        {
//            await _gadgetService.DeleteAsync(id);
//            return NoContent();
//        }
//    }

//    //[ApiController]
//    //[Route("api/[controller]")]
//    //public class StudentsController : ControllerBase
//    //{
//    //    private readonly IStudentService _studentService;

//    //    public StudentsController(IStudentService studentService)
//    //    {
//    //        _studentService = studentService;
//    //    }

//    //    [HttpGet("{id}")]
//    //    public async Task<IActionResult> GetStudentById(int id)
//    //    {
//    //        var student = await _studentService.GetStudentByIdAsync(id);
//    //        if (student == null) return NotFound();
//    //        return Ok(student);
//    //    }

//    //    [HttpGet]
//    //    public async Task<IActionResult> GetAllStudents()
//    //    {
//    //        var students = await _studentService.GetAllStudentsAsync();
//    //        return Ok(students);
//    //    }

//    //    [HttpPost]
//    //    public async Task<IActionResult> AddStudent([FromBody] StudentDto studentDto)
//    //    {
//    //        await _studentService.AddStudentAsync(studentDto);
//    //        return CreatedAtAction(nameof(GetStudentById), new { id = studentDto.Id }, studentDto);
//    //    }

//    //    [HttpPut("{id}")]
//    //    public async Task<IActionResult> UpdateStudent(int id, [FromBody] StudentDto studentDto)
//    //    {
//    //        if (id != studentDto.Id) return BadRequest();
//    //        await _studentService.UpdateStudentAsync(studentDto);
//    //        return NoContent();
//    //    }

//    //    [HttpDelete("{id}")]
//    //    public async Task<IActionResult> DeleteStudent(int id)
//    //    {
//    //        await _studentService.DeleteStudentAsync(id);
//    //        return NoContent();
//    //    }
//    //}
//}


using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Application.DTOs;
using Application.Services;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GadgetsController : BaseController<GadgetDto, IGadgetService>
    {
        private readonly IGadgetService _gadgetService;

        public GadgetsController(IGadgetService gadgetService) : base(gadgetService)
        {
            _gadgetService = gadgetService;
        }

        [HttpGet("brand/{brand}")]
        public async Task<IActionResult> GetByBrand(string brand)
        {
            if (string.IsNullOrWhiteSpace(brand))
            {
                return BadRequest("Brand cannot be null or empty.");
            }

            var gadgets = await _gadgetService.GetGadgetsByBrandAsync(brand);
            return Ok(gadgets);
        }
    }
}
