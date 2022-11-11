using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CustCustomerExternalCodeEntityVocabulary : SimpleVocabulary
    {
        public CustCustomerExternalCodeEntityVocabulary()
        {
            VocabularyName = "CustCustomerExternalCodeEntity";
            KeyPrefix = "commonDataModel.custcustomerexternalcodeentity";
            KeySeparator = ".";
            Grouping = "/CustCustomerExternalCodeEntity";

            AddGroup("CustCustomerExternalCodeEntity Details", group =>
            {
                CustomerExternalCodeClassId = group.Add(new VocabularyKey(nameof(CustomerExternalCodeClassId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerAccountNumber = group.Add(new VocabularyKey(nameof(CustomerAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExternalCode = group.Add(new VocabularyKey(nameof(ExternalCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExtCodeRelationTableId = group.Add(new VocabularyKey(nameof(ExtCodeRelationTableId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExtCodeTableTableId = group.Add(new VocabularyKey(nameof(ExtCodeTableTableId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey CustomerExternalCodeClassId { get; private set; }
        public VocabularyKey CustomerAccountNumber { get; private set; }
        public VocabularyKey ExternalCode { get; private set; }
        public VocabularyKey ExtCodeRelationTableId { get; private set; }
        public VocabularyKey ExtCodeTableTableId { get; private set; }


    }
}