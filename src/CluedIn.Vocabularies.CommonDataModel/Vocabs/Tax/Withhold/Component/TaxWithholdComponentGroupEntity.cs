using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TaxWithholdComponentGroupEntityVocabulary : SimpleVocabulary
    {
        public TaxWithholdComponentGroupEntityVocabulary()
        {
            VocabularyName = "TaxWithholdComponentGroupEntity";
            KeyPrefix = "commonDataModel.taxwithholdcomponentgroupentity";
            KeySeparator = ".";
            Grouping = "/TaxWithholdComponentGroupEntity";

            AddGroup("TaxWithholdComponentGroupEntity Details", group =>
            {
                WithholdingTaxComponentGroup = group.Add(new VocabularyKey(nameof(WithholdingTaxComponentGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SectionCode = group.Add(new VocabularyKey(nameof(SectionCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Status = group.Add(new VocabularyKey(nameof(Status), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxType = group.Add(new VocabularyKey(nameof(TaxType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey WithholdingTaxComponentGroup { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey SectionCode { get; private set; }
        public VocabularyKey Status { get; private set; }
        public VocabularyKey TaxType { get; private set; }


    }
}