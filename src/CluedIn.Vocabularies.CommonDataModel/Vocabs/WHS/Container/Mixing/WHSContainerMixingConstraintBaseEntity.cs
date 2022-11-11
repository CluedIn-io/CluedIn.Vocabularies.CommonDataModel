using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSContainerMixingConstraintBaseEntityVocabulary : SimpleVocabulary
    {
        public WHSContainerMixingConstraintBaseEntityVocabulary()
        {
            VocabularyName = "Common Data Model WHSContainerMixingConstraintBaseEntity";
            KeyPrefix = "commonDataModel.whscontainermixingconstraintbaseentity";
            KeySeparator = ".";
            Grouping = "/WHSContainerMixingConstraintBaseEntity";

            AddGroup("Common Data Model WHSContainerMixingConstraintBaseEntity Details", group =>
            {
                ConstraintTableId = group.Add(new VocabularyKey(nameof(ConstraintTableId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ConstraintTableName = group.Add(new VocabularyKey(nameof(ConstraintTableName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ContainerBuildTemplateId = group.Add(new VocabularyKey(nameof(ContainerBuildTemplateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ConstraintFieldId = group.Add(new VocabularyKey(nameof(ConstraintFieldId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ConstraintFieldArrayIndex = group.Add(new VocabularyKey(nameof(ConstraintFieldArrayIndex), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ConstraintTableId { get; private set; }
        public VocabularyKey ConstraintTableName { get; private set; }
        public VocabularyKey ContainerBuildTemplateId { get; private set; }
        public VocabularyKey ConstraintFieldId { get; private set; }
        public VocabularyKey ConstraintFieldArrayIndex { get; private set; }


    }
}