using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TaxWithholdItemGroupEntityVocabulary : SimpleVocabulary
    {
        public TaxWithholdItemGroupEntityVocabulary()
        {
            VocabularyName = "TaxWithholdItemGroupEntity";
            KeyPrefix = "commonDataModel.taxwithholditemgroupentity";
            KeySeparator = ".";
            Grouping = "/TaxWithholdItemGroupEntity";

            AddGroup("TaxWithholdItemGroupEntity Details", group =>
            {
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxWithholdItemGroup = group.Add(new VocabularyKey(nameof(TaxWithholdItemGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxWithholdRevenueTable = group.Add(new VocabularyKey(nameof(TaxWithholdRevenueTable), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxWithholdRevenueCode = group.Add(new VocabularyKey(nameof(TaxWithholdRevenueCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxWithholdCode = group.Add(new VocabularyKey(nameof(TaxWithholdCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Name { get; private set; }
        public VocabularyKey TaxWithholdItemGroup { get; private set; }
        public VocabularyKey TaxWithholdRevenueTable { get; private set; }
        public VocabularyKey TaxWithholdRevenueCode { get; private set; }
        public VocabularyKey TaxWithholdCode { get; private set; }


    }
}