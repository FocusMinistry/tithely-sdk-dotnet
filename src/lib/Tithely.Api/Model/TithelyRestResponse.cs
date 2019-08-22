using System.Net;

namespace Tithely.Api.Model {
    public interface ITithelyRestResponse<T> where T : new() {
        string RequestValue { get; set; }

        string JsonResponse { get; set; }

        HttpStatusCode StatusCode { get; set; }

        string ErrorMessage { get; set; }

        bool IsSuccessful { get; }

        T Result { get; set; }
    }

    public class TithelyRestResponse<T> : ITithelyRestResponse<T> where T : new() {
        public string RequestValue { get; set; }

        public string JsonResponse { get; set; }

        public HttpStatusCode StatusCode { get; set; }

        public string ErrorMessage { get; set; }

        public bool IsSuccessful {
            get {
                return ((int)StatusCode >= 200 && (int)StatusCode < 300);
            }
        }

        public T Result { get; set; }
    }
}
