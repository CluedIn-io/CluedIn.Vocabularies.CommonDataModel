using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailTenderTypeCardEntityVocabulary : SimpleVocabulary
    {
        public RetailTenderTypeCardEntityVocabulary()
        {
            VocabularyName = "RetailTenderTypeCardEntity";
            KeyPrefix = "commonDataModel.retailtendertypecardentity";
            KeySeparator = ".";
            Grouping = "/RetailTenderTypeCardEntity";

            AddGroup("RetailTenderTypeCardEntity Details", group =>
            {
                CardIssuer = group.Add(new VocabularyKey(nameof(CardIssuer), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CardTypeId = group.Add(new VocabularyKey(nameof(CardTypeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CardTypes = group.Add(new VocabularyKey(nameof(CardTypes), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey CardIssuer { get; private set; }
        public VocabularyKey CardTypeId { get; private set; }
        public VocabularyKey CardTypes { get; private set; }
        public VocabularyKey Name { get; private set; }


    }
}