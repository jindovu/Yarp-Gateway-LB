namespace YALB.Api.Models
{
    public class GenericResponse<T>
    {
        public string? Url { get; set; }
        public List<T>? DataList { get; set; }
        public T? Data { get; set; }
    }
}
