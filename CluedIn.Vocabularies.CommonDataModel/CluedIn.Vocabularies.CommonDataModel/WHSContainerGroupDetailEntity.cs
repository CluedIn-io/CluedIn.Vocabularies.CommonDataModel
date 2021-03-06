using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSContainerGroupDetailEntityVocabulary : SimpleVocabulary
    {
        public WHSContainerGroupDetailEntityVocabulary()
        {
            VocabularyName = "Common Data Model WHSContainerGroupDetailEntity";
            KeyPrefix = "commonDataModel.whscontainergroupdetailentity";
            KeySeparator = ".";
            Grouping = "/WHSContainerGroupDetailEntity";

            AddGroup("Common Data Model WHSContainerGroupDetailEntity Details", group =>
            {
                ContainerTypeId = group.Add(new VocabularyKey(nameof(ContainerTypeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ContainerUtilizationPercentage = group.Add(new VocabularyKey(nameof(ContainerUtilizationPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ContainerGroupId = group.Add(new VocabularyKey(nameof(ContainerGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ContainerGroupDetailSequenceNumber = group.Add(new VocabularyKey(nameof(ContainerGroupDetailSequenceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey ContainerTypeId { get; private set; }
public VocabularyKey ContainerUtilizationPercentage { get; private set; }
public VocabularyKey ContainerGroupId { get; private set; }
public VocabularyKey ContainerGroupDetailSequenceNumber { get; private set; }


    }
}