using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LifeEventVocabulary : SimpleVocabulary
    {
        public LifeEventVocabulary()
        {
            VocabularyName = "Life Event";
            KeyPrefix = "commonDataModel.lifeevent";
            KeySeparator = ".";
            Grouping = "/LifeEvent";

            AddGroup("LifeEvent Details", group =>
            {
                LifemomentId = group.Add(new VocabularyKey(nameof(LifemomentId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CreatedOn = group.Add(new VocabularyKey(nameof(CreatedOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ModifiedOn = group.Add(new VocabularyKey(nameof(ModifiedOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Statecode = group.Add(new VocabularyKey(nameof(Statecode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Statuscode = group.Add(new VocabularyKey(nameof(Statuscode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ImportSequenceNumber = group.Add(new VocabularyKey(nameof(ImportSequenceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OverriddenCreatedOn = group.Add(new VocabularyKey(nameof(OverriddenCreatedOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TimeZoneRuleVersionNumber = group.Add(new VocabularyKey(nameof(TimeZoneRuleVersionNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UTCConversionTimeZoneCode = group.Add(new VocabularyKey(nameof(UTCConversionTimeZoneCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LifeMomentCategory = group.Add(new VocabularyKey(nameof(LifeMomentCategory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Lifemomentdate = group.Add(new VocabularyKey(nameof(Lifemomentdate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Lifemomenttitle = group.Add(new VocabularyKey(nameof(Lifemomenttitle), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LifeMomentType = group.Add(new VocabularyKey(nameof(LifeMomentType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MsfsiModifiedOn = group.Add(new VocabularyKey(nameof(MsfsiModifiedOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey LifemomentId { get; private set; }
        public VocabularyKey CreatedOn { get; private set; }
        public VocabularyKey ModifiedOn { get; private set; }
        public VocabularyKey Statecode { get; private set; }
        public VocabularyKey Statuscode { get; private set; }
        public VocabularyKey ImportSequenceNumber { get; private set; }
        public VocabularyKey OverriddenCreatedOn { get; private set; }
        public VocabularyKey TimeZoneRuleVersionNumber { get; private set; }
        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey LifeMomentCategory { get; private set; }
        public VocabularyKey Lifemomentdate { get; private set; }
        public VocabularyKey Lifemomenttitle { get; private set; }
        public VocabularyKey LifeMomentType { get; private set; }
        public VocabularyKey MsfsiModifiedOn { get; private set; }
    }
}