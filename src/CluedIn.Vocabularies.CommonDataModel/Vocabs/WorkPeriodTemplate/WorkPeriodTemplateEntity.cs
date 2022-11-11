using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WorkPeriodTemplateEntityVocabulary : SimpleVocabulary
    {
        public WorkPeriodTemplateEntityVocabulary()
        {
            VocabularyName = "WorkPeriodTemplateEntity";
            KeyPrefix = "commonDataModel.workperiodtemplateentity";
            KeySeparator = ".";
            Grouping = "/WorkPeriodTemplateEntity";

            AddGroup("WorkPeriodTemplateEntity Details", group =>
            {
                FixedStartWeekDay = group.Add(new VocabularyKey(nameof(FixedStartWeekDay), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsDefault = group.Add(new VocabularyKey(nameof(IsDefault), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TemplateName = group.Add(new VocabularyKey(nameof(TemplateName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkCalendarTimeTemplateId = group.Add(new VocabularyKey(nameof(WorkCalendarTimeTemplateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LegalEntityRecId = group.Add(new VocabularyKey(nameof(LegalEntityRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LegalEntityId = group.Add(new VocabularyKey(nameof(LegalEntityId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey FixedStartWeekDay { get; private set; }
        public VocabularyKey IsDefault { get; private set; }
        public VocabularyKey TemplateName { get; private set; }
        public VocabularyKey WorkCalendarTimeTemplateId { get; private set; }
        public VocabularyKey LegalEntityRecId { get; private set; }
        public VocabularyKey LegalEntityId { get; private set; }


    }
}