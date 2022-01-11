using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSContainerMixingConstraintEntityVocabulary : SimpleVocabulary
    {
        public WHSContainerMixingConstraintEntityVocabulary()
        {
            VocabularyName = "Common Data Model WHSContainerMixingConstraintEntity";
            KeyPrefix = "commonDataModel.whscontainermixingconstraintentity";
            KeySeparator = ".";
            Grouping = "/WHSContainerMixingConstraintEntity";

            AddGroup("Common Data Model WHSContainerMixingConstraintEntity Details", group =>
            {
                ConstraintFieldName = group.Add(new VocabularyKey(nameof(ConstraintFieldName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ConstraintTableId = group.Add(new VocabularyKey(nameof(ConstraintTableId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ConstraintTableName = group.Add(new VocabularyKey(nameof(ConstraintTableName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ContainerBuildTemplateId = group.Add(new VocabularyKey(nameof(ContainerBuildTemplateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey ConstraintFieldName { get; private set; }
public VocabularyKey ConstraintTableId { get; private set; }
public VocabularyKey ConstraintTableName { get; private set; }
public VocabularyKey ContainerBuildTemplateId { get; private set; }


    }
}