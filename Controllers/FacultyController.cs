
using AutoMapper;
using FacultyImageUrl.Data;
using FacultyImageUrl.DTO;
using Microsoft.AspNetCore.Mvc;

namespace FacultyImageUrl.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FacultyController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly HttpClient _httpClient;
        private readonly IMapper _mapper;
        private const string DefaultImageUrl = "https://example.com/default-image.jpg"; // رابط الصورة الافتراضية

        public FacultyController(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _httpClient = new HttpClient();
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetFaculty()
        {
            // الحصول على قائمة أعضاء هيئة التدريس من قاعدة البيانات
            var facultyList = _context.FacultyMembers.ToList();

            // تحويل قائمة الكيانات إلى قائمة DTOs
            var facultyDtoList = new List<FacultyMemberDto>();

            foreach (var faculty in facultyList)
            {
                // تحويل كائن faculty من نوع FacultyMember إلى كائن facultyDto من نوع FacultyMemberDto باستخدام AutoMapper
                var facultyDto = _mapper.Map<FacultyMemberDto>(faculty);

                // التحقق من صحة رابط الصورة وتعيين الرابط الافتراضي إذا كان غير صالح أو غير موجود
                if (string.IsNullOrEmpty(facultyDto.ImgURL) || !await IsImageUrlValid(facultyDto.ImgURL))
                {
                    facultyDto.ImgURL = DefaultImageUrl;
                }

                facultyDtoList.Add(facultyDto);
            }

            return Ok(facultyDtoList);
        }


        // طريقة للتحقق من صحة رابط الصورة باستخدام HttpClient
        private async Task<bool> IsImageUrlValid(string url)
        {
            try
            {
                var response = await _httpClient.GetAsync(url);
                return response.IsSuccessStatusCode; // التحقق من أن الاستجابة ناجحة
            }
            catch
            {
                return false; // في حالة وجود خطأ، اعتبر الرابط غير صالح
            }
        }
    }
}
