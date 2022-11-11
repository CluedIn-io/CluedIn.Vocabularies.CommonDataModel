using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class DimAttributeLedgerFund_PSNEntityVocabulary : SimpleVocabulary
    {
        public DimAttributeLedgerFund_PSNEntityVocabulary()
        {
            VocabularyName = "DimAttributeLedgerFund_PSNEntity";
            KeyPrefix = "commonDataModel.dimattributeledgerfund_psnentity";
            KeySeparator = ".";
            Grouping = "/DimAttributeLedgerFund_PSNEntity";

            AddGroup("DimAttributeLedgerFund_PSNEntity Details", group =>
            {
                Value = group.Add(new VocabularyKey(nameof(Value), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Value { get; private set; }
        public VocabularyKey Name { get; private set; }


    }
}