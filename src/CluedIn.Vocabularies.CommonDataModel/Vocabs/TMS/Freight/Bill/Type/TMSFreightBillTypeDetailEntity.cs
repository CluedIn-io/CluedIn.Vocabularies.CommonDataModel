using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TMSFreightBillTypeDetailEntityVocabulary : SimpleVocabulary
    {
        public TMSFreightBillTypeDetailEntityVocabulary()
        {
            VocabularyName = "Common Data Model TMSFreightBillTypeDetailEntity";
            KeyPrefix = "commonDataModel.tmsfreightbilltypedetailentity";
            KeySeparator = ".";
            Grouping = "/TMSFreightBillTypeDetailEntity";

            AddGroup("Common Data Model TMSFreightBillTypeDetailEntity Details", group =>
            {
                FreightBillDetailFieldDescription = group.Add(new VocabularyKey(nameof(FreightBillDetailFieldDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FreightBillTypeId = group.Add(new VocabularyKey(nameof(FreightBillTypeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FreightBillLineFieldName = group.Add(new VocabularyKey(nameof(FreightBillLineFieldName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsMatchingRequired = group.Add(new VocabularyKey(nameof(IsMatchingRequired), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FieldSequenceNumber = group.Add(new VocabularyKey(nameof(FieldSequenceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey FreightBillDetailFieldDescription { get; private set; }
        public VocabularyKey FreightBillTypeId { get; private set; }
        public VocabularyKey FreightBillLineFieldName { get; private set; }
        public VocabularyKey IsMatchingRequired { get; private set; }
        public VocabularyKey FieldSequenceNumber { get; private set; }


    }
}