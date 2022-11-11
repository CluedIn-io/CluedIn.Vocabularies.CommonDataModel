using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailTenderTypeCardNumberEntityVocabulary : SimpleVocabulary
    {
        public RetailTenderTypeCardNumberEntityVocabulary()
        {
            VocabularyName = "Common Data Model RetailTenderTypeCardNumberEntity";
            KeyPrefix = "commonDataModel.retailtendertypecardnumberentity";
            KeySeparator = ".";
            Grouping = "/RetailTenderTypeCardNumberEntity";

            AddGroup("Common Data Model RetailTenderTypeCardNumberEntity Details", group =>
            {
                CardNumberFrom = group.Add(new VocabularyKey(nameof(CardNumberFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CardNumberLength = group.Add(new VocabularyKey(nameof(CardNumberLength), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CardNumberTo = group.Add(new VocabularyKey(nameof(CardNumberTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CardTypeId = group.Add(new VocabularyKey(nameof(CardTypeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey CardNumberFrom { get; private set; }
        public VocabularyKey CardNumberLength { get; private set; }
        public VocabularyKey CardNumberTo { get; private set; }
        public VocabularyKey CardTypeId { get; private set; }


    }
}