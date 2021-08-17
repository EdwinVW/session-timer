using System;
using System.Collections.Generic;

namespace SessionTimer.Models
{
    public class Schedule
    {
        private int _activeSectionIndex;

        public string Name { get; private set; }

        public List<Section> Sections { get; private set; }

        public Schedule(string name)
        {
            Name = name;
            Sections = new List<Section>();
            Sections.ForEach(t => t.CurrentTime = t.Time);
            _activeSectionIndex = 0;
        }

        public void AddSection(string name, string speaker, TimeSpan time)
        {
            bool enabled = Sections.Count == 0;
            Sections.Add(new Section
            {
                Name = name,
                Speaker = speaker,
                Time = time,
                CurrentTime = time,
                Enabled = enabled
            });
        }

        public void Tick()
        {
            var activeSection = Sections[_activeSectionIndex];
            if (activeSection != null && activeSection.Enabled)
            {
                activeSection.CurrentTime = activeSection.CurrentTime.Subtract(TimeSpan.FromSeconds(1));
                if (activeSection.CurrentTime == TimeSpan.Zero)
                {
                    activeSection.Enabled = false;
                    if (_activeSectionIndex < Sections.Count - 1)
                    {
                        _activeSectionIndex++;
                        Sections[_activeSectionIndex].Enabled = true;
                    }
                }
            }
        }
    }
}
