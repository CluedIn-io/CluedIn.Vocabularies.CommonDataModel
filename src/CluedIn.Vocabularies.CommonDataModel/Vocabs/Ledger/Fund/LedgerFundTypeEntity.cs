using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LedgerFundTypeEntityVocabulary : SimpleVocabulary
    {
        public LedgerFundTypeEntityVocabulary()
        {
            VocabularyName = "Common Data Model LedgerFundTypeEntity";
            KeyPrefix = "commonDataModel.ledgerfundtypeentity";
            KeySeparator = ".";
            Grouping = "/LedgerFundTypeEntity";

            AddGroup("Common Data Model LedgerFundTypeEntity Details", group =>
            {
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FundType = group.Add(new VocabularyKey(nameof(FundType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Description { get; private set; }
        public VocabularyKey FundType { get; private set; }


    }
}