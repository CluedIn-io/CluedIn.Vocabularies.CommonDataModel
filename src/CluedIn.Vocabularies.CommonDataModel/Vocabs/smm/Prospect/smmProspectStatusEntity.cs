using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SmmProspectStatusEntityVocabulary : SimpleVocabulary
    {
        public SmmProspectStatusEntityVocabulary()
        {
            VocabularyName = "Smm Prospect Status Entity";
            KeyPrefix = "commonDataModel.smmprospectstatusentity";
            KeySeparator = ".";
            Grouping = "/SmmProspectStatusEntity";

            AddGroup("SmmProspectStatusEntity Details", group =>
            {
                StatusDescription = group.Add(new VocabularyKey(nameof(StatusDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusId = group.Add(new VocabularyKey(nameof(StatusId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey StatusDescription { get; private set; }
        public VocabularyKey StatusId { get; private set; }
    }
}