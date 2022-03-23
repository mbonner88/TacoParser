namespace LoggingKata
{
    public interface ITrackable
    {
        string Name { get; set; }
        Point Location { get; set; }
        public string Coords()
        {
            return $"{Location.Latitude}, {Location.Longitude}";
        }
    }
}