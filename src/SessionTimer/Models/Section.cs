using System;

namespace SessionTimer.Models
{
    public class Section
    {
        public string Name { get; set; }
        public string Speaker { get; set; }
        public TimeSpan Time { get; set; }
        public TimeSpan CurrentTime { get; set; }
        public bool Enabled { get; set; }
    }
}
