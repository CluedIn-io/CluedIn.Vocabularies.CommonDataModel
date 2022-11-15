using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TaxFringeVariationEntityVocabulary : SimpleVocabulary
    {
        public TaxFringeVariationEntityVocabulary()
        {
            VocabularyName = "Tax Fringe Variation Entity";
            KeyPrefix = "commonDataModel.taxfringevariationentity";
            KeySeparator = ".";
            Grouping = "/TaxFringeVariationEntity";

            AddGroup("TaxFringeVariationEntity Details", group =>
            {
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReasonCode = group.Add(new VocabularyKey(nameof(ReasonCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey ReasonCode { get; private set; }
    }
}