using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SalesProspectRelationTypeEntityVocabulary : SimpleVocabulary
    {
        public SalesProspectRelationTypeEntityVocabulary()
        {
            VocabularyName = "Common Data Model SalesProspectRelationTypeEntity";
            KeyPrefix = "commonDataModel.salesprospectrelationtypeentity";
            KeySeparator = ".";
            Grouping = "/SalesProspectRelationTypeEntity";

            AddGroup("Common Data Model SalesProspectRelationTypeEntity Details", group =>
            {
                WillProspectConversionDeleteProspects = group.Add(new VocabularyKey(nameof(WillProspectConversionDeleteProspects), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TableSource = group.Add(new VocabularyKey(nameof(TableSource), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TypeDescription = group.Add(new VocabularyKey(nameof(TypeDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TypeId = group.Add(new VocabularyKey(nameof(TypeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey WillProspectConversionDeleteProspects { get; private set; }
        public VocabularyKey TableSource { get; private set; }
        public VocabularyKey TypeDescription { get; private set; }
        public VocabularyKey TypeId { get; private set; }


    }
}