using BLL;
using BLL.BLLApi;
using BLL.BLLModels;
using Common;
using DAL.DALApi;
using DAL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ClayKef.Controlleers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
      
        IUICourseService coursesService;
        IUIPriceService uIPriceService;

        public CoursesController(IUICourseService coursesService)
        {
            this.coursesService = coursesService;
        }
        
       /* [HttpGet]
         public async Task<ActionResult<List<UICourse>>> GetAllCourses(*//*BaseQueryParams queryParams*//*){
            return coursesService.GetCourses(*//*queryParams*//*);
         }*/
        [HttpGet]
        public async Task<ActionResult<List<UICourse>>> GetCourses([FromQuery] CoursesParams queryParams)
        {
            return coursesService.GetFilteredCourses(queryParams);
        }
        /*        public async Task<ActionResult<List<UIPrice>>> GetPrice([FromQuery] PriceParams queryParams)
                {
                    return uIPriceService.GetAllPricess(queryParams);
                }*/
        [HttpGet("{id}")]
        public async Task<ActionResult<UICourse>> GetById(int id)
        {
            return await coursesService.GetCourseById(id);
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<UICourse>> DeleteCourse(int id)
        {
            return await coursesService.RemoveCourse(id);
        }
        [HttpPost]
        public async Task<ActionResult<UICourse>> AddCourse([FromBody] UICourse newCourse)
        {
            return await coursesService.PostCourse(newCourse);
        }
    }
}
