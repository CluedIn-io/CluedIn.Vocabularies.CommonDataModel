using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class DimAttributeRDeferralsTable_RUEntityVocabulary : SimpleVocabulary
    {
        public DimAttributeRDeferralsTable_RUEntityVocabulary()
        {
            VocabularyName = "Common Data Model DimAttributeRDeferralsTable_RUEntity";
            KeyPrefix = "commonDataModel.dimattributerdeferralstable_ruentity";
            KeySeparator = ".";
            Grouping = "/DimAttributeRDeferralsTable_RUEntity";

            AddGroup("Common Data Model DimAttributeRDeferralsTable_RUEntity Details", group =>
            {
                Value = group.Add(new VocabularyKey(nameof(Value), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Value { get; private set; }
        public VocabularyKey Name { get; private set; }


    }
}