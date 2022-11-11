using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CustBillingClassificationCodeEntityVocabulary : SimpleVocabulary
    {
        public CustBillingClassificationCodeEntityVocabulary()
        {
            VocabularyName = "CustBillingClassificationCodeEntity";
            KeyPrefix = "commonDataModel.custbillingclassificationcodeentity";
            KeySeparator = ".";
            Grouping = "/CustBillingClassificationCodeEntity";

            AddGroup("CustBillingClassificationCodeEntity Details", group =>
            {
                CustBillingClassification = group.Add(new VocabularyKey(nameof(CustBillingClassification), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustBillingCode = group.Add(new VocabularyKey(nameof(CustBillingCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Priority = group.Add(new VocabularyKey(nameof(Priority), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BillingClassification = group.Add(new VocabularyKey(nameof(BillingClassification), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BillingCode = group.Add(new VocabularyKey(nameof(BillingCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey CustBillingClassification { get; private set; }
        public VocabularyKey CustBillingCode { get; private set; }
        public VocabularyKey Priority { get; private set; }
        public VocabularyKey BillingClassification { get; private set; }
        public VocabularyKey BillingCode { get; private set; }


    }
}