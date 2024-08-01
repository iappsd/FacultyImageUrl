namespace FacultyImageUrl.Entity;

public class FacultyMember
{
    public int Id { get; set; } // معرف عضو هيئة التدريس
    public string Name { get; set; } = string.Empty; // اسم عضو هيئة التدريس
    public string ImgURL { get; set; } = string.Empty; // رابط الصورة
}

