using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PaymentFormatCodeEntityVocabulary : SimpleVocabulary
    {
        public PaymentFormatCodeEntityVocabulary()
        {
            VocabularyName = "Common Data Model PaymentFormatCodeEntity";
            KeyPrefix = "commonDataModel.paymentformatcodeentity";
            KeySeparator = ".";
            Grouping = "/PaymentFormatCodeEntity";

            AddGroup("Common Data Model PaymentFormatCodeEntity Details", group =>
            {
                Code = group.Add(new VocabularyKey(nameof(Code), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Type = group.Add(new VocabularyKey(nameof(Type), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Code { get; private set; }
        public VocabularyKey Type { get; private set; }
        public VocabularyKey Description { get; private set; }


    }
}