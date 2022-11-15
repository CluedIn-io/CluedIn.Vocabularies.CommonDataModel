using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class MarketingEmailTestAttributeVocabulary : SimpleVocabulary
    {
        public MarketingEmailTestAttributeVocabulary()
        {
            VocabularyName = "Marketing Email Test Attribute";
            KeyPrefix = "commonDataModel.marketingemailtestattribute";
            KeySeparator = ".";
            Grouping = "/MarketingEmailTestAttribute";

            AddGroup("MarketingEmailTestAttribute Details", group =>
            {
                MarketingEmailTestAttributeId = group.Add(new VocabularyKey(nameof(MarketingEmailTestAttributeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Property = group.Add(new VocabularyKey(nameof(Property), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Value = group.Add(new VocabularyKey(nameof(Value), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Variant = group.Add(new VocabularyKey(nameof(Variant), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey MarketingEmailTestAttributeId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Property { get; private set; }
        public VocabularyKey Value { get; private set; }
        public VocabularyKey Variant { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}