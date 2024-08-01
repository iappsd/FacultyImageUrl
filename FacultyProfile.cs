using AutoMapper;
using FacultyImageUrl.DTO;
using FacultyImageUrl.Entity;

namespace FacultyImageUrl;

public class FacultyProfile : Profile
{
    public FacultyProfile()
    {
        // تعيين الخريطة بين كيان FacultyMember و DTO FacultyMemberDto
        CreateMap<FacultyMember, FacultyMemberDto>();
    }
}