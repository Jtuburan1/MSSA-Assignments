namespace EmpManagementSystem.Services
{
    public interface IFileUpload
    {
        Task<bool> UploadFile(IFormFile file);
        public string? FileName { get; set; }
    }
}
