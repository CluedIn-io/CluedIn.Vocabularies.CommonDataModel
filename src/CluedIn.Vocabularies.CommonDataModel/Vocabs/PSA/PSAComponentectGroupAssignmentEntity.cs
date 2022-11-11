using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PSAComponentectGroupAssignmentEntityVocabulary : SimpleVocabulary
    {
        public PSAComponentectGroupAssignmentEntityVocabulary()
        {
            VocabularyName = "Common Data Model PSAComponentectGroupAssignmentEntity";
            KeyPrefix = "commonDataModel.psacomponentectgroupassignmententity";
            KeySeparator = ".";
            Grouping = "/PSAComponentectGroupAssignmentEntity";

            AddGroup("Common Data Model PSAComponentectGroupAssignmentEntity Details", group =>
            {
                Category = group.Add(new VocabularyKey(nameof(Category), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerAccount = group.Add(new VocabularyKey(nameof(CustomerAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IndirectCostComponentGroup = group.Add(new VocabularyKey(nameof(IndirectCostComponentGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RuleSearchKey = group.Add(new VocabularyKey(nameof(RuleSearchKey), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectID = group.Add(new VocabularyKey(nameof(ProjectID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectContractID = group.Add(new VocabularyKey(nameof(ProjectContractID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Resource = group.Add(new VocabularyKey(nameof(Resource), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EffectiveFrom = group.Add(new VocabularyKey(nameof(EffectiveFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ResourcePersonnelNumber = group.Add(new VocabularyKey(nameof(ResourcePersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Category { get; private set; }
        public VocabularyKey CustomerAccount { get; private set; }
        public VocabularyKey IndirectCostComponentGroup { get; private set; }
        public VocabularyKey RuleSearchKey { get; private set; }
        public VocabularyKey ProjectID { get; private set; }
        public VocabularyKey ProjectContractID { get; private set; }
        public VocabularyKey Resource { get; private set; }
        public VocabularyKey EffectiveFrom { get; private set; }
        public VocabularyKey ResourcePersonnelNumber { get; private set; }


    }
}