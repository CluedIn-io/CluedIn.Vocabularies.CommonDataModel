using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ProjectLinePropertySetupEntityVocabulary : SimpleVocabulary
    {
        public ProjectLinePropertySetupEntityVocabulary()
        {
            VocabularyName = "ProjectLinePropertySetupEntity";
            KeyPrefix = "commonDataModel.projectlinepropertysetupentity";
            KeySeparator = ".";
            Grouping = "/ProjectLinePropertySetupEntity";

            AddGroup("ProjectLinePropertySetupEntity Details", group =>
            {
                CategoryCode = group.Add(new VocabularyKey(nameof(CategoryCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CategoryRelation = group.Add(new VocabularyKey(nameof(CategoryRelation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LinePropertyId = group.Add(new VocabularyKey(nameof(LinePropertyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectCode = group.Add(new VocabularyKey(nameof(ProjectCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectRelation = group.Add(new VocabularyKey(nameof(ProjectRelation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsDebitNoteSetupEnabled = group.Add(new VocabularyKey(nameof(IsDebitNoteSetupEnabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey CategoryCode { get; private set; }
        public VocabularyKey CategoryRelation { get; private set; }
        public VocabularyKey LinePropertyId { get; private set; }
        public VocabularyKey ProjectCode { get; private set; }
        public VocabularyKey ProjectRelation { get; private set; }
        public VocabularyKey IsDebitNoteSetupEnabled { get; private set; }


    }
}