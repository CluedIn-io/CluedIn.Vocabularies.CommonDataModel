using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class EInvoicePropertyTypeApplicabilitySetupEntityVocabulary : SimpleVocabulary
    {
        public EInvoicePropertyTypeApplicabilitySetupEntityVocabulary()
        {
            VocabularyName = "E Invoice Property Type Applicability Setup Entity";
            KeyPrefix = "commonDataModel.einvoicepropertytypeapplicabilitysetupentity";
            KeySeparator = ".";
            Grouping = "/EInvoicePropertyTypeApplicabilitySetupEntity";

            AddGroup("EInvoicePropertyTypeApplicabilitySetupEntity Details", group =>
            {
                RefTableId = group.Add(new VocabularyKey(nameof(RefTableId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TypeId = group.Add(new VocabularyKey(nameof(TypeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PropertyType = group.Add(new VocabularyKey(nameof(PropertyType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TableName = group.Add(new VocabularyKey(nameof(TableName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey RefTableId { get; private set; }
        public VocabularyKey TypeId { get; private set; }
        public VocabularyKey PropertyType { get; private set; }
        public VocabularyKey TableName { get; private set; }
    }
}