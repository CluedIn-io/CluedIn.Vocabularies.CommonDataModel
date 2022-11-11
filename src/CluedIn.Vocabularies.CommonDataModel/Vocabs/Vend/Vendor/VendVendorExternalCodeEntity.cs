using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class VendVendorExternalCodeEntityVocabulary : SimpleVocabulary
    {
        public VendVendorExternalCodeEntityVocabulary()
        {
            VocabularyName = "VendVendorExternalCodeEntity";
            KeyPrefix = "commonDataModel.vendvendorexternalcodeentity";
            KeySeparator = ".";
            Grouping = "/VendVendorExternalCodeEntity";

            AddGroup("VendVendorExternalCodeEntity Details", group =>
            {
                VendorExternalCodeClassId = group.Add(new VocabularyKey(nameof(VendorExternalCodeClassId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorAccountNumber = group.Add(new VocabularyKey(nameof(VendorAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExternalCode = group.Add(new VocabularyKey(nameof(ExternalCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExtCodeRelationTableId = group.Add(new VocabularyKey(nameof(ExtCodeRelationTableId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExtCodeTableTableId = group.Add(new VocabularyKey(nameof(ExtCodeTableTableId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey VendorExternalCodeClassId { get; private set; }
        public VocabularyKey VendorAccountNumber { get; private set; }
        public VocabularyKey ExternalCode { get; private set; }
        public VocabularyKey ExtCodeRelationTableId { get; private set; }
        public VocabularyKey ExtCodeTableTableId { get; private set; }


    }
}