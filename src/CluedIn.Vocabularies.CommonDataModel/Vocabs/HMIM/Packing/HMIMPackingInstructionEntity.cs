using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class HMIMPackingInstructionEntityVocabulary : SimpleVocabulary
    {
        public HMIMPackingInstructionEntityVocabulary()
        {
            VocabularyName = "Common Data Model HMIMPackingInstructionEntity";
            KeyPrefix = "commonDataModel.hmimpackinginstructionentity";
            KeySeparator = ".";
            Grouping = "/HMIMPackingInstructionEntity";

            AddGroup("Common Data Model HMIMPackingInstructionEntity Details", group =>
            {
                PackInstCode = group.Add(new VocabularyKey(nameof(PackInstCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey PackInstCode { get; private set; }
        public VocabularyKey Description { get; private set; }


    }
}