using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class FBObservationCodeEntityVocabulary : SimpleVocabulary
    {
        public FBObservationCodeEntityVocabulary()
        {
            VocabularyName = "FBObservationCodeEntity";
            KeyPrefix = "commonDataModel.fbobservationcodeentity";
            KeySeparator = ".";
            Grouping = "/FBObservationCodeEntity";

            AddGroup("FBObservationCodeEntity Details", group =>
            {
                ObservationCode = group.Add(new VocabularyKey(nameof(ObservationCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ObservationCode { get; private set; }
        public VocabularyKey Description { get; private set; }


    }
}