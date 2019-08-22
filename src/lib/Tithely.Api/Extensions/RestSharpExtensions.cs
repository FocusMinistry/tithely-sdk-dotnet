using Tithely.Api.Model;
using RestSharp;

namespace Tithely.Api.Extensions {
    public static class RestSharpExtensions {
        public static ITithelyRestResponse<S> ToTithelyResponse<S>(this IRestResponse<S> restResponse) where S : new() {
            var response = new TithelyRestResponse<S>();

            response.StatusCode = restResponse.StatusCode;
            response.JsonResponse = restResponse.Content;

            if ((int)restResponse.StatusCode >= 300) {
                response.ErrorMessage = restResponse.ErrorMessage;
            }
            else {
                response.Result = restResponse.Data;
            }
            return response;
        }

        public static ITithelyRestResponse<S> ToTithelyResponse<S>(this IRestResponse<S> restResponse, string requestInput) where S : new() {
            var response = restResponse.ToTithelyResponse();
            response.RequestValue = requestInput;
            return response;
        }
    }
}
