using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TransportationTypeTableEntityVocabulary : SimpleVocabulary
    {
        public TransportationTypeTableEntityVocabulary()
        {
            VocabularyName = "Transportation Type Table Entity";
            KeyPrefix = "commonDataModel.transportationtypetableentity";
            KeySeparator = ".";
            Grouping = "/TransportationTypeTableEntity";

            AddGroup("TransportationTypeTableEntity Details", group =>
            {
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Type = group.Add(new VocabularyKey(nameof(Type), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey Type { get; private set; }
    }
}