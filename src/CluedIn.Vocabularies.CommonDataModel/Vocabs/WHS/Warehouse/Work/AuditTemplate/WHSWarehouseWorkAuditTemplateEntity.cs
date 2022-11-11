using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSWarehouseWorkAuditTemplateEntityVocabulary : SimpleVocabulary
    {
        public WHSWarehouseWorkAuditTemplateEntityVocabulary()
        {
            VocabularyName = "WHSWarehouseWorkAuditTemplateEntity";
            KeyPrefix = "commonDataModel.whswarehouseworkaudittemplateentity";
            KeySeparator = ".";
            Grouping = "/WHSWarehouseWorkAuditTemplateEntity";

            AddGroup("WHSWarehouseWorkAuditTemplateEntity Details", group =>
            {
                AuditTriggeringEvent = group.Add(new VocabularyKey(nameof(AuditTriggeringEvent), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AuditTriggeringReferenceWarehouseWorkFieldName = group.Add(new VocabularyKey(nameof(AuditTriggeringReferenceWarehouseWorkFieldName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AuditTriggeringFieldId = group.Add(new VocabularyKey(nameof(AuditTriggeringFieldId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MobileDeviceDisplayLabel = group.Add(new VocabularyKey(nameof(MobileDeviceDisplayLabel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TemplateDescription = group.Add(new VocabularyKey(nameof(TemplateDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusChangeTriggeringValue = group.Add(new VocabularyKey(nameof(StatusChangeTriggeringValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TemplateId = group.Add(new VocabularyKey(nameof(TemplateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey AuditTriggeringEvent { get; private set; }
        public VocabularyKey AuditTriggeringReferenceWarehouseWorkFieldName { get; private set; }
        public VocabularyKey AuditTriggeringFieldId { get; private set; }
        public VocabularyKey MobileDeviceDisplayLabel { get; private set; }
        public VocabularyKey TemplateDescription { get; private set; }
        public VocabularyKey StatusChangeTriggeringValue { get; private set; }
        public VocabularyKey TemplateId { get; private set; }


    }
}