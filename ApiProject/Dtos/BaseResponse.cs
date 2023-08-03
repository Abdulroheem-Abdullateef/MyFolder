namespace ApiProject.Dtos
{
    public class BaseResponse<T>
    {
        public bool Suceeded {get; set;}
        public string Message {get; set;}
        public T Data {get; set;}
    }
}