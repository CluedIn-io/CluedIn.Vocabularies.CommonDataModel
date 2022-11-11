using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SMAServiceRepairResolutionEntityVocabulary : SimpleVocabulary
    {
        public SMAServiceRepairResolutionEntityVocabulary()
        {
            VocabularyName = "Common Data Model SMAServiceRepairResolutionEntity";
            KeyPrefix = "commonDataModel.smaservicerepairresolutionentity";
            KeySeparator = ".";
            Grouping = "/SMAServiceRepairResolutionEntity";

            AddGroup("Common Data Model SMAServiceRepairResolutionEntity Details", group =>
            {
                ResolutionDescription = group.Add(new VocabularyKey(nameof(ResolutionDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ResolutionId = group.Add(new VocabularyKey(nameof(ResolutionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ResolutionDescription { get; private set; }
        public VocabularyKey ResolutionId { get; private set; }


    }
}