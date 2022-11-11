using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class FiscalEstablishmentGroupEntityVocabulary : SimpleVocabulary
    {
        public FiscalEstablishmentGroupEntityVocabulary()
        {
            VocabularyName = "Common Data Model FiscalEstablishmentGroupEntity";
            KeyPrefix = "commonDataModel.fiscalestablishmentgroupentity";
            KeySeparator = ".";
            Grouping = "/FiscalEstablishmentGroupEntity";

            AddGroup("Common Data Model FiscalEstablishmentGroupEntity Details", group =>
            {
                FiscalEstablishmentGroup = group.Add(new VocabularyKey(nameof(FiscalEstablishmentGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey FiscalEstablishmentGroup { get; private set; }
        public VocabularyKey Description { get; private set; }


    }
}