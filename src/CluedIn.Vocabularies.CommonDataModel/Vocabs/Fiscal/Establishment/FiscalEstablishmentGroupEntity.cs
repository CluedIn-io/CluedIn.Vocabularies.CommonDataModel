using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class FiscalEstablishmentGroupEntityVocabulary : SimpleVocabulary
    {
        public FiscalEstablishmentGroupEntityVocabulary()
        {
            VocabularyName = "FiscalEstablishmentGroupEntity";
            KeyPrefix = "commonDataModel.fiscalestablishmentgroupentity";
            KeySeparator = ".";
            Grouping = "/FiscalEstablishmentGroupEntity";

            AddGroup("FiscalEstablishmentGroupEntity Details", group =>
            {
                FiscalEstablishmentGroup = group.Add(new VocabularyKey(nameof(FiscalEstablishmentGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey FiscalEstablishmentGroup { get; private set; }
        public VocabularyKey Description { get; private set; }


    }
}