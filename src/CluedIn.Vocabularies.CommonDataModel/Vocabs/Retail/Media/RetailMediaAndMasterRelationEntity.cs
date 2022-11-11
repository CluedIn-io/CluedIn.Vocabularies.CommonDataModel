using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailMediaAndMasterRelationEntityVocabulary : SimpleVocabulary
    {
        public RetailMediaAndMasterRelationEntityVocabulary()
        {
            VocabularyName = "Common Data Model RetailMediaAndMasterRelationEntity";
            KeyPrefix = "commonDataModel.retailmediaandmasterrelationentity";
            KeySeparator = ".";
            Grouping = "/RetailMediaAndMasterRelationEntity";

            AddGroup("Common Data Model RetailMediaAndMasterRelationEntity Details", group =>
            {
                ResourceId = group.Add(new VocabularyKey(nameof(ResourceId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MasterType = group.Add(new VocabularyKey(nameof(MasterType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MasterEntityRecId = group.Add(new VocabularyKey(nameof(MasterEntityRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsDefaultImage = group.Add(new VocabularyKey(nameof(IsDefaultImage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ResourceId { get; private set; }
        public VocabularyKey MasterType { get; private set; }
        public VocabularyKey MasterEntityRecId { get; private set; }
        public VocabularyKey IsDefaultImage { get; private set; }


    }
}