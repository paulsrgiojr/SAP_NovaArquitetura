namespace Hurb.BusinessPartner.Models
{
    public class ResponseModel
    {

        private object[] Data { get; set; }

        private ErrorModel Error { get; set; }

        public ResponseModel(object[] Data = null, ErrorModel Error = null)
        {
            this.Data = Data;
            this.Error = Error;
        }

    }

    public class ErrorModel
    {
        public int Code { get; set; }
        public string Message { get; set; }
        public string InnerMessage { get; set; }
    }
}