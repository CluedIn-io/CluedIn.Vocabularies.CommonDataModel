using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ResResourceSetupDataEntityVocabulary : SimpleVocabulary
    {
        public ResResourceSetupDataEntityVocabulary()
        {
            VocabularyName = "Common Data Model ResResourceSetupDataEntity";
            KeyPrefix = "commonDataModel.resresourcesetupdataentity";
            KeySeparator = ".";
            Grouping = "/ResResourceSetupDataEntity";

            AddGroup("Common Data Model ResResourceSetupDataEntity Details", group =>
            {
                DefaultTimeCategory = group.Add(new VocabularyKey(nameof(DefaultTimeCategory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LegalEntity = group.Add(new VocabularyKey(nameof(LegalEntity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Period = group.Add(new VocabularyKey(nameof(Period), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Resource = group.Add(new VocabularyKey(nameof(Resource), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaxHoursCalendar = group.Add(new VocabularyKey(nameof(MaxHoursCalendar), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultTimeCategoryId = group.Add(new VocabularyKey(nameof(DefaultTimeCategoryId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ResourceLegalEntityDataArea = group.Add(new VocabularyKey(nameof(ResourceLegalEntityDataArea), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PeriodId = group.Add(new VocabularyKey(nameof(PeriodId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ResourceId = group.Add(new VocabularyKey(nameof(ResourceId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ResourceName = group.Add(new VocabularyKey(nameof(ResourceName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UseResourceRate = group.Add(new VocabularyKey(nameof(UseResourceRate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidateProjectResource = group.Add(new VocabularyKey(nameof(ValidateProjectResource), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidateResourceCategory = group.Add(new VocabularyKey(nameof(ValidateResourceCategory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaxHoursCalendarId = group.Add(new VocabularyKey(nameof(MaxHoursCalendarId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaxWorkingHours = group.Add(new VocabularyKey(nameof(MaxWorkingHours), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RequireStartStopTime = group.Add(new VocabularyKey(nameof(RequireStartStopTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey DefaultTimeCategory { get; private set; }
        public VocabularyKey LegalEntity { get; private set; }
        public VocabularyKey Period { get; private set; }
        public VocabularyKey Resource { get; private set; }
        public VocabularyKey MaxHoursCalendar { get; private set; }
        public VocabularyKey DefaultTimeCategoryId { get; private set; }
        public VocabularyKey ResourceLegalEntityDataArea { get; private set; }
        public VocabularyKey PeriodId { get; private set; }
        public VocabularyKey ResourceId { get; private set; }
        public VocabularyKey ResourceName { get; private set; }
        public VocabularyKey UseResourceRate { get; private set; }
        public VocabularyKey ValidateProjectResource { get; private set; }
        public VocabularyKey ValidateResourceCategory { get; private set; }
        public VocabularyKey MaxHoursCalendarId { get; private set; }
        public VocabularyKey MaxWorkingHours { get; private set; }
        public VocabularyKey RequireStartStopTime { get; private set; }


    }
}