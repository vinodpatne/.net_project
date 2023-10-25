namespace SunsetSerenity.Contracts.Breakfast;

public record UpdateBreakfastRequest(
    string Name,
    string Description,
    DateTime StartDateTime,
    DateTime EndDateTime,
    List<string> Content,
    List<string> Sweet
);