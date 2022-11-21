using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class EventPurchaseVocabulary : SimpleVocabulary
    {
        public EventPurchaseVocabulary()
        {
            VocabularyName = "Event Purchase";
            KeyPrefix = "commonDataModel.eventpurchase";
            KeySeparator = ".";
            Grouping = "/EventPurchase";

            AddGroup("EventPurchase Details", group =>
            {
                Area = group.Add(new VocabularyKey(nameof(Area), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CompanySize = group.Add(new VocabularyKey(nameof(CompanySize), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EventPurchaseId = group.Add(new VocabularyKey(nameof(EventPurchaseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Industry = group.Add(new VocabularyKey(nameof(Industry), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Paid = group.Add(new VocabularyKey(nameof(Paid), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Processed = group.Add(new VocabularyKey(nameof(Processed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                YearsInIndustry = group.Add(new VocabularyKey(nameof(YearsInIndustry), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Area { get; private set; }
        public VocabularyKey CompanySize { get; private set; }
        public VocabularyKey EventPurchaseId { get; private set; }
        public VocabularyKey Industry { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Paid { get; private set; }
        public VocabularyKey Processed { get; private set; }
        public VocabularyKey YearsInIndustry { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}