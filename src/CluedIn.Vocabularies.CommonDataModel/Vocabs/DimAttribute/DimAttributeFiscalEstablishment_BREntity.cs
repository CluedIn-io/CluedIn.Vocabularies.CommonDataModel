using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class DimAttributeFiscalEstablishment_BREntityVocabulary : SimpleVocabulary
    {
        public DimAttributeFiscalEstablishment_BREntityVocabulary()
        {
            VocabularyName = "DimAttributeFiscalEstablishment_BREntity";
            KeyPrefix = "commonDataModel.dimattributefiscalestablishment_brentity";
            KeySeparator = ".";
            Grouping = "/DimAttributeFiscalEstablishment_BREntity";

            AddGroup("DimAttributeFiscalEstablishment_BREntity Details", group =>
            {
                Value = group.Add(new VocabularyKey(nameof(Value), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Value { get; private set; }
        public VocabularyKey Name { get; private set; }


    }
}