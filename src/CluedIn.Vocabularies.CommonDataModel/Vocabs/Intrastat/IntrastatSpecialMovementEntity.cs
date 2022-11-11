using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class IntrastatSpecialMovementEntityVocabulary : SimpleVocabulary
    {
        public IntrastatSpecialMovementEntityVocabulary()
        {
            VocabularyName = "IntrastatSpecialMovementEntity";
            KeyPrefix = "commonDataModel.intrastatspecialmovemententity";
            KeySeparator = ".";
            Grouping = "/IntrastatSpecialMovementEntity";

            AddGroup("IntrastatSpecialMovementEntity Details", group =>
            {
                SpecialMovement = group.Add(new VocabularyKey(nameof(SpecialMovement), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey SpecialMovement { get; private set; }
        public VocabularyKey Description { get; private set; }


    }
}