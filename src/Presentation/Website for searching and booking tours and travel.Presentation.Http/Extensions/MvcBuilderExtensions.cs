namespace Website_for_searching_and_booking_tours_and_travel.Presentation.Http.Extensions;

public static class MvcBuilderExtensions
{
    public static IMvcBuilder AddPresentationHttp(this IMvcBuilder builder)
    {
        return builder.AddApplicationPart(typeof(IAssemblyMarker).Assembly);
    }
}