using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class MarketingDataImportVocabulary : SimpleVocabulary
    {
        public MarketingDataImportVocabulary()
        {
            VocabularyName = "Marketing Data Import";
            KeyPrefix = "commonDataModel.marketingdataimport";
            KeySeparator = ".";
            Grouping = "/MarketingDataImport";

            AddGroup("MarketingDataImport Details", group =>
            {
                Dataversion = group.Add(new VocabularyKey(nameof(Dataversion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Importcompleted = group.Add(new VocabularyKey(nameof(Importcompleted), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MarketingdataimportId = group.Add(new VocabularyKey(nameof(MarketingdataimportId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NewName = group.Add(new VocabularyKey(nameof(NewName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Dataversion { get; private set; }
        public VocabularyKey Importcompleted { get; private set; }
        public VocabularyKey MarketingdataimportId { get; private set; }
        public VocabularyKey NewName { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}