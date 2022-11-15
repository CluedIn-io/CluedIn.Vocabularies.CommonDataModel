using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TaxWithholdNatureOfRemittanceEntityVocabulary : SimpleVocabulary
    {
        public TaxWithholdNatureOfRemittanceEntityVocabulary()
        {
            VocabularyName = "Tax Withhold Nature Of Remittance Entity";
            KeyPrefix = "commonDataModel.taxwithholdnatureofremittanceentity";
            KeySeparator = ".";
            Grouping = "/TaxWithholdNatureOfRemittanceEntity";

            AddGroup("TaxWithholdNatureOfRemittanceEntity Details", group =>
            {
                RemittanceCategoryCode = group.Add(new VocabularyKey(nameof(RemittanceCategoryCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RemittanceDetails = group.Add(new VocabularyKey(nameof(RemittanceDetails), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey RemittanceCategoryCode { get; private set; }
        public VocabularyKey RemittanceDetails { get; private set; }
    }
}