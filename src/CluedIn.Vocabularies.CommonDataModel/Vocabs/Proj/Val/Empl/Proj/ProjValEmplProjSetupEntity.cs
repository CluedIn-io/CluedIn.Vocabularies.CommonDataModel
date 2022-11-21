using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ProjValEmplProjSetupEntityVocabulary : SimpleVocabulary
    {
        public ProjValEmplProjSetupEntityVocabulary()
        {
            VocabularyName = "Proj Val Empl Proj Setup Entity";
            KeyPrefix = "commonDataModel.projvalemplprojsetupentity";
            KeySeparator = ".";
            Grouping = "/ProjValEmplProjSetupEntity";

            AddGroup("ProjValEmplProjSetupEntity Details", group =>
            {
                Projid = group.Add(new VocabularyKey(nameof(Projid), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Resource = group.Add(new VocabularyKey(nameof(Resource), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ResourceLegalEntityDataArea = group.Add(new VocabularyKey(nameof(ResourceLegalEntityDataArea), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ResourceId = group.Add(new VocabularyKey(nameof(ResourceId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GroupId = group.Add(new VocabularyKey(nameof(GroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ResourceLegalEntity = group.Add(new VocabularyKey(nameof(ResourceLegalEntity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Projid { get; private set; }
        public VocabularyKey Resource { get; private set; }
        public VocabularyKey ResourceLegalEntityDataArea { get; private set; }
        public VocabularyKey ResourceId { get; private set; }
        public VocabularyKey GroupId { get; private set; }
        public VocabularyKey ResourceLegalEntity { get; private set; }
    }
}