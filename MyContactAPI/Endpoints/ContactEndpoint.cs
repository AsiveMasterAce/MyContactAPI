namespace MyContactAPI.Endpoints
{
    public static class ContactEndpoint
    {

        public static IEndpointRouteBuilder MapEndpoints(this IEndpointRouteBuilder endpoint)
        {

            var group = endpoint.MapGroup("api/contact/");
            group.MapGet("contacts",FetchContacts);
            return endpoint;

        }
        private static async Task FetchContacts()
        {

        }
    }
}
