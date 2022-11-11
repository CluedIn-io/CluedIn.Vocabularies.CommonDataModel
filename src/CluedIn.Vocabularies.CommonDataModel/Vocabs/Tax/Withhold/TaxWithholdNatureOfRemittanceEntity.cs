using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TaxWithholdNatureOfRemittanceEntityVocabulary : SimpleVocabulary
    {
        public TaxWithholdNatureOfRemittanceEntityVocabulary()
        {
            VocabularyName = "Common Data Model TaxWithholdNatureOfRemittanceEntity";
            KeyPrefix = "commonDataModel.taxwithholdnatureofremittanceentity";
            KeySeparator = ".";
            Grouping = "/TaxWithholdNatureOfRemittanceEntity";

            AddGroup("Common Data Model TaxWithholdNatureOfRemittanceEntity Details", group =>
            {
                RemittanceCategoryCode = group.Add(new VocabularyKey(nameof(RemittanceCategoryCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RemittanceDetails = group.Add(new VocabularyKey(nameof(RemittanceDetails), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey RemittanceCategoryCode { get; private set; }
        public VocabularyKey RemittanceDetails { get; private set; }


    }
}