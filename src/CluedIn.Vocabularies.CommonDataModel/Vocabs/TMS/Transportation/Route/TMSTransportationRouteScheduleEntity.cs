using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TMSTransportationRouteScheduleEntityVocabulary : SimpleVocabulary
    {
        public TMSTransportationRouteScheduleEntityVocabulary()
        {
            VocabularyName = "TMSTransportationRouteScheduleEntity";
            KeyPrefix = "commonDataModel.tmstransportationroutescheduleentity";
            KeySeparator = ".";
            Grouping = "/TMSTransportationRouteScheduleEntity";

            AddGroup("TMSTransportationRouteScheduleEntity Details", group =>
            {
                IsRouteRecurrenceActive = group.Add(new VocabularyKey(nameof(IsRouteRecurrenceActive), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EffectiveStartDateTime = group.Add(new VocabularyKey(nameof(EffectiveStartDateTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillRouteGenerationScheduleOnFriday = group.Add(new VocabularyKey(nameof(WillRouteGenerationScheduleOnFriday), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillRouteGenerationScheduleOnMonday = group.Add(new VocabularyKey(nameof(WillRouteGenerationScheduleOnMonday), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ScheduleName = group.Add(new VocabularyKey(nameof(ScheduleName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillRouteGenerationScheduleOnSaturday = group.Add(new VocabularyKey(nameof(WillRouteGenerationScheduleOnSaturday), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillRouteGenerationScheduleOnSunday = group.Add(new VocabularyKey(nameof(WillRouteGenerationScheduleOnSunday), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillRouteGenerationScheduleOnThursday = group.Add(new VocabularyKey(nameof(WillRouteGenerationScheduleOnThursday), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillRouteGenerationScheduleOnTuesday = group.Add(new VocabularyKey(nameof(WillRouteGenerationScheduleOnTuesday), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillRouteGenerationScheduleOnWednesday = group.Add(new VocabularyKey(nameof(WillRouteGenerationScheduleOnWednesday), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WeeklyIntervalDays = group.Add(new VocabularyKey(nameof(WeeklyIntervalDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EffectiveEndDateTime = group.Add(new VocabularyKey(nameof(EffectiveEndDateTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LoadTemplateId = group.Add(new VocabularyKey(nameof(LoadTemplateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransportationRoutePlanId = group.Add(new VocabularyKey(nameof(TransportationRoutePlanId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReferenceTableId = group.Add(new VocabularyKey(nameof(ReferenceTableId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey IsRouteRecurrenceActive { get; private set; }
        public VocabularyKey EffectiveStartDateTime { get; private set; }
        public VocabularyKey WillRouteGenerationScheduleOnFriday { get; private set; }
        public VocabularyKey WillRouteGenerationScheduleOnMonday { get; private set; }
        public VocabularyKey ScheduleName { get; private set; }
        public VocabularyKey WillRouteGenerationScheduleOnSaturday { get; private set; }
        public VocabularyKey WillRouteGenerationScheduleOnSunday { get; private set; }
        public VocabularyKey WillRouteGenerationScheduleOnThursday { get; private set; }
        public VocabularyKey WillRouteGenerationScheduleOnTuesday { get; private set; }
        public VocabularyKey WillRouteGenerationScheduleOnWednesday { get; private set; }
        public VocabularyKey WeeklyIntervalDays { get; private set; }
        public VocabularyKey EffectiveEndDateTime { get; private set; }
        public VocabularyKey LoadTemplateId { get; private set; }
        public VocabularyKey TransportationRoutePlanId { get; private set; }
        public VocabularyKey ReferenceTableId { get; private set; }


    }
}