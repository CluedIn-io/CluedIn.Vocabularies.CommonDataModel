using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SMAServiceTaskEntityVocabulary : SimpleVocabulary
    {
        public SMAServiceTaskEntityVocabulary()
        {
            VocabularyName = "SMAServiceTaskEntity";
            KeyPrefix = "commonDataModel.smaservicetaskentity";
            KeySeparator = ".";
            Grouping = "/SMAServiceTaskEntity";

            AddGroup("SMAServiceTaskEntity Details", group =>
            {
                TaskDescription = group.Add(new VocabularyKey(nameof(TaskDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaskId = group.Add(new VocabularyKey(nameof(TaskId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey TaskDescription { get; private set; }
        public VocabularyKey TaskId { get; private set; }


    }
}