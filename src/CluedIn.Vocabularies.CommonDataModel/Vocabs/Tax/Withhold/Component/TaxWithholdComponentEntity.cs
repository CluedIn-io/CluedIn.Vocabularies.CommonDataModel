using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TaxWithholdComponentEntityVocabulary : SimpleVocabulary
    {
        public TaxWithholdComponentEntityVocabulary()
        {
            VocabularyName = "Common Data Model TaxWithholdComponentEntity";
            KeyPrefix = "commonDataModel.taxwithholdcomponententity";
            KeySeparator = ".";
            Grouping = "/TaxWithholdComponentEntity";

            AddGroup("Common Data Model TaxWithholdComponentEntity Details", group =>
            {
                WithholingTaxComponent = group.Add(new VocabularyKey(nameof(WithholingTaxComponent), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxType = group.Add(new VocabularyKey(nameof(TaxType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WithholdingTaxComponentGroupRecId = group.Add(new VocabularyKey(nameof(WithholdingTaxComponentGroupRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WithholdingTaxComponentGroup = group.Add(new VocabularyKey(nameof(WithholdingTaxComponentGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey WithholingTaxComponent { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey TaxType { get; private set; }
        public VocabularyKey WithholdingTaxComponentGroupRecId { get; private set; }
        public VocabularyKey WithholdingTaxComponentGroup { get; private set; }


    }
}