using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class MCRExpediteCodeEntityVocabulary : SimpleVocabulary
    {
        public MCRExpediteCodeEntityVocabulary()
        {
            VocabularyName = "MCRExpediteCodeEntity";
            KeyPrefix = "commonDataModel.mcrexpeditecodeentity";
            KeySeparator = ".";
            Grouping = "/MCRExpediteCodeEntity";

            AddGroup("MCRExpediteCodeEntity Details", group =>
            {
                Expedite = group.Add(new VocabularyKey(nameof(Expedite), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Expedite { get; private set; }
        public VocabularyKey Description { get; private set; }


    }
}