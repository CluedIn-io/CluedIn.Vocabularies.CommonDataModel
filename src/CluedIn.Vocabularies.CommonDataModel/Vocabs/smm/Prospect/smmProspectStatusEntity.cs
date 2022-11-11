using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class smmProspectStatusEntityVocabulary : SimpleVocabulary
    {
        public smmProspectStatusEntityVocabulary()
        {
            VocabularyName = "smmProspectStatusEntity";
            KeyPrefix = "commonDataModel.smmprospectstatusentity";
            KeySeparator = ".";
            Grouping = "/smmProspectStatusEntity";

            AddGroup("smmProspectStatusEntity Details", group =>
            {
                StatusDescription = group.Add(new VocabularyKey(nameof(StatusDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusId = group.Add(new VocabularyKey(nameof(StatusId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey StatusDescription { get; private set; }
        public VocabularyKey StatusId { get; private set; }


    }
}