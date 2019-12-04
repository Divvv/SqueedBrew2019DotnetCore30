namespace SqueedBrewDemos.NullableReferences
{
    public class SqueedBrew
    {
        public int? Participants { get; set; }

        public string? VenueName { get; set; }

        public SqueedOffice? Office { get; set; }
    }

    public class SqueedOffice
    {

    }

    public class SqueedBrewService
    {
        public int? CountParticipants(SqueedBrew brew)
        {
            return brew?.Participants;
        }

        public string? GetVenueName(SqueedBrew brew)
        {
            return brew?.VenueName;
        }
    }
}
