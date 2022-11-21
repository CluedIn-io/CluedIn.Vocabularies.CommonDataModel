using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WorkCalendarTimeTemplateEntityVocabulary : SimpleVocabulary
    {
        public WorkCalendarTimeTemplateEntityVocabulary()
        {
            VocabularyName = "Work Calendar Time Template Entity";
            KeyPrefix = "commonDataModel.workcalendartimetemplateentity";
            KeySeparator = ".";
            Grouping = "/WorkCalendarTimeTemplateEntity";

            AddGroup("WorkCalendarTimeTemplateEntity Details", group =>
            {
                TemplateId = group.Add(new VocabularyKey(nameof(TemplateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TemplateName = group.Add(new VocabularyKey(nameof(TemplateName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsPickingUpClosedMonday = group.Add(new VocabularyKey(nameof(IsPickingUpClosedMonday), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsPickingUpClosedTuesday = group.Add(new VocabularyKey(nameof(IsPickingUpClosedTuesday), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsPickingUpClosedWednesday = group.Add(new VocabularyKey(nameof(IsPickingUpClosedWednesday), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsPickingUpClosedThursday = group.Add(new VocabularyKey(nameof(IsPickingUpClosedThursday), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsPickingUpClosedFriday = group.Add(new VocabularyKey(nameof(IsPickingUpClosedFriday), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsPickingUpClosedSaturday = group.Add(new VocabularyKey(nameof(IsPickingUpClosedSaturday), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsPickingUpClosedSunday = group.Add(new VocabularyKey(nameof(IsPickingUpClosedSunday), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey TemplateId { get; private set; }
        public VocabularyKey TemplateName { get; private set; }
        public VocabularyKey IsPickingUpClosedMonday { get; private set; }
        public VocabularyKey IsPickingUpClosedTuesday { get; private set; }
        public VocabularyKey IsPickingUpClosedWednesday { get; private set; }
        public VocabularyKey IsPickingUpClosedThursday { get; private set; }
        public VocabularyKey IsPickingUpClosedFriday { get; private set; }
        public VocabularyKey IsPickingUpClosedSaturday { get; private set; }
        public VocabularyKey IsPickingUpClosedSunday { get; private set; }
    }
}