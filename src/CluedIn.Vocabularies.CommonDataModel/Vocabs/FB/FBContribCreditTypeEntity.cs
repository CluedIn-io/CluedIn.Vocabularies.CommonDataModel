using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class FBContribCreditTypeEntityVocabulary : SimpleVocabulary
    {
        public FBContribCreditTypeEntityVocabulary()
        {
            VocabularyName = "FBContribCreditTypeEntity";
            KeyPrefix = "commonDataModel.fbcontribcredittypeentity";
            KeySeparator = ".";
            Grouping = "/FBContribCreditTypeEntity";

            AddGroup("FBContribCreditTypeEntity Details", group =>
            {
                CreditType = group.Add(new VocabularyKey(nameof(CreditType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidFromDate = group.Add(new VocabularyKey(nameof(ValidFromDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidToDate = group.Add(new VocabularyKey(nameof(ValidToDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey CreditType { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey ValidFromDate { get; private set; }
        public VocabularyKey ValidToDate { get; private set; }


    }
}