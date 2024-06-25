namespace MyContactAPI.Endpoints
{
    public static class ContactEndpoint
    {

        public static IEndpointRouteBuilder MapEndpoints(this IEndpointRouteBuilder endpoint)
        {

            var group = endpoint.MapGroup("api/contact/");

            return endpoint;
        }

    }
}
